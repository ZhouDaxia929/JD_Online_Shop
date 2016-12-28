using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;
//using System.Windows.Forms;

namespace JD_Online_Shop_Dal.NetWork {
    class parsePage {
        private string url;
        public bool isInsertGoodInfo { get; set; }
        public parsePage (string url) {
            this.url = url;
        }
        
        //将每个页面的业务逻辑放在Runnable接口的run()方法中，这样可以调用多线程爬去每个页面
        public void run () {
            //通过构造函数插入的URL，然后获取该URL的响应结果
            string content = SpiderUtils.download(url);
            //利用HtmlAgilityPack来加载分析Html页面内容
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(content);
            string goodsId = this.goodsId(htmlDoc);
            //if(goodsId != "") {
                insertGoodInfo(htmlDoc);
                insertComments(goodsId);
                insertHotComment(goodsId);
                insertCommentSummary(goodsId);
            //}
        }
        /*
        public void run2 () {
            //通过构造函数插入的URL，然后获取该URL的响应结果
            string content = SpiderUtils.download(url);
            //利用HtmlAgilityPack来加载分析Html页面内容
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(content);
            string goodsId = this.goodsId(htmlDoc);
            if (goodsId != "") {
                insertComments(goodsId);
                insertHotComment(goodsId);
                insertCommentSummary(goodsId);
            }
        }
        */

        private void insertGoodInfo (HtmlDocument htmlDoc) {
            string goodId = goodsId(htmlDoc);
            string goodName = goodsName(htmlDoc);
            string goodPrice = goodsPrice(htmlDoc);
            string goodUrl = url;
            string goodPicUrl = goodsPicUrl(htmlDoc);
            string goodDetils = goodsDetils(htmlDoc);

            /*
            WebClient myWebClient = new WebClient();
            Uri uri = new Uri(goodPicUrl);
            Byte[] mybyte = myWebClient.DownloadData(url);
            */
            //string result = this.SaveAsWebImg(goodPicUrl);
            this.SaveAsWebImg(goodPicUrl,goodId);
            Byte[] mybyte = this.SaveImgToDB(goodId);
            DBHelper helper = new DBHelper("JD_Online_Shop");
            helper.GoodsInitialize(goodId, goodName, 1000, goodPrice, goodUrl, goodPicUrl, mybyte, goodDetils);
        }

        private string goodsId (HtmlDocument htmlDoc) {
            string GoodId = string.Empty;
            HtmlNode Hnode = htmlDoc.DocumentNode.SelectSingleNode(".//*[@id='parameter2']/li[2]");
            if(Hnode == null) {
                Hnode = htmlDoc.DocumentNode.SelectSingleNode(".//*[@id='detail']/div[2]/div[1]/div[1]/ul[2]/li[2]");
                if (Hnode != null)
                    GoodId = Hnode.InnerText.Substring(5);
            }
            else {
                GoodId = Hnode.InnerText.Substring(5);
            }
            
            return GoodId;
        }
        private string goodsName (HtmlDocument htmlDoc) {
            string GoodName = string.Empty;
            HtmlNode Hnode = htmlDoc.DocumentNode.SelectSingleNode(".//*[@id='name']/h1");
            if(Hnode == null) {
                Hnode = htmlDoc.DocumentNode.SelectSingleNode("html/body/div[5]/div/div[2]/div[1]");
                if (Hnode != null)
                    GoodName = Hnode.InnerText;
            }
            else {
                GoodName = Hnode.InnerText;
            }
            //html / body / div[5] / div / div[2] / div[1]           
            return GoodName;
        }
        private string goodsPrice (HtmlDocument htmlDoc) {
            string id = goodsId(htmlDoc);
            string GoodPrice = "null";
            if (id.Equals(string.Empty)) {
                return GoodPrice;
            }
            else {
                string pricURL = "https://p.3.cn/prices/get?type=1&area=1_72_2799&pdtk=&pduid=1481166803710777284406&pdpin=&pdbp=0&skuid=J_" + id;
                string con = SpiderUtils.download(pricURL);
                //反序列化，解析json字符串
                JArray JA = (JArray)JsonConvert.DeserializeObject(con);
                JObject OB = (JObject)JA[0];
                GoodPrice = OB["p"].ToString();
            }
            return GoodPrice;
        }
        private string goodsDetils (HtmlDocument htmlDoc) {
            StringBuilder info = new StringBuilder();
            HtmlNodeCollection HNC = htmlDoc.DocumentNode.SelectNodes(".//*[@id='parameter2']/li");
            if(HNC == null) {
                HNC = htmlDoc.DocumentNode.SelectNodes(".//*[@id='detail']/div[2]/div[1]/div[1]/ul[2]/li");
                if (HNC != null && HNC.Count != 0)
                    foreach (HtmlNode Hnode in HNC) {
                        info.Append(Hnode.InnerText);
                        info.Append("--");
                    }
            }
            else {
                if (HNC != null && HNC.Count != 0)
                    foreach (HtmlNode Hnode in HNC) {
                        info.Append(Hnode.InnerText);
                        info.Append("--");
                    }
            }
            return info.ToString();
        }
        private string goodsPicUrl (HtmlDocument htmlDoc) {
            string GoodPicUrl = "";
            HtmlNode Hnode = htmlDoc.DocumentNode.SelectSingleNode("//*[@id='spec-n1']/img");
            if (Hnode != null) {
                GoodPicUrl = Hnode.GetAttributeValue("data-origin", "");
                if(GoodPicUrl == "")
                    GoodPicUrl = Hnode.GetAttributeValue("src", "");
            }             
            return GoodPicUrl;
        }

        //商品评论部分
        private void insertComments(string goodsId) {
            if(goodsId == "2879902") {
                goodsId = "3752769";
            }
            //每一页评论的抬头都会有好评度，只需要加载第一页
            string url = "https://sclub.jd.com/comment/productPageComments.action?productId=" + goodsId + "&score=0&sortType=3&page=0&pageSize=10&isShadowSku=0";
            //获取商品评价总数，然后除以每页评价数10，得出总页数。
            /*
            string content1 = SpiderUtils.download(url);
            JObject OB = (JObject)JsonConvert.DeserializeObject(content1);
            JToken o2 = OB["productCommentSummary"];
            JToken o3 = o2["commentCount"];
            int count = Convert.ToInt32(o3.ToString());
            int pageCount = count / 10 + 1;
            */
            //但是，每个商品评价太多了，这里直接赋值1页，共10条评论
            int pageCount = 1;
            for(int j = 0; j < pageCount; j++) {
                string urlStr = "https://sclub.jd.com/comment/productPageComments.action?productId=" + goodsId + "&score=0&sortType=3&page=" + j + "&pageSize=10&isShadowSku=0";
                string contentStr = SpiderUtils.download(urlStr);
                JObject jsonObj = (JObject)JsonConvert.DeserializeObject(contentStr);
                string val = jsonObj.GetValue("comments").ToString();
                JArray jsonArray = JArray.Parse(val);
                for (int i = 0; i < jsonArray.Count; i++) {
                    JObject j_Object = (JObject)jsonArray[i];
                    //string str = jsonArray[i]["guid"].ToString();                    
                    string goodId = goodsId; //商品ID                   
                    string guid = j_Object.GetValue("guid").ToString();//guid  
                    string content = j_Object.GetValue("content").ToString();//评论内容
                    string creationTime = j_Object.GetValue("creationTime").ToString();//评论创建时间
                    string isTop = j_Object.GetValue("isTop").ToString();//isTop
                    string referenceImage = j_Object.GetValue("referenceImage").ToString();//参考图片URL
                    string referenceName = j_Object.GetValue("referenceName").ToString();//参考名称
                    string referenceTime = j_Object.GetValue("referenceTime").ToString();//参考的创建日期
                    string referenceType = j_Object.GetValue("referenceType").ToString();//评论类型
                    string referenceTypeId = j_Object.GetValue("referenceTypeId").ToString();//评论类型ID
                    string firstCategory = j_Object.GetValue("firstCategory").ToString();//
                    string secondCategory = j_Object.GetValue("secondCategory").ToString();//
                    string thirdCategory = j_Object.GetValue("thirdCategory").ToString();//
                    

                    //下面是数据库插入语句
                    string sSql = "insert into Comment(goodId, guid, content, creationTime, isTop, referenceImage, referenceName, "
                        + "referenceTime,referenceType ,referenceTypeId ,firstCategory ,secondCategory ,thirdCategory) values ("
                                + "'" + goodId + "',"
                                + "'" + guid + "',"
                                + "'" + content + "',"
                                + "'" + creationTime + "',"
                                + "'" + isTop + "',"
                                + "'" + referenceImage + "',"
                                + "'" + referenceName + "',"
                                + "'" + referenceTime + "',"
                                + "'" + referenceType + "',"
                                + "'" + referenceTypeId + "',"
                                + "'" + firstCategory + "',"
                                + "'" + secondCategory + "',"
                                + "'" + thirdCategory + "')";
                    DBHelper helper = new DBHelper("JD_Online_Shop");
                    helper.Update(sSql);
                }
            }
        }
        private void insertHotComment(string goodsId) {
            if (goodsId == "2879902") {
                goodsId = "3752769";
            }
            string url = "https://sclub.jd.com/comment/productPageComments.action?productId=" + goodsId + "&score=0&sortType=3&page=0&pageSize=10&isShadowSku=0";
            string content = SpiderUtils.download(url);
            JObject jsonObj = (JObject)JsonConvert.DeserializeObject(content);
            string val = jsonObj.GetValue("hotCommentTagStatistics").ToString();
            JArray jsonArray = JArray.Parse(val);
            for(int i = 0; i < jsonArray.Count; i++) {
                JObject j_Obj = (JObject)jsonArray[i];
                string productId = j_Obj.GetValue("productId").ToString(); //商品ID
                string tagId = j_Obj.GetValue("id").ToString(); //用户某类印象ID
                string count = j_Obj.GetValue("count").ToString(); //用户印象种类数
                string status = j_Obj.GetValue("status").ToString(); //用户某类印象状态
                string rid = j_Obj.GetValue("rid").ToString(); //rid
                string name = j_Obj.GetValue("name").ToString(); //用户某类印象（例如：大小合适，灵敏度高，反应灵敏等）
                string modified = j_Obj.GetValue("modified").ToString(); //一类用户印象最后更新的时间

                //下面是数据库插入语句，一会儿再写
                string sSql = "insert into hotComment(goodId, productId, tagId, count, status, rid, name, modified) values ("
                                + "'" + goodsId + "',"
                                + "'" + productId + "',"
                                + "'" + tagId + "',"
                                + "'" + count + "',"
                                + "'" + status + "',"
                                + "'" + rid + "',"
                                + "'" + name + "',"
                                + "'" + modified + "')";
                DBHelper helper = new DBHelper("JD_Online_Shop");
                helper.Update(sSql);
            }
        }
        private void insertCommentSummary(string goodsId) {
            if (goodsId == "2879902") {
                goodsId = "3752769";
            }
            string url = "https://sclub.jd.com/comment/productPageComments.action?productId=" + goodsId + "&score=0&sortType=3&page=0&pageSize=10&isShadowSku=0";
            string content = SpiderUtils.download(url);
            JObject jsonObject = (JObject)JsonConvert.DeserializeObject(content);
            JToken o2 = jsonObject["productCommentSummary"];
            //Object obj = jsonObject.GetValue("productCommentSummary");
            //JObject j_Obj = new JObject(obj);

            // 获取好评度中的信息
            //o2[""].ToString();
            string productId = o2["productId"].ToString(); //商品ID
            string commentUrl = url; //商品好评度URL
            string commentCount = o2["commentCount"].ToString(); //商品评价数
            string goodRateShow = o2["goodRateShow"].ToString(); //好评度
            string generalRateShow = o2["generalRateShow"].ToString(); //中评度
            string poorRateShow = o2["poorRateShow"].ToString(); //差评度
            string goodCount = o2["goodCount"].ToString(); //好评数
            string generalCount = o2["generalCount"].ToString(); //中评数
            string poorCount = o2["poorCount"].ToString(); //差评数

            //下面是数据库插入语句，一会儿再写
            string sSql = "insert into CommentSummary(goodId, productId, commentUrl, commentCount, goodRateShow, generalRateShow, poorRateShow, goodCount, generalCount, poorCount) values ("
                                + "'" + goodsId + "',"
                                + "'" + productId + "',"
                                + "'" + commentUrl + "',"
                                + "'" + commentCount + "',"
                                + "'" + goodRateShow + "',"
                                + "'" + generalRateShow + "',"
                                + "'" + poorRateShow + "',"
                                + "'" + goodCount + "',"
                                + "'" + generalCount + "',"
                                + "'" + poorCount + "')";
            DBHelper helper = new DBHelper("JD_Online_Shop");
            helper.Update(sSql);
        }
        private void SaveAsWebImg(string picUrl, string goodId) {
            picUrl = "http:" + picUrl;
            string result = "";
            string fileName = "";
            //string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/File/";  //目录
            string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"Goodpics\";  //目录
            try {
                if (!String.IsNullOrEmpty(picUrl)) {
                    Random rd = new Random();
                    DateTime nowTime = DateTime.Now;
                    fileName = goodId + "_" + nowTime.Month.ToString() + nowTime.Day.ToString() + nowTime.Hour.ToString() + nowTime.Minute.ToString() + nowTime.Second.ToString() + rd.Next(1000, 1000000) + ".jpg";
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(picUrl, path + fileName);
                    result = fileName;
                }
            }
            catch { }
        }
        private Byte[] SaveImgToDB(string goodId) {
            string goodID = "";
            Byte[] mybyte = new Byte[1] { 1 };
            string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"Goodpics\";  //目录
            //string Path = path + fileName;
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach(FileInfo dC in dir.GetFiles("*")) {
                string[] st = dC.Name.Split('_');
                goodID = st[0];
                if(goodID == goodId) {
                    FileStream fs = new FileStream(dC.FullName, FileMode.Open, FileAccess.Read);
                    mybyte = new byte[fs.Length];
                    fs.Read(mybyte, 0, mybyte.Length);
                    fs.Close();
                    return mybyte;
                }  
            }
            return mybyte;
        }
    }
}

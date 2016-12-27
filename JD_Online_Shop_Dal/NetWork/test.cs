using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JD_Online_Shop_Dal.NetWork {
    class test {
        public static HashSet<string> test1 () { //获取商品的URL
            string content = SpiderUtils.download("https://sale.jd.com/act/6hd0T3HtkcEmqjpM.html");
            Regex compile = new Regex("//item.jd.com/([0-9]+).html", RegexOptions.Compiled);
            MatchCollection matchs;
            matchs = compile.Matches(content);
            HashSet<string> hashSet = new HashSet<string>();
            foreach (Match m in matchs) {
                hashSet.Add(m.ToString());
                //Console.WriteLine(m.ToString());
            }
            return hashSet;
        }
        public static HashSet<string> test2 () { //获取商品名称
            HashSet<string> hashSet = test.test1();
            HashSet<string> data = new HashSet<string>();
            int count = 0;
            foreach (string goodURL in hashSet) {
                string content = SpiderUtils.download("https:" + goodURL);

                //利用HtmlAgilityPack来加载分析Html页面内容
                HtmlDocument htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(content);

                //得到商品名称节点
                //var Tnode = htmlDoc.DocumentNode.SelectSingleNode(@"//strong[@class='price']/img");
                HtmlNode Hnode = htmlDoc.DocumentNode.SelectSingleNode(".//*[@id='name']/h1");
                if (Hnode != null) {
                    data.Add(Hnode.InnerText);
                }
                if (count++ > 15) {
                    return data;
                }
            }
            return data;
        }
        public static HashSet<string> test3 () { //获取ID
            HashSet<string> hashSet = test.test1();
            HashSet<string> data = new HashSet<string>();
            int count = 0;
            foreach (string goodURL in hashSet) {
                string content = SpiderUtils.download("https:" + goodURL);
                HtmlDocument htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(content);
                HtmlNode Hnode = htmlDoc.DocumentNode.SelectSingleNode(".//*[@id='parameter2']/li[2]");
                if (Hnode != null)
                    data.Add(Hnode.InnerText.Substring(5));
                if (count++ > 30) {
                    return data;
                }
            }
            return data;
        }
        public static HashSet<string> test4 () { //获取商品图片URL
            HashSet<string> hashSet = test.test1();
            HashSet<string> data = new HashSet<string>();
            int count = 0;
            foreach (string goodURL in hashSet) {
                string content = SpiderUtils.download("https:" + goodURL);
                HtmlDocument htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(content);
                HtmlNode Hnode = htmlDoc.DocumentNode.SelectSingleNode("//*[@id='spec-n1']/img");
                if (Hnode != null)
                    data.Add(Hnode.GetAttributeValue("src", ""));
                if (count++ > 15) {
                    return data;
                }
            }
            return data;
        }
        public static HashSet<string> test5 () { //获取商品的介绍详情
            HashSet<string> hashSet = test.test1();
            HashSet<string> data = new HashSet<string>();
            int count = 0;
            foreach (string goodURL in hashSet) {
                string content = SpiderUtils.download("https:" + goodURL);
                HtmlDocument htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(content);
                HtmlNodeCollection HNC = htmlDoc.DocumentNode.SelectNodes(".//*[@id='parameter2']/li");
                if (HNC != null && HNC.Count != 0)
                    foreach (HtmlNode Hnode in HNC) {
                        data.Add(Hnode.InnerText);
                    }
                if (count++ > 1) {
                    return data;
                }
            }
            return data;
        }
        public static HashSet<string> test6 () { //获取商品价格
            HashSet<string> goodIds = test3();
            HashSet<string> Price = new HashSet<string>();
            foreach (string goodId in goodIds) {
                string pricURL = "https://p.3.cn/prices/get?type=1&area=1_72_2799&pdtk=&pduid=1340247559&pdpin=&pdbp=0&skuid=J_" + goodId;
                string con = SpiderUtils.download(pricURL);
                //JsonReader reader = new JsonReader(new Str)
                //反序列化，解析json字符串
                JArray JA = (JArray)JsonConvert.DeserializeObject(con);
                JObject OB = (JObject)JA[0];
                //string priceStr = OB["p"].ToString();
                Price.Add(OB["p"].ToString());
            }
            return Price;
        }
    }
}

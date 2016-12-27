using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;

namespace JD_Online_Shop_Dal.NetWork {
    class SpiderUtils {
        static Encoding encoding = Encoding.GetEncoding("gb2312");
        public static string download (string url) {
            //WebClient web = new WebClient();
            //web.Encoding = System.Text.Encoding.Unicode;
            byte[] bytes = new WebClient().DownloadData(url);
            //byte[] bytes = web.DownloadData(url);
            //通过编码得到页面的内容string，用HttpUtility.HtmlDecode解码
            string content = HttpUtility.HtmlDecode(encoding.GetString(bytes));
            return content;
        }
    }
}

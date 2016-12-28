using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace JD_Online_Shop_Dal.NetWork {
    public class Spider {
        public bool Pass { get; set; }
        private HashSet<string> hashSet;
        public Spider () {
            Pass = false;
            hashSet = test.test1();
            hashSet.Remove("2879902");
        }
        public void start () {
            int i = 0;
            foreach (string goodUrl in hashSet) {
                if(goodUrl == "2879902") {
                    break;
                }
                else {
                    parsePage npp = new parsePage("https:" + goodUrl);
                    Thread th = new Thread(new ThreadStart(npp.run));
                    th.Start();

                    if (i++ == 35) {
                        break;
                    }
                } 
            }
        }
        public void test111 () {
            //1677061
            parsePage npp = new parsePage("https://item.jd.com/1677061.html");
            npp.run();
            //parsePage npp1 = new parsePage("https://item.jd.com/3752769.html");
            //npp1.run();
        }
        /*
        public void start2 () {
            foreach (string goodUrl in hashSet) {
                parsePage npp = new parsePage("https:" + goodUrl);
                Thread th = new Thread(new ThreadStart(npp.run2));
                th.Start();
            }
        }
        */

    }
}

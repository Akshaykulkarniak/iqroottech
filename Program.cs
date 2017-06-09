using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using System.Net;
using System.IO;

namespace webscrap
{
    class Program
    {
        static void Main(string[] args)
        
       {
           HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.flipkart.com/ivoltaa-ivfk1-sync-charge-cable/p/itmeswvchvqtvzyz?pid=ACCESWVC2PKGRCBB&srno=b_1_1&otracker=hp_omu_Deals%20of%20the%20Day_1_Just%20%E2%82%B9149_f4d57701-5efd-473b-ac73-faef5cb96b5f_DesktopSite&lid=LSTACCESWVC2PKGRCBBJEZSZB");

           //HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.compareraja.in/apple-macbook-air-mmgf2hna-price.html");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
           StreamReader stream = new StreamReader(response.GetResponseStream());
           string final_response = stream.ReadToEnd();
          // Regex r = new Regex(@"54,49\d+.\d+");
       //   Regex a = new Regex(@"Pr\w+:\s \w");

           Regex a = new Regex(@"<!--\s\w+-\w+: 21\w+ -->\w+");

         // Regex r = new Regex(@"delivery to \w+ ");
         //  Regex p = new Regex(@"\d\w\w \w+\d \w+");
           // Regex r = new Regex(@"\d.\d\w+ \w+ \w+ \w\d \w+");
            //Regex s = new Regex(@"12\w+ \w+");
           //Regex r = new Regex(@"Rs.\d+,\d+");
          
            //compare raja //Regex r = new Regex(@"");
            Match b = a.Match(final_response);
       //     Match m = r.Match(final_response);
         //   Match n = p.Match(final_response);
           // Match o = s.Match(final_response);
          //Console.WriteLine(m.Value);
          //Console.WriteLine(n.Value);
          //Console.WriteLine(o.Value);
          Console.WriteLine(b.Value);
         //  Console.WriteLine(final_response);
            Console.ReadKey();
        
        


        }
    }
}

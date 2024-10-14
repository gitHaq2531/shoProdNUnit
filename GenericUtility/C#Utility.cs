using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace shoProd.GenericUtility
{
    internal class C_Utility
    {
        public long GetRandomData()
        {
            Random rndm = new Random();
            long v = rndm.Next(1000);
            return v;
        }
        public string GetCurrentSystemDate()
        {
            DateTime dt = DateTime.Now;
            string timeStamp = dt.ToString().Replace(':', '-');
            return timeStamp;
        }
        
        public string getRequiredDateTime(int num)
        {
            DateTime date = DateTime.Now;
            DateTime dtt = date.AddDays(num);
            string requireddate = dtt.ToString("yyyy-MM-dd");
            return requireddate;
          //  Console.WriteLine(requireddate);
        }
    }
}

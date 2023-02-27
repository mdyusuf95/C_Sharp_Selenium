using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Selenium.Main.Genric
{
    public  class CShapUtilities
    {


        /// <summary>
        /// this methos is usefull to get ramndon integer
        /// </summary>
        /// <param name="range"></param>
        /// <returns></returns>
        public int RandomInteger(int range)
        {
            Random r = new Random();
            int rnum = r.Next(range);
            return rnum;
        }

        /// <summary>
        ///  this methos is usefull date
        /// </summary>
        /// <returns></returns>

        public String GetDate()
        {
            DateTime dateTime = DateTime.Now;
            string date = dateTime.ToShortDateString();
            return date;
        }

        /// <summary>
        /// this method is usefull to get time
        /// </summary>
        /// <returns></returns>
        public String GetTime()
        {
            DateTime dateTime = DateTime.Now;
            string time = dateTime.ToShortTimeString();
            return time;
        }

        /// <summary>
        ///  this method is usefull to get both time and date
        /// </summary>
        /// <returns></returns>
        public String GetDateAndTime()
        {
            DateTime dateTime = DateTime.Now;
            string dataAndtime = dateTime.ToString();
            return dataAndtime;
        }
    }
}

using System;

namespace CSVExmple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma käsittelee pilkuilla erotetun datan.");
            string data = "aasi,kahvi,väsymys,kaneli,aivot,tietokone,pettymys,torstai,pora,koodi,18. pistettä";
            Versio3(data);
        }
        #region Version 1
        /// <summary>
        /// Function replaces strings commas with new lines
        /// d = strings data, which is separated with commas
        /// </summary>
        /// <param name="d"></param>
        static void Versio1(string d)
        {
            string tmpData = d.Replace(',', '\n');

            Console.WriteLine(d);
            Console.WriteLine(tmpData);
        }
        #endregion
        #region Version 2
        /// <summary>
        /// Function searches for commas and prints data in between with commas
        /// </summary>
        /// <param name="d"></param>
        static void Versio2(string d)
        {
            //Console.WriteLine(d.Substring(0, 4));

            int i = 0;

            while (true)
            {
                int p = d.IndexOf(',', i);

                if (p != -1)
                {
                    Console.WriteLine(d.Substring(i, p - i));
                    i = p + 1;
                }
                else
                {
                    Console.WriteLine(d.Substring(i));
                    break;
                }
            }
        }
        #endregion
        #region Version 3
        static void Versio3(string d)
        {
            string[] tmpData = d.Split(',');

            for (int i = 0; i < tmpData.Length; i++)
            {
                Console.WriteLine(tmpData[i]);
            }
        }
        #endregion
    }
}
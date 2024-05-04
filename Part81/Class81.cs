using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part81
{
    internal class Class81
    {


        public static void MainFunction()
        {




            Country Country = new Country()
            {
                Code = "PAK",
                Name = "Pakistan",
                Capital = "Isl"
            };
            Country Country2 = new Country()
            {
                Code = "IND",
                Name = "India",
                Capital = "Delhi"
            };
            Country Country3 = new Country()
            {
                Code = "JAP",
                Name = "Japan",
                Capital = "Washington"
            };
            Country Country4 = new Country()
            {
                Code = "CHI",
                Name = "China",
                Capital = "Chicago"
            };


            //List<Country> list = new List<Country>();
            //list.Add(Country);
            //list.Add(Country2);
            //list.Add(Country3);
            //list.Add(Country4);


            Dictionary<string,Country> dicCountries = new Dictionary<string, Country>();

            dicCountries.Add(Country.Code, Country);
            dicCountries.Add(Country2.Code, Country2);
            dicCountries.Add(Country3.Code, Country3);
            dicCountries[Country4.Code] = Country4;
            string strUserChoice = string.Empty;
            //Console.WriteLine("before sorting");
            //foreach (Country i in list)
            //{
            //    Console.WriteLine(i.Id);
            //}


            //Console.WriteLine("after sorting");
            //foreach (Country i in list)
            //{
            //    Console.WriteLine(i.Id);
            //}

            do {
                Console.WriteLine("Please Enter the Country Code");
                string str = Console.ReadLine().ToUpper();

                Country result = dicCountries.ContainsKey(str) ? dicCountries[str] : null;

                if (result == null)
                {
                    Console.WriteLine("Please enter a valid Country code");
                }

                else
                {
                    Console.WriteLine($"{result.Name} and {result.Capital}");
                }
                do
                {
                    Console.WriteLine("Do you want to COntinue - Yes or No");
                    strUserChoice = Console.ReadLine().ToUpper();
                }
                while (strUserChoice != "YES" && strUserChoice != "NO");
            }
            while(strUserChoice == "YES");
            }

    }



    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }

        
    }
}

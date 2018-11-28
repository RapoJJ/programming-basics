using System;
using System.IO;

namespace ExampleFileHandling1
{
    class Program
    {
        static void Main(string[] args)
        {
            string choise = null;
            string path = @"C:\TEMP\TESTI.DAT";
            string msg = "";
            do
            {
                choise = UserInterface();

                switch (choise.ToUpper())
                {
                    case "K":
                        WriteToFile(path);
                        msg = "\nTiedostoon kirjoitus on päättynyt! \nPaina Enter jatkaaksesi!";
                        break;
                    case "L":
                        AddDataToFile(path);
                        msg = "\nTiedoston loppuun kirjoitus on päättynyt! \nPaina Enter jatkaaksesi!";
                        break;
                    case "N":
                        ReadFile(path);
                        msg = "\nTiedoston lukeminen on päättynyt! \nPaina Enter jatkaaksesi!";
                        break;
                    case "X":
                        msg = "\nOhjelman suoritus päättyy!";
                        break;
                    default:
                        msg = "Nyt tuli huti yritä uudestaan - Paina Enter ja aloita alusta!";
                        break;
                }

                Console.WriteLine(msg);
                Console.ReadLine();
                Console.Clear();
            }
            while (choise.ToUpper() != "X");

        }


        /// <summary>
        /// User Interface
        /// </summary>
        /// <returns></returns>
        static string UserInterface()
        {
            Console.WriteLine("Tiedoston käsittely esimerkki!");
            Console.WriteLine("[K] Kirjoita tiedostoon - Tekee kokonaan uuden");
            Console.WriteLine("[L] Kirjoita tiedoston loppuun - Lisätään tiedostoon tietoja");
            Console.WriteLine("[N] Näytä tiedoston sisältö");
            Console.WriteLine("[X] Lopeta ohjelmansuoritus");
            Console.WriteLine();
            Console.Write("Valitse mitä tehdään: ");

            return Console.ReadLine();
        }

        /// <summary>
        /// Write to file by using StreamWriter Class
        /// Create a new file
        /// string filePath is 
        /// </summary>
        /// <param name="filePath"></param>
        static void WriteToFile(string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("TERVE TAAS!");
                sw.WriteLine(DateTime.Now.ToString());
                sw.WriteLine($"Tiedoston sijainti on: \t\t{filePath}");
            }
        }

        /// <summary>
        /// Read file by using StreamReader class
        /// </summary>
        /// <param name="filePath"></param>
        static void ReadFile(string filePath)
        {
            try
            {


                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line = null;

                    Console.WriteLine("Tiedostosta löytyy seuraavat rivit:\n");
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Tapahtui virhe: {ex.Message}");
            }
        }

        /// <summary>
        /// Append data to end of file by using StreamWriter Class
        /// </summary>
        /// <param name="filePath"></param>
        static void AddDataToFile(string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine("-----------------------------------------");
                sw.WriteLine("TERVE TAAS - tässä lisätään rivit tiedoston loppuun!");
                sw.WriteLine(DateTime.Now.ToString());
                sw.WriteLine("Tiedoston sijainti on: \t\t{0}", filePath);
            }
        }
    }
}
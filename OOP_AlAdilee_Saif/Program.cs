using ReisLibrary.Models;
using System;

namespace OOP_AlAdilee_Saif
{
    class Program
    {
        public static string lijn = new string('_', 77);
        static void Main(string[] args)
        {
            ReisBureau[] reisBureau = newReisbureau();
            Persoon[] persoons = newpersson();
            //Reis[] reis = newReis();
            //newreservatie(reisBureau, reis, persoons);
        }
        private static ReisBureau[] newReisbureau()
        {
            ReisBureau[] reisBureau = new ReisBureau[3];
            reisBureau[0] = new ReisBureau
            {
                Naam = "World Travel.CO",
                Adres = new Adres()
                {
                    Gemeente = "worldGe",
                    Straat = "worldStraat 9",
                    HuisNr = "9",
                    Postcode = 9999
                }
            };
            reisBureau[1] = new ReisBureau
            {
                Naam = "Local Travel.CO",
                Adres = new Adres()
                {
                    Gemeente = "localGe",
                    Straat = "localStraat ",
                    HuisNr = "7",
                    Postcode = 7777
                }
            };

            reisBureau[2] = new ReisBureau
            {
                Naam = "Fun Travel.CO",
                Adres = new Adres()
                {
                    Gemeente = "funGe",
                    Straat = "funStraat ",
                    HuisNr = "8",
                    Postcode = 8888
                }
            };
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(lijn);
            Console.WriteLine();
            Console.WriteLine($"reisBureau name : {reisBureau[0].Naam}\n Gemeente : {reisBureau[0].Adres.Gemeente}\n straat : {reisBureau[0].Adres.Straat}\n huisNr : {reisBureau[0].Adres.HuisNr}\n poscode : {reisBureau[0].Adres.Postcode}");
            Console.WriteLine($"reisBureau name : {reisBureau[1].Naam}\n Gemeente : {reisBureau[1].Adres.Gemeente}\n straat : {reisBureau[1].Adres.Straat}\n huisNr : {reisBureau[1].Adres.HuisNr}\n poscode : {reisBureau[1].Adres.Postcode}");
            Console.WriteLine($"reisBureau name : {reisBureau[2].Naam}\n Gemeente : {reisBureau[2].Adres.Gemeente}\n straat : {reisBureau[2].Adres.Straat}\n huisNr : {reisBureau[2].Adres.HuisNr}\n poscode : {reisBureau[2].Adres.Postcode}");
            Console.WriteLine();
            Console.WriteLine(lijn);
            Console.WriteLine();
            Console.ResetColor();
            return reisBureau;
        }
        //private static Reis[] newReis()
        //{
        //    Reis[] reis = new Reis[5];
        //    //reis[0] = new Autovakantie(aantalPersoonen = 7, vertrekDatume(22, 11, 2020), terugKeerDatume(11, 12, 2020));
        //    reis[0] = new Autovakantie
        //    {
        //        AantalPersoonen = 7,
        //        TerugKeerDatume = new DateTime(22, 12, 2020),
        //        VertrekDatume = new DateTime(22, 12, 2020)
        //    };
        //    reis[1] = new Autovakantie
        //    {
        //        AantalPersoonen = 5,
        //        VertrekDatume = new DateTime(22, 11, 2020),
        //        TerugKeerDatume = new DateTime(24, 12, 2020)
        //    };
        //    reis[2] = new Cruise
        //    {
        //        AantalPersoonen = 5,
        //        VertrekDatume = new DateTime(10, 12, 2020),
        //        TerugKeerDatume = new DateTime(24, 02, 2021)
        //    };
        //    reis[3] = new Vliegtuigvakantie
        //    {
        //        AantalPersoonen = 3,
        //        VertrekDatume = new DateTime(10, 12, 2020),
        //        TerugKeerDatume = new DateTime(24, 02, 2021)
        //    };
        //    reis[4] = new Vliegtuigvakantie
        //    {
        //        AantalPersoonen = 3,
        //        VertrekDatume = new DateTime(10, 12, 2020),
        //        TerugKeerDatume = new DateTime(24, 03, 2021)
        //    };
        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    Console.WriteLine(lijn);
        //    Console.WriteLine();
        //    Console.WriteLine(reis[0].AantalPersoonen);
        //    Console.WriteLine($"reis #1 name : {reis[0].AantalDagen}\ntotal persoonen : {reis[0].AantalPersoonen}\n vertruken op :  {reis[0].VertrekDatume.Date}\nterug op : {reis[0].TerugKeerDatume.Date}");
        //    Console.WriteLine($"reis #2 name : {reis[1].AantalDagen}\ntotal persoonen : {reis[1].AantalPersoonen}\n vertruken op :  {reis[1].VertrekDatume.Date}\nterug op : {reis[1].TerugKeerDatume.Date}");
        //    Console.WriteLine($"reis #3 name : {reis[2].AantalDagen}\ntotal persoonen : {reis[2].AantalPersoonen}\n vertruken op :  {reis[2].VertrekDatume.Date}\nterug op : {reis[2].TerugKeerDatume.Date}");
        //    Console.WriteLine($"reis #4 name : {reis[3].AantalDagen}\ntotal persoonen : {reis[3].AantalPersoonen}\n vertruken op :  {reis[3].VertrekDatume.Date}\nterug op : {reis[3].TerugKeerDatume.Date}");
        //    Console.WriteLine($"reis #5 name : {reis[4].AantalDagen}\ntotal persoonen : {reis[4].AantalPersoonen}\n vertruken op :  {reis[4].VertrekDatume.Date}\nterug op : {reis[4].TerugKeerDatume.Date}");
        //    Console.WriteLine();
        //    Console.WriteLine(lijn);
        //    Console.WriteLine();
        //    Console.ResetColor();
        //    return reis;
        //}
        private static Persoon[] newpersson()
        {
            Persoon[] persoons = new Persoon[5];
            persoons[0] = new Persoon
            {
                VoorNaam = "SAif1",
                FamilieNaam = "s1s",
                Adres = new Adres
                {
                    Gemeente = "saifGe1",
                    HuisNr = "s1s",
                    Postcode = 1111,
                    Straat = "saifStraat"
                }
            };
            persoons[1] = new Persoon
            {
                FamilieNaam = "s2s",
                VoorNaam = "Saif2",
                Adres = new Adres
                {
                    Postcode = 2222,
                    Gemeente = "saifGe2",
                    Straat = "s2s",
                    HuisNr = "s2"
                }
            };
            persoons[2] = new Persoon
            {
                FamilieNaam = "s3s",
                VoorNaam = "saif3",
                Adres = new Adres
                {
                    Postcode = 3333,
                    Gemeente = "saifGe3",
                    Straat = "s3s",
                    HuisNr = "s3"
                }
            };
            persoons[3] = new Persoon
            {
                FamilieNaam = "s4s",
                VoorNaam = "saif4",
                Adres = new Adres
                {
                    Postcode = 4444,
                    Gemeente = "saifGe4",
                    Straat = "s4s",
                    HuisNr = "s4"
                }
            };
            persoons[4] = new Persoon
            {
                FamilieNaam = "s5s",
                VoorNaam = "saif5",
                Adres = new Adres
                {
                    Postcode = 5555,
                    Gemeente = "saifGe5",
                    Straat = "s5s",
                    HuisNr = "s5"
                }
            };
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(lijn);
            Console.WriteLine();
            Console.WriteLine($"name : {persoons[0].Naam}\n Gemeente : {persoons[0].Adres.Gemeente}\n straat : {persoons[0].Adres.Straat}\n huisNr : {persoons[0].Adres.HuisNr}\n poscode : {persoons[0].Adres.Postcode}");
            Console.WriteLine($"name : {persoons[1].Naam}\n Gemeente : {persoons[1].Adres.Gemeente}\n straat : {persoons[1].Adres.Straat}\n huisNr : {persoons[1].Adres.HuisNr}\n poscode : {persoons[1].Adres.Postcode}");
            Console.WriteLine($"name : {persoons[2].Naam}\n Gemeente : {persoons[2].Adres.Gemeente}\n straat : {persoons[2].Adres.Straat}\n huisNr : {persoons[2].Adres.HuisNr}\n poscode : {persoons[2].Adres.Postcode}");
            Console.WriteLine($"name : {persoons[3].Naam}\n Gemeente : {persoons[3].Adres.Gemeente}\n straat : {persoons[3].Adres.Straat}\n huisNr : {persoons[3].Adres.HuisNr}\n poscode : {persoons[3].Adres.Postcode}");
            Console.WriteLine($"name : {persoons[4].Naam}\n Gemeente : {persoons[4].Adres.Gemeente}\n straat : {persoons[4].Adres.Straat}\n huisNr : {persoons[4].Adres.HuisNr}\n poscode : {persoons[4].Adres.Postcode}");
            Console.WriteLine();
            Console.WriteLine(lijn);
            Console.WriteLine();
            Console.ResetColor();
            return persoons;
        }
        private static void newreservatie(ReisBureau[] reisBureau, Reis[] reis, Persoon[] persoons)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(lijn);
            Console.WriteLine();
            ReisReservatie[] reisReservaties = new ReisReservatie[5];
            reisReservaties[0] = new ReisReservatie(persoons[0], reis[0], reisBureau[1]);
            reisReservaties[0] = new ReisReservatie(persoons[2], reis[3], reisBureau[2]);
            reisReservaties[0] = new ReisReservatie(persoons[1], reis[2], reisBureau[0]);
            reisReservaties[0] = new ReisReservatie(persoons[3], reis[4], reisBureau[2]);
            reisReservaties[0] = new ReisReservatie(persoons[4], reis[0], reisBureau[0]);
            Console.WriteLine();
            Console.WriteLine(lijn);
            Console.WriteLine();
            Console.ResetColor();
        }

        //void ShowLog()
        //{
        //    foreach (LogMessage item in LoggerService.Logs)
        //    {
        //        Console.WriteLine(item.GenerrerID());
        //    }
        //} 
    }
}

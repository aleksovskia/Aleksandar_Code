﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodeAcademyZadaci
{
    public class MainTransakcija
    {
        public static void RunTransakcija()
        {
            var transakcii = new List<Transakcija>()
            {
                new DeviznaTransakcija(new Datum(20,01,2021),1000,"EUR"), //61000
                new DeviznaTransakcija(new Datum(20,01,2021),2000,"USD"), //100.000
                new DenarskaTransakcija(new Datum(20,01,2021),2000) // 2000
            };

            var smetka = new Smetka(transakcii, "123");
            smetka.IzvestajVoDenari();
            //    Console.WriteLine("Vnesi broj na transakcii: ");
            //    var n = Convert.ToInt32(Console.ReadLine());
            //    Transakcija transakcija = new Transakcija();
            //    List<Transakcija> listOdTransakcii = new List<Transakcija>();
            //    for (int i = 0; i < n; i++)
            //    {

            //        Console.WriteLine($"Vnesi Vid, datum i iznos na transakcijata za Denarska transakcija: {i + 1} ");
            //        var splited = Console.ReadLine().Split(" ");
            //        var vidNaTransakcija = Convert.ToInt32(splited[0]);  // 1. Denarska transakcija  2. Devizna transakcija
            //        int den = 1;
            //        int mesec = 1;
            //        int godina = 1;
            //        try
            //        {
            //            den = Convert.ToInt32(splited[1]);
            //            mesec = Convert.ToInt32(splited[2]);
            //            godina = Convert.ToInt32(splited[3]);
            //        }
            //        catch (Exception e)
            //        {
            //            Console.WriteLine(e.Message);


            //        }

            //        var izTransakcija = Convert.ToDouble(splited[4]);
            //        var datum_na_transakcija = new Datum(den, mesec, godina);
            //        var valuta = "MKD";
            //        transakcija = new DenarskaTransakcija(datum_na_transakcija, izTransakcija);
            //        if (vidNaTransakcija == 2)
            //        {
            //            valuta = splited[5];
            //            transakcija = new DeviznaTransakcija(datum_na_transakcija, izTransakcija, valuta);
            //        }
            //        listOdTransakcii.Add(transakcija);
            //    }
            //    var smetka = new Smetka(listOdTransakcii, "300047024112789");
            //    Console.WriteLine("Vnesete Pocetna sostojba vo MKD");
            //    smetka.SetPocetnoSaldo(Convert.ToInt32(Console.ReadLine()));
            //    // -- Pecatenje --
            //    smetka.pecatiTransakcii(); // ===PECHATENJE NA SITE TRANSAKCII===
            //    smetka.IzvestajVoDenari(); // ===IZVESHTAJ ZA SOSTOJBATA NA SMETKATA VO DENARI===
            //    smetka.IzvestajVoEvra(); // ===IZVESHTAJ ZA SOSTOJBATA NA SMETKATA VO EVRA===
            //    smetka.IzvestajVoDolari(); //===IZVESHTAJ ZA SOSTOJBATA NA SMETKATA VO DOLARI===
            //    Console.WriteLine("=== PROMENA NA KURSOT NA EVROTO I DOLAROT===");
            //    transakcija.SetEUR(62.1); // setiranje na kursot za Euroto
            //    transakcija.SetUSD(49.8);  // setiranje na kursot za Dolarot
            //    smetka.IzvestajVoDenari(); // ===IZVESHTAJ ZA SOSTOJBATA NA SMETKATA VO DENARI===
            //    smetka.IzvestajVoEvra(); // ===IZVESHTAJ ZA SOSTOJBATA NA SMETKATA VO EVRA===
            //    smetka.IzvestajVoDolari(); //===IZVESHTAJ ZA SOSTOJBATA NA SMETKATA VO DOLARI===
        }

        public class Transakcija
        {
            public Datum Datum_na_transakcija { get; set; }
            public double Iznos_transakcija { get; set; }
            public static double EUR { get; set; } = 61;
            public static double USD { get; set; } = 50;

            public Transakcija()
            {

            }

            public Transakcija(Datum datum, double iznos)
            {
                Datum_na_transakcija = datum;
                Iznos_transakcija = iznos;
            }

            public virtual double VoDenari()
            {
                return Iznos_transakcija;
            }

            public virtual double VoEvra()
            {
                return Iznos_transakcija;
            }

            public virtual double VoDolari()
            {
                return Iznos_transakcija;
            }

            public virtual void Pecati()
            {
                Console.WriteLine($"{Datum_na_transakcija.Den}/{Datum_na_transakcija.Mesec}/{Datum_na_transakcija.Godina} {Iznos_transakcija}");
            }

            public double SetEUR(double eur)
            {
                return EUR = eur;
            }

            public double SetUSD(double usd)
            {
                return USD = usd;
            }
        }

        public class Datum
        {
            public int Den { get; set; }
            public int Mesec { get; set; }
            public int Godina { get; set; }

            public Datum()
            {

            }

            public Datum(int den, int mesec, int godina)
            {
                Den = den;
                Mesec = mesec;
                Godina = godina;
            }
        }

        public class DenarskaTransakcija : Transakcija
        {
            public DenarskaTransakcija(Datum datum, double iznos)
                : base(datum, iznos)
            {
                if (datum.Den > 31 || datum.Den < 1 && datum.Mesec < 1 || datum.Mesec > 12)
                {
                    throw new InvalidDateException($"Invalid Date {datum.Den}/{datum.Mesec}/{datum.Godina}");
                }
            }

            public override double VoEvra()
            {
                return Iznos_transakcija / EUR;
            }

            public override double VoDolari()
            {
                return Iznos_transakcija / USD;
            }

            public override void Pecati()
            {
                Console.WriteLine($"{Datum_na_transakcija.Den}/{Datum_na_transakcija.Mesec}/{Datum_na_transakcija.Godina} {Iznos_transakcija} MKD");
            }
        }
        public class DeviznaTransakcija : Transakcija
        {
            public string Valuta { get; set; }
            public DeviznaTransakcija(Datum datum, double iznos, string valuta)
                : base(datum, iznos)
            {
                if (valuta != "EUR" && valuta != "USD")
                {
                    throw new NotSupportedCurrencyException($"{Valuta} is not a supported currency");
                }
                Valuta = valuta;
            }

            public override void Pecati()
            {
                Console.WriteLine($"{Datum_na_transakcija.Den}/{Datum_na_transakcija.Mesec}/{Datum_na_transakcija.Godina} {Iznos_transakcija} {Valuta}");
            }

            public override double VoDenari()
            {
                if (Valuta == "EUR")
                {
                    return Iznos_transakcija * EUR;
                }
                else if (Valuta == "USD")
                {
                    return Iznos_transakcija * USD;
                }
                else
                {
                    throw new NotSupportedCurrencyException($"{Valuta} is not a supported currency");
                }
            }
            public override double VoEvra()
            {
                if (Valuta == "EUR")
                {
                    return Iznos_transakcija;
                }
                else if (Valuta == "USD")
                {
                    return Iznos_transakcija * USD / EUR;
                }
                else
                {
                    throw new NotSupportedCurrencyException($"{Valuta} is not a supported currency");
                }
            }

            public override double VoDolari()
            {
                if (Valuta == "USD")
                {
                    return Iznos_transakcija;
                }
                else if (Valuta == "USD")
                {
                    return Iznos_transakcija * USD / EUR;
                }
                else
                {
                    throw new NotSupportedCurrencyException($"{Valuta} is not a supported currency");
                }

            }
        }

        public class InvalidDateException : Exception
        {
            public InvalidDateException(string mesage)
                : base(mesage)
            {

            }
        }

        public class NotSupportedCurrencyException : Exception
        {
            public NotSupportedCurrencyException(string mesage)
                : base(mesage)
            {

            }
        }
        public class Smetka
        {
            public List<Transakcija> Transakcii { get; set; } = new List<Transakcija>();
            public string Broj_na_smetka { get; set; }
            public double Pocetno_saldo_mkd { get; set; } = 0;

            public Smetka()
            {

            }

            public Smetka(List<Transakcija> transakcii, string broj_na_smetka)
            {
                Transakcii = transakcii;
                Broj_na_smetka = broj_na_smetka;
            }

            public double saldo_na_smetka(string valuta = "MKD")
            {
                double saldo_na_smetka = 0;
                foreach (Transakcija trans in Transakcii)
                {
                    if (valuta == "EUR")
                    {
                        saldo_na_smetka += trans.VoEvra();
                    }
                    else if (valuta == "USD")
                    {
                        saldo_na_smetka += trans.VoDolari();
                    }
                    else
                    {
                        saldo_na_smetka += trans.VoDenari();
                    }


                }
                if (valuta == "EUR")
                {
                    return saldo_na_smetka + Pocetno_saldo_mkd / DeviznaTransakcija.EUR;
                }
                else if (valuta == "USD")
                {
                    return saldo_na_smetka + Pocetno_saldo_mkd / DeviznaTransakcija.USD;
                }
                return saldo_na_smetka + Pocetno_saldo_mkd;
            }

            public void IzvestajVoDenari()
            {
                Console.WriteLine("=== IZVESHTAJ ZA SOSTOJBATA NA SMETKATA VO DENARI ===");
                Console.WriteLine($"Korisnikot so smetka: {Broj_na_smetka} ima momentalno saldo od {Math.Round(saldo_na_smetka(), 2)} MKD");
            }

            public void IzvestajVoEvra()
            {
                Console.WriteLine("=== IZVESHTAJ ZA SOSTOJBATA NA SMETKATA VO EVRA===");
                Console.WriteLine($"Korisnikot so smetka: {Broj_na_smetka} ima momentalno saldo od {Math.Round(saldo_na_smetka("EUR"), 2)} EUR");
            }

            public void IzvestajVoDolari()
            {
                Console.WriteLine("===IZVESHTAJ ZA SOSTOJBATA NA SMETKATA VO DOLARI===");
                Console.WriteLine($"Korisnikot so smetka: {Broj_na_smetka} ima momentalno saldo od {Math.Round(saldo_na_smetka("USD"), 2)} USD");
            }

            public void pecatiTransakcii()
            {
                Console.WriteLine("===PECHATENJE NA SITE TRANSAKCII===");
                foreach (Transakcija trans in Transakcii)
                {
                    trans.Pecati();
                }
            }

            public double SetPocetnoSaldo(double saldo)
            {
                return Pocetno_saldo_mkd = saldo;

            }
        }
    }
}

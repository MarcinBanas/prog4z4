using System;

namespace prog4z4
{
    class Program
    {
        static void Main(string[] args)
        {
            var Kontekst1 = new KontekstTPH();
            Kontekst1.Database.EnsureCreated();
            Kontekst1.Osobas.Add(new Klient { Imie = "Marcin", Nazwisko = "Banaś", NumerRejestracyjny = "1234", NumerTelefonu = "888222999" });
            Kontekst1.Osobas.Add(new Pracownik { Imie = "Janusz", Nazwisko = "Kowalski", DataZatrudnienia = new DateTime(2021, 06, 01), DataZwolnienia = null });
            Kontekst1.Osobas.Add(new Klient { Imie = "M", Nazwisko = "B", NumerRejestracyjny = "123334", NumerTelefonu = "88822222999" });
            Kontekst1.SaveChanges();

            var Kontekst2 = new KontekstTPT();
            Kontekst2.Database.EnsureCreated();
            Kontekst2.Osobas.Add(new Klient { Imie = "Marcin", Nazwisko = "Banaś", NumerRejestracyjny = "1234", NumerTelefonu = "888222999" });
            Kontekst2.Osobas.Add(new Pracownik { Imie = "Janusz", Nazwisko = "Kowalski", DataZatrudnienia = new DateTime(2021, 06, 01), DataZwolnienia = null });
            Kontekst2.Osobas.Add(new Klient { Imie = "M", Nazwisko = "B", NumerRejestracyjny = "123334", NumerTelefonu = "88822222999" });
            Kontekst2.SaveChanges();
        }
    }
}

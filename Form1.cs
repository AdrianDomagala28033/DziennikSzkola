using Microsoft.EntityFrameworkCore;
using MiniDziennik.Context;
using MiniDziennik.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniDziennik
{
    public partial class Form1 : Form
    {
        SqlContext sqlContext;
        public Form1()
        {
            sqlContext = new SqlContext();
            InitializeComponent();
            //DodajKlasy();
            //DodajUczniow();
            tabelaUczniowGridView.AutoGenerateColumns = false;
            WyswietlUczniow();
            UzupelnijListeKlas();
        }

        private void UzupelnijListeKlas()
        {
            List<Klasa> listaKlas = sqlContext.Klasa.ToList();
            klasyComboBox.DataSource = listaKlas;
            klasyComboBox.DisplayMember = "NazwaKlasy";
        }

        private void WyswietlUczniow()
        {
            var listaUczniow = sqlContext.Uczniowie.Include(x=> x.Klasa);
            tabelaUczniowGridView.DataSource = listaUczniow.Select(x => new UczniowieKlasy { 
            Id = x.Id,
            Imie = x.Imie,
            Nazwisko = x.Nazwisko,
            Klasa = x.Klasa.NazwaKlasy,
            RokUrodzenia = x.RokUrodzenia
            }).ToList();
                
        }

        private void DodajKlasy()
        {
            sqlContext.Klasa.Add(new Klasa()
            {
                NazwaKlasy = "1A"
            });
            sqlContext.Klasa.Add(new Klasa()
            {
                NazwaKlasy = "2B"
            });
            sqlContext.Klasa.Add(new Klasa()
            {
                NazwaKlasy = "3C"
            });
            sqlContext.Klasa.Add(new Klasa()
            {
                NazwaKlasy = "3D"
            });
            sqlContext.SaveChanges();
        }

        private void DodajUczniow()
        {
            sqlContext.Uczniowie.Add(new Uczniowie()
            {
                Imie = "Ardian",
                Nazwisko = "Siedomagał",
                RokUrodzenia = 2003,
                KlasaId = 4
            });
            sqlContext.Uczniowie.Add(new Uczniowie()
            {
                Imie = "Jakub",
                Nazwisko = "Lodzik",
                RokUrodzenia = 2003,
                KlasaId = 4
            });
            sqlContext.Uczniowie.Add(new Uczniowie()
            {
                Imie = "Jan",
                Nazwisko = "Adam",
                RokUrodzenia = 2005,
                KlasaId = 2
            });
            sqlContext.Uczniowie.Add(new Uczniowie()
            {
                Imie = "Marcin",
                Nazwisko = "Banditfura",
                RokUrodzenia = 2006,
                KlasaId = 1
            });
            sqlContext.Uczniowie.Add(new Uczniowie()
            {
                Imie = "Anon",
                Nazwisko = "Koza",
                RokUrodzenia = 2003,
                KlasaId = 3
            });
            sqlContext.Uczniowie.Add(new Uczniowie()
            {
                Imie = "Mariusz",
                Nazwisko = "Kowal",
                RokUrodzenia = 2003,
                KlasaId = 3
            });
            sqlContext.Uczniowie.Add(new Uczniowie()
            {
                Imie = "Daniel",
                Nazwisko = "Nieczai",
                RokUrodzenia = 2005,
                KlasaId = 2
            });
            sqlContext.Uczniowie.Add(new Uczniowie()
            {
                Imie = "Marek",
                Nazwisko = "Konar",
                RokUrodzenia = 2006,
                KlasaId = 1
            });
            sqlContext.SaveChanges();
        }
    }
}

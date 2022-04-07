using Microsoft.EntityFrameworkCore;
using MiniDziennik.Context;
using MiniDziennik.Model;
using MiniDziennik.Okienka;
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
            listaKlas.Insert(0, new Klasa()
            {
                Id = 0,
                NazwaKlasy = "<Wszystkie>"
            });
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

        private void dodajButton_Click(object sender, EventArgs e)
        {
            DodajEdytujOkno oknoDodajEdytuj = new DodajEdytujOkno("Dodaj");

            if(oknoDodajEdytuj.ShowDialog() == DialogResult.OK)
            {
                sqlContext.Uczniowie.Add(new Uczniowie()
                {
                    Imie = oknoDodajEdytuj.Imie,
                    Nazwisko = oknoDodajEdytuj.Nazwisko,
                    Klasa = oknoDodajEdytuj.KlasaNazwa,
                    KlasaId = oknoDodajEdytuj.KlasaId,
                    RokUrodzenia = oknoDodajEdytuj.RokUrodzenia
                }); 
                sqlContext.SaveChanges();
            }

        }
        private void edytujButton_Click(object sender, EventArgs e)
        {
            DodajEdytujOkno oknoDodajEdytuj = new DodajEdytujOkno("Edytuj");

            if (oknoDodajEdytuj.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void szukajButton_Click(object sender, EventArgs e)
        {
            var listaFiltrowana = sqlContext.Uczniowie.Include(x => x.Klasa);
            Klasa klasyUczniow = klasyComboBox.SelectedItem as Klasa;
            String imieUcznia = imieTextBox.Text;
            String nazwiskoUcznia = nazwiskoTextBox.Text;
            int rokUrodzenia = (int)dataUrodzeniaNumeric.Value;
            String rokUrodzeniaStr = dataUrodzeniaNumeric.Text;
            tabelaUczniowGridView.DataSource = listaFiltrowana.Where(x => klasyUczniow.Id == 0 || x.KlasaId == klasyUczniow.Id)
            .Where(x => x.Imie == imieUcznia || imieUcznia == "")
            .Where(x => x.Nazwisko == nazwiskoUcznia || nazwiskoUcznia == "")
            .Where(x => x.RokUrodzenia == rokUrodzenia || rokUrodzeniaStr == "")
            .Select(x => new UczniowieKlasy
            {
                Id = x.Id,
                Imie = x.Imie,
                Nazwisko = x.Nazwisko,
                Klasa = x.Klasa.NazwaKlasy,
                RokUrodzenia = x.RokUrodzenia
            }).ToList();
            
        }

        private void dodajKlaseButton_Click(object sender, EventArgs e)
        {
            OknoDodajKlase oknoDodajKlase = new OknoDodajKlase();

            if (oknoDodajKlase.ShowDialog() == DialogResult.OK)
            {
                sqlContext.Klasa.Add(new Klasa()
                {
                    NazwaKlasy = oknoDodajKlase.NazwaKlasy
                });
                sqlContext.SaveChanges();
                UzupelnijListeKlas();
            }
        }

        
    }
}

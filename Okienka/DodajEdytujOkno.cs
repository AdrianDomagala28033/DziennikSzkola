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

namespace MiniDziennik.Okienka
{
    public partial class DodajEdytujOkno : Form
    {
        
        SqlContext sqlContext;
        public String Imie { 
            get {
                return imieTextBoxDE.Text;
            } }
        public String Nazwisko
        {
            get
            {
                return nazwiskoTextBoxDE.Text;
            }
        }
        public String KlasaNazwa
        {
            get
            {
                Klasa nazwaKlasy = klasaComboBoxDE.SelectedItem as Klasa;
                return sqlContext.Klasa.Where(k => k.NazwaKlasy == nazwaKlasy.NazwaKlasy).FirstOrDefault().NazwaKlasy;
            }
        }
        public int RokUrodzenia
        {
            get
            {
                return (int)rokUrodzeniaNumericDE.Value;
            }
        }
        public int KlasaId { get
            {
                Klasa klasaId = klasaComboBoxDE.SelectedItem as Klasa;
                return sqlContext.Klasa.Where(k => k.Id == klasaId.Id).FirstOrDefault().Id;
            }
         }

        

        public DodajEdytujOkno(String guzik, Uczniowie uczen)
        {
            sqlContext = new SqlContext();
            InitializeComponent();
            dodajUczniaButtonDE.Text = guzik;
            UzupelnijListeKlas();
        }

        private void UzupelnijListeKlas()
        {
            List<Klasa> listaKlas = sqlContext.Klasa.ToList();
            
            klasaComboBoxDE.DataSource = listaKlas;
            klasaComboBoxDE.DisplayMember = "NazwaKlasy";
        }

        private void dodajUczniaButtonDE_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Imie) && !string.IsNullOrEmpty(Nazwisko))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Uzupełnij!!");
            }
        }
        private void EdytujUcznia(Uczniowie uczen)
        {
   
                imieTextBoxDE.Text = uczen.Imie;
                nazwiskoTextBoxDE.Text = uczen.Nazwisko;
                klasaComboBoxDE.SelectedItem = uczen.Klasa;
                rokUrodzeniaNumericDE.Value = uczen.RokUrodzenia;
            
        }
        private void anulujButtonDE_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

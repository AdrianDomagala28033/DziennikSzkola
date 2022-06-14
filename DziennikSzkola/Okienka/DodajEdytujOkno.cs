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
        public Uczniowie DodanyUczen { get; set; }
        SqlContext sqlContext;
        
        

        public DodajEdytujOkno(string guzik, Uczniowie uczen, List<Klasa> klasa)
        {
            sqlContext = new SqlContext();
            InitializeComponent();
            DodanyUczen = uczen;
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
            if (imieTextBoxDE.Text == "" &&
                nazwiskoTextBoxDE.Text == "" &&
                rokUrodzeniaNumericDE.Value == 0 &&
                klasaComboBoxDE.SelectedIndex == 0)
            {
                MessageBox.Show("Uzupełnij!!");
            }
            else
            {
                DialogResult = DialogResult.OK;
                DodanyUczen.Imie = imieTextBoxDE.Text;
                DodanyUczen.Nazwisko = nazwiskoTextBoxDE.Text;
                DodanyUczen.RokUrodzenia = (int)rokUrodzeniaNumericDE.Value;
                DodanyUczen.KlasaId = (klasaComboBoxDE.SelectedItem as Klasa).Id;
                Close();
            }
        }
        private void EdytujUcznia( Uczniowie uczen)
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

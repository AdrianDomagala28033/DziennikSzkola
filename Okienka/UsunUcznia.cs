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
    public partial class UsunUcznia : Form
    {

        SqlContext sqlContext;
        public String Imie
        {
            get
            {
                return imieTextBoxU.Text;
            }
        }
        public String Nazwisko
        {
            get
            {
                return nazwiskoTextBoxU.Text;
            }
        }
        public String Klasa
        {
            get
            {
                Klasa nazwaKlasy = klasaComboBoxU.SelectedItem as Klasa;
                return sqlContext.Klasa.Where(k => k.NazwaKlasy == nazwaKlasy.NazwaKlasy).FirstOrDefault().NazwaKlasy;
            }
        }
        public int RokUrodzenia
        {
            get
            {
                return (int)rokUrodzeniaNumericU.Value;
            }
        }

        public UsunUcznia()
        {
            InitializeComponent();
            sqlContext = new SqlContext();
            UzupelnijListeKlas();
        }

        private void UzupelnijListeKlas()
        {
            List<Klasa> listaKlas = sqlContext.Klasa.ToList();

            klasaComboBoxU.DataSource = listaKlas;
            klasaComboBoxU.DisplayMember = "NazwaKlasy";
        }
        private void usunUczniaButtonU_Click(object sender, EventArgs e)
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

        private void anulujButtonDE_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

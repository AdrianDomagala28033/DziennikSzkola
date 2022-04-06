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
        public String Imie { get {
                return imieTextBoxDE.Text;
            } }
        public String Nazwisko
        {
            get
            {
                return nazwiskoTextBoxDE.Text;
            }
        }
        
        public DodajEdytujOkno()
        {
            InitializeComponent();
        }

        private void dodajUczniaButtonDE_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Imie))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Uzupełnij!!");
                //NazwaKlasy
            }
        }

        private void anulujButtonDE_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class OknoDodajKlase : Form
    {
        public String NazwaKlasy { get {
                return nazwaKlasyTextBox.Text;
            } }
        public OknoDodajKlase()
        {
            InitializeComponent();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NazwaKlasy))
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

        private void anulujButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

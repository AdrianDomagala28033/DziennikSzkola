using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDziennik.Model
{
    class Uczniowie
    {
        public int Id { get; set; }
        public String Imie { get; set; }
        public String Nazwisko { get; set; }
        public int RokUrodzenia { get; set; }

        public int KlasaId { get; set; }
        public Klasa Klasa { get; set; }
    }
}

﻿using MiniDziennik.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDziennik.Model
{
    class UczniowieKlasy
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int RokUrodzenia { get; set; }
        public string Klasa { get; set; }
    }
}


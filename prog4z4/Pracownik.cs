﻿using System;
using System.Collections.Generic;
using System.Text;

namespace prog4z4
{
    public class Pracownik : Osoba
    {
        public DateTime DataZatrudnienia { get; set; }
        public DateTime? DataZwolnienia { get; set; }
    }
}

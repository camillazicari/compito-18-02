﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compito_18_02.Models
{
    public class Studi
    {
        public string Qualifica { get; set; }
        public string Istituto { get; set; }
        public string Tipo { get; set; }
        public DateOnly Dal {  get; set; }
        public DateOnly Al { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Pod : Kategori
    {
        public string PodNamn {  get; set; }
        
        public int AntalAvsnitt {  get; set; }

        public Pod()
        {

        }
}

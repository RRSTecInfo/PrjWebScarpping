﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjWebScrapping.Infra.CrossCutting.Classes
{
    public class WebScrapper
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; } 
        public string Url { get; set; } 
        public string Preco {  get; set; }
    }
}

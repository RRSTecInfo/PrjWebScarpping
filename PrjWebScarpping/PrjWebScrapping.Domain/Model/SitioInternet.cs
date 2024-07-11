using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjWebScrapping.Domain.Model
{
    public class SitioInternet:  BaseEntity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string EnderecoInternet {  get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1_EF
{
    internal class Ogrenci
    {
        [Key] public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public int okulNo { get; set; }
    }
}

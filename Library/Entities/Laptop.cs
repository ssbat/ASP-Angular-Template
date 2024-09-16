using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Laptop
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public float Price { get; set; }
        public string Procesor { get; set; }
        public int Ram { get; set; }
        public string Gpu { get; set; }
        public int Storage { get; set; }
    }
}

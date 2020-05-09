using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storm.Data.Models
{
    public class Product
    {
        public int id { set; get; }
        public string name { set; get; }
        public string shortdesc { set; get; }
        public string longdesc { set; get; }
        public string img { set; get; }
        public ushort price { set; get; }
        public bool isFavourite { set; get; }
        public bool available { set; get; }
        public int categoryid { set; get; }
        public virtual Category Category { set; get; }
    }
}

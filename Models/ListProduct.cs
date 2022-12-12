using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Milea_Petrica_Lab7.Models
{
    public class ListProduct
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [ForeignKey(typeof(ShopList))]
        public int ShopListID { get; set; }

        public int ProductID { get; set; }
    }
}

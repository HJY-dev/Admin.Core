using Castle.Components.DictionaryAdapter;
using FreeSql.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Core.Model.Test
{
    [Table(Name = "Customers")]
    public class Customers
    {
        [Column(IsPrimary =true)]
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}

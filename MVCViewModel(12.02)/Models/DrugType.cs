using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class DrugType
    {
        public string Name { get; set; }
        public DrugType(string Name)
        {
            this.Name = Name;
        }
    }
}

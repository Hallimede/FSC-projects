using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Homework6
{
     public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [Required]
        public string Name{get;set;}
        public Client(string name) { Name = name; }
        public Client() { Name = default; }

        public override string ToString()
        {
            return Name;
        }
    }
}

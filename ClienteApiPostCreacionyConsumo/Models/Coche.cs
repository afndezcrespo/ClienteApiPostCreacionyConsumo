using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteApiPostCreacionyConsumo.Models
{
    public class Coche
    {
      
        public int IdCoche { get; set; }
       
        public String Marca { get; set; }
        
        public String Origen { get; set; }
        
        public String Modelo { get; set; }
        
        public int CV { get; set; }
        
        public int VelocidadMaxima { get; set; }
      
        public decimal Aceleracion { get; set; }
    }
}

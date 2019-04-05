using ClienteApiPostCreacionyConsumo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteApiPostCreacionyConsumo.Repositories
{
   public interface IRepositoryApiCoches
    {
        Task<List<String>> GetMarcas();
        Task<List<Coche>> GetCochesPorMarca(String marca);
        Task<List<Coche>> GetCoches();
    }
}

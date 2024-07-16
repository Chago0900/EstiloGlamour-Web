using System.Collections.Generic;
using System.Threading.Tasks;
using EstiloGlamourApi.Models;
using Microsoft.Extensions.Configuration;

namespace EstiloGlamourApi
{
    public interface IProductoRepository
    {
        Task<Producto> Get(string Id);
        Task<IEnumerable<Producto>> GetAll();
        Task Add(Producto producto);
        Task Delete(string Id);
        Task Update(Producto producto, string id);           
    }
}
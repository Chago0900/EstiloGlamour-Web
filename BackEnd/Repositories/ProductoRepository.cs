using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EstiloGlamourApi.Models;
using EstiloGlamourApi.Data;


namespace EstiloGlamourApi.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly IEstiloGlamourOnlinedatabaseContext _context;
        public ProductoRepository(IEstiloGlamourOnlinedatabaseContext context)
        {
            _context = context;
    
        }
        public async Task Add(Producto producto)
        {        
            _context.PRODUCTO.Add(producto);
            await _context.SaveChangesAsync();
        }
    
        public async Task Delete(string Id)
        {
            var itemToRemove = await _context.PRODUCTO.FindAsync(Id);
            if (itemToRemove == null)
                throw new NullReferenceException();
            
            // Borra el objeto
            _context.PRODUCTO.Remove(itemToRemove);
            await _context.SaveChangesAsync();
        }
    
        public async Task<Producto> Get(string Id)
        {
            return await _context.PRODUCTO.FindAsync(Id);
        }
    
        public async Task<IEnumerable<Producto>> GetAll()
        {
            return await _context.PRODUCTO.ToListAsync();
        }
    
        public async Task Update(Producto producto, string id)
        {
            var itemToUpdate = await _context.PRODUCTO.FindAsync(id);
            if (itemToUpdate == null)
                throw new NullReferenceException();
            itemToUpdate.Nombre = producto.Nombre;
            itemToUpdate.Casa = producto.Casa;
            itemToUpdate.Descripcion = producto.Descripcion;
            itemToUpdate.Tamanio = producto.Tamanio;
            itemToUpdate.Genero = producto.Genero;
            itemToUpdate.Imagen = producto.Imagen;
            itemToUpdate.Precio_mayor = producto.Precio_mayor;
            itemToUpdate.Tipo_perfume = producto.Tipo_perfume;
            itemToUpdate.Precio_detalle = producto.Precio_detalle;

            await _context.SaveChangesAsync();
    
        }

    }
}
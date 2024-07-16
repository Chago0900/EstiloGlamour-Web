using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EstiloGlamourApi.Models;
using EstiloGlamourApi.Data;


namespace EstiloGlamourApi.Repositories
{
    public class CampeonatoRepository : ICampeonatoRepository
    {
        private readonly IEstiloGlamourOnlinedatabaseContext _context;
        public CampeonatoRepository(IEstiloGlamourOnlinedatabaseContext context)
        {
            _context = context;
    
        }
        public async Task Add(Campeonato campeonato)
        {        
            _context.CAMPEONATO.Add(campeonato);
            await _context.SaveChangesAsync();
        }
    
        public async Task Delete(string Id)
        {
            var itemToRemove = await _context.CAMPEONATO.FindAsync(Id);
            if (itemToRemove == null)
                throw new NullReferenceException();
            
            // Borra el objeto
            _context.CAMPEONATO.Remove(itemToRemove);
            await _context.SaveChangesAsync();
        }
    
        public async Task<Campeonato> Get(string Id)
        {
            return await _context.CAMPEONATO.FindAsync(Id);
        }
    
        public async Task<IEnumerable<Campeonato>> GetAll()
        {
            return await _context.CAMPEONATO.ToListAsync();
        }
    
        public async Task Update(Campeonato campeonato, string id)
        {
            var itemToUpdate = await _context.CAMPEONATO.FindAsync(id);
            if (itemToUpdate == null)
                throw new NullReferenceException();
            itemToUpdate.Nombre = campeonato.Nombre;
            itemToUpdate.Fecha_inicio = campeonato.Fecha_inicio;
            itemToUpdate.Fecha_fin = campeonato.Fecha_fin;
            itemToUpdate.Descripcion_reglas = campeonato.Descripcion_reglas;

            await _context.SaveChangesAsync();
    
        }

    }
}
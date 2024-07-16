using Microsoft.EntityFrameworkCore;
using EstiloGlamourApi.Models;
using System.Threading.Tasks;


namespace EstiloGlamourApi.Data
{
    public class EstiloGlamourOnlinedatabaseContext : DbContext, IEstiloGlamourOnlinedatabaseContext
    {

        public EstiloGlamourOnlinedatabaseContext(DbContextOptions<EstiloGlamourOnlinedatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Campeonato> CAMPEONATO { get; init; }
        public DbSet<Producto> PRODUCTO { get; init; }

    }
}

        

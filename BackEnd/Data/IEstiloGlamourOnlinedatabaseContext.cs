using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EstiloGlamourApi.Models;

// Represents a session with the database and can be used to query and save instances of your entities.

namespace EstiloGlamourApi.Data
{
    public interface IEstiloGlamourOnlinedatabaseContext
    {
        DbSet<Campeonato> CAMPEONATO { get; init; }
        DbSet<Producto> PRODUCTO { get; init; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
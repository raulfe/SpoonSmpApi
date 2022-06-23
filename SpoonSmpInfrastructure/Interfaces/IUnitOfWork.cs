using SpoonSmpCore.Models.Database;
using System;
using System.Threading.Tasks;

namespace SpoonSmpInfrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<RegistedUser> RegistedRepository { get; }
        IRepository<Spaces> SpaceRepository { get; }
        IRepository<SystemUser> SystemRepository { get; }
        IRepository<User> UserRepository { get; }
        IRepository<Reservations> ReservationRepository { get; }
        void SaveChanges();
        Task SaveChangesAsync();
    }
}

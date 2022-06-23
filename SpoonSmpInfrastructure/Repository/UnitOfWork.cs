using SpoonSmpCore.Models.Database;
using SpoonSmpInfrastructure.Context;
using SpoonSmpInfrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpoonSmpInfrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly haguayContext _context;
        private readonly IRepository<RegistedUser> _registedRepository;
        private readonly IRepository<Reservations> _reservationsRepository;
        private readonly IRepository<Spaces> _spaceRepository;
        private readonly IRepository<SystemUser> _systemRepository;
        private readonly IRepository<User> _userRepository;
        public UnitOfWork(haguayContext context)
        {
            _context = context;
        }
        public IRepository<RegistedUser> RegistedRepository => _registedRepository ?? new Repository<RegistedUser>(_context);

        public IRepository<Spaces> SpaceRepository => _spaceRepository ?? new Repository<Spaces>(_context);

        public IRepository<SystemUser> SystemRepository => _systemRepository ?? new Repository<SystemUser>(_context);

        public IRepository<User> UserRepository => _userRepository ?? new Repository<User>(_context);

        public IRepository<Reservations> ReservationRepository => _reservationsRepository ?? new Repository<Reservations>(_context);

        public void Dispose()
        {
            if(_context != null)
            {
                _context.Dispose();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

﻿using Microsoft.EntityFrameworkCore;
using ProgressBoardApp.DAL.DataAccess;
using ProgressBoardApp.DAL.Interfaces;
using ProgressBoardApp.Domain.Entities;

namespace ProgressBoardApp.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private ProgressBoardContext db;
        private UserRepository userRepository;

        public EFUnitOfWork(DbContextOptions<ProgressBoardContext> options)
        {
            db = new ProgressBoardContext(options);
        }
        public IRepository<User> Users
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(db);
                return userRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

﻿using Ninject.Modules;
using ProgressBoardApp.DAL.Interfaces;
using ProgressBoardApp.DAL.Repositories;

namespace ProgressBoardApp.BAL.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        private string connectionString;
        public ServiceModule(string connection)
        {
            connectionString = connection;
        }
        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}
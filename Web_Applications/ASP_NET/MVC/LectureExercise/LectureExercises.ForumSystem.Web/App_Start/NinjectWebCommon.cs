﻿using LectureExercise.Forum.Data;
using LectureExercise.Forum.Data.Repositories;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Modules;
using Ninject.Web.Common;
using Ninject.Web.Common.WebHost;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;

namespace LectureExercises.ForumSystem.Web.App_Start
{
    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            return Container;
        }

        public static T GetConcreteInstance<T>()
        {
            object instance = Container.TryGet<T>();
            if (instance != null)
                return (T)instance;
            throw new InvalidOperationException(string.Format("Unable to create an instance of {0}", typeof(T).FullName));
        }

        public static IKernel _container;
        private static IKernel Container
        {
            get
            {
                if (_container == null)
                {
                    _container = new StandardKernel();
                    _container.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                    _container.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                    RegisterServices(_container);
                }
                return _container;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(x =>
           {
               x.FromThisAssembly()
               .SelectAllClasses()
               .BindDefaultInterface();

           });
            kernel.Bind(typeof(DbContext), typeof(MsSqlDbContext)).To<MsSqlDbContext>().InRequestScope();
            kernel.Bind(typeof(IEfRepository<>)).To(typeof(EfRepository<>));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using RealEstateApp2.Models;
using Ninject;
namespace RealEstateApp2.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            // put bindings here


            kernel.Bind<IHouseRepository>().To<EFHouseRepository>();

        }
    }
}
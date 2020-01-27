using AutomaticRatingMechanism;
using AutomaticRatingMechanism.Inputs;
using AutomaticRatingMechanism.Logger;
using Contracts;
using System;
using Unity;

namespace BootStrap
{
    public static class BootStrapper
    {
        public static IUnityContainer OnStartup()
        {
            var container = new UnityContainer();
            container.RegisterType<ILogger, ConsoleLogger>();
            container.RegisterType<ISpecificationInput, SpecificationInputFromFile>();
            container.RegisterType<IMechanism, AutoRatingMechanism>();
            return container;
        }      
    }
}

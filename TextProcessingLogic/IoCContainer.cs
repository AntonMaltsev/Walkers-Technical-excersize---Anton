using System;
using SimpleInjector;

namespace TextProcessingLogic.IoC
{
    public static class IoCContainer
    {
        private static readonly object InstanceLock = new object();

        private static volatile Container containerInstance;

        public static Container Default
        {
            get
            {
                if (containerInstance == null)
                {
                    lock (InstanceLock)
                    {
                        if (containerInstance == null)
                        {
                            containerInstance = new Container();
                            containerInstance.Options.AllowOverridingRegistrations = true;
                        }
                    }
                }

                return containerInstance;
            }
        }

        public static void OverrideContainer(Container container)
        {            
            if(container == null)
                throw new ArgumentNullException("container");

            lock (InstanceLock)
            {
                containerInstance = container;
            }
        }
    }
}


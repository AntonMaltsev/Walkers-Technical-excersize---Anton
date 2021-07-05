using System;
using SimpleInjector;

namespace TextProcessing.Logic
{
    public static class IoCContainer
    {
        private static readonly object InstanceLock = new object();

        private static volatile Container _containerInstance;

        public static Container Default
        {
            get
            {
                if (_containerInstance == null)
                {
                    lock (InstanceLock)
                    {
                        if (_containerInstance == null)
                        {
                            _containerInstance = new Container();
                            _containerInstance.Options.AllowOverridingRegistrations = true;
                        }
                    }
                }

                lock (InstanceLock)
                {
                    return _containerInstance;
                }
            }
        }

        public static void OverrideContainer(Container container)
        {            
            if(container == null)
                throw new ArgumentNullException("container");

            lock (InstanceLock)
            {
                _containerInstance = container;
            }
        }
    }
}


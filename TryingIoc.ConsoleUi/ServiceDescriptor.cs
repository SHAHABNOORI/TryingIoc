﻿using System;

namespace TryingIoc.ConsoleUi
{
    public class ServiceDescriptor
    {
        public ServiceDescriptor(object implementation, ServiceLifeTime lifeTime)
        {
            ServiceType = implementation.GetType();
            Implementation = implementation;
            LifeTime = lifeTime;
        }

        public ServiceDescriptor(Type serviceType, Type implementationType, ServiceLifeTime lifeTime)
        {
            ServiceType = serviceType;
            ImplementationType = implementationType;
            LifeTime = lifeTime;
        }

        public Type ServiceType { get; }
        
        public Type ImplementationType { get; }

        public object Implementation { get; internal set; }

        public ServiceLifeTime LifeTime { get; }
    }
}
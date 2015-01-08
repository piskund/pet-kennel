// ------------------------------------------------------------------------
// <copyright file="UnityStaticFactoryExtensions.cs" company="DEP Space">
//     DEP Space. All rights reserved
// </copyright>
// <author>
//     Dmitry Piskun
// </author>
// <summary>
//      Initially created on 05/12/2013
// </summary>
// ------------------------------------------------------------------------

namespace Mechs.Common.Helpers
{
    using System;
    using Microsoft.Practices.Unity;
    using Microsoft.Practices.Unity.StaticFactory;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class UnityStaticFactoryExtensions
    {
        private static IStaticFactoryConfiguration GetExtension(IUnityContainer container)
        {
            var ext = container.Configure<StaticFactoryExtension>();
            if (ext == null)
            {
                container.AddNewExtension<StaticFactoryExtension>();
                ext = container.Configure<StaticFactoryExtension>();
            }
            return ext;
        }

        public static IUnityContainer RegisterFactory<T>(
            this IUnityContainer container,
            Func<IUnityContainer, T> factoryMethod)
        {
            GetExtension(container).RegisterFactory<T>(c => factoryMethod(c));
            return container;
        }

        public static IUnityContainer RegisterFactory<T>(
            this IUnityContainer container,
            string name,
            Func<IUnityContainer, T> factoryMethod)
        {
            GetExtension(container).RegisterFactory<T>(name, c => factoryMethod(c));
            return container;
        }
    }
}

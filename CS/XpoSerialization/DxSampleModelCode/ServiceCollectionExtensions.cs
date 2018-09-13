﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using XpoSerialization.DxSampleModel;
namespace XpoSerialization.DxSampleModel
{
    public partial class DxSampleModelUnitOfWork : UnitOfWork
    {
        public DxSampleModelUnitOfWork() : base() { }
        public DxSampleModelUnitOfWork(DevExpress.Xpo.Metadata.XPDictionary dictionary) : base(dictionary) { }
        public DxSampleModelUnitOfWork(IDataLayer layer, params IDisposable[] disposeOnDisconnect) : base(layer, disposeOnDisconnect) { }
        public DxSampleModelUnitOfWork(IObjectLayer layer, params IDisposable[] disposeOnDisconnect) : base(layer, disposeOnDisconnect) { }
    }
}
namespace Microsoft.Extensions.DependencyInjection
{
    public static class DxSampleModelXpoServiceCollectionExtensions
    {
        public static IServiceCollection AddDxSampleModelAsXpoDefaultUnitOfWork(this IServiceCollection serviceCollection, bool useDataLayerAsSingletone = true, Action<DataLayerOptionsBuilder> customDataLayerOptionsBuilder = null)
        {
            Action<DataLayerOptionsBuilder> optionsBuilder = CreateDataLayerOptionsBuilder(customDataLayerOptionsBuilder);
            return serviceCollection.AddXpoDefaultUnitOfWork(useDataLayerAsSingletone, optionsBuilder);
        }
        public static IServiceCollection AddDxSampleModelAsXpoDefaultSession(this IServiceCollection serviceCollection, bool useDataLayerAsSingletone = true, Action<DataLayerOptionsBuilder> customDataLayerOptionsBuilder = null)
        {
            Action<DataLayerOptionsBuilder> optionsBuilder = CreateDataLayerOptionsBuilder(customDataLayerOptionsBuilder);
            return serviceCollection.AddXpoDefaultSession(useDataLayerAsSingletone, optionsBuilder);
        }
        public static IServiceCollection AddDxSampleModelUnitOfWork(this IServiceCollection serviceCollection, bool useDataLayerAsSingletone = true, Action<DataLayerOptionsBuilder> customDataLayerOptionsBuilder = null)
        {
            Action<DataLayerOptionsBuilder> optionsBuilder = CreateDataLayerOptionsBuilder(customDataLayerOptionsBuilder);
            return serviceCollection.AddXpoCustomSession<DxSampleModelUnitOfWork>(useDataLayerAsSingletone, optionsBuilder);
        }
        public static IServiceCollection AddDxSampleModelXpoDefaultDataLayer(this IServiceCollection serviceCollection, ServiceLifetime lifetime, Action<DataLayerOptionsBuilder> customDataLayerOptionsBuilder = null)
        {
            Action<DataLayerOptionsBuilder> optionsBuilder = CreateDataLayerOptionsBuilder(customDataLayerOptionsBuilder);
            return serviceCollection.AddXpoDefaultDataLayer(lifetime, customDataLayerOptionsBuilder);
        }
        static Action<DataLayerOptionsBuilder> CreateDataLayerOptionsBuilder(Action<DataLayerOptionsBuilder> injectCustomDataLayerOptionsBuilder)
        {
            return (options) =>
            {
                options.UseConnectionString(ConnectionHelper.ConnectionString)
                .UseEntityTypes(ConnectionHelper.GetPersistentTypes());
                if (injectCustomDataLayerOptionsBuilder != null)
                {
                    injectCustomDataLayerOptionsBuilder(options);
                }
            };
        }
    }
}

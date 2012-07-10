using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using experienciacessivel.infrastructure.crosscutting.Adapter;
using AutoMapper;

namespace experienciacessivel.infrastructure.impl.Adapter
{
    public class AutomapperTypeAdapterFactory
        : ITypeAdapterFactory
    {
        #region Constructor

        /// <summary>
        /// Create a new Automapper type adapter factory
        /// </summary>
        public AutomapperTypeAdapterFactory()
        {
            //scan all assemblies finding Automapper Profile
            var profiles = AppDomain.CurrentDomain
                .GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => t.BaseType == typeof (Profile));

            Mapper.Initialize(cfg =>
                                  {
                                      foreach (var item in profiles)
                                      {
                                          if (item.FullName != "AutoMapper.SelfProfiler`2")
                                              cfg.AddProfile(Activator.CreateInstance(item) as Profile);
                                      }
                                  });
        }

        #endregion

        #region ITypeAdapterFactory Members

        public ITypeAdapter Create()
        {
            return new AutomapperTypeAdapter();
        }

        #endregion
    }
}
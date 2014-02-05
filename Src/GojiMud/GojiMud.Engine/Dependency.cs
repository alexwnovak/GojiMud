﻿using Microsoft.Practices.Unity;

namespace GojiMud.Engine
{
   public static class Dependency
   {
      private static IUnityContainer _unityContainer;

      public static IUnityContainer UnityContainer
      {
         get
         {
            return _unityContainer;
         }
      }

      public static void CreateUnityContainer()
      {
         _unityContainer = new UnityContainer();
      }

      public static void RegisterInstance<T>( T instance )
      {
         _unityContainer.RegisterInstance( instance );
      }

      public static void RegisterType<TFrom, TTo>() where TTo : TFrom
      {
         _unityContainer.RegisterType<TFrom, TTo>();
      }

      public static T Resolve<T>()
      {
         return _unityContainer.Resolve<T>();
      }
   }
}

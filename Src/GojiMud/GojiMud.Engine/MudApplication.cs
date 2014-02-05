namespace GojiMud.Engine
{
   public class MudApplication
   {
      private static void InitializeDependencyInjection()
      {
         Dependency.CreateUnityContainer();
      }

      public void Run( string[] arguments )
      {
         InitializeDependencyInjection();
      }
   }
}

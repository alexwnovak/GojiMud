using GojiMud.Engine;

namespace GojiMud.Launcher
{
   internal static class Program
   {
      private static void Main( string[] arguments )
      {
         var mudApplication = new MudApplication();

         mudApplication.Run( arguments );
      }
   }
}

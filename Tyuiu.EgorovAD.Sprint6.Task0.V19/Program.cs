using Tyuiu.EgorovAD.Sprint6.Task0.V19.Lib;
namespace Tyuiu.EgorovAD.Sprint6.Task0.V19
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}
using BookManagement_HoangNgocTrinh;

namespace BookManagement
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
       
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}
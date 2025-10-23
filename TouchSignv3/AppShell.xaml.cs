using TouchSignv3;

namespace TouchSignv3
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Registramos SecondPage para que funcione Shell navigation
            Routing.RegisterRoute(nameof(SecondPage), typeof(SecondPage));
        }
    }
}
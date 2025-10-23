using Microsoft.Maui.Controls;
namespace TouchSignv3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Letter_Clicked(object sender, EventArgs e)
        {
            if (sender is ImageButton btn)
            {
                string letter = btn.StyleId;
                TxtDisplay.Text += letter;
            }
        }

        private void Space_Clicked(object sender, EventArgs e)
        {
            TxtDisplay.Text += " ";
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtDisplay.Text))
                TxtDisplay.Text = TxtDisplay.Text.Substring(0, TxtDisplay.Text.Length - 1);
        }

        private void Enter_Clicked(object sender, EventArgs e)
        {
            string mensaje = TxtDisplay.Text;

            if (!string.IsNullOrWhiteSpace(mensaje))
            {
                MessagesContainer.Children.Clear();

                var mensajeLabel = new Label
                {
                    Text = mensaje,
                    TextColor = Colors.Black,
                    FontSize = 25,
                    Padding = new Thickness(10),
                    HorizontalOptions = LayoutOptions.End,
                    MaximumWidthRequest = 500,
                    LineBreakMode = LineBreakMode.WordWrap,
                };

                var mensajeBurbuja = new Frame
                {
                    Content = mensajeLabel,
                    CornerRadius = 15,
                    Padding = 0,
                    Margin = new Thickness(0, 5, 0, 5),
                    BackgroundColor = Color.FromArgb("#FFFFFF"),
                    HasShadow = false,
                    HorizontalOptions = LayoutOptions.Center
                };

                MessagesContainer.Children.Add(mensajeBurbuja);

                TxtDisplay.Text = string.Empty;
            }
        }

        // 🔽 MÉTODO NUEVO: Para ir a la Segunda Página
        private async void GoToSecondPage_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(SecondPage));
        }
    }
}

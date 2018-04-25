using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaDemoApp.Control
{
    public class ButtonDemo : UserControl
    {
        public ButtonDemo()
        {
            this.InitializeComponent();
            this.FindControl<Button>("button1").Click += (s, e) =>
            {
                this.FindControl<TextBlock>("txt").Text = "Button1 is Click";
            };
            this.FindControl<Button>("button2").Click += (s, e) =>
            {
                this.FindControl<TextBlock>("txt").Text = "Button2 is Click";
            };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

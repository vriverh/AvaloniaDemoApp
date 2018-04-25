using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaDemoApp.Control
{
    public class RepeatButtonDemo : UserControl
    {
        private int _clickNumber = 0;

        public RepeatButtonDemo()
        {
            this.InitializeComponent();
            this.FindControl<Button>("fastRepeatButton").Click += RepeatButtonDemo_Click;
            this.FindControl<Button>("slowRepeatButton").Click += RepeatButtonDemo_Click;
        }

        private void RepeatButtonDemo_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            this.FindControl<TextBlock>("clickNumberTxt").Text = _clickNumber++.ToString();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

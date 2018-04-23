using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaDemoApp.Control
{
    public class ControlDemo : Window
    {
        public ControlDemo()
        {
            this.InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            this.FindControl<Button>("ContentControlDemoButton").Click += (s, e) =>
            {
                ContentControlDemo contentControlDemo = new ContentControlDemo();
                contentControlDemo.ShowDialog();
            };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

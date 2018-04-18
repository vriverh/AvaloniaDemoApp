using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaDemoApp.Layout;

namespace AvaloniaDemoApp
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            this.FindControl<Button>("LayoutDemoButton").Click += (s, e) =>
            {
                LayoutDemo layoutDemo = new LayoutDemo();
                layoutDemo.ShowDialog();
            };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

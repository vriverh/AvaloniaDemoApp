using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaDemoApp.Control;
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
            //this.FindControl<Button>("LayoutDemoButton").Click += (s, e) =>
            //{
            //    LayoutDemo layoutDemo = new LayoutDemo();
            //    layoutDemo.ShowDialog();
            //};
            //this.FindControl<Button>("ControlDemoButton").Click += (s, e) =>
            //{
            //    ControlDemo controlDemo = new ControlDemo();
            //    controlDemo.ShowDialog();
            //};
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

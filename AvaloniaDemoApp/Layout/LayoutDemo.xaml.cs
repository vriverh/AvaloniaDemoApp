using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaDemoApp.Layout
{
    public class LayoutDemo : Window
    {
        public LayoutDemo()
        {
            this.InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            this.FindControl<Button>("StackPanelDemoButton").Click += (s, e) =>
            {
                StackPanelDemo stackPanelDemo = new StackPanelDemo();
                stackPanelDemo.ShowDialog();
            };
            this.FindControl<Button>("WrapPanelDemoButton").Click += (s, e) =>
            {
                WrapPanelDemo wrapPanelDemo = new WrapPanelDemo();
                wrapPanelDemo.ShowDialog();
            };
            this.FindControl<Button>("DockPanelDemoButton").Click += (s, e) =>
            {
                DockPanelDemo dockPanelDemo = new DockPanelDemo();
                dockPanelDemo.ShowDialog();
            };
            this.FindControl<Button>("GridDemoButton").Click += (s, e) =>
            {
                GridDemo gridDemo = new GridDemo();
                gridDemo.ShowDialog();
            };
            this.FindControl<Button>("CanvasDemoButton").Click += (s, e) =>
            {
                CanvasDemo canvasDemo = new CanvasDemo();
                canvasDemo.ShowDialog();
            };
            this.FindControl<Button>("BorderDemoButton").Click += (s, e) =>
            {
                BorderDemo borderDemo = new BorderDemo();
                borderDemo.ShowDialog();
            };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

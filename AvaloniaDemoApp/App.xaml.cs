using Avalonia;
using Avalonia.Markup.Xaml;

namespace AvaloniaDemoApp
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

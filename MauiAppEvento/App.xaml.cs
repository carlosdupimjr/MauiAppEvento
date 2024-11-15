namespace MauiAppEvento;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new Views.AgendarEvento());
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        var Window = base.CreateWindow(activationState);

        Window.Width = 500;
        Window.Height = 700;

        return Window;
    }
}

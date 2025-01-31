using MauiProject = Microsoft.Maui.Controls.Application;

namespace FireAlarmConfigTool.Application;

public partial class App : MauiProject
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new MainPage()) { Title = "FireAlarmConfigTool" };
    }
}

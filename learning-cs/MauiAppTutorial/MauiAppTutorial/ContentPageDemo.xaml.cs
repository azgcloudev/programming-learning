using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTutorial;

public partial class ContentPageDemo : ContentPage
{
    public ContentPageDemo()
    {
        InitializeComponent();
    }

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        // navigate to a new page
        Navigation.PushAsync(new MainPage());
    }
    
    private void Button_OnClicked_1(object? sender, EventArgs e)
    {
        // navigate to a new page
        Navigation.PushAsync(new FlyoutDemo());
    }
    
    private void Button_OnClicked_2(object? sender, EventArgs e)
    {
        // navigate to a new page
        Navigation.PushAsync(new TabbedDemo());
    }
}
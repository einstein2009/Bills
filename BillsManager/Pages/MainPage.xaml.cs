using BillsManager.Models;
using BillsManager.PageModels;

namespace BillsManager.Pages;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageModel model)
    {
        InitializeComponent();
        BindingContext = model;
    }
}
using MudBlazor;

namespace Freshlay.Web.Components.Layout;

public partial class MainLayout
{
    public MudTheme FreshlayTheme => new()
    {
        Palette = new()
        {
            TextPrimary = new("#145240"),
            Primary = new("#145240"),
            PrimaryLighten = new("#DEE7D3"),
            Secondary = new("#F8F9F8"),
            SecondaryDarken = new("#F1F1F1"),
            SecondaryLighten = new("#F3F5F0"),
            Info = new("#F88FCD"),
            InfoDarken = new("#FCD2EB"),
            InfoLighten = new("#FFE4F4"),
            Warning = new("#FBC600"),
            WarningDarken = new("#FDE899"),
            Success = new("#5B9786"),
            SuccessLighten = new("#B5E634"),
            Tertiary = new("#7C8A86"),
            TertiaryDarken = new("#F5F1F0"),
        }
    };
}
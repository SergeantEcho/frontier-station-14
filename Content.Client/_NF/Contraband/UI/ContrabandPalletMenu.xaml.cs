using Content.Client.UserInterface.Controls;
using Content.Shared._NF.Contraband.Components;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client._NF.Contraband.UI;

[GenerateTypedNameReferences]
public sealed partial class ContrabandPalletMenu : FancyWindow
{
    public Action? SellRequested;
    public Action? AppraiseRequested;

    public ContrabandPalletMenu()
    {
        RobustXamlLoader.Load(this);
        SellButton.OnPressed += OnSellPressed;
        AppraiseButton.OnPressed += OnAppraisePressed;
        Title = Loc.GetString("contraband-pallet-console-menu-title");
    }

    public void SetAppraisal(int amount)
    {
        AppraisalLabel.Text = Loc.GetString("contraband-console-menu-points-amount", ("amount", amount.ToString()));
    }

    public void SetCount(int count)
    {
        CountLabel.Text = count.ToString();
    }
    public void SetEnabled(bool enabled)
    {
        AppraiseButton.Disabled = !enabled;
        SellButton.Disabled = !enabled;
    }

    private void OnSellPressed(BaseButton.ButtonEventArgs obj)
    {
        SellRequested?.Invoke();
    }

    private void OnAppraisePressed(BaseButton.ButtonEventArgs obj)
    {
        AppraiseRequested?.Invoke();
    }
}
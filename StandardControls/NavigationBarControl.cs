namespace UserInterface.StandardControls;

public partial class NavigationBarControl : UserControl
{
    public NavigationBarControl()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Set the next button enabled or disabled.
    /// </summary>
    public event Action? OnNextClick;
    private void nextButton_Click(object sender, EventArgs e)
    {
        OnNextClick?.Invoke();
    }

    /// <summary>
    /// Set the next button enabled or disabled.
    /// </summary>
    public event Action? OnBackClick;
    private void backButton_Click(object sender, EventArgs e)
    {
        OnBackClick?.Invoke();
    }
    private void exitButton_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    public void ToggleButtonsVisibility(bool nextButtonVisible, bool backButtonVisible, bool exitButtonVisible)
    {
        this.nextButton.Visible = nextButtonVisible;
        this.backButton.Visible = backButtonVisible;
        this.exitButton.Visible = exitButtonVisible;
    }
}

using UserInterface.Models.Contents;
using UserInterface.StandardControls;

namespace UserInterface.Steps;

public partial class StartingInfoStep : StepControl
{
    public StartingInfoStep()
    {
        InitializeComponent();
        StepContent = new StartingInfoContent();
    }
}

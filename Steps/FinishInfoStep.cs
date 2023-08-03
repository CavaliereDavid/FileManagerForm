using UserInterface.Models.Contents;
using UserInterface.StandardControls;

namespace UserInterface.Steps;

public partial class FinishInfoStep : StepControl
{
    public FinishInfoStep()
    {
        InitializeComponent();
        StepContent = new FinishInfoContent();
    }
}

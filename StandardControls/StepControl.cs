using UserInterface.Models;
using UserInterface.Models.Abstractions;

namespace UserInterface.StandardControls;

public partial class StepControl : UserControl
{
    /// <summary>
    /// The map between the designer input fields and the content where to
    /// store the configuration data.
    ///
    /// </summary>
    public IStepContent StepContent { get; init; }

    public StepControl()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Used to set default values from designer.
    /// </summary>
    protected virtual void FixContent() { }

    /// <summary>
    /// Used to Validate the current step.
    /// </summary>
    /// <returns></returns>
    public virtual ValidationMessage ValidateStep()
    {
        ValidationMessage validationStepContent = StepContent.Validate();

        if (validationStepContent.IsValid)
            return new("The step is valid", true);

        return validationStepContent;
    }

    private void StepControl_Load(object sender, EventArgs e)
    {

    }
}

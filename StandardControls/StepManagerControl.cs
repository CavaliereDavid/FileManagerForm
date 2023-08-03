using UserInterface.Models;
using UserInterface.Steps;

namespace UserInterface.StandardControls;

public partial class StepManagerControl : UserControl
{
    public event Action<int> StepChanged;
    public event Func<int, bool, bool> RequestButtonVisibility;
    /// <summary>
    /// The list of steps.
    /// </summary>
    public List<StepControl> Steps { get; } = new();

    /// <summary>
    /// The current shown step.
    /// </summary>
    public StepControl CurrentStep { get; private set; }

    /// <summary>
    /// True if the current step is the last step of the steps list.
    /// Otherwise false.
    /// </summary>
    public bool IsCurrentStepTheLast
    {
        get => Steps.Last() == CurrentStep;
    }

    /// <summary>
    /// True if the current step is the first step of the steps list.
    /// Otherwise false.
    /// </summary>
    public bool IsCurrentStepTheFirst
    {
        get => Steps.First() == CurrentStep;
    }

    public StepManagerControl()
    {
        InitializeComponent();
        Init();
    }

    /// <summary>
    /// Initialize the steps manager.
    /// </summary>
    public void Init()
    {
        StepControl startingInfoStep = new StartingInfoStep();
        StepControl folderManagementStep = new FolderManagementStep();
        StepControl fileManagementStep = new FileManagementStep();
        StepControl finishInfoStep = new FinishInfoStep();  
        SetupSteps(startingInfoStep, folderManagementStep, fileManagementStep, finishInfoStep);

        SetCurrentStep(0);
    }

    private void SetCurrentStep(int index)
    {
        // check if the index is in the range of the steps list.
        // if not we can do nothing.
        // if yes we can set the current step to the step at the given index.
        if (index < 0 || index >= Steps.Count)
        {
            return;
        }

        // Raise the StepChanged event to notify the parent form about the step change
        StepChanged?.Invoke(index);

        // Request the visibility of the "Next" and "Exit" buttons from the parent form
        bool nextButtonVisible = RequestButtonVisibility?.Invoke(index, true) ?? false;
        bool exitButtonVisible = RequestButtonVisibility?.Invoke(index, false) ?? false;



        // hide the current step.
        // It could be null if we are at the application start.
        CurrentStep?.Hide();

        // set the current step to the step at the given index
        CurrentStep = Steps[index];

        // show the current step
        CurrentStep.Show();

    }


    private void SetupSteps(params StepControl[] steps)
    {
        // add the steps in our list
        Steps.AddRange(steps.ToArray());

        // add the steps winform controls to the steps manager winform control
        Controls.AddRange(Steps.ToArray());
    }

    public void GoToNext()
    {
        if (!ValidateCurrentStep())
        {
            return;
        }

        // get the current step index
        int currentIndex = Steps.IndexOf(CurrentStep);

        // get the next step index
        int nextStepIndex = currentIndex + 1;

        if (nextStepIndex < Steps.Count)
        {
            // set the current step to the next step
            SetCurrentStep(nextStepIndex);
        }

    }

    /// <summary>
    /// Go to previous step.
    /// </summary>
    public void GoToPrevious()
    {
        // get the current step index
        int currentIndex = Steps.IndexOf(CurrentStep);

        // get the previous step index
        int previousStepIndex = Steps.IndexOf(CurrentStep) - 1;

        if (previousStepIndex >= 0)
        {
            // set the current step to the previous step
            SetCurrentStep(previousStepIndex);
        }
    }

    private bool ValidateCurrentStep()
    {
        ValidationMessage stepValidation = CurrentStep.ValidateStep();

        if (!stepValidation.IsValid)
        {
            MessageBox.Show(stepValidation.Message);
            return false;
        }
        return true;
    }
}

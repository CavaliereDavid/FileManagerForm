namespace UserInterface
{
    public partial class UserInterfaceForm : Form
    {
        public UserInterfaceForm()
        {
            InitializeComponent();

            // Subscribe to the events of NavigationBarControl
            navigationBarControl.OnBackClick += NavigationBarControl_OnBackClick;
            navigationBarControl.OnNextClick += NavigationBarControl_OnNextClick;

            // Subscribe to the events of StepManagerControl
            stepManagerControl.StepChanged += StepManagerControl_StepChanged;
            stepManagerControl.RequestButtonVisibility += StepManagerControl_RequestButtonVisibility;
        }

        private bool StepManagerControl_RequestButtonVisibility(int currentIndex, bool isNextButton)
        {
            // For the first step, hide the "Back" and "Exit" buttons and show the "Next" button
            if (currentIndex == 0)
            {
                return isNextButton;
            }

            // For the last step, hide the "Next" button and show the "Back" and "Exit" buttons
            if (currentIndex == stepManagerControl.Steps.Count - 1)
            {
                return !isNextButton;
            }

            // For other steps, show both "Back" and "Next" buttons and hide the "Exit" button
            return true;
        }

        private void StepManagerControl_StepChanged(int currentIndex)
        {
            // Update the visibility of the "Back" and "Exit" buttons based on the current step index
            if (currentIndex == 0) // First step
            {
                navigationBarControl.ToggleButtonsVisibility(nextButtonVisible: true, backButtonVisible: false, exitButtonVisible: false);
            }
            else if (currentIndex == stepManagerControl.Steps.Count - 1) // Last step
            {
                navigationBarControl.ToggleButtonsVisibility(nextButtonVisible: false, backButtonVisible: true, exitButtonVisible: true);
            }
            else // Other steps
            {
                navigationBarControl.ToggleButtonsVisibility(nextButtonVisible: true, backButtonVisible: true, exitButtonVisible: false);
            }
        }

        private void NavigationBarControl_OnBackClick()
        {
            stepManagerControl.GoToPrevious();
        }

        private void NavigationBarControl_OnNextClick()
        {
            stepManagerControl.GoToNext();
        }
    }
}
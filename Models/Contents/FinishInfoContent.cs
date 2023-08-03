using UserInterface.Models.Abstractions;

namespace UserInterface.Models.Contents;

public class FinishInfoContent : IStepContent
{
    public ValidationMessage Validate()
    {
        return ValidationMessage.Ok();
    }
}

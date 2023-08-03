using UserInterface.Models.Abstractions;

namespace UserInterface.Models.Contents;

public class StartingInfoContent : IStepContent
{
    public ValidationMessage Validate()
    {
        return ValidationMessage.Ok();
    }
}

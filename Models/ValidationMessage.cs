namespace UserInterface.Models;

public class ValidationMessage
{
    /// <summary>
    /// Create a new instance of ValidationMessage.
    /// </summary>
    /// <param name="message">The message from the validation process.</param>
    /// <param name="isValid">Has the validation process been successful?</param>
    public ValidationMessage(string message, bool isValid)
    {
        Message = message;
        IsValid = isValid;
    }

    /// <summary>
    /// The message from the validation process.
    /// </summary>
    public string? Message { get; set; }

    /// <summary>
    /// Has the validation process been successful?
    /// </summary>
    public bool IsValid { get; set; }

    public static ValidationMessage Fail(string message)
    {
        return new ValidationMessage(message, false);
    }

    public static ValidationMessage Ok(string message = "")
    {
        return new ValidationMessage(message, true);
    }
}

using UserInterface.Models.Abstractions;

namespace UserInterface.Models.Contents;

public class FolderManagementContent : IStepContent
{
    public string? CreateFolderName { get; set; }
    public string? CreateFolderDestination { get; set; }
    public string? CopyFolderSource { get; set; }
    public string? CopyFolderDestination { get; set; }
    public string? DeleteFolder { get; set; }
    public string? MoveFolderSource { get; set; }
    public string? MoveFolderDestination { get; set; }
    public string? RenameFolder { get; set; }
    public string? NewFolderName { get; set; }
    public string? CompressFolderSource { get; set; }
    public string? CompressFolderDestination { get; set; }
    public string? DecompressFolderSource { get; set; }
    public string? DecompressFolderDestination { get; set; }


    public ValidationMessage Validate()
    {
        return ValidationMessage.Ok();
    }
}

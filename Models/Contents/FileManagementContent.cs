using UserInterface.Models.Abstractions;

namespace UserInterface.Models.Contents;

public class FileManagementContent : IStepContent
{
    public string? CreateFileName { get; set; }
    public string? CreateFileDestination { get; set; }
    public string? FileExtension { get; set; }
    public string? WrittenContent { get; set; }
    public string? CopyFileSource { get; set; }
    public string? CopyFileDestination { get; set; }
    public string? DeleteFile { get; set; }
    public string? MoveFileSource { get; set; }
    public string? MoveFileDestination { get; set; }
    public string? RenameFile { get; set; }
    public string? NewFileName { get; set; }
    public string? CompressFileSource { get; set; }
    public string? CompressFileDestination { get; set; }
    public string? DecompressFileSource { get; set; }
    public string? DecompressFileDestination { get; set; }

    public ValidationMessage Validate()
    {
        return ValidationMessage.Ok();
    }
}

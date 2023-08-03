namespace UserInterface.Models.Utils.FileUtils;

public class FileUtils
{
    private readonly MessageHandler messageHandler;

    public FileUtils(MessageHandler messageHandler)
    {
        this.messageHandler = messageHandler;
    }

    /// <summary>
    /// Displays a file dialog and allows the user to select a file from the system.
    /// </summary>
    /// <returns>The selected file's path as a string. Returns null if the user cancels the file selection.</returns>
    public string BrowseFile()
    {
        try
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
            }
        }
        catch (Exception ex)
        {
            messageHandler.ShowErrorMessageBox(
                $"An error occurred while browsing for the file: {ex.Message}"
            );
        }

        return null; // Return null if the user cancels the file selection.
    }

    /// <summary>
    /// Creates a new file in the specified parent folder with the given name, extension, and content.
    /// </summary>
    /// <param name="parentFolderPath">The path of the parent folder where the new file will be created.</param>
    /// <param name="newFileName">The name of the new file to be created.</param>
    /// <param name="fileExtension">The extension of the new file.</param>
    /// <param name="content">The content to be written inside the new file.</param>
    public void CreateFile(
        string parentFolderPath,
        string newFileName,
        string fileExtension,
        string content
    )
    {
        try
        {
            if (!messageHandler.IsValidFolderPath(parentFolderPath))
            {
                messageHandler.ShowWarningMessageBox(
                    "Please enter a valid destination folder path."
                );
                return;
            }

            // Check if the new folder name is empty
            if (string.IsNullOrWhiteSpace(newFileName))
            {
                messageHandler.ShowWarningMessageBox("File name cannot be empty.");
                return;
            }

            if (!IsValidFileExtension(fileExtension))
            {
                messageHandler.ShowErrorMessageBox(
                    "Invalid file extension. Supported extensions are txt, xml, html, and csv."
                );
                return;
            }

            string fileNameWithExtension = $"{newFileName}.{fileExtension}";
            string filePath = Path.Combine(parentFolderPath, fileNameWithExtension);

            // Check if the file already exists in the destination folder
            if (File.Exists(filePath))
            {
                bool overwrite = messageHandler.ShowConfirmationMessageBox(
                    $"A file with the same name '{fileNameWithExtension}' already exists. Do you want to overwrite it?",
                    "Confirmation"
                );

                if (!overwrite)
                {
                    return; // User chose not to overwrite, so return without creating the file.
                }
            }

            // If content is empty, ask the user if they want to create an empty file
            if (string.IsNullOrWhiteSpace(content))
            {
                bool createEmptyFile = messageHandler.ShowConfirmationMessageBox(
                    "The file content is empty. Do you want to create an empty file?",
                    "Confirmation"
                );

                if (!createEmptyFile)
                {
                    return; // User chose not to create an empty file, so return without creating the file.
                }
            }

            File.WriteAllText(filePath, content);
        }
        catch (Exception ex)
        {
            messageHandler.ShowErrorMessageBox($"Error creating file: {ex.Message}");
        }
    }

    // <summary>
    /// Copies a file from the source file path to the destination file path.
    /// </summary>
    /// <param name="sourceFilePath">The path of the source file to be copied.</param>
    /// <param name="destinationFilePath">The path of the destination file.</param>
    public void CopyFile(string sourceFilePath, string destinationFilePath)
    {
        try
        {
            if (!messageHandler.IsValidFilePath(sourceFilePath))
            {
                messageHandler.ShowWarningMessageBox("Invalid source file path.");
                return;
            }

            if (!messageHandler.IsValidFolderPath(destinationFilePath))
            {
                messageHandler.ShowWarningMessageBox(
                    "Please enter a valid destination folder path."
                );
                return;
            }

            // Combine the destination folder path with the file name from the source file path
            destinationFilePath = Path.Combine(
                destinationFilePath,
                Path.GetFileName(sourceFilePath)
            );

            // Check if the destination file already exists
            if (File.Exists(destinationFilePath))
            {
                bool overwrite = messageHandler.ShowConfirmationMessageBox(
                    "File already exists. Do you want to overwrite it?",
                    "Confirmation"
                );

                if (!overwrite)
                {
                    messageHandler.ShowInformationMessageBox("File copying canceled.");
                    return; // User chose not to overwrite, so return without copying the file.
                }
                else
                {
                    File.Delete(destinationFilePath);
                }
            }

            File.Copy(sourceFilePath, destinationFilePath);
            messageHandler.ShowInformationMessageBox("File copied successfully!");
        }
        catch (Exception ex)
        {
            messageHandler.ShowErrorMessageBox($"Error copying file: {ex.Message}");
        }
    }

    /// <summary>
    /// Deletes the specified file.
    /// </summary>
    /// <param name="filePath">The path of the file to be deleted.</param>
    public void DeleteFile(string filePath)
    {
        try
        {
            if (!messageHandler.IsValidFilePath(filePath))
            {
                messageHandler.ShowWarningMessageBox("Invalid file path.");
                return;
            }

            File.Delete(filePath);
            messageHandler.ShowInformationMessageBox("File deleted successfully!");
        }
        catch (Exception ex)
        {
            messageHandler.ShowErrorMessageBox($"Error deleting file: {ex.Message}");
        }
    }

    /// <summary>
    /// Moves a file from the source file path to the destination parent folder path.
    /// </summary>
    /// <param name="sourceFilePath">The path of the source file to be moved.</param>
    /// <param name="destinationParentFolderPath">The path of the destination parent folder.</param>
    public void MoveFile(string sourceFilePath, string destinationParentFolderPath)
    {
        try
        {
            if (!messageHandler.IsValidFilePath(sourceFilePath))
            {
                messageHandler.ShowWarningMessageBox("Invalid source file path.");
                return;
            }

            if (!messageHandler.IsValidFolderPath(destinationParentFolderPath))
            {
                messageHandler.ShowErrorMessageBox("Destination folder does not exist.");
                return;
            }

            string destinationFilePath = Path.Combine(
                destinationParentFolderPath,
                Path.GetFileName(sourceFilePath)
            );

            // Check if the destination file already exists
            if (File.Exists(destinationFilePath))
            {
                bool overwrite = messageHandler.ShowConfirmationMessageBox(
                    "File already exists. Do you want to overwrite it?",
                    "Confirmation"
                );

                if (!overwrite)
                {
                    messageHandler.ShowInformationMessageBox("File moving canceled.");
                    return; // User chose not to overwrite, so return without moving the file.
                }
                else
                {
                    File.Delete(destinationFilePath);
                }
            }

            File.Move(sourceFilePath, destinationFilePath);
            messageHandler.ShowInformationMessageBox("File moved successfully!");
        }
        catch (Exception ex)
        {
            messageHandler.ShowErrorMessageBox($"Error moving file: {ex.Message}");
        }
    }

    /// <summary>
    /// Renames a file with the given new file name.
    /// </summary>
    /// <param name="sourceFilePath">The path of the file to be renamed.</param>
    /// <param name="newFileName">The new name for the file.</param>
    public void RenameFile(string sourceFilePath, string newFileName)
    {
        try
        {
            if (!messageHandler.IsValidFilePath(sourceFilePath))
            {
                messageHandler.ShowWarningMessageBox("Invalid source file path.");
                return;
            }

            if (string.IsNullOrWhiteSpace(newFileName))
            {
                messageHandler.ShowErrorMessageBox("New file name cannot be empty.");
                return;
            }

            string sourceFileDirectory = Path.GetDirectoryName(sourceFilePath);
            string newFilePath = Path.Combine(
                sourceFileDirectory,
                $"{newFileName}{Path.GetExtension(sourceFilePath)}"
            );
            if (File.Exists(newFilePath))
            {
                bool overwrite = messageHandler.ShowConfirmationMessageBox(
                    "File with the same name already exists. Do you want to overwrite it?",
                    "Confirmation"
                );
                if (!overwrite)
                {
                    messageHandler.ShowInformationMessageBox("File renaming canceled.");
                    return; // User chose not to overwrite, so return without renaming the file.
                }
                else
                {
                    File.Delete(newFilePath);
                }
            }

            File.Move(sourceFilePath, newFilePath);
            messageHandler.ShowInformationMessageBox("File renamed successfully!");
        }
        catch (Exception ex)
        {
            messageHandler.ShowErrorMessageBox($"Error renaming file: {ex.Message}");
        }
    }

    private bool IsValidFileExtension(string fileExtension)
    {
        string[] validExtensions = { "txt", "xml", "html", "csv" };
        return Array.IndexOf(validExtensions, fileExtension.ToLower()) != -1;
    }
}

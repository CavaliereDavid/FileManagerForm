using System.IO.Compression;

namespace UserInterface.Models.Utils.FolderUtils
{
    public class FolderUtils
    {
        private readonly MessageHandler messageHandler;

        public FolderUtils(MessageHandler errorHandler)
        {
            this.messageHandler = errorHandler;
        }

        public string BrowseFolder()
        {
            try
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedPath = folderBrowserDialog.SelectedPath;

                        // Check if the selected folder path is valid
                        if (messageHandler.IsValidFolderPath(selectedPath))
                        {
                            return selectedPath;
                        }
                        else
                        {
                            messageHandler.ShowWarningMessageBox("Please select a valid folder.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                messageHandler.ShowErrorMessageBox(
                    $"An error occurred while browsing for the folder: {ex.Message}"
                );
            }

            return null; // Return null if the user cancels the folder browsing.
        }

        public void CreateFolder(string parentFolderPath, string newFolderName)
        {
            try
            {
                // Check if the new folder name is empty
                if (string.IsNullOrWhiteSpace(newFolderName))
                {
                    messageHandler.ShowWarningMessageBox("Folder name cannot be empty.");
                    return;
                }

                // Check if the parent folder path is valid
                if (!messageHandler.IsValidFolderPath(parentFolderPath))
                {
                    messageHandler.ShowWarningMessageBox("Please enter a valid folder path.");
                    return;
                }

                string newFolderPath = Path.Combine(parentFolderPath, newFolderName);

                if (Directory.Exists(newFolderPath))
                {
                    // Prompt the user if they want to overwrite the existing folder.
                    bool overwrite = messageHandler.ShowConfirmationMessageBox(
                        "Folder with the same name already exists. Do you want to overwrite it?",
                        "Folder Overwrite Confirmation"
                    );

                    if (!overwrite)
                    {
                        return;
                    }

                    // Delete the existing folder if the user chose to overwrite.
                    Directory.Delete(newFolderPath, true);
                }

                Directory.CreateDirectory(newFolderPath);
                messageHandler.ShowInformationMessageBox("Folder created successfully.");
            }
            catch (Exception ex)
            {
                messageHandler.ShowErrorMessageBox($"Error creating folder: {ex.Message}");
            }
        }

        public void CopyFolder(string sourceFolderPath, string destinationFolderPath)
        {
            try
            {
                // Check if the source folder path is valid
                if (!messageHandler.IsValidFolderPath(sourceFolderPath))
                {
                    messageHandler.ShowWarningMessageBox(
                        "Please enter a valid source folder path."
                    );
                    return;
                }

                // Check if the destination folder path is valid
                if (!messageHandler.IsValidFolderPath(destinationFolderPath))
                {
                    messageHandler.ShowWarningMessageBox(
                        "Please enter a valid destination folder path."
                    );
                    return;
                }

                DirectoryInfo sourceDirInfo = new DirectoryInfo(sourceFolderPath);
                string destinationFolderName = Path.GetFileName(sourceFolderPath);
                string destinationFolderFullPath = Path.Combine(
                    destinationFolderPath,
                    destinationFolderName
                );

                if (Directory.Exists(destinationFolderFullPath))
                {
                    bool overwrite = messageHandler.ShowConfirmationMessageBox(
                        "Destination folder already exists. Do you want to overwrite its contents?",
                        "Confirmation"
                    );

                    if (overwrite)
                    {
                        // Delete the destination folder and its contents.
                        Directory.Delete(destinationFolderFullPath, true);
                    }
                    else
                    {
                        return; // User chose not to overwrite, so return without performing the copy.
                    }
                }

                Directory.CreateDirectory(destinationFolderFullPath);

                foreach (FileInfo file in sourceDirInfo.GetFiles())
                {
                    string destFilePath = Path.Combine(destinationFolderFullPath, file.Name);
                    file.CopyTo(destFilePath, true);
                }

                foreach (DirectoryInfo subDir in sourceDirInfo.GetDirectories())
                {
                    string destSubDirPath = Path.Combine(destinationFolderFullPath, subDir.Name);
                    CopyFolder(subDir.FullName, destSubDirPath);
                }

                messageHandler.ShowInformationMessageBox("Folder copied successfully.");
            }
            catch (Exception ex)
            {
                messageHandler.ShowErrorMessageBox($"Error copying folder: {ex.Message}");
            }
        }

        public void DeleteFolder(string folderPath)
        {
            try
            {
                // Check if the folder path is valid
                if (!messageHandler.IsValidFolderPath(folderPath))
                {
                    messageHandler.ShowWarningMessageBox("Please enter a valid folder path.");
                    return;
                }

                Directory.Delete(folderPath, true);
                messageHandler.ShowInformationMessageBox("Folder deleted successfully.");
            }
            catch (Exception ex)
            {
                messageHandler.ShowErrorMessageBox($"Error deleting folder: {ex.Message}");
            }
        }

        public void MoveFolder(string sourceFolderPath, string destinationFolderPath)
        {
            try
            {
                // Check if the source folder path is valid
                if (!messageHandler.IsValidFolderPath(sourceFolderPath))
                {
                    messageHandler.ShowWarningMessageBox(
                        "Please enter a valid source folder path."
                    );
                    return;
                }

                // Check if the destination folder path is valid
                if (!messageHandler.IsValidFolderPath(destinationFolderPath))
                {
                    messageHandler.ShowWarningMessageBox(
                        "Please enter a valid destination folder path."
                    );
                    return;
                }

                DirectoryInfo sourceDirInfo = new DirectoryInfo(sourceFolderPath);
                string destinationFolderName = Path.GetFileName(sourceFolderPath);
                string destinationFolderFullPath = Path.Combine(
                    destinationFolderPath,
                    destinationFolderName
                );

                if (Directory.Exists(destinationFolderFullPath))
                {
                    bool overwrite = messageHandler.ShowConfirmationMessageBox(
                        "Destination folder already exists. Do you want to overwrite it?",
                        "Confirmation"
                    );

                    if (overwrite)
                    {
                        // Delete the destination folder and its contents.
                        Directory.Delete(destinationFolderFullPath, true);
                    }
                    else
                    {
                        return; // User chose not to overwrite, so return without performing the move.
                    }
                }

                Directory.Move(sourceFolderPath, destinationFolderFullPath);
                messageHandler.ShowInformationMessageBox("Folder moved successfully.");
            }
            catch (Exception ex)
            {
                messageHandler.ShowErrorMessageBox($"Error moving folder: {ex.Message}");
            }
        }

        public void RenameFolder(string sourceFolderPath, string newFolderName)
        {
            try
            {
                // Check if the source folder path is valid
                if (!messageHandler.IsValidFolderPath(sourceFolderPath))
                {
                    messageHandler.ShowWarningMessageBox(
                        "Please enter a valid source folder path."
                    );
                    return;
                }

                // Check if the new folder name is empty
                if (string.IsNullOrWhiteSpace(newFolderName))
                {
                    messageHandler.ShowWarningMessageBox("Please enter the new folder name.");
                    return;
                }

                string parentFolderPath = Directory.GetParent(sourceFolderPath).FullName;
                string newFolderPath = Path.Combine(parentFolderPath, newFolderName);

                if (Directory.Exists(newFolderPath))
                {
                    messageHandler.ShowWarningMessageBox(
                        "Destination folder with the same name already exists."
                    );
                    return;
                }

                Directory.Move(sourceFolderPath, newFolderPath);
                messageHandler.ShowInformationMessageBox("Folder renamed successfully.");
            }
            catch (Exception ex)
            {
                messageHandler.ShowErrorMessageBox($"Error renaming folder: {ex.Message}");
            }
        }

        public void CompressFolder(string sourceFolderPath, string destinationFolderPath)
        {
            try
            {
                // Check if the source folder path is valid
                if (!messageHandler.IsValidFolderPath(sourceFolderPath))
                {
                    messageHandler.ShowWarningMessageBox(
                        "Please enter a valid source folder path."
                    );
                    return;
                }

                // Check if the destination folder path is valid
                if (!messageHandler.IsValidFolderPath(destinationFolderPath))
                {
                    messageHandler.ShowWarningMessageBox(
                        "Please enter a valid destination folder path."
                    );
                    return;
                }

                string sourceFolderName = new DirectoryInfo(sourceFolderPath).Name;
                string destinationZipFilePath = Path.Combine(
                    destinationFolderPath,
                    sourceFolderName + ".zip"
                );

                if (File.Exists(destinationZipFilePath))
                {
                    // Prompt the user if they want to overwrite the existing destination zip file
                    bool overwrite = messageHandler.ShowConfirmationMessageBox(
                        "Destination zip file already exists. Do you want to overwrite it?",
                        "Confirmation"
                    );

                    if (!overwrite)
                    {
                        return; // User chose not to overwrite, so return without compressing the folder.
                    }
                    else
                    {
                        File.Delete(destinationZipFilePath); // Delete the existing destination zip file before compressing the folder.
                    }
                }

                // Create the destination zip file using ZipArchive
                using (
                    ZipArchive zipArchive = ZipFile.Open(
                        destinationZipFilePath,
                        ZipArchiveMode.Create
                    )
                )
                {
                    CompressFolderRecursively(
                        sourceFolderPath,
                        zipArchive,
                        sourceFolderPath.Length + 1
                    );
                }

                messageHandler.ShowInformationMessageBox("Folder compressed successfully.");
            }
            catch (Exception ex)
            {
                messageHandler.ShowErrorMessageBox($"Error compressing folder: {ex.Message}");
            }
        }

        private void CompressFolderRecursively(
            string sourceFolderPath,
            ZipArchive zipArchive,
            int sourceFolderLength
        )
        {
            foreach (string filePath in Directory.GetFiles(sourceFolderPath))
            {
                string relativeFilePath = filePath.Substring(sourceFolderLength);
                zipArchive.CreateEntryFromFile(filePath, relativeFilePath);
            }

            foreach (string subdirectoryPath in Directory.GetDirectories(sourceFolderPath))
            {
                CompressFolderRecursively(subdirectoryPath, zipArchive, sourceFolderLength);
            }

            // If the folder is empty (no files or subdirectories), add an entry for the folder itself.
            if (
                Directory.GetFiles(sourceFolderPath).Length == 0
                && Directory.GetDirectories(sourceFolderPath).Length == 0
            )
            {
                string relativeFolderPath = sourceFolderPath.Substring(sourceFolderLength);
                zipArchive.CreateEntry(relativeFolderPath + "/");
            }
        }

        public void DecompressFolder(string sourceZipFilePath, string destinationFolderPath)
        {
            try
            {
                // Check if the source zip file path is valid
                if (!messageHandler.IsValidFilePath(sourceZipFilePath))
                {
                    messageHandler.ShowWarningMessageBox(
                        "Please enter a valid source zip file path."
                    );
                    return;
                }

                // Check if the destination folder path is valid
                if (!messageHandler.IsValidFolderPath(destinationFolderPath))
                {
                    messageHandler.ShowWarningMessageBox(
                        "Please enter a valid destination folder path."
                    );
                    return;
                }

                // Check if the file extension of the source zip file is ".zip"
                if (
                    !Path.GetExtension(sourceZipFilePath)
                        .Equals(".zip", StringComparison.OrdinalIgnoreCase)
                )
                {
                    messageHandler.ShowErrorMessageBox(
                        "Invalid source zip file format. Please select a valid .zip file."
                    );
                    return;
                }

                // Get the folder name from the source zip file without the .zip extension
                string folderName = Path.GetFileNameWithoutExtension(sourceZipFilePath);

                // Combine the destination folder path with the folder name
                string destinationFolderFullPath = Path.Combine(destinationFolderPath, folderName);

                if (Directory.Exists(destinationFolderFullPath))
                {
                    // Prompt the user if they want to overwrite the existing destination folder
                    bool overwrite = messageHandler.ShowConfirmationMessageBox(
                        "Destination folder already exists. Do you want to overwrite it?",
                        "Confirmation"
                    );

                    if (!overwrite)
                    {
                        return; // User chose not to overwrite, so return without decompressing the folder.
                    }
                    else
                    {
                        // Delete the existing destination folder before extracting the zip file
                        Directory.Delete(destinationFolderFullPath, true);
                    }
                }

                // Create the destination folder
                Directory.CreateDirectory(destinationFolderFullPath);

                // Extract the zip file using ZipArchive to preserve folder structure
                using (ZipArchive zipArchive = ZipFile.OpenRead(sourceZipFilePath))
                {
                    if (zipArchive.Entries.Count == 0)
                    {
                        // The zip file is empty, so just create the destination folder without extracting anything
                        return;
                    }

                    foreach (ZipArchiveEntry entry in zipArchive.Entries)
                    {
                        string entryDestinationPath = Path.Combine(
                            destinationFolderFullPath,
                            entry.FullName
                        );

                        // Check if the entry is a directory
                        if (entry.FullName.EndsWith("/") || entry.FullName.EndsWith("\\"))
                        {
                            // Create the directory
                            Directory.CreateDirectory(entryDestinationPath);
                        }
                        else
                        {
                            // Create the parent directory if it does not exist
                            Directory.CreateDirectory(Path.GetDirectoryName(entryDestinationPath));

                            // Extract the file
                            entry.ExtractToFile(entryDestinationPath, true);
                        }
                    }
                }

                messageHandler.ShowInformationMessageBox("Folder decompressed successfully.");
            }
            catch (Exception ex)
            {
                messageHandler.ShowErrorMessageBox($"Error decompressing folder: {ex.Message}");
            }
        }
    }
}

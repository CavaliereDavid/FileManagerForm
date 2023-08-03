namespace UserInterface.Models
{
    public class MessageHandler
    {
        /// <summary>
        /// Shows a confirmation message box with the specified message and caption.
        /// </summary>
        /// <param name="message">The message to be displayed in the confirmation box.</param>
        /// <param name="caption">The caption or title of the confirmation box.</param>
        /// <returns>True if the user clicks the "Yes" button; otherwise, false.</returns>
        public bool ShowConfirmationMessageBox(string message, string caption)
        {
            return MessageBox.Show(
                    message,
                    caption,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                ) == DialogResult.Yes;
        }

        /// <summary>
        /// Shows an error message box with the specified error message.
        /// </summary>
        /// <param name="message">The error message to be displayed in the message box.</param>
        public void ShowErrorMessageBox(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Shows an information message box with the specified message.
        /// </summary>
        /// <param name="message">The message to be displayed in the information box.</param>
        public void ShowInformationMessageBox(string message)
        {
            MessageBox.Show(
                message,
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        /// <summary>
        /// Shows a warning message box with the specified message.
        /// </summary>
        /// <param name="message">The message to be displayed in the warning box.</param>
        public void ShowWarningMessageBox(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Checks if the specified folder path is valid and exists.
        /// </summary>
        /// <param name="folderPath">The folder path to be checked.</param>
        /// <returns>True if the folder path is valid and exists; otherwise, false.</returns>
        public bool IsValidFolderPath(string folderPath)
        {
            return !string.IsNullOrWhiteSpace(folderPath) && System.IO.Directory.Exists(folderPath);
        }

        /// <summary>
        /// Checks if the specified file path is valid and exists.
        /// </summary>
        /// <param name="filePath">The file path to be checked.</param>
        /// <returns>True if the file path is valid and exists; otherwise, false.</returns>
        public bool IsValidFilePath(string filePath)
        {
            return !string.IsNullOrWhiteSpace(filePath) && System.IO.File.Exists(filePath);
        }
    }
}

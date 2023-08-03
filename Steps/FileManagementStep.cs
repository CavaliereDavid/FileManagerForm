using UserInterface.Models;
using UserInterface.Models.Contents;
using UserInterface.Models.Utils.FileUtils;
using UserInterface.Models.Utils.FolderUtils;
using UserInterface.StandardControls;

namespace UserInterface.Steps
{
    public partial class FileManagementStep : StepControl
    {
        private readonly MessageHandler messageHandler;
        private readonly FileUtils fileUtils;
        private readonly FolderUtils folderUtils;

        public FileManagementStep()
        {
            InitializeComponent();
            StepContent = new FileManagementContent();

            messageHandler = new MessageHandler();
            fileUtils = new(messageHandler);
            folderUtils = new(messageHandler);
        }

        private FileManagementContent _concreteContent;
        private FileManagementContent concreteContent
        {
            get
            {
                ArgumentNullException.ThrowIfNull(StepContent);
                return _concreteContent ??= (FileManagementContent)StepContent;
            }
        }

        private void createFileNameTextBox_TextChanged(object sender, EventArgs e)
        {
            concreteContent.CreateFileName = createFileNameTextBox.Text;
        }

        private void fileExtensionTextBox_TextChanged(object sender, EventArgs e)
        {
            concreteContent.FileExtension = fileExtensionTextBox.Text;
        }

        private void createBrowseButton_Click(object sender, EventArgs e)
        {
            string selectedFolder = folderUtils.BrowseFolder();
            if (selectedFolder != null)
            {
                concreteContent.CreateFileDestination = selectedFolder;
                createFileDestinationTextBox.Text = selectedFolder;
            }
        }

        private void writeFileContentTextBox_TextChanged(object sender, EventArgs e)
        {
            concreteContent.WrittenContent = writeFileContentTextBox.Text;
        }

        private void copySourceBrowseButton_Click(object sender, EventArgs e)
        {
            string selectedFolder = fileUtils.BrowseFile();
            if (selectedFolder != null)
            {
                concreteContent.CopyFileSource = selectedFolder;
                copyFileSourceTextBox.Text = selectedFolder;
            }
        }

        private void copyDestinationBrowseButton_Click(object sender, EventArgs e)
        {
            string selectedFolder = folderUtils.BrowseFolder();
            if (selectedFolder != null)
            {
                concreteContent.CopyFileDestination = selectedFolder;
                copyFileDestinationTextBox.Text = selectedFolder;
            }
        }

        private void deleteBrowseButton_Click(object sender, EventArgs e)
        {
            string selectedFile = fileUtils.BrowseFile();
            if (selectedFile != null)
            {
                concreteContent.DeleteFile = selectedFile;
                deleteFileTextBox.Text = selectedFile;
            }
        }

        private void moveSourceBrowseButton_Click(object sender, EventArgs e)
        {
            string selectedFile = fileUtils.BrowseFile();
            if (selectedFile != null)
            {
                concreteContent.MoveFileSource = selectedFile;
                moveFileSourceTextBox.Text = selectedFile;
            }

        }

        private void moveDestinationBrowseButton_Click(object sender, EventArgs e)
        {
            string selectedFolder = folderUtils.BrowseFolder();
            if (selectedFolder != null)
            {
                concreteContent.MoveFileDestination = selectedFolder;
                moveFileDestinationTextBox.Text = selectedFolder;
            }
        }

        private void renameBrowseButton_Click(object sender, EventArgs e)
        {
            string selectedFile = fileUtils.BrowseFile();
            if (selectedFile != null)
            {
                concreteContent.RenameFile = selectedFile;
                renameFileTextBox.Text = selectedFile;
            }
        }

        private void newFileNameTextBox_TextChanged(object sender, EventArgs e)
        {
            concreteContent.NewFileName = newFileNameTextBox.Text;
        }

        private void createFileButton_Click(object sender, EventArgs e)
        {
            fileUtils.CreateFile(
                concreteContent.CreateFileDestination,
                concreteContent.CreateFileName,
                concreteContent.FileExtension,
                concreteContent.WrittenContent
            );
        }

        private void copyFileButton_Click(object sender, EventArgs e)
        {
            fileUtils.CopyFile(concreteContent.CopyFileSource, concreteContent.CopyFileDestination);
        }

        private void deleteFileButton_Click(object sender, EventArgs e)
        {
            fileUtils.DeleteFile(concreteContent.DeleteFile);
        }

        private void moveFileButton_Click(object sender, EventArgs e)
        {
            fileUtils.MoveFile(concreteContent.MoveFileSource, concreteContent.MoveFileDestination);
        }

        private void renameFileButton_Click(object sender, EventArgs e)
        {
            fileUtils.RenameFile(concreteContent.RenameFile, concreteContent.NewFileName);
        }
    }
}

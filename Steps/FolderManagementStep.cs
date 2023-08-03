using UserInterface.Models;
using UserInterface.Models.Contents;
using UserInterface.Models.Utils.FileUtils;
using UserInterface.Models.Utils.FolderUtils;
using UserInterface.StandardControls;

namespace UserInterface.Steps;

public partial class FolderManagementStep : StepControl
{
    private readonly MessageHandler messageHandler;
    private readonly FileUtils fileUtils;
    private readonly FolderUtils folderUtils;
    public FolderManagementStep()
    {
        InitializeComponent();
        StepContent = new FolderManagementContent();

        messageHandler = new MessageHandler(); 
        fileUtils = new(messageHandler);
        folderUtils = new(messageHandler);
    }

    private FolderManagementContent _concreteContent;
    private FolderManagementContent concreteContent
    {
        get
        {
            ArgumentNullException.ThrowIfNull(StepContent);
            return _concreteContent ??= (FolderManagementContent)StepContent;
        }
    }

    private void createFolderNameTextBox_TextChanged(object sender, EventArgs e)
    {
        concreteContent.CreateFolderName = createFolderNameTextBox.Text;
    }

    private void createBrowseButton_Click(object sender, EventArgs e)
    {
        string selectedFolder = folderUtils.BrowseFolder();
        if (selectedFolder != null)
        {
            concreteContent.CreateFolderDestination = selectedFolder;
            createFolderDestinationTextBox.Text = selectedFolder;
        }
    }

    private void copySourceBrowseButton_Click(object sender, EventArgs e)
    {
        string selectedFolder = folderUtils.BrowseFolder();
        if (selectedFolder != null)
        {
            concreteContent.CopyFolderSource = selectedFolder;
            copyFolderSourceTextBox.Text = selectedFolder;
        }
    }

    private void copyDestinationBrowseButton_Click(object sender, EventArgs e)
    {
        string selectedFolder = folderUtils.BrowseFolder();
        if (selectedFolder != null)
        {
            concreteContent.CopyFolderDestination = selectedFolder;
            copyFolderDestinationTextBox.Text = selectedFolder;
        }
    }

    private void deleteBrowseButton_Click(object sender, EventArgs e)
    {
        string selectedFolder = folderUtils.BrowseFolder();
        if (selectedFolder != null)
        {
            concreteContent.DeleteFolder = selectedFolder;
            deleteFolderTextBox.Text = selectedFolder;
        }
    }

    private void moveSourceBrowseButton_Click(object sender, EventArgs e)
    {
        string selectedFolder = folderUtils.BrowseFolder();
        if (selectedFolder != null)
        {
            concreteContent.MoveFolderSource = selectedFolder;
            moveFolderSourceTextBox.Text = selectedFolder;
        }
    }

    private void moveDestinationBrowseButton_Click(object sender, EventArgs e)
    {
        string selectedFolder = folderUtils.BrowseFolder();
        if (selectedFolder != null)
        {
            concreteContent.MoveFolderDestination = selectedFolder;
            moveFolderDestinationTextBox.Text = selectedFolder;
        }
    }

    private void renameBrowseButton_Click(object sender, EventArgs e)
    {
        string selectedFolder = folderUtils.BrowseFolder();
        if (selectedFolder != null)
        {
            concreteContent.RenameFolder = selectedFolder;
            renameFolderTextBox.Text = selectedFolder;
        }
    }

    private void newFolderNameTextBox_TextChanged(object sender, EventArgs e)
    {
        concreteContent.NewFolderName = newFolderNameTextBox.Text;
    }

    private void compressSourceBrowseButton_Click(object sender, EventArgs e)
    {
        string selectedFolder = folderUtils.BrowseFolder();
        if (selectedFolder != null)
        {
            concreteContent.CompressFolderSource = selectedFolder;
            compressFolderSourceTextBox.Text = selectedFolder;
        }
    }

    private void compressDestinationBrowseButton_Click(object sender, EventArgs e)
    {
        string selectedFolder = folderUtils.BrowseFolder();
        if (selectedFolder != null)
        {
            concreteContent.CompressFolderDestination = selectedFolder;
            compressFolderDestinationTextBox.Text = selectedFolder;
        }
    }

    private void decompressSourceBrowseButton_Click(object sender, EventArgs e)
    {
        string selectedFile = fileUtils.BrowseFile();
        if (selectedFile != null)
        {
            concreteContent.DecompressFolderSource = selectedFile;
            decompressFolderSourceTextBox.Text = selectedFile;
        }
    }

    private void decompressDestinationBrowseButton_Click(object sender, EventArgs e)
    {
        string selectedFolder = folderUtils.BrowseFolder();
        if (selectedFolder != null)
        {
            concreteContent.DecompressFolderDestination = selectedFolder;
            decompressFolderDestinationTextBox.Text = selectedFolder;
        }
    }

    private void createFolderButton_Click(object sender, EventArgs e)
    {
        folderUtils.CreateFolder(
            concreteContent.CreateFolderDestination,
            concreteContent.CreateFolderName
        );
    }

    private void copyFolderButton_Click(object sender, EventArgs e)
    {
        folderUtils.CopyFolder(
            concreteContent.CopyFolderSource,
            concreteContent.CopyFolderDestination
        );
    }

    private void deleteFolderButton_Click(object sender, EventArgs e)
    {
        folderUtils.DeleteFolder(concreteContent.DeleteFolder);
    }

    private void moveFolderButton_Click(object sender, EventArgs e)
    {
        folderUtils.MoveFolder(
            concreteContent.MoveFolderSource,
            concreteContent.MoveFolderDestination
        );
    }

    private void renameFolderButton_Click(object sender, EventArgs e)
    {
        folderUtils.RenameFolder(concreteContent.RenameFolder, concreteContent.NewFolderName);
    }

    private void compressFolderButton_Click(object sender, EventArgs e)
    {
        folderUtils.CompressFolder(
            concreteContent.CompressFolderSource,
            concreteContent.CompressFolderDestination
        );
    }

    private void decompressFolderButton_Click(object sender, EventArgs e)
    {
        folderUtils.DecompressFolder(
            concreteContent.DecompressFolderSource,
            concreteContent.DecompressFolderDestination
        );
    }
}

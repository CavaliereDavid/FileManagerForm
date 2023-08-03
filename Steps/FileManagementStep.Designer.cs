namespace UserInterface.Steps
{
    partial class FileManagementStep
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            createFileNameTextBox = new TextBox();
            fileExtensionTextBox = new TextBox();
            createFileDestinationTextBox = new TextBox();
            copyFileSourceTextBox = new TextBox();
            copyFileDestinationTextBox = new TextBox();
            deleteFileTextBox = new TextBox();
            moveFileSourceTextBox = new TextBox();
            moveFileDestinationTextBox = new TextBox();
            renameFileTextBox = new TextBox();
            newFileNameTextBox = new TextBox();
            createBrowseButton = new Button();
            copySourceBrowseButton = new Button();
            copyDestinationBrowseButton = new Button();
            deleteBrowseButton = new Button();
            moveSourceBrowseButton = new Button();
            moveDestinationBrowseButton = new Button();
            renameBrowseButton = new Button();
            createFileButton = new Button();
            copyFileButton = new Button();
            deleteFileButton = new Button();
            moveFileButton = new Button();
            renameFileButton = new Button();
            writeFileContentTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Size = new Size(224, 15);
            label1.Text = "Welcome to the file management page";
            label1.Visible = true;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Size = new Size(200, 15);
            label2.Text = "Here you can manage all your files";
            label2.Visible = true;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.Size = new Size(65, 15);
            label3.Text = "Create file";
            label3.Visible = true;
            // 
            // label4
            // 
            label4.Size = new Size(64, 15);
            label4.Text = "File name :";
            label4.Visible = true;
            // 
            // label5
            // 
            label5.Size = new Size(190, 15);
            label5.Text = "File extension (txt, xml, csv, html) :";
            label5.Visible = true;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Size = new Size(120, 15);
            label6.Text = "File destination path :";
            label6.Visible = true;
            // 
            // label7
            // 
            label7.Size = new Size(85, 15);
            label7.Text = "Write content :";
            label7.Visible = true;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label8.Size = new Size(55, 15);
            label8.Text = "Copy file";
            label8.Visible = true;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Size = new Size(148, 15);
            label9.Text = "Select the file source path :";
            label9.Visible = true;
            // 
            // label10
            // 
            label10.Size = new Size(172, 15);
            label10.Text = "Select the file destination path :";
            label10.Visible = true;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label11.Size = new Size(66, 15);
            label11.Text = "Delete file";
            label11.Visible = true;
            // 
            // label12
            // 
            label12.Size = new Size(132, 15);
            label12.Text = "Select the file to delete :";
            label12.Visible = true;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label13.Size = new Size(76, 15);
            label13.Text = "Move folder";
            label13.Visible = true;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Size = new Size(148, 15);
            label14.Text = "Select the file source path :";
            label14.Visible = true;
            // 
            // label15
            // 
            label15.Size = new Size(172, 15);
            label15.Text = "Select the file destination path :";
            label15.Visible = true;
            // 
            // label16
            // 
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label16.Size = new Size(74, 15);
            label16.Text = "Rename file";
            label16.Visible = true;
            // 
            // label17
            // 
            label17.Size = new Size(140, 15);
            label17.Text = "Select the file to rename :";
            label17.Visible = true;
            // 
            // label18
            // 
            label18.Size = new Size(120, 15);
            label18.Text = "Choose a new name :";
            label18.Visible = true;
            // 
            // createFileNameTextBox
            // 
            createFileNameTextBox.Location = new Point(215, 79);
            createFileNameTextBox.Name = "createFileNameTextBox";
            createFileNameTextBox.Size = new Size(274, 23);
            createFileNameTextBox.TabIndex = 26;
            createFileNameTextBox.TextChanged += createFileNameTextBox_TextChanged;
            // 
            // fileExtensionTextBox
            // 
            fileExtensionTextBox.Location = new Point(215, 106);
            fileExtensionTextBox.Name = "fileExtensionTextBox";
            fileExtensionTextBox.Size = new Size(274, 23);
            fileExtensionTextBox.TabIndex = 27;
            fileExtensionTextBox.TextChanged += fileExtensionTextBox_TextChanged;
            // 
            // createFileDestinationTextBox
            // 
            createFileDestinationTextBox.Location = new Point(215, 133);
            createFileDestinationTextBox.Name = "createFileDestinationTextBox";
            createFileDestinationTextBox.Size = new Size(274, 23);
            createFileDestinationTextBox.TabIndex = 28;
            // 
            // copyFileSourceTextBox
            // 
            copyFileSourceTextBox.Location = new Point(215, 205);
            copyFileSourceTextBox.Name = "copyFileSourceTextBox";
            copyFileSourceTextBox.Size = new Size(274, 23);
            copyFileSourceTextBox.TabIndex = 30;
            // 
            // copyFileDestinationTextBox
            // 
            copyFileDestinationTextBox.Location = new Point(215, 234);
            copyFileDestinationTextBox.Name = "copyFileDestinationTextBox";
            copyFileDestinationTextBox.Size = new Size(274, 23);
            copyFileDestinationTextBox.TabIndex = 31;
            // 
            // deleteFileTextBox
            // 
            deleteFileTextBox.Location = new Point(215, 295);
            deleteFileTextBox.Name = "deleteFileTextBox";
            deleteFileTextBox.Size = new Size(274, 23);
            deleteFileTextBox.TabIndex = 32;
            // 
            // moveFileSourceTextBox
            // 
            moveFileSourceTextBox.Location = new Point(215, 349);
            moveFileSourceTextBox.Name = "moveFileSourceTextBox";
            moveFileSourceTextBox.Size = new Size(274, 23);
            moveFileSourceTextBox.TabIndex = 33;
            // 
            // moveFileDestinationTextBox
            // 
            moveFileDestinationTextBox.Location = new Point(215, 378);
            moveFileDestinationTextBox.Name = "moveFileDestinationTextBox";
            moveFileDestinationTextBox.Size = new Size(274, 23);
            moveFileDestinationTextBox.TabIndex = 34;
            // 
            // renameFileTextBox
            // 
            renameFileTextBox.Location = new Point(215, 430);
            renameFileTextBox.Name = "renameFileTextBox";
            renameFileTextBox.Size = new Size(274, 23);
            renameFileTextBox.TabIndex = 35;
            // 
            // newFileNameTextBox
            // 
            newFileNameTextBox.Location = new Point(215, 457);
            newFileNameTextBox.Name = "newFileNameTextBox";
            newFileNameTextBox.Size = new Size(274, 23);
            newFileNameTextBox.TabIndex = 36;
            newFileNameTextBox.TextChanged += newFileNameTextBox_TextChanged;
            // 
            // createBrowseButton
            // 
            createBrowseButton.Location = new Point(495, 133);
            createBrowseButton.Name = "createBrowseButton";
            createBrowseButton.Size = new Size(75, 23);
            createBrowseButton.TabIndex = 37;
            createBrowseButton.Text = "Browse";
            createBrowseButton.UseVisualStyleBackColor = true;
            createBrowseButton.Click += createBrowseButton_Click;
            // 
            // copySourceBrowseButton
            // 
            copySourceBrowseButton.Location = new Point(495, 205);
            copySourceBrowseButton.Name = "copySourceBrowseButton";
            copySourceBrowseButton.Size = new Size(75, 23);
            copySourceBrowseButton.TabIndex = 39;
            copySourceBrowseButton.Text = "Browse";
            copySourceBrowseButton.UseVisualStyleBackColor = true;
            copySourceBrowseButton.Click += copySourceBrowseButton_Click;
            // 
            // copyDestinationBrowseButton
            // 
            copyDestinationBrowseButton.Location = new Point(495, 234);
            copyDestinationBrowseButton.Name = "copyDestinationBrowseButton";
            copyDestinationBrowseButton.Size = new Size(75, 23);
            copyDestinationBrowseButton.TabIndex = 40;
            copyDestinationBrowseButton.Text = "Browse";
            copyDestinationBrowseButton.UseVisualStyleBackColor = true;
            copyDestinationBrowseButton.Click += copyDestinationBrowseButton_Click;
            // 
            // deleteBrowseButton
            // 
            deleteBrowseButton.Location = new Point(495, 295);
            deleteBrowseButton.Name = "deleteBrowseButton";
            deleteBrowseButton.Size = new Size(75, 23);
            deleteBrowseButton.TabIndex = 41;
            deleteBrowseButton.Text = "Browse";
            deleteBrowseButton.UseVisualStyleBackColor = true;
            deleteBrowseButton.Click += deleteBrowseButton_Click;
            // 
            // moveSourceBrowseButton
            // 
            moveSourceBrowseButton.Location = new Point(495, 349);
            moveSourceBrowseButton.Name = "moveSourceBrowseButton";
            moveSourceBrowseButton.Size = new Size(75, 23);
            moveSourceBrowseButton.TabIndex = 42;
            moveSourceBrowseButton.Text = "Browse";
            moveSourceBrowseButton.UseVisualStyleBackColor = true;
            moveSourceBrowseButton.Click += moveSourceBrowseButton_Click;
            // 
            // moveDestinationBrowseButton
            // 
            moveDestinationBrowseButton.Location = new Point(495, 378);
            moveDestinationBrowseButton.Name = "moveDestinationBrowseButton";
            moveDestinationBrowseButton.Size = new Size(75, 23);
            moveDestinationBrowseButton.TabIndex = 43;
            moveDestinationBrowseButton.Text = "Browse";
            moveDestinationBrowseButton.UseVisualStyleBackColor = true;
            moveDestinationBrowseButton.Click += moveDestinationBrowseButton_Click;
            // 
            // renameBrowseButton
            // 
            renameBrowseButton.Location = new Point(495, 430);
            renameBrowseButton.Name = "renameBrowseButton";
            renameBrowseButton.Size = new Size(75, 23);
            renameBrowseButton.TabIndex = 44;
            renameBrowseButton.Text = "Browse";
            renameBrowseButton.UseVisualStyleBackColor = true;
            renameBrowseButton.Click += renameBrowseButton_Click;
            // 
            // createFileButton
            // 
            createFileButton.Location = new Point(576, 160);
            createFileButton.Name = "createFileButton";
            createFileButton.Size = new Size(123, 23);
            createFileButton.TabIndex = 46;
            createFileButton.Text = "Create file";
            createFileButton.UseVisualStyleBackColor = true;
            createFileButton.Click += createFileButton_Click;
            // 
            // copyFileButton
            // 
            copyFileButton.Location = new Point(576, 233);
            copyFileButton.Name = "copyFileButton";
            copyFileButton.Size = new Size(123, 23);
            copyFileButton.TabIndex = 47;
            copyFileButton.Text = "Copy file";
            copyFileButton.UseVisualStyleBackColor = true;
            copyFileButton.Click += copyFileButton_Click;
            // 
            // deleteFileButton
            // 
            deleteFileButton.Location = new Point(576, 295);
            deleteFileButton.Name = "deleteFileButton";
            deleteFileButton.Size = new Size(123, 23);
            deleteFileButton.TabIndex = 48;
            deleteFileButton.Text = "Delete file";
            deleteFileButton.UseVisualStyleBackColor = true;
            deleteFileButton.Click += deleteFileButton_Click;
            // 
            // moveFileButton
            // 
            moveFileButton.Location = new Point(576, 377);
            moveFileButton.Name = "moveFileButton";
            moveFileButton.Size = new Size(123, 23);
            moveFileButton.TabIndex = 49;
            moveFileButton.Text = "Move folder";
            moveFileButton.UseVisualStyleBackColor = true;
            moveFileButton.Click += moveFileButton_Click;
            // 
            // renameFileButton
            // 
            renameFileButton.Location = new Point(576, 456);
            renameFileButton.Name = "renameFileButton";
            renameFileButton.Size = new Size(123, 23);
            renameFileButton.TabIndex = 50;
            renameFileButton.Text = "Rename file";
            renameFileButton.UseVisualStyleBackColor = true;
            renameFileButton.Click += renameFileButton_Click;
            // 
            // writeFileContentTextBox
            // 
            writeFileContentTextBox.Location = new Point(215, 160);
            writeFileContentTextBox.Name = "writeFileContentTextBox";
            writeFileContentTextBox.Size = new Size(274, 23);
            writeFileContentTextBox.TabIndex = 51;
            writeFileContentTextBox.TextChanged += writeFileContentTextBox_TextChanged;
            // 
            // FileManagementStep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(writeFileContentTextBox);
            Controls.Add(renameFileButton);
            Controls.Add(moveFileButton);
            Controls.Add(deleteFileButton);
            Controls.Add(copyFileButton);
            Controls.Add(createFileButton);
            Controls.Add(renameBrowseButton);
            Controls.Add(moveDestinationBrowseButton);
            Controls.Add(moveSourceBrowseButton);
            Controls.Add(deleteBrowseButton);
            Controls.Add(copyDestinationBrowseButton);
            Controls.Add(copySourceBrowseButton);
            Controls.Add(createBrowseButton);
            Controls.Add(newFileNameTextBox);
            Controls.Add(renameFileTextBox);
            Controls.Add(moveFileDestinationTextBox);
            Controls.Add(moveFileSourceTextBox);
            Controls.Add(deleteFileTextBox);
            Controls.Add(copyFileDestinationTextBox);
            Controls.Add(copyFileSourceTextBox);
            Controls.Add(createFileDestinationTextBox);
            Controls.Add(fileExtensionTextBox);
            Controls.Add(createFileNameTextBox);
            Name = "FileManagementStep";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(label9, 0);
            Controls.SetChildIndex(label10, 0);
            Controls.SetChildIndex(label11, 0);
            Controls.SetChildIndex(label12, 0);
            Controls.SetChildIndex(label13, 0);
            Controls.SetChildIndex(label14, 0);
            Controls.SetChildIndex(label15, 0);
            Controls.SetChildIndex(label16, 0);
            Controls.SetChildIndex(label17, 0);
            Controls.SetChildIndex(label18, 0);
            Controls.SetChildIndex(label19, 0);
            Controls.SetChildIndex(label20, 0);
            Controls.SetChildIndex(label21, 0);
            Controls.SetChildIndex(label22, 0);
            Controls.SetChildIndex(label23, 0);
            Controls.SetChildIndex(label24, 0);
            Controls.SetChildIndex(label25, 0);
            Controls.SetChildIndex(label26, 0);
            Controls.SetChildIndex(createFileNameTextBox, 0);
            Controls.SetChildIndex(fileExtensionTextBox, 0);
            Controls.SetChildIndex(createFileDestinationTextBox, 0);
            Controls.SetChildIndex(copyFileSourceTextBox, 0);
            Controls.SetChildIndex(copyFileDestinationTextBox, 0);
            Controls.SetChildIndex(deleteFileTextBox, 0);
            Controls.SetChildIndex(moveFileSourceTextBox, 0);
            Controls.SetChildIndex(moveFileDestinationTextBox, 0);
            Controls.SetChildIndex(renameFileTextBox, 0);
            Controls.SetChildIndex(newFileNameTextBox, 0);
            Controls.SetChildIndex(createBrowseButton, 0);
            Controls.SetChildIndex(copySourceBrowseButton, 0);
            Controls.SetChildIndex(copyDestinationBrowseButton, 0);
            Controls.SetChildIndex(deleteBrowseButton, 0);
            Controls.SetChildIndex(moveSourceBrowseButton, 0);
            Controls.SetChildIndex(moveDestinationBrowseButton, 0);
            Controls.SetChildIndex(renameBrowseButton, 0);
            Controls.SetChildIndex(createFileButton, 0);
            Controls.SetChildIndex(copyFileButton, 0);
            Controls.SetChildIndex(deleteFileButton, 0);
            Controls.SetChildIndex(moveFileButton, 0);
            Controls.SetChildIndex(renameFileButton, 0);
            Controls.SetChildIndex(writeFileContentTextBox, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox createFileNameTextBox;
        private TextBox fileExtensionTextBox;
        private TextBox createFileDestinationTextBox;
        private TextBox copyFileSourceTextBox;
        private TextBox copyFileDestinationTextBox;
        private TextBox deleteFileTextBox;
        private TextBox moveFileSourceTextBox;
        private TextBox moveFileDestinationTextBox;
        private TextBox renameFileTextBox;
        private TextBox newFileNameTextBox;
        private Button createBrowseButton;
        private Button copySourceBrowseButton;
        private Button copyDestinationBrowseButton;
        private Button deleteBrowseButton;
        private Button moveSourceBrowseButton;
        private Button moveDestinationBrowseButton;
        private Button renameBrowseButton;
        private Button createFileButton;
        private Button copyFileButton;
        private Button deleteFileButton;
        private Button moveFileButton;
        private Button renameFileButton;
        private TextBox writeFileContentTextBox;
    }
}

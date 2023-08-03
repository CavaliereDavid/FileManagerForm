using UserInterface.StandardControls;

namespace UserInterface
{
    partial class UserInterfaceForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerControl = new HeaderControl();
            navigationBarControl = new NavigationBarControl();
            stepManagerControl = new StepManagerControl();
            SuspendLayout();
            // 
            // headerControl
            // 
            headerControl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            headerControl.BackColor = SystemColors.Highlight;
            headerControl.BackgroundImageLayout = ImageLayout.Zoom;
            headerControl.Location = new Point(0, 0);
            headerControl.Name = "headerControl";
            headerControl.Size = new Size(714, 110);
            headerControl.TabIndex = 1;
            // 
            // navigationBarControl
            // 
            navigationBarControl.BackColor = SystemColors.Highlight;
            navigationBarControl.Dock = DockStyle.Bottom;
            navigationBarControl.Location = new Point(0, 831);
            navigationBarControl.Margin = new Padding(3, 4, 3, 4);
            navigationBarControl.Name = "navigationBarControl";
            navigationBarControl.Size = new Size(714, 28);
            navigationBarControl.TabIndex = 0;
            // 
            // stepManagerControl
            // 
            stepManagerControl.BackColor = SystemColors.ControlLightLight;
            stepManagerControl.Location = new Point(0, 110);
            stepManagerControl.Margin = new Padding(3, 4, 3, 4);
            stepManagerControl.Name = "stepManagerControl";
            stepManagerControl.Size = new Size(716, 723);
            stepManagerControl.TabIndex = 2;
            // 
            // UserInterfaceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(714, 859);
            Controls.Add(navigationBarControl);
            Controls.Add(headerControl);
            Controls.Add(stepManagerControl);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "UserInterfaceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Folder and file manager";
            ResumeLayout(false);
        }

        #endregion

        private StandardControls.HeaderControl headerControl;
        private StandardControls.NavigationBarControl navigationBarControl;
        private StandardControls.StepManagerControl stepManagerControl;
    }
}
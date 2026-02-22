using System.Runtime.CompilerServices;

namespace gravity_box
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            clearToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem = new ToolStripMenuItem();
            startSimulationToolStripMenuItem = new ToolStripMenuItem();
            ObjectPictureBox = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ObjectPictureBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { clearToolStripMenuItem, createToolStripMenuItem, startSimulationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(582, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Enabled = false;
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(57, 24);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(66, 24);
            createToolStripMenuItem.Text = "Create";
            createToolStripMenuItem.Click += createToolStripMenuItem_Click;
            // 
            // startSimulationToolStripMenuItem
            // 
            startSimulationToolStripMenuItem.Enabled = false;
            startSimulationToolStripMenuItem.Name = "startSimulationToolStripMenuItem";
            startSimulationToolStripMenuItem.Size = new Size(129, 24);
            startSimulationToolStripMenuItem.Text = "Start Simulation";
            startSimulationToolStripMenuItem.Click += startSimulationToolStripMenuItem_Click;
            // 
            // ObjectPictureBox
            // 
            ObjectPictureBox.Image = Properties.Resources._object;
            ObjectPictureBox.Location = new Point(250, 100);
            ObjectPictureBox.Name = "ObjectPictureBox";
            ObjectPictureBox.Size = new Size(100, 100);
            ObjectPictureBox.TabIndex = 1;
            ObjectPictureBox.TabStop = false;
            ObjectPictureBox.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(582, 753);
            Controls.Add(ObjectPictureBox);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fall Simulator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ObjectPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem startSimulationToolStripMenuItem;
        private PictureBox ObjectPictureBox;
    }
}

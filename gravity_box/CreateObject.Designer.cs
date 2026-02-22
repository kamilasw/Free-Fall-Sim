namespace gravity_box
{
    partial class CreateObject
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            heightValue = new NumericUpDown();
            HeightLabel = new Label();
            createButton = new Button();
            ((System.ComponentModel.ISupportInitialize)heightValue).BeginInit();
            SuspendLayout();
            // 
            // heightValue
            // 
            heightValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            heightValue.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            heightValue.Location = new Point(259, 47);
            heightValue.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            heightValue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            heightValue.Name = "heightValue";
            heightValue.Size = new Size(104, 32);
            heightValue.TabIndex = 0;
            heightValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // HeightLabel
            // 
            HeightLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            HeightLabel.AutoSize = true;
            HeightLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HeightLabel.Location = new Point(83, 55);
            HeightLabel.Name = "HeightLabel";
            HeightLabel.Size = new Size(159, 24);
            HeightLabel.TabIndex = 1;
            HeightLabel.Text = "Height in meters";
            // 
            // createButton
            // 
            createButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createButton.Location = new Point(162, 125);
            createButton.Name = "createButton";
            createButton.Size = new Size(158, 53);
            createButton.TabIndex = 2;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // CreateObject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(470, 233);
            Controls.Add(createButton);
            Controls.Add(HeightLabel);
            Controls.Add(heightValue);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CreateObject";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Create the Object";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)heightValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown heightValue;
        private Label HeightLabel;
        private Button createButton;
    }
}
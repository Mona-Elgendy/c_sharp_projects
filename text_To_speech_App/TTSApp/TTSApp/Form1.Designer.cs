namespace TTSApp
{
    partial class Form1
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
            this.SpeechTextBox = new System.Windows.Forms.TextBox();
            this.SpeakButton = new System.Windows.Forms.Button();
            this.SoundTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.PersonComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SoundTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // SpeechTextBox
            // 
            this.SpeechTextBox.Location = new System.Drawing.Point(39, 95);
            this.SpeechTextBox.Multiline = true;
            this.SpeechTextBox.Name = "SpeechTextBox";
            this.SpeechTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SpeechTextBox.Size = new System.Drawing.Size(719, 227);
            this.SpeechTextBox.TabIndex = 0;
            // 
            // SpeakButton
            // 
            this.SpeakButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeakButton.Location = new System.Drawing.Point(39, 27);
            this.SpeakButton.Name = "SpeakButton";
            this.SpeakButton.Size = new System.Drawing.Size(165, 47);
            this.SpeakButton.TabIndex = 1;
            this.SpeakButton.Text = "&Speak";
            this.SpeakButton.UseVisualStyleBackColor = true;
            this.SpeakButton.Click += new System.EventHandler(this.SpeakButton_Click);
            // 
            // SoundTrackBar
            // 
            this.SoundTrackBar.Location = new System.Drawing.Point(505, 366);
            this.SoundTrackBar.Maximum = 100;
            this.SoundTrackBar.Name = "SoundTrackBar";
            this.SoundTrackBar.Size = new System.Drawing.Size(256, 56);
            this.SoundTrackBar.TabIndex = 2;
            this.SoundTrackBar.Value = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Volume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Speed";
            // 
            // SpeedTrackBar
            // 
            this.SpeedTrackBar.Location = new System.Drawing.Point(126, 366);
            this.SpeedTrackBar.Minimum = -10;
            this.SpeedTrackBar.Name = "SpeedTrackBar";
            this.SpeedTrackBar.Size = new System.Drawing.Size(213, 56);
            this.SpeedTrackBar.TabIndex = 4;
            // 
            // PersonComboBox
            // 
            this.PersonComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonComboBox.FormattingEnabled = true;
            this.PersonComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PersonComboBox.Location = new System.Drawing.Point(482, 35);
            this.PersonComboBox.Name = "PersonComboBox";
            this.PersonComboBox.Size = new System.Drawing.Size(276, 33);
            this.PersonComboBox.TabIndex = 6;
            this.PersonComboBox.Text = "Male";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 457);
            this.Controls.Add(this.PersonComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SpeedTrackBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SoundTrackBar);
            this.Controls.Add(this.SpeakButton);
            this.Controls.Add(this.SpeechTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text To Speech Demo";
            ((System.ComponentModel.ISupportInitialize)(this.SoundTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SpeechTextBox;
        private System.Windows.Forms.Button SpeakButton;
        private System.Windows.Forms.TrackBar SoundTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar SpeedTrackBar;
        private System.Windows.Forms.ComboBox PersonComboBox;
    }
}


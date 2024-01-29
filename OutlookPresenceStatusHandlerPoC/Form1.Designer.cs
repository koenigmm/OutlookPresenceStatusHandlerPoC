namespace OutlookPresenceStatusHandlerPoC
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
            this.Webex = new System.Windows.Forms.Panel();
            this.activateProvider = new System.Windows.Forms.Button();
            this.Intro = new System.Windows.Forms.Label();
            this.WebexButton = new System.Windows.Forms.RadioButton();
            this.SkypeButton = new System.Windows.Forms.RadioButton();
            this.Webex.SuspendLayout();
            this.SuspendLayout();
            // 
            // Webex
            // 
            this.Webex.Controls.Add(this.SkypeButton);
            this.Webex.Controls.Add(this.WebexButton);
            this.Webex.Location = new System.Drawing.Point(130, 112);
            this.Webex.Name = "Webex";
            this.Webex.Size = new System.Drawing.Size(504, 255);
            this.Webex.TabIndex = 1;
            // 
            // activateProvider
            // 
            this.activateProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activateProvider.Location = new System.Drawing.Point(288, 392);
            this.activateProvider.Name = "activateProvider";
            this.activateProvider.Size = new System.Drawing.Size(156, 46);
            this.activateProvider.TabIndex = 2;
            this.activateProvider.Text = "Aktivieren";
            this.activateProvider.UseVisualStyleBackColor = true;
            this.activateProvider.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Intro
            // 
            this.Intro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intro.Location = new System.Drawing.Point(12, 13);
            this.Intro.Name = "Intro";
            this.Intro.Size = new System.Drawing.Size(776, 68);
            this.Intro.TabIndex = 3;
            this.Intro.Text = "Wählen Sie den gewünschten Anbieter für die Outlook-Statusanzeige aus und klicken" +
    " Sie anschließend auf \"Aktivieren\"";
            // 
            // WebexButton
            // 
            this.WebexButton.AutoSize = true;
            this.WebexButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebexButton.Location = new System.Drawing.Point(205, 15);
            this.WebexButton.Name = "WebexButton";
            this.WebexButton.Size = new System.Drawing.Size(89, 28);
            this.WebexButton.TabIndex = 0;
            this.WebexButton.TabStop = true;
            this.WebexButton.Text = "Webex";
            this.WebexButton.UseVisualStyleBackColor = true;
            // 
            // SkypeButton
            // 
            this.SkypeButton.AutoSize = true;
            this.SkypeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkypeButton.Location = new System.Drawing.Point(205, 49);
            this.SkypeButton.Name = "SkypeButton";
            this.SkypeButton.Size = new System.Drawing.Size(80, 28);
            this.SkypeButton.TabIndex = 1;
            this.SkypeButton.TabStop = true;
            this.SkypeButton.Text = "Skype";
            this.SkypeButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Intro);
            this.Controls.Add(this.activateProvider);
            this.Controls.Add(this.Webex);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Webex.ResumeLayout(false);
            this.Webex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Webex;
        private System.Windows.Forms.Button activateProvider;
        private System.Windows.Forms.Label Intro;
        private System.Windows.Forms.RadioButton SkypeButton;
        private System.Windows.Forms.RadioButton WebexButton;
    }
}


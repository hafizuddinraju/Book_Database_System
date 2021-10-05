namespace Bookdatabase
{
    partial class HomeView
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
            this.buttonSaveInformation = new System.Windows.Forms.Button();
            this.buttonFindoutInformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSaveInformation
            // 
            this.buttonSaveInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveInformation.Location = new System.Drawing.Point(270, 99);
            this.buttonSaveInformation.Name = "buttonSaveInformation";
            this.buttonSaveInformation.Size = new System.Drawing.Size(255, 48);
            this.buttonSaveInformation.TabIndex = 0;
            this.buttonSaveInformation.Text = "Save Information";
            this.buttonSaveInformation.UseVisualStyleBackColor = true;
            this.buttonSaveInformation.Click += new System.EventHandler(this.buttonSaveInformation_Click);
            // 
            // buttonFindoutInformation
            // 
            this.buttonFindoutInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindoutInformation.Location = new System.Drawing.Point(270, 231);
            this.buttonFindoutInformation.Name = "buttonFindoutInformation";
            this.buttonFindoutInformation.Size = new System.Drawing.Size(255, 48);
            this.buttonFindoutInformation.TabIndex = 1;
            this.buttonFindoutInformation.Text = "Findout Information";
            this.buttonFindoutInformation.UseVisualStyleBackColor = true;
            this.buttonFindoutInformation.Click += new System.EventHandler(this.buttonFindoutInformation_Click);
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFindoutInformation);
            this.Controls.Add(this.buttonSaveInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeView";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSaveInformation;
        private System.Windows.Forms.Button buttonFindoutInformation;
    }
}
namespace Bookdatabase
{
    partial class ManuFindView
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
            this.buttonFindBook = new System.Windows.Forms.Button();
            this.buttonFindAuthor = new System.Windows.Forms.Button();
            this.buttonFindPublisher = new System.Windows.Forms.Button();
            this.buttonFindContributor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFindBook
            // 
            this.buttonFindBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindBook.Location = new System.Drawing.Point(281, 70);
            this.buttonFindBook.Name = "buttonFindBook";
            this.buttonFindBook.Size = new System.Drawing.Size(187, 41);
            this.buttonFindBook.TabIndex = 0;
            this.buttonFindBook.Text = "FindBook";
            this.buttonFindBook.UseVisualStyleBackColor = true;
            this.buttonFindBook.Click += new System.EventHandler(this.buttonFindBook_Click);
            // 
            // buttonFindAuthor
            // 
            this.buttonFindAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindAuthor.Location = new System.Drawing.Point(281, 150);
            this.buttonFindAuthor.Name = "buttonFindAuthor";
            this.buttonFindAuthor.Size = new System.Drawing.Size(187, 41);
            this.buttonFindAuthor.TabIndex = 1;
            this.buttonFindAuthor.Text = "FindAuthor";
            this.buttonFindAuthor.UseVisualStyleBackColor = true;
            this.buttonFindAuthor.Click += new System.EventHandler(this.buttonFindAuthor_Click);
            // 
            // buttonFindPublisher
            // 
            this.buttonFindPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindPublisher.Location = new System.Drawing.Point(281, 232);
            this.buttonFindPublisher.Name = "buttonFindPublisher";
            this.buttonFindPublisher.Size = new System.Drawing.Size(187, 41);
            this.buttonFindPublisher.TabIndex = 2;
            this.buttonFindPublisher.Text = "FindPublisher";
            this.buttonFindPublisher.UseVisualStyleBackColor = true;
            this.buttonFindPublisher.Click += new System.EventHandler(this.buttonFindPublisher_Click);
            // 
            // buttonFindContributor
            // 
            this.buttonFindContributor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindContributor.Location = new System.Drawing.Point(281, 306);
            this.buttonFindContributor.Name = "buttonFindContributor";
            this.buttonFindContributor.Size = new System.Drawing.Size(187, 41);
            this.buttonFindContributor.TabIndex = 3;
            this.buttonFindContributor.Text = "FindContributor";
            this.buttonFindContributor.UseVisualStyleBackColor = true;
            this.buttonFindContributor.Click += new System.EventHandler(this.buttonFindContributor_Click);
            // 
            // ManuFindView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFindContributor);
            this.Controls.Add(this.buttonFindPublisher);
            this.Controls.Add(this.buttonFindAuthor);
            this.Controls.Add(this.buttonFindBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManuFindView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManuFindView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFindBook;
        private System.Windows.Forms.Button buttonFindAuthor;
        private System.Windows.Forms.Button buttonFindPublisher;
        private System.Windows.Forms.Button buttonFindContributor;
    }
}
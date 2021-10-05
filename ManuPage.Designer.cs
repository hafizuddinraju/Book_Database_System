namespace Bookdatabase
{
    partial class ManuPage
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
            this.buttonBook = new System.Windows.Forms.Button();
            this.buttonAuthor = new System.Windows.Forms.Button();
            this.buttonPublisher = new System.Windows.Forms.Button();
            this.buttonContributor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBook
            // 
            this.buttonBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBook.Location = new System.Drawing.Point(319, 70);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(151, 47);
            this.buttonBook.TabIndex = 0;
            this.buttonBook.Text = "Book";
            this.buttonBook.UseVisualStyleBackColor = true;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // buttonAuthor
            // 
            this.buttonAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAuthor.Location = new System.Drawing.Point(319, 146);
            this.buttonAuthor.Name = "buttonAuthor";
            this.buttonAuthor.Size = new System.Drawing.Size(151, 47);
            this.buttonAuthor.TabIndex = 1;
            this.buttonAuthor.Text = "Author";
            this.buttonAuthor.UseVisualStyleBackColor = true;
            this.buttonAuthor.Click += new System.EventHandler(this.buttonAuthor_Click);
            // 
            // buttonPublisher
            // 
            this.buttonPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPublisher.Location = new System.Drawing.Point(319, 214);
            this.buttonPublisher.Name = "buttonPublisher";
            this.buttonPublisher.Size = new System.Drawing.Size(151, 47);
            this.buttonPublisher.TabIndex = 2;
            this.buttonPublisher.Text = "Publisher";
            this.buttonPublisher.UseVisualStyleBackColor = true;
            this.buttonPublisher.Click += new System.EventHandler(this.buttonPublisher_Click);
            // 
            // buttonContributor
            // 
            this.buttonContributor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContributor.Location = new System.Drawing.Point(319, 294);
            this.buttonContributor.Name = "buttonContributor";
            this.buttonContributor.Size = new System.Drawing.Size(151, 47);
            this.buttonContributor.TabIndex = 3;
            this.buttonContributor.Text = "Contributor";
            this.buttonContributor.UseVisualStyleBackColor = true;
            this.buttonContributor.Click += new System.EventHandler(this.buttonContributor_Click);
            // 
            // ManuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonContributor);
            this.Controls.Add(this.buttonPublisher);
            this.Controls.Add(this.buttonAuthor);
            this.Controls.Add(this.buttonBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManuPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManuPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Button buttonAuthor;
        private System.Windows.Forms.Button buttonPublisher;
        private System.Windows.Forms.Button buttonContributor;
    }
}
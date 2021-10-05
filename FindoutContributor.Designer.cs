namespace Bookdatabase
{
    partial class FindoutContributor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCon_ID = new System.Windows.Forms.TextBox();
            this.textBoxCon_Level = new System.Windows.Forms.TextBox();
            this.textBoxCon_Type = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonFindoutContributor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Con_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Con_Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Con_Type";
            // 
            // textBoxCon_ID
            // 
            this.textBoxCon_ID.Location = new System.Drawing.Point(421, 54);
            this.textBoxCon_ID.Name = "textBoxCon_ID";
            this.textBoxCon_ID.Size = new System.Drawing.Size(168, 20);
            this.textBoxCon_ID.TabIndex = 0;
            // 
            // textBoxCon_Level
            // 
            this.textBoxCon_Level.Location = new System.Drawing.Point(421, 223);
            this.textBoxCon_Level.Name = "textBoxCon_Level";
            this.textBoxCon_Level.Size = new System.Drawing.Size(168, 20);
            this.textBoxCon_Level.TabIndex = 2;
            // 
            // textBoxCon_Type
            // 
            this.textBoxCon_Type.Location = new System.Drawing.Point(421, 302);
            this.textBoxCon_Type.Name = "textBoxCon_Type";
            this.textBoxCon_Type.Size = new System.Drawing.Size(168, 20);
            this.textBoxCon_Type.TabIndex = 3;
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(419, 116);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(96, 38);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonFindoutContributor
            // 
            this.buttonFindoutContributor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindoutContributor.Location = new System.Drawing.Point(586, 116);
            this.buttonFindoutContributor.Name = "buttonFindoutContributor";
            this.buttonFindoutContributor.Size = new System.Drawing.Size(156, 38);
            this.buttonFindoutContributor.TabIndex = 1;
            this.buttonFindoutContributor.Text = "FindoutContributor";
            this.buttonFindoutContributor.UseVisualStyleBackColor = true;
            this.buttonFindoutContributor.Click += new System.EventHandler(this.buttonFindoutContributor_Click);
            // 
            // FindoutContributor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFindoutContributor);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.textBoxCon_Type);
            this.Controls.Add(this.textBoxCon_Level);
            this.Controls.Add(this.textBoxCon_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindoutContributor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindoutContributor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCon_ID;
        private System.Windows.Forms.TextBox textBoxCon_Level;
        private System.Windows.Forms.TextBox textBoxCon_Type;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonFindoutContributor;
    }
}
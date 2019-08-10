namespace WindowsFormsApp1
{
    partial class frmAdmin
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtScore = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtName.Location = new System.Drawing.Point(319, 174);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(163, 20);
            this.TxtName.TabIndex = 5;
            this.TxtName.Text = "Name";
            // 
            // TxtScore
            // 
            this.TxtScore.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtScore.Location = new System.Drawing.Point(319, 200);
            this.TxtScore.Name = "TxtScore";
            this.TxtScore.Size = new System.Drawing.Size(163, 20);
            this.TxtScore.TabIndex = 4;
            this.TxtScore.Text = "Score";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(319, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 41);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add new score";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtScore);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmAdmin";
            this.Text = "Input Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtScore;
        private System.Windows.Forms.Button btnAdd;
    }
}
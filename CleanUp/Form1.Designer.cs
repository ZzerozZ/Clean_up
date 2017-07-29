namespace CleanUp
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
            this.btnCleanSysFiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCleanSysFiles
            // 
            this.btnCleanSysFiles.Location = new System.Drawing.Point(173, 51);
            this.btnCleanSysFiles.Name = "btnCleanSysFiles";
            this.btnCleanSysFiles.Size = new System.Drawing.Size(107, 40);
            this.btnCleanSysFiles.TabIndex = 0;
            this.btnCleanSysFiles.Text = "Xóa rác";
            this.btnCleanSysFiles.UseVisualStyleBackColor = true;
            this.btnCleanSysFiles.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "NGHĨA ĐẸP TRAI VL";
            // 
            // btnGame
            // 
            this.btnGame.Location = new System.Drawing.Point(32, 51);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(107, 40);
            this.btnGame.TabIndex = 2;
            this.btnGame.Text = "Garenal Plus";
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 103);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCleanSysFiles);
            this.Name = "Form1";
            this.Text = "Nghĩa đẹp trai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCleanSysFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGame;
    }
}


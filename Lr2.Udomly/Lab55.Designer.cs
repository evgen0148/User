namespace Lr2.Udomly
{
    partial class Lab55
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
            this.label5 = new System.Windows.Forms.Label();
            this.klik4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(327, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 148;
            this.label5.Text = "Задание №5";
            // 
            // klik4
            // 
            this.klik4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.klik4.Location = new System.Drawing.Point(656, 356);
            this.klik4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.klik4.Name = "klik4";
            this.klik4.Size = new System.Drawing.Size(80, 36);
            this.klik4.TabIndex = 150;
            this.klik4.Text = "Назад";
            this.klik4.UseVisualStyleBackColor = true;
            this.klik4.Click += new System.EventHandler(this.klik4_Click);
            // 
            // Lab55
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.klik4);
            this.Controls.Add(this.label5);
            this.Name = "Lab55";
            this.Text = "Задание 5.5";
            this.Load += new System.EventHandler(this.Lab55_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Lab55_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button klik4;
    }
}
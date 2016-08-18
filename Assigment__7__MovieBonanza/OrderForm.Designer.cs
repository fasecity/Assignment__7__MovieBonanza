namespace Assigment__7__MovieBonanza
{
    partial class OrderForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TitleTextBox2 = new System.Windows.Forms.TextBox();
            this.CategoryTextBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CostTextBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(604, 576);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(162, 56);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CostTextBox2);
            this.groupBox1.Location = new System.Drawing.Point(367, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 522);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // TitleTextBox2
            // 
            this.TitleTextBox2.BackColor = System.Drawing.Color.White;
            this.TitleTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTextBox2.Location = new System.Drawing.Point(42, 86);
            this.TitleTextBox2.Name = "TitleTextBox2";
            this.TitleTextBox2.ReadOnly = true;
            this.TitleTextBox2.Size = new System.Drawing.Size(225, 35);
            this.TitleTextBox2.TabIndex = 2;
            // 
            // CategoryTextBox2
            // 
            this.CategoryTextBox2.BackColor = System.Drawing.Color.White;
            this.CategoryTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryTextBox2.Location = new System.Drawing.Point(42, 170);
            this.CategoryTextBox2.Name = "CategoryTextBox2";
            this.CategoryTextBox2.ReadOnly = true;
            this.CategoryTextBox2.Size = new System.Drawing.Size(225, 35);
            this.CategoryTextBox2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(42, 258);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(225, 261);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // CostTextBox2
            // 
            this.CostTextBox2.BackColor = System.Drawing.Color.White;
            this.CostTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostTextBox2.Location = new System.Drawing.Point(63, 94);
            this.CostTextBox2.Name = "CostTextBox2";
            this.CostTextBox2.ReadOnly = true;
            this.CostTextBox2.Size = new System.Drawing.Size(270, 35);
            this.CostTextBox2.TabIndex = 0;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 644);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.CategoryTextBox2);
            this.Controls.Add(this.TitleTextBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backButton);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox TitleTextBox2;
        public System.Windows.Forms.TextBox CategoryTextBox2;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox CostTextBox2;
    }
}
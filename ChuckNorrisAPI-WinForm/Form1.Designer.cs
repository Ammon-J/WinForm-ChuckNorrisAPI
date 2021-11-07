namespace ChuckNorrisAPI_WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jokeCategoriesCbBx = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.jokeGBx = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(94, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuck Norris Joke Generator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(273, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Joke";
            // 
            // jokeCategoriesCbBx
            // 
            this.jokeCategoriesCbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jokeCategoriesCbBx.FormattingEnabled = true;
            this.jokeCategoriesCbBx.Location = new System.Drawing.Point(172, 364);
            this.jokeCategoriesCbBx.Name = "jokeCategoriesCbBx";
            this.jokeCategoriesCbBx.Size = new System.Drawing.Size(248, 28);
            this.jokeCategoriesCbBx.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(198, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 96);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generate Joke";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(228, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Joke Category";
            // 
            // jokeGBx
            // 
            this.jokeGBx.BackColor = System.Drawing.SystemColors.Control;
            this.jokeGBx.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.jokeGBx.Location = new System.Drawing.Point(94, 166);
            this.jokeGBx.Name = "jokeGBx";
            this.jokeGBx.Size = new System.Drawing.Size(433, 115);
            this.jokeGBx.TabIndex = 6;
            this.jokeGBx.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 569);
            this.Controls.Add(this.jokeGBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.jokeCategoriesCbBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox jokeCategoriesCbBx;
        private Button button1;
        private Label label3;
        private GroupBox jokeGBx;
    }
}
namespace _23._10._22
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
            this.components = new System.ComponentModel.Container();
            this.timertxt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bstart = new System.Windows.Forms.Button();
            this.bstop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timertxt
            // 
            this.timertxt.AutoSize = true;
            this.timertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timertxt.ForeColor = System.Drawing.Color.White;
            this.timertxt.Location = new System.Drawing.Point(122, 59);
            this.timertxt.Name = "timertxt";
            this.timertxt.Size = new System.Drawing.Size(96, 20);
            this.timertxt.TabIndex = 0;
            this.timertxt.Text = "Осталось:";
            // 
            // bstart
            // 
            this.bstart.Location = new System.Drawing.Point(23, 40);
            this.bstart.Name = "bstart";
            this.bstart.Size = new System.Drawing.Size(75, 23);
            this.bstart.TabIndex = 1;
            this.bstart.Text = "Старт";
            this.bstart.UseVisualStyleBackColor = true;
            this.bstart.Click += new System.EventHandler(this.bstart_Click);
            // 
            // bstop
            // 
            this.bstop.Location = new System.Drawing.Point(23, 78);
            this.bstop.Name = "bstop";
            this.bstop.Size = new System.Drawing.Size(75, 23);
            this.bstop.TabIndex = 2;
            this.bstop.Text = "Стоп";
            this.bstop.UseVisualStyleBackColor = true;
            this.bstop.Click += new System.EventHandler(this.bstop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(526, 176);
            this.Controls.Add(this.bstop);
            this.Controls.Add(this.bstart);
            this.Controls.Add(this.timertxt);
            this.MaximumSize = new System.Drawing.Size(542, 215);
            this.MinimumSize = new System.Drawing.Size(542, 215);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Button bstart;
        private Button bstop;
        public Label timertxt;
    }
}
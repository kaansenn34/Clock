
namespace Clock
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
            this.hm = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.dt = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // hm
            // 
            this.hm.AutoSize = true;
            this.hm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hm.Font = new System.Drawing.Font("Agency FB", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.hm.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.hm.Location = new System.Drawing.Point(209, 9);
            this.hm.Name = "hm";
            this.hm.Size = new System.Drawing.Size(360, 192);
            this.hm.TabIndex = 0;
            this.hm.Text = "22:22";
            this.hm.Click += new System.EventHandler(this.Form1_Load);
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.d.Font = new System.Drawing.Font("Agency FB", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.d.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.d.Location = new System.Drawing.Point(337, 213);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(126, 47);
            this.d.TabIndex = 1;
            this.d.Text = "Pazartesi";
            this.d.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.s.Font = new System.Drawing.Font("Agency FB", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.s.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.s.Location = new System.Drawing.Point(575, 93);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(54, 47);
            this.s.TabIndex = 2;
            this.s.Text = "22";
            this.s.Click += new System.EventHandler(this.label3_Click);
            // 
            // dt
            // 
            this.dt.AutoSize = true;
            this.dt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dt.Font = new System.Drawing.Font("Agency FB", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dt.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.dt.Location = new System.Drawing.Point(293, 404);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(186, 47);
            this.dt.TabIndex = 3;
            this.dt.Text = "25 Aralık 2021";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(762, 450);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.s);
            this.Controls.Add(this.d);
            this.Controls.Add(this.hm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hm;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Label dt;
        private System.Windows.Forms.Timer timer;
    }
}


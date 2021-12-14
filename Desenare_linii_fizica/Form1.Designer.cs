
namespace Desenare_linii_fizica
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ValUnghi = new System.Windows.Forms.HScrollBar();
            this.AfUnghi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AfForta = new System.Windows.Forms.Label();
            this.ValForta = new System.Windows.Forms.HScrollBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AfMiu = new System.Windows.Forms.Label();
            this.ValMiu = new System.Windows.Forms.HScrollBar();
            this.PtMasa = new System.Windows.Forms.GroupBox();
            this.AfMasa = new System.Windows.Forms.Label();
            this.ValMasa = new System.Windows.Forms.HScrollBar();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.PtMasa.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AfUnghi);
            this.groupBox1.Controls.Add(this.ValUnghi);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(318, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unghi";
            // 
            // ValUnghi
            // 
            this.ValUnghi.Location = new System.Drawing.Point(3, 22);
            this.ValUnghi.Maximum = 90;
            this.ValUnghi.Name = "ValUnghi";
            this.ValUnghi.Size = new System.Drawing.Size(312, 18);
            this.ValUnghi.TabIndex = 1;
            this.ValUnghi.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ValUnghi_Scroll);
            // 
            // AfUnghi
            // 
            this.AfUnghi.AutoSize = true;
            this.AfUnghi.Location = new System.Drawing.Point(163, 58);
            this.AfUnghi.Name = "AfUnghi";
            this.AfUnghi.Size = new System.Drawing.Size(18, 20);
            this.AfUnghi.TabIndex = 1;
            this.AfUnghi.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AfForta);
            this.groupBox2.Controls.Add(this.ValForta);
            this.groupBox2.Location = new System.Drawing.Point(342, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(318, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Forța";
            // 
            // AfForta
            // 
            this.AfForta.AutoSize = true;
            this.AfForta.Location = new System.Drawing.Point(163, 58);
            this.AfForta.Name = "AfForta";
            this.AfForta.Size = new System.Drawing.Size(18, 20);
            this.AfForta.TabIndex = 1;
            this.AfForta.Text = "0";
            // 
            // ValForta
            // 
            this.ValForta.Location = new System.Drawing.Point(3, 22);
            this.ValForta.Maximum = 90;
            this.ValForta.Name = "ValForta";
            this.ValForta.Size = new System.Drawing.Size(312, 18);
            this.ValForta.TabIndex = 1;
            this.ValForta.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ValForta_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AfMiu);
            this.groupBox3.Controls.Add(this.ValMiu);
            this.groupBox3.Location = new System.Drawing.Point(667, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(318, 96);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Coeficient de frecare";
            // 
            // AfMiu
            // 
            this.AfMiu.AutoSize = true;
            this.AfMiu.Location = new System.Drawing.Point(163, 58);
            this.AfMiu.Name = "AfMiu";
            this.AfMiu.Size = new System.Drawing.Size(18, 20);
            this.AfMiu.TabIndex = 1;
            this.AfMiu.Text = "0";
            // 
            // ValMiu
            // 
            this.ValMiu.Location = new System.Drawing.Point(3, 22);
            this.ValMiu.Maximum = 90;
            this.ValMiu.Name = "ValMiu";
            this.ValMiu.Size = new System.Drawing.Size(312, 18);
            this.ValMiu.TabIndex = 1;
            this.ValMiu.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ValMiu_Scroll);
            // 
            // PtMasa
            // 
            this.PtMasa.Controls.Add(this.AfMasa);
            this.PtMasa.Controls.Add(this.ValMasa);
            this.PtMasa.Location = new System.Drawing.Point(993, 15);
            this.PtMasa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PtMasa.Name = "PtMasa";
            this.PtMasa.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PtMasa.Size = new System.Drawing.Size(318, 96);
            this.PtMasa.TabIndex = 3;
            this.PtMasa.TabStop = false;
            this.PtMasa.Text = "Masa";
            // 
            // AfMasa
            // 
            this.AfMasa.AutoSize = true;
            this.AfMasa.Location = new System.Drawing.Point(163, 58);
            this.AfMasa.Name = "AfMasa";
            this.AfMasa.Size = new System.Drawing.Size(18, 20);
            this.AfMasa.TabIndex = 1;
            this.AfMasa.Text = "0";
            // 
            // ValMasa
            // 
            this.ValMasa.Location = new System.Drawing.Point(3, 22);
            this.ValMasa.Maximum = 90;
            this.ValMasa.Minimum = 1;
            this.ValMasa.Name = "ValMasa";
            this.ValMasa.Size = new System.Drawing.Size(312, 18);
            this.ValMasa.TabIndex = 1;
            this.ValMasa.Value = 1;
            this.ValMasa.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ValMasa_Scroll);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(18, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Animatie";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(144, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1332, 642);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PtMasa);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Miscare corp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.PtMasa.ResumeLayout(false);
            this.PtMasa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.HScrollBar ValUnghi;
        private System.Windows.Forms.Label AfUnghi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label AfForta;
        private System.Windows.Forms.HScrollBar ValForta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label AfMiu;
        private System.Windows.Forms.HScrollBar ValMiu;
        private System.Windows.Forms.GroupBox PtMasa;
        private System.Windows.Forms.Label AfMasa;
        private System.Windows.Forms.HScrollBar ValMasa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
    }
}


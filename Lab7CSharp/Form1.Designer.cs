namespace Lab7CSharp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();

            // panelRed
            this.panelRed.BackColor = System.Drawing.Color.Gray;
            this.panelRed.Location = new System.Drawing.Point(50, 30);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(60, 60);
            this.panelRed.TabIndex = 0;

            // panelYellow
            this.panelYellow.BackColor = System.Drawing.Color.Gray;
            this.panelYellow.Location = new System.Drawing.Point(50, 100);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(60, 60);
            this.panelYellow.TabIndex = 1;

            // panelGreen
            this.panelGreen.BackColor = System.Drawing.Color.Gray;
            this.panelGreen.Location = new System.Drawing.Point(50, 170);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(60, 60);
            this.panelGreen.TabIndex = 2;

            // btnStart
            this.btnStart.Location = new System.Drawing.Point(130, 100);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 30);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // numericUpDown1
            this.numericUpDown1.Location = new System.Drawing.Point(130, 60);
            this.numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Інтервал (сек):";

            // timer1
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 260);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panelGreen);
            this.Controls.Add(this.panelYellow);
            this.Controls.Add(this.panelRed);
            this.Name = "Form1";
            this.Text = "Світлофор";
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

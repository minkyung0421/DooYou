namespace DooGame
{
    partial class Scene
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
            this.domibeP = new System.Windows.Forms.Panel();
            this.blackP = new System.Windows.Forms.Panel();
            this.TextS1 = new System.Windows.Forms.TextBox();
            this.NextS2 = new System.Windows.Forms.Button();
            this.NextS1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.domibeP.SuspendLayout();
            this.blackP.SuspendLayout();
            this.SuspendLayout();
            // 
            // domibeP
            // 
            this.domibeP.Controls.Add(this.blackP);
            this.domibeP.Controls.Add(this.NextS1);
            this.domibeP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.domibeP.Location = new System.Drawing.Point(0, 0);
            this.domibeP.Name = "domibeP";
            this.domibeP.Size = new System.Drawing.Size(784, 561);
            this.domibeP.TabIndex = 0;
            this.domibeP.Visible = false;
            this.domibeP.Paint += new System.Windows.Forms.PaintEventHandler(this.domibeP_Paint);
            // 
            // blackP
            // 
            this.blackP.Controls.Add(this.NextS2);
            this.blackP.Controls.Add(this.TextS1);
            this.blackP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blackP.Location = new System.Drawing.Point(0, 0);
            this.blackP.Name = "blackP";
            this.blackP.Size = new System.Drawing.Size(784, 561);
            this.blackP.TabIndex = 1;
            this.blackP.Visible = false;
            this.blackP.Paint += new System.Windows.Forms.PaintEventHandler(this.blackP_Paint);
            // 
            // TextS1
            // 
            this.TextS1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextS1.Location = new System.Drawing.Point(29, 362);
            this.TextS1.Multiline = true;
            this.TextS1.Name = "TextS1";
            this.TextS1.ReadOnly = true;
            this.TextS1.Size = new System.Drawing.Size(710, 175);
            this.TextS1.TabIndex = 1;
            // 
            // NextS2
            // 
            this.NextS2.Location = new System.Drawing.Point(697, 526);
            this.NextS2.Name = "NextS2";
            this.NextS2.Size = new System.Drawing.Size(75, 23);
            this.NextS2.TabIndex = 0;
            this.NextS2.Text = "▶";
            this.NextS2.UseVisualStyleBackColor = true;
            // 
            // NextS1
            // 
            this.NextS1.Location = new System.Drawing.Point(697, 526);
            this.NextS1.Name = "NextS1";
            this.NextS1.Size = new System.Drawing.Size(75, 23);
            this.NextS1.TabIndex = 0;
            this.NextS1.Text = "▶";
            this.NextS1.UseVisualStyleBackColor = true;
            this.NextS1.Click += new System.EventHandler(this.NextS1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Scene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.domibeP);
            this.DoubleBuffered = true;
            this.Name = "Scene";
            this.Text = "Scene";
            this.Load += new System.EventHandler(this.Scene_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Scene_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Scene_MouseClick);
            this.domibeP.ResumeLayout(false);
            this.blackP.ResumeLayout(false);
            this.blackP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel domibeP;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button NextS1;
        private System.Windows.Forms.Panel blackP;
        private System.Windows.Forms.Button NextS2;
        private System.Windows.Forms.TextBox TextS1;
        private System.Windows.Forms.Timer timer2;
    }
}
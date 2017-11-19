namespace Lab4
{
    partial class SharpGLForm
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
            this.openGLControl = new SharpGL.OpenGLControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.doiTuongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hinhLapPhuongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mat1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mat2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mat3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mat4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mat5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mat6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hinhCauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hinhTruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matTrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xungQuanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hinhNonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xungQuanhToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openGLControl
            // 
            this.openGLControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openGLControl.DrawFPS = true;
            this.openGLControl.Location = new System.Drawing.Point(0, 24);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.FBO;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl.Size = new System.Drawing.Size(884, 637);
            this.openGLControl.TabIndex = 0;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl.Resized += new System.EventHandler(this.openGLControl_Resized);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doiTuongToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // doiTuongToolStripMenuItem
            // 
            this.doiTuongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinhLapPhuongToolStripMenuItem,
            this.hinhCauToolStripMenuItem,
            this.hinhTruToolStripMenuItem,
            this.hinhNonToolStripMenuItem});
            this.doiTuongToolStripMenuItem.Name = "doiTuongToolStripMenuItem";
            this.doiTuongToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.doiTuongToolStripMenuItem.Text = "Doi tuong";
            // 
            // hinhLapPhuongToolStripMenuItem
            // 
            this.hinhLapPhuongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mat1ToolStripMenuItem,
            this.mat2ToolStripMenuItem,
            this.mat3ToolStripMenuItem,
            this.mat4ToolStripMenuItem,
            this.mat5ToolStripMenuItem,
            this.mat6ToolStripMenuItem});
            this.hinhLapPhuongToolStripMenuItem.Name = "hinhLapPhuongToolStripMenuItem";
            this.hinhLapPhuongToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.hinhLapPhuongToolStripMenuItem.Text = "Hinh lap phuong";
            // 
            // mat1ToolStripMenuItem
            // 
            this.mat1ToolStripMenuItem.Name = "mat1ToolStripMenuItem";
            this.mat1ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.mat1ToolStripMenuItem.Text = "Mat 1";
            this.mat1ToolStripMenuItem.Click += new System.EventHandler(this.mat1ToolStripMenuItem_Click);
            // 
            // mat2ToolStripMenuItem
            // 
            this.mat2ToolStripMenuItem.Name = "mat2ToolStripMenuItem";
            this.mat2ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.mat2ToolStripMenuItem.Text = "Mat 2";
            this.mat2ToolStripMenuItem.Click += new System.EventHandler(this.mat2ToolStripMenuItem_Click);
            // 
            // mat3ToolStripMenuItem
            // 
            this.mat3ToolStripMenuItem.Name = "mat3ToolStripMenuItem";
            this.mat3ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.mat3ToolStripMenuItem.Text = "Mat 3";
            this.mat3ToolStripMenuItem.Click += new System.EventHandler(this.mat3ToolStripMenuItem_Click);
            // 
            // mat4ToolStripMenuItem
            // 
            this.mat4ToolStripMenuItem.Name = "mat4ToolStripMenuItem";
            this.mat4ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.mat4ToolStripMenuItem.Text = "Mat 4";
            this.mat4ToolStripMenuItem.Click += new System.EventHandler(this.mat4ToolStripMenuItem_Click);
            // 
            // mat5ToolStripMenuItem
            // 
            this.mat5ToolStripMenuItem.Name = "mat5ToolStripMenuItem";
            this.mat5ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.mat5ToolStripMenuItem.Text = "Mat 5";
            this.mat5ToolStripMenuItem.Click += new System.EventHandler(this.mat5ToolStripMenuItem_Click);
            // 
            // mat6ToolStripMenuItem
            // 
            this.mat6ToolStripMenuItem.Name = "mat6ToolStripMenuItem";
            this.mat6ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.mat6ToolStripMenuItem.Text = "Mat 6";
            this.mat6ToolStripMenuItem.Click += new System.EventHandler(this.mat6ToolStripMenuItem_Click);
            // 
            // hinhCauToolStripMenuItem
            // 
            this.hinhCauToolStripMenuItem.Name = "hinhCauToolStripMenuItem";
            this.hinhCauToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.hinhCauToolStripMenuItem.Text = "Hinh cau";
            this.hinhCauToolStripMenuItem.Click += new System.EventHandler(this.hinhCauToolStripMenuItem_Click);
            // 
            // hinhTruToolStripMenuItem
            // 
            this.hinhTruToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matTrenToolStripMenuItem,
            this.matDayToolStripMenuItem,
            this.xungQuanhToolStripMenuItem});
            this.hinhTruToolStripMenuItem.Name = "hinhTruToolStripMenuItem";
            this.hinhTruToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.hinhTruToolStripMenuItem.Text = "Hinh tru";
            // 
            // matTrenToolStripMenuItem
            // 
            this.matTrenToolStripMenuItem.Name = "matTrenToolStripMenuItem";
            this.matTrenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.matTrenToolStripMenuItem.Text = "Mat tren";
            this.matTrenToolStripMenuItem.Click += new System.EventHandler(this.matTrenToolStripMenuItem_Click);
            // 
            // matDayToolStripMenuItem
            // 
            this.matDayToolStripMenuItem.Name = "matDayToolStripMenuItem";
            this.matDayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.matDayToolStripMenuItem.Text = "Mat day";
            this.matDayToolStripMenuItem.Click += new System.EventHandler(this.matDayToolStripMenuItem_Click);
            // 
            // xungQuanhToolStripMenuItem
            // 
            this.xungQuanhToolStripMenuItem.Name = "xungQuanhToolStripMenuItem";
            this.xungQuanhToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xungQuanhToolStripMenuItem.Text = "Xung quanh";
            this.xungQuanhToolStripMenuItem.Click += new System.EventHandler(this.xungQuanhToolStripMenuItem_Click);
            // 
            // hinhNonToolStripMenuItem
            // 
            this.hinhNonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xungQuanhToolStripMenuItem1,
            this.dayToolStripMenuItem});
            this.hinhNonToolStripMenuItem.Name = "hinhNonToolStripMenuItem";
            this.hinhNonToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.hinhNonToolStripMenuItem.Text = "Hinh non";
            // 
            // xungQuanhToolStripMenuItem1
            // 
            this.xungQuanhToolStripMenuItem1.Name = "xungQuanhToolStripMenuItem1";
            this.xungQuanhToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.xungQuanhToolStripMenuItem1.Text = "Xung quanh";
            this.xungQuanhToolStripMenuItem1.Click += new System.EventHandler(this.xungQuanhToolStripMenuItem1_Click);
            // 
            // dayToolStripMenuItem
            // 
            this.dayToolStripMenuItem.Name = "dayToolStripMenuItem";
            this.dayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dayToolStripMenuItem.Text = "Day";
            this.dayToolStripMenuItem.Click += new System.EventHandler(this.dayToolStripMenuItem_Click);
            // 
            // SharpGLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.openGLControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SharpGLForm";
            this.Text = "SharpGL Form";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doiTuongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hinhLapPhuongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mat1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mat2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mat3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mat4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mat5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mat6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hinhCauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hinhTruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matTrenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matDayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xungQuanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hinhNonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xungQuanhToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dayToolStripMenuItem;
    }
}


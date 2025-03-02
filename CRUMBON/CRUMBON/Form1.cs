

using System.Runtime.Versioning;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Threading;

namespace CRUMBON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static void TaskBox(Control owner, bool aC, string title, string heading, string mainBody, bool okButton, string okButtonText, TaskDialogIcon icon)
        {
            if (okButton == true)
            {
                TaskDialogButton okayButton = new(okButtonText);

                TaskDialogPage page = new()
                {
                    Caption = title,
                    SizeToContent = true,
                    Text = mainBody,
                    AllowCancel = aC,
                    Heading = heading,
                    Icon = icon,
                    Buttons = new TaskDialogButtonCollection() { okayButton }
                };

                TaskDialog.ShowDialog(owner, page);

            }
            else
            {
                TaskDialogPage page = new()
                {
                    Caption = title,
                    SizeToContent = true,
                    Text = mainBody,
                    AllowCancel = aC,
                    Heading = heading,
                    Icon = icon
                };

                TaskDialog.ShowDialog(owner, page);

            }
        }
        public class Win32Window : IWin32Window
        {
            readonly IntPtr handle;
            public Win32Window(IWin32Window window)
            {
                handle = window.Handle;
            }
            IntPtr IWin32Window.Handle => handle;
        }
        /// <summary>
        /// Example for opening a web page for windows forms
        /// </summary>
        /// <param name="owner">control or form</param>
        public static void OpenLink(Control owner)
        {
            TaskDialogCommandLinkButton continueButton = new("&Download it now", "You will need to run the download installer");

            TaskDialogPage page = new()
            {
                Caption = "CRUMBON",
                Heading = "You must install .NET Desktop Runtime to run this application.",
                AllowCancel = false,
                Buttons = { continueButton, },
                Icon = new TaskDialogIcon(Properties.Resources.CRUMBON),
                SizeToContent = true,
                EnableLinks = true,
                Expander = new TaskDialogExpander()
                {
                    CollapsedButtonText = "See details",
                    ExpandedButtonText = "Hide details",
                    Text = "Architecture: x64\nApp host version: 9.0.2\n\nLearn more:\n<a href=\"https://omg-hi-if-you-found-this-easter-egg-you-can-call-yourself-mclenin.com\">https://aka.ms/dotnet/app-launch-filed</a>\n\nDownload link:\n<a href=\"https://omg-hi-if-you-found-this-easter-egg-you-can-call-yourself-mclenin.com\">https://aka.ms/dotnet-core-applaunch?missing_runtime=true&arch=x64&rid=win</a>\n<a href=\"https://omg-hi-if-you-found-this-easter-egg-you-can-call-yourself-mclenin.com\">x64&os=win10&apphost_version=9.0.2&gui=true</a>"
                },
            };

            TaskDialog.ShowDialog(owner, page);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //TaskBox(this, false, "hello","heee","hg",true,"e",TaskDialogIcon.Error);
            OpenLink(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenLink(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult one = MessageBox.Show("Are you sure you want to run me?", "CRUMBON", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (one == DialogResult.Yes)
            {
                DialogResult ono = MessageBox.Show("Are you really really really sure???", "CRUMBON", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ono == DialogResult.Yes)
                {
                    this.Close();
                    Thread th = new Thread(opennf);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else { this.Close(); }
            }
            else { this.Close(); }

        }

        private void opennf(object obj)
        {
            Application.Run(new Form2());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            TaskBox(this, false, "OMG HI", "You found an easter egg!", "you win like a million dollars or something.", true, "YIPPE KI YAY!", TaskDialogIcon.ShieldSuccessGreenBar);
        }
    }
}

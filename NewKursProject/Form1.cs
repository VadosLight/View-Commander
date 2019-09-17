using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace NewKursProject
{

    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();


            webBrowser1.Url = new Uri(Environment.CurrentDirectory);
            webBrowser2.Url = new Uri(Environment.CurrentDirectory);


            var s1 = webBrowser1.Url.ToString();
            s1 = s1.Remove(0, 8);

            var s2 = webBrowser2.Url.ToString();
            s2 = s2.Remove(0, 8);

            txtPath1.Text = s1;
            txtPath2.Text = s2;

            btnGo.Enabled = false;

            var t = new ToolTip();
            t.SetToolTip(btnBack, "Предыдущая папка.");
            t.SetToolTip(btnForward, "Следующая папка.");
            t.SetToolTip(btnPrevFolder, "Вверх до корневой папки.");
            t.SetToolTip(btnOpen, "Указать путь 1.");


            t.SetToolTip(btnBack2, "Предыдущая папка.");
            t.SetToolTip(btnForward2, "Следующая папка.");
            t.SetToolTip(btnPrevFolder2, "Вверх до корневой папки.");
            t.SetToolTip(btnOpen2, "Указать путь 2.");

            t.SetToolTip(btnRefresh, "Обновить содержимое окон.");
            t.SetToolTip(btnCMD, "Запустить командную строку.");
            t.SetToolTip(btnNotepad, "Открыть блокнот.");
            t.SetToolTip(btnGo, "Перейти по заданному пути.");

            t.SetToolTip(btnCalc, "Запустить калькулятор.");

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog { Description = @"Select path." })
            {
                if (fbd.ShowDialog() != DialogResult.OK) return;
                webBrowser1.Url = new Uri(fbd.SelectedPath);
                txtPath1.Text = fbd.SelectedPath;
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void btnCMD_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe");

        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            if (webBrowser2.CanGoBack)
            {
                webBrowser2.GoBack();
            }
        }

        private void btnForward2_Click(object sender, EventArgs e)
        {
            if (webBrowser2.CanGoForward)
            {
                webBrowser2.GoForward();
            }

        }

        private void btnOpen2_Click(object sender, EventArgs e)
        {
            
            using (var fbd = new FolderBrowserDialog { Description = @"Select path." })
            {
                if (fbd.ShowDialog() != DialogResult.OK) return;
                webBrowser2.Url = new Uri(fbd.SelectedPath);
                txtPath2.Text = fbd.SelectedPath;

            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Form2();
            frm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            try
            {
                var s1 = webBrowser1.Url.ToString();
                s1 = s1.Remove(0, 8);

                var s2 = webBrowser2.Url.ToString();
                s2 = s2.Remove(0, 8);

                txtPath1.Text = s1;
                txtPath2.Text = s2;
            }
            catch
            {
                // ignored
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            var s = txtInput1.Text;
            try
            {
                if (s == "Смысл жизни" || s == "54")
                {
                    MessageBox.Show(@"42!");
                }
                else
                {
                    webBrowser1.Url = new Uri(s);
                    txtInput1.Text = "";
                } 
            }
            catch
            {
                MessageBox.Show(@"The path is not correct!");
                txtInput1.Text = "";
            }
        }

        private void txtInput1_Click(object sender, EventArgs e)
        {
            txtInput1.SelectAll();
        }

        private void txtPath1_Click(object sender, EventArgs e)
        {
            txtPath1.SelectAll();
        }

        private void txtPath2_Click(object sender, EventArgs e)
        {
            txtPath2.SelectAll();
        }

        private void txtInput1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)) return;
            if (e.KeyChar != (char) Keys.Enter) return;
            if (sender.Equals(txtInput1))
            {
                btnGo.Focus();
            }
        }

        private void txtInput1_TextChanged(object sender, EventArgs e)
        {
            btnGo.Enabled = txtInput1.Text.Length != 0;
        }

        private void btnPrevFolder_Click(object sender, EventArgs e)
        {
            var str = txtPath1.Text;
            str = str.Replace("\\", "/");
            try
            {
            str = str.Substring(0, str.LastIndexOf('/'));
            }
            catch
            {
                // ignored
            }

            //Исключения-------------------
            if (str == "C:" || str == "c:")
                str = "C:/";

            if (str == "D:" || str == "d:")
                str = "D:/";

            if (str == "E:" || str == "e:")
                str = "E:/";

            if (str == "F:" || str == "f:")
                str = "F:/";

            if (str == "G:" || str == "g:")
                str = "G:/";
            //-----------------------------
            try
            {
                webBrowser1.Url = new Uri(str);
                txtPath1.Text = str;
            }
            catch
            {
                // ignored
            }
        }

        private void btnPrevFolder2_Click(object sender, EventArgs e)
        {
            var str = txtPath2.Text;
            try
            {
                str = str.Substring(0, str.LastIndexOf('/'));
            }
            catch
            {
                // ignored
            }

            //Исключения-------------------
            if (str == "C:" || str == "c:")
                str = "C:/";

            if (str == "D:" || str == "d:")
                str = "D:/";

            if (str == "E:" || str == "e:")
                str = "E:/";

            if (str == "F:" || str == "f:")
                str = "F:/";

            if (str == "G:" || str == "g:")
                str = "G:/";
            //-----------------------------
            try
            {
                webBrowser2.Url = new Uri(str);
                txtPath2.Text = str;
            }
            catch
            {
                // ignored
            }
        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;

            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");

            Controls.Clear();

            InitializeComponent();

            //string path = Directory.GetCurrentDirectory();
            webBrowser1.Url = new Uri(Environment.CurrentDirectory);
            webBrowser2.Url = new Uri(Environment.CurrentDirectory);

            btnGo.Enabled = false;

            var t = new ToolTip();
            t.SetToolTip(btnBack, "Предыдущая папка.");
            t.SetToolTip(btnForward, "Следующая папка.");
            t.SetToolTip(btnPrevFolder, "Вверх до корневой папки.");
            t.SetToolTip(btnOpen, "Указать путь 1.");


            t.SetToolTip(btnBack2, "Предыдущая папка.");
            t.SetToolTip(btnForward2, "Следующая папка.");
            t.SetToolTip(btnPrevFolder2, "Вверх до корневой папки.");
            t.SetToolTip(btnOpen2, "Указать путь 2.");

            t.SetToolTip(btnRefresh, "Обновить содержимое окон.");
            t.SetToolTip(btnCMD, "Запустить командную строку.");
            t.SetToolTip(btnNotepad, "Открыть блокнот.");
            t.SetToolTip(btnGo, "Перейти по заданному пути.");

            t.SetToolTip(btnCalc, "Запустить калькулятор.");



        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;

            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-EN");

            Controls.Clear();

            InitializeComponent();

           // string path = Directory.GetCurrentDirectory();
            webBrowser1.Url = new Uri(Environment.CurrentDirectory);
            webBrowser2.Url = new Uri(Environment.CurrentDirectory);

            btnGo.Enabled = false;

            var t = new ToolTip();
            t.SetToolTip(btnBack, "Previous folder.");
            t.SetToolTip(btnForward, "Next folder.");
            t.SetToolTip(btnPrevFolder, "Up to the root folder.");
            t.SetToolTip(btnOpen, "Specify path 1.");


            t.SetToolTip(btnBack2, "Previous folder.");
            t.SetToolTip(btnForward2, "Next folder.");
            t.SetToolTip(btnPrevFolder2, "Up to the root folder.");
            t.SetToolTip(btnOpen2, "Specify path 2.");

            t.SetToolTip(btnRefresh, "Refresh the contents of windows.");
            t.SetToolTip(btnCMD, "Run the command line.");
            t.SetToolTip(btnNotepad, "Open notepad.");
            t.SetToolTip(btnGo, "Go to the specified path.");

            t.SetToolTip(btnCalc, "Open calculator.");
        }

        private void deutchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;

            Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");

            Controls.Clear();

            InitializeComponent();

            //string path = Directory.GetCurrentDirectory();
            webBrowser1.Url = new Uri(Environment.CurrentDirectory);
            webBrowser2.Url = new Uri(Environment.CurrentDirectory);

            btnGo.Enabled = false;

            var t = new ToolTip();
            t.SetToolTip(btnBack, "Zurück Ordner.");
            t.SetToolTip(btnForward, "Next Ordner.");
            t.SetToolTip(btnPrevFolder, "Up Ordner zu verankern.");
            t.SetToolTip(btnOpen, "Geben Sie den Pfad 1.");


            t.SetToolTip(btnBack2, "Zurück Ordner.");
            t.SetToolTip(btnForward2, "Next Ordner.");
            t.SetToolTip(btnPrevFolder2, "Up Ordner zu verankern.");
            t.SetToolTip(btnOpen2, "Geben Sie den Pfad 2.");

            t.SetToolTip(btnRefresh, "Aktualisieren Sie die Inhalte der Fenster.");
            t.SetToolTip(btnCMD, "Run Befehlszeile.");
            t.SetToolTip(btnNotepad, "Öffnen Sie das Notebook ein.");
            t.SetToolTip(btnGo, "Bewegen entlang eines vorbestimmten Weges.");

            t.SetToolTip(btnCalc, "Run rechner.");
        }

    }
}

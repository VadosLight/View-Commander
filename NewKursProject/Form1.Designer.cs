namespace NewKursProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath1 = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выборЯзыкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.русскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deutchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCMD = new System.Windows.Forms.Button();
            this.btnNotepad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.txtPath2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.btnForward2 = new System.Windows.Forms.Button();
            this.btnOpen2 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnPrevFolder = new System.Windows.Forms.Button();
            this.btnPrevFolder2 = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            resources.ApplyResources(this.btnForward, "btnForward");
            this.btnForward.FlatAppearance.BorderSize = 0;
            this.btnForward.Name = "btnForward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnOpen
            // 
            resources.ApplyResources(this.btnOpen, "btnOpen");
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtPath1
            // 
            resources.ApplyResources(this.txtPath1, "txtPath1");
            this.txtPath1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPath1.Name = "txtPath1";
            this.txtPath1.ReadOnly = true;
            this.txtPath1.Click += new System.EventHandler(this.txtPath1_Click);
            // 
            // webBrowser1
            // 
            resources.ApplyResources(this.webBrowser1, "webBrowser1");
            this.webBrowser1.Name = "webBrowser1";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выборЯзыкаToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // выборЯзыкаToolStripMenuItem
            // 
            resources.ApplyResources(this.выборЯзыкаToolStripMenuItem, "выборЯзыкаToolStripMenuItem");
            this.выборЯзыкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.русскийToolStripMenuItem,
            this.englishToolStripMenuItem,
            this.deutchToolStripMenuItem});
            this.выборЯзыкаToolStripMenuItem.Name = "выборЯзыкаToolStripMenuItem";
            // 
            // русскийToolStripMenuItem
            // 
            resources.ApplyResources(this.русскийToolStripMenuItem, "русскийToolStripMenuItem");
            this.русскийToolStripMenuItem.Name = "русскийToolStripMenuItem";
            this.русскийToolStripMenuItem.Click += new System.EventHandler(this.русскийToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // deutchToolStripMenuItem
            // 
            resources.ApplyResources(this.deutchToolStripMenuItem, "deutchToolStripMenuItem");
            this.deutchToolStripMenuItem.Name = "deutchToolStripMenuItem";
            this.deutchToolStripMenuItem.Click += new System.EventHandler(this.deutchToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnCMD
            // 
            resources.ApplyResources(this.btnCMD, "btnCMD");
            this.btnCMD.Name = "btnCMD";
            this.btnCMD.UseVisualStyleBackColor = true;
            this.btnCMD.Click += new System.EventHandler(this.btnCMD_Click);
            // 
            // btnNotepad
            // 
            resources.ApplyResources(this.btnNotepad, "btnNotepad");
            this.btnNotepad.Name = "btnNotepad";
            this.btnNotepad.UseVisualStyleBackColor = true;
            this.btnNotepad.Click += new System.EventHandler(this.btnNotepad_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // webBrowser2
            // 
            resources.ApplyResources(this.webBrowser2, "webBrowser2");
            this.webBrowser2.Name = "webBrowser2";
            // 
            // txtPath2
            // 
            resources.ApplyResources(this.txtPath2, "txtPath2");
            this.txtPath2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPath2.Name = "txtPath2";
            this.txtPath2.ReadOnly = true;
            this.txtPath2.Click += new System.EventHandler(this.txtPath2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnBack2
            // 
            resources.ApplyResources(this.btnBack2, "btnBack2");
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.UseVisualStyleBackColor = true;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // btnForward2
            // 
            resources.ApplyResources(this.btnForward2, "btnForward2");
            this.btnForward2.Name = "btnForward2";
            this.btnForward2.UseVisualStyleBackColor = true;
            this.btnForward2.Click += new System.EventHandler(this.btnForward2_Click);
            // 
            // btnOpen2
            // 
            resources.ApplyResources(this.btnOpen2, "btnOpen2");
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.UseVisualStyleBackColor = true;
            this.btnOpen2.Click += new System.EventHandler(this.btnOpen2_Click);
            // 
            // btnRefresh
            // 
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtInput1
            // 
            resources.ApplyResources(this.txtInput1, "txtInput1");
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Click += new System.EventHandler(this.txtInput1_Click);
            this.txtInput1.TextChanged += new System.EventHandler(this.txtInput1_TextChanged);
            this.txtInput1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput1_KeyPress);
            // 
            // btnGo
            // 
            resources.ApplyResources(this.btnGo, "btnGo");
            this.btnGo.Name = "btnGo";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imageList1, "imageList1");
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnPrevFolder
            // 
            resources.ApplyResources(this.btnPrevFolder, "btnPrevFolder");
            this.btnPrevFolder.FlatAppearance.BorderSize = 0;
            this.btnPrevFolder.Name = "btnPrevFolder";
            this.btnPrevFolder.UseVisualStyleBackColor = true;
            this.btnPrevFolder.Click += new System.EventHandler(this.btnPrevFolder_Click);
            // 
            // btnPrevFolder2
            // 
            resources.ApplyResources(this.btnPrevFolder2, "btnPrevFolder2");
            this.btnPrevFolder2.Name = "btnPrevFolder2";
            this.btnPrevFolder2.UseVisualStyleBackColor = true;
            this.btnPrevFolder2.Click += new System.EventHandler(this.btnPrevFolder2_Click);
            // 
            // btnCalc
            // 
            resources.ApplyResources(this.btnCalc, "btnCalc");
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btnPrevFolder2);
            this.Controls.Add(this.btnPrevFolder);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnOpen2);
            this.Controls.Add(this.btnForward2);
            this.Controls.Add(this.btnBack2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPath2);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNotepad);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnCMD);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.txtPath1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.MouseEnter += new System.EventHandler(this.btnRefresh_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnCMD;
        private System.Windows.Forms.Button btnNotepad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.TextBox txtPath2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Button btnForward2;
        private System.Windows.Forms.Button btnOpen2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnPrevFolder;
        private System.Windows.Forms.Button btnPrevFolder2;
        private System.Windows.Forms.ToolStripMenuItem выборЯзыкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem русскийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deutchToolStripMenuItem;
        private System.Windows.Forms.Button btnCalc;
    }
}


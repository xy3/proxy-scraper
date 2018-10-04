namespace ProxyScraper
{
    partial class ProxyScraper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProxyScraper));
            this.BTN_Quit = new System.Windows.Forms.Button();
            this.BTN_Load = new System.Windows.Forms.Button();
            this.BTN_Gather = new System.Windows.Forms.Button();
            this.TB_Sources = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LABEL_NumberOfSources = new System.Windows.Forms.Label();
            this.TB_Proxies = new System.Windows.Forms.TextBox();
            this.LABEL_NumberOfProxies = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.BTN_Save = new System.Windows.Forms.Button();
            this.BTN_saveurls = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Quit
            // 
            this.BTN_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Quit.ForeColor = System.Drawing.Color.White;
            this.BTN_Quit.Location = new System.Drawing.Point(173, 16);
            this.BTN_Quit.Name = "BTN_Quit";
            this.BTN_Quit.Size = new System.Drawing.Size(22, 23);
            this.BTN_Quit.TabIndex = 0;
            this.BTN_Quit.Text = "X";
            this.BTN_Quit.UseVisualStyleBackColor = true;
            this.BTN_Quit.Click += new System.EventHandler(this.BTN_Quit_Click);
            // 
            // BTN_Load
            // 
            this.BTN_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Load.ForeColor = System.Drawing.Color.White;
            this.BTN_Load.Location = new System.Drawing.Point(12, 275);
            this.BTN_Load.Name = "BTN_Load";
            this.BTN_Load.Size = new System.Drawing.Size(88, 23);
            this.BTN_Load.TabIndex = 0;
            this.BTN_Load.Text = "SOURCES";
            this.BTN_Load.UseVisualStyleBackColor = true;
            this.BTN_Load.Click += new System.EventHandler(this.BTN_Load_Click);
            // 
            // BTN_Gather
            // 
            this.BTN_Gather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Gather.ForeColor = System.Drawing.Color.White;
            this.BTN_Gather.Location = new System.Drawing.Point(106, 275);
            this.BTN_Gather.Name = "BTN_Gather";
            this.BTN_Gather.Size = new System.Drawing.Size(89, 23);
            this.BTN_Gather.TabIndex = 0;
            this.BTN_Gather.Text = "SCRAPE";
            this.BTN_Gather.UseVisualStyleBackColor = true;
            this.BTN_Gather.Click += new System.EventHandler(this.BTN_Gather_Click);
            // 
            // TB_Sources
            // 
            this.TB_Sources.BackColor = System.Drawing.Color.Black;
            this.TB_Sources.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Sources.ForeColor = System.Drawing.Color.White;
            this.TB_Sources.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TB_Sources.Location = new System.Drawing.Point(12, 304);
            this.TB_Sources.Name = "TB_Sources";
            this.TB_Sources.ReadOnly = true;
            this.TB_Sources.Size = new System.Drawing.Size(183, 20);
            this.TB_Sources.TabIndex = 2;
            this.TB_Sources.WordWrap = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 27);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LABEL_NumberOfSources
            // 
            this.LABEL_NumberOfSources.AutoSize = true;
            this.LABEL_NumberOfSources.ForeColor = System.Drawing.Color.White;
            this.LABEL_NumberOfSources.Location = new System.Drawing.Point(12, 380);
            this.LABEL_NumberOfSources.Name = "LABEL_NumberOfSources";
            this.LABEL_NumberOfSources.Size = new System.Drawing.Size(13, 13);
            this.LABEL_NumberOfSources.TabIndex = 4;
            this.LABEL_NumberOfSources.Text = "0";
            // 
            // TB_Proxies
            // 
            this.TB_Proxies.BackColor = System.Drawing.Color.Black;
            this.TB_Proxies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Proxies.ForeColor = System.Drawing.Color.Magenta;
            this.TB_Proxies.Location = new System.Drawing.Point(12, 45);
            this.TB_Proxies.Multiline = true;
            this.TB_Proxies.Name = "TB_Proxies";
            this.TB_Proxies.ReadOnly = true;
            this.TB_Proxies.Size = new System.Drawing.Size(183, 224);
            this.TB_Proxies.TabIndex = 5;
            this.TB_Proxies.WordWrap = false;
            // 
            // LABEL_NumberOfProxies
            // 
            this.LABEL_NumberOfProxies.AutoSize = true;
            this.LABEL_NumberOfProxies.ForeColor = System.Drawing.Color.White;
            this.LABEL_NumberOfProxies.Location = new System.Drawing.Point(12, 345);
            this.LABEL_NumberOfProxies.Name = "LABEL_NumberOfProxies";
            this.LABEL_NumberOfProxies.Size = new System.Drawing.Size(13, 13);
            this.LABEL_NumberOfProxies.TabIndex = 4;
            this.LABEL_NumberOfProxies.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Proxies:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sources:";
            // 
            // BTN_Save
            // 
            this.BTN_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Save.ForeColor = System.Drawing.Color.White;
            this.BTN_Save.Location = new System.Drawing.Point(106, 330);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(89, 29);
            this.BTN_Save.TabIndex = 6;
            this.BTN_Save.Text = "SAVE";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // BTN_saveurls
            // 
            this.BTN_saveurls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_saveurls.ForeColor = System.Drawing.Color.White;
            this.BTN_saveurls.Location = new System.Drawing.Point(80, 365);
            this.BTN_saveurls.Name = "BTN_saveurls";
            this.BTN_saveurls.Size = new System.Drawing.Size(115, 29);
            this.BTN_saveurls.TabIndex = 7;
            this.BTN_saveurls.Text = "SAVE GOOD URLS";
            this.BTN_saveurls.UseVisualStyleBackColor = true;
            this.BTN_saveurls.Click += new System.EventHandler(this.BTN_saveurls_Click);
            // 
            // ProxyScraper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(207, 408);
            this.Controls.Add(this.BTN_saveurls);
            this.Controls.Add(this.TB_Proxies);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LABEL_NumberOfProxies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LABEL_NumberOfSources);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TB_Sources);
            this.Controls.Add(this.BTN_Load);
            this.Controls.Add(this.BTN_Quit);
            this.Controls.Add(this.BTN_Gather);
            this.Controls.Add(this.BTN_Save);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(207, 427);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(207, 395);
            this.Name = "ProxyScraper";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEPP PROXYSCRAPER";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Quit;
        private System.Windows.Forms.Button BTN_Load;
        private System.Windows.Forms.Button BTN_Gather;
        private System.Windows.Forms.TextBox TB_Sources;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LABEL_NumberOfSources;
        private System.Windows.Forms.TextBox TB_Proxies;
        private System.Windows.Forms.Label LABEL_NumberOfProxies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Button BTN_saveurls;
    }
}


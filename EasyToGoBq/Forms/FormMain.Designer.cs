namespace EasyToGoBq.Forms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.PnlConnection = new System.Windows.Forms.Panel();
            this.LblConnection = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TblLayoutPanelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.PnlDashbord = new System.Windows.Forms.Panel();
            this.LblDashbord = new System.Windows.Forms.Label();
            this.PcbDashbord = new System.Windows.Forms.PictureBox();
            this.PnlReport = new System.Windows.Forms.Panel();
            this.LblReport = new System.Windows.Forms.Label();
            this.PcbReport = new System.Windows.Forms.PictureBox();
            this.PnlRecharge = new System.Windows.Forms.Panel();
            this.LblRecharge = new System.Windows.Forms.Label();
            this.PcbRecharge = new System.Windows.Forms.PictureBox();
<<<<<<< HEAD
            this.PnlSettings = new System.Windows.Forms.Panel();
            this.LblSettings = new System.Windows.Forms.Label();
            this.PcbSettings = new System.Windows.Forms.PictureBox();
=======
>>>>>>> ab255756f7385a16265ac778b9199dfb1ae78ece
            this.PnlMain = new System.Windows.Forms.Panel();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.LblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.PnlSettings = new System.Windows.Forms.Panel();
            this.LblSettings = new System.Windows.Forms.Label();
            this.PcbSettings = new System.Windows.Forms.PictureBox();
            this.PnlHeader.SuspendLayout();
            this.PnlConnection.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TblLayoutPanelMenu.SuspendLayout();
            this.PnlDashbord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbDashbord)).BeginInit();
            this.PnlReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbReport)).BeginInit();
            this.PnlRecharge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbRecharge)).BeginInit();
<<<<<<< HEAD
=======
            this.StatusStrip.SuspendLayout();
>>>>>>> ab255756f7385a16265ac778b9199dfb1ae78ece
            this.PnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.White;
            this.PnlHeader.Controls.Add(this.PnlConnection);
            this.PnlHeader.Controls.Add(this.panel1);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(984, 47);
            this.PnlHeader.TabIndex = 0;
            // 
            // PnlConnection
            // 
            this.PnlConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlConnection.BackColor = System.Drawing.Color.White;
            this.PnlConnection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlConnection.Controls.Add(this.LblConnection);
            this.PnlConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlConnection.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlConnection.Location = new System.Drawing.Point(852, 19);
            this.PnlConnection.Name = "PnlConnection";
            this.PnlConnection.Size = new System.Drawing.Size(120, 22);
            this.PnlConnection.TabIndex = 3;
            this.PnlConnection.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // LblConnection
            // 
            this.LblConnection.AutoSize = true;
            this.LblConnection.BackColor = System.Drawing.Color.Transparent;
            this.LblConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblConnection.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.LblConnection.Location = new System.Drawing.Point(13, 2);
            this.LblConnection.Name = "LblConnection";
            this.LblConnection.Size = new System.Drawing.Size(72, 16);
            this.LblConnection.TabIndex = 0;
            this.LblConnection.Text = "Connexion";
            this.LblConnection.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TblLayoutPanelMenu);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 47);
            this.panel1.TabIndex = 0;
            // 
            // TblLayoutPanelMenu
            // 
            this.TblLayoutPanelMenu.ColumnCount = 4;
            this.TblLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.64267F));
            this.TblLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.35733F));
            this.TblLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
<<<<<<< HEAD
            this.TblLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
=======
            this.TblLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
>>>>>>> ab255756f7385a16265ac778b9199dfb1ae78ece
            this.TblLayoutPanelMenu.Controls.Add(this.PnlDashbord, 0, 0);
            this.TblLayoutPanelMenu.Controls.Add(this.PnlReport, 1, 0);
            this.TblLayoutPanelMenu.Controls.Add(this.PnlRecharge, 2, 0);
            this.TblLayoutPanelMenu.Controls.Add(this.PnlSettings, 3, 0);
            this.TblLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblLayoutPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.TblLayoutPanelMenu.Name = "TblLayoutPanelMenu";
            this.TblLayoutPanelMenu.RowCount = 1;
            this.TblLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblLayoutPanelMenu.Size = new System.Drawing.Size(786, 47);
            this.TblLayoutPanelMenu.TabIndex = 0;
            // 
            // PnlDashbord
            // 
            this.PnlDashbord.Controls.Add(this.LblDashbord);
            this.PnlDashbord.Controls.Add(this.PcbDashbord);
            this.PnlDashbord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDashbord.Location = new System.Drawing.Point(3, 3);
            this.PnlDashbord.Name = "PnlDashbord";
<<<<<<< HEAD
            this.PnlDashbord.Size = new System.Drawing.Size(202, 41);
=======
            this.PnlDashbord.Size = new System.Drawing.Size(203, 41);
>>>>>>> ab255756f7385a16265ac778b9199dfb1ae78ece
            this.PnlDashbord.TabIndex = 0;
            this.PnlDashbord.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // LblDashbord
            // 
            this.LblDashbord.AutoSize = true;
            this.LblDashbord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblDashbord.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDashbord.ForeColor = System.Drawing.Color.Black;
            this.LblDashbord.Location = new System.Drawing.Point(54, 10);
            this.LblDashbord.Name = "LblDashbord";
            this.LblDashbord.Size = new System.Drawing.Size(129, 20);
            this.LblDashbord.TabIndex = 2;
            this.LblDashbord.Text = "Tableau de bord";
            this.LblDashbord.Click += new System.EventHandler(this.NavigationControles_Click);
            this.LblDashbord.MouseEnter += new System.EventHandler(this.Menu_MouseEnter);
            this.LblDashbord.MouseLeave += new System.EventHandler(this.Menu_MouseLeave);
            // 
            // PcbDashbord
            // 
            this.PcbDashbord.Image = global::EasyToGoBq.Properties.Resources.menu;
            this.PcbDashbord.Location = new System.Drawing.Point(9, 3);
            this.PcbDashbord.Name = "PcbDashbord";
            this.PcbDashbord.Size = new System.Drawing.Size(35, 35);
            this.PcbDashbord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbDashbord.TabIndex = 0;
            this.PcbDashbord.TabStop = false;
            this.PcbDashbord.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // PnlReport
            // 
            this.PnlReport.Controls.Add(this.LblReport);
            this.PnlReport.Controls.Add(this.PcbReport);
            this.PnlReport.Dock = System.Windows.Forms.DockStyle.Fill;
<<<<<<< HEAD
            this.PnlReport.Location = new System.Drawing.Point(211, 3);
=======
            this.PnlReport.Location = new System.Drawing.Point(212, 3);
>>>>>>> ab255756f7385a16265ac778b9199dfb1ae78ece
            this.PnlReport.Name = "PnlReport";
            this.PnlReport.Size = new System.Drawing.Size(197, 41);
            this.PnlReport.TabIndex = 1;
            this.PnlReport.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // LblReport
            // 
            this.LblReport.AutoSize = true;
            this.LblReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblReport.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReport.ForeColor = System.Drawing.Color.Black;
            this.LblReport.Location = new System.Drawing.Point(57, 10);
            this.LblReport.Name = "LblReport";
            this.LblReport.Size = new System.Drawing.Size(86, 20);
            this.LblReport.TabIndex = 2;
            this.LblReport.Text = "Document";
            this.LblReport.Click += new System.EventHandler(this.NavigationControles_Click);
            this.LblReport.MouseEnter += new System.EventHandler(this.Menu_MouseEnter);
            this.LblReport.MouseLeave += new System.EventHandler(this.Menu_MouseLeave);
            // 
            // PcbReport
            // 
            this.PcbReport.Image = global::EasyToGoBq.Properties.Resources.icons8_Print_48px;
            this.PcbReport.Location = new System.Drawing.Point(10, 3);
            this.PcbReport.Name = "PcbReport";
            this.PcbReport.Size = new System.Drawing.Size(35, 35);
            this.PcbReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbReport.TabIndex = 1;
            this.PcbReport.TabStop = false;
            this.PcbReport.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // PnlRecharge
            // 
            this.PnlRecharge.Controls.Add(this.LblRecharge);
            this.PnlRecharge.Controls.Add(this.PcbRecharge);
            this.PnlRecharge.Dock = System.Windows.Forms.DockStyle.Fill;
<<<<<<< HEAD
            this.PnlRecharge.Location = new System.Drawing.Point(414, 3);
=======
            this.PnlRecharge.Location = new System.Drawing.Point(415, 3);
>>>>>>> ab255756f7385a16265ac778b9199dfb1ae78ece
            this.PnlRecharge.Name = "PnlRecharge";
            this.PnlRecharge.Size = new System.Drawing.Size(190, 41);
            this.PnlRecharge.TabIndex = 2;
            this.PnlRecharge.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // LblRecharge
            // 
            this.LblRecharge.AutoSize = true;
            this.LblRecharge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblRecharge.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecharge.ForeColor = System.Drawing.Color.Black;
            this.LblRecharge.Location = new System.Drawing.Point(59, 10);
            this.LblRecharge.Name = "LblRecharge";
            this.LblRecharge.Size = new System.Drawing.Size(82, 20);
            this.LblRecharge.TabIndex = 2;
            this.LblRecharge.Text = "Recharge";
            this.LblRecharge.Click += new System.EventHandler(this.NavigationControles_Click);
            this.LblRecharge.MouseEnter += new System.EventHandler(this.Menu_MouseEnter);
            this.LblRecharge.MouseLeave += new System.EventHandler(this.Menu_MouseLeave);
            // 
            // PcbRecharge
            // 
            this.PcbRecharge.Image = global::EasyToGoBq.Properties.Resources.settings;
            this.PcbRecharge.Location = new System.Drawing.Point(10, 3);
            this.PcbRecharge.Name = "PcbRecharge";
            this.PcbRecharge.Size = new System.Drawing.Size(35, 35);
            this.PcbRecharge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbRecharge.TabIndex = 1;
            this.PcbRecharge.TabStop = false;
            this.PcbRecharge.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
<<<<<<< HEAD
=======
            // PnlMain
            // 
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 47);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(984, 462);
            this.PnlMain.TabIndex = 1;
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(64)))), ((int)(((byte)(2)))));
            this.StatusStrip.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblStatus});
            this.StatusStrip.Location = new System.Drawing.Point(0, 509);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(984, 22);
            this.StatusStrip.TabIndex = 2;
            this.StatusStrip.Text = "Status";
            // 
            // LblStatus
            // 
            this.LblStatus.ForeColor = System.Drawing.Color.White;
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(74, 17);
            this.LblStatus.Text = "Bienvenue";
            // 
>>>>>>> ab255756f7385a16265ac778b9199dfb1ae78ece
            // PnlSettings
            // 
            this.PnlSettings.Controls.Add(this.LblSettings);
            this.PnlSettings.Controls.Add(this.PcbSettings);
<<<<<<< HEAD
            this.PnlSettings.Location = new System.Drawing.Point(610, 3);
=======
            this.PnlSettings.Location = new System.Drawing.Point(611, 3);
>>>>>>> ab255756f7385a16265ac778b9199dfb1ae78ece
            this.PnlSettings.Name = "PnlSettings";
            this.PnlSettings.Size = new System.Drawing.Size(172, 41);
            this.PnlSettings.TabIndex = 3;
            this.PnlSettings.Click += new System.EventHandler(this.NavigationControles_Click);
            this.PnlSettings.MouseEnter += new System.EventHandler(this.Menu_MouseEnter);
            this.PnlSettings.MouseLeave += new System.EventHandler(this.Menu_MouseLeave);
            // 
            // LblSettings
            // 
            this.LblSettings.AutoSize = true;
            this.LblSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSettings.ForeColor = System.Drawing.Color.Black;
            this.LblSettings.Location = new System.Drawing.Point(68, 10);
            this.LblSettings.Name = "LblSettings";
            this.LblSettings.Size = new System.Drawing.Size(86, 20);
            this.LblSettings.TabIndex = 4;
            this.LblSettings.Text = "Paramètre";
            this.LblSettings.Click += new System.EventHandler(this.NavigationControles_Click);
            this.LblSettings.MouseEnter += new System.EventHandler(this.Menu_MouseEnter);
            this.LblSettings.MouseLeave += new System.EventHandler(this.Menu_MouseLeave);
            // 
            // PcbSettings
            // 
            this.PcbSettings.Image = global::EasyToGoBq.Properties.Resources.settings;
            this.PcbSettings.Location = new System.Drawing.Point(13, 3);
            this.PcbSettings.Name = "PcbSettings";
            this.PcbSettings.Size = new System.Drawing.Size(35, 35);
            this.PcbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbSettings.TabIndex = 3;
            this.PcbSettings.TabStop = false;
            this.PcbSettings.Click += new System.EventHandler(this.NavigationControles_Click);
            this.PcbSettings.MouseEnter += new System.EventHandler(this.Menu_MouseEnter);
            this.PcbSettings.MouseLeave += new System.EventHandler(this.Menu_MouseLeave);
<<<<<<< HEAD
            // 
            // PnlMain
            // 
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 47);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(984, 462);
            this.PnlMain.TabIndex = 1;
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(64)))), ((int)(((byte)(2)))));
            this.StatusStrip.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblStatus});
            this.StatusStrip.Location = new System.Drawing.Point(0, 509);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(984, 22);
            this.StatusStrip.TabIndex = 2;
            this.StatusStrip.Text = "Status";
            // 
            // LblStatus
            // 
            this.LblStatus.ForeColor = System.Drawing.Color.White;
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(74, 17);
            this.LblStatus.Text = "Bienvenue";
=======
>>>>>>> ab255756f7385a16265ac778b9199dfb1ae78ece
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 531);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.PnlHeader);
            this.Controls.Add(this.StatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 550);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy To Go Banque";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.PnlHeader.ResumeLayout(false);
            this.PnlConnection.ResumeLayout(false);
            this.PnlConnection.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.TblLayoutPanelMenu.ResumeLayout(false);
            this.PnlDashbord.ResumeLayout(false);
            this.PnlDashbord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbDashbord)).EndInit();
            this.PnlReport.ResumeLayout(false);
            this.PnlReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbReport)).EndInit();
            this.PnlRecharge.ResumeLayout(false);
            this.PnlRecharge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbRecharge)).EndInit();
<<<<<<< HEAD
=======
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
>>>>>>> ab255756f7385a16265ac778b9199dfb1ae78ece
            this.PnlSettings.ResumeLayout(false);
            this.PnlSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel LblStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel TblLayoutPanelMenu;
        private System.Windows.Forms.Panel PnlDashbord;
        private System.Windows.Forms.Panel PnlReport;
        private System.Windows.Forms.Panel PnlRecharge;
        private System.Windows.Forms.PictureBox PcbDashbord;
        private System.Windows.Forms.PictureBox PcbReport;
        private System.Windows.Forms.PictureBox PcbRecharge;
        private System.Windows.Forms.Label LblDashbord;
        private System.Windows.Forms.Label LblReport;
        private System.Windows.Forms.Label LblRecharge;
        private System.Windows.Forms.Panel PnlConnection;
        private System.Windows.Forms.Label LblConnection;
        private System.Windows.Forms.Panel PnlSettings;
        private System.Windows.Forms.Label LblSettings;
        private System.Windows.Forms.PictureBox PcbSettings;
    }
}
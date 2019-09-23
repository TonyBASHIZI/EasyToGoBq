﻿namespace EasyToGoBq.Forms
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
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlDashbord = new System.Windows.Forms.Panel();
            this.PnlReport = new System.Windows.Forms.Panel();
            this.PnlSettings = new System.Windows.Forms.Panel();
            this.PcbDashbord = new System.Windows.Forms.PictureBox();
            this.PcbReport = new System.Windows.Forms.PictureBox();
            this.PcbSettings = new System.Windows.Forms.PictureBox();
            this.LblDashbord = new System.Windows.Forms.Label();
            this.LblReport = new System.Windows.Forms.Label();
            this.LblSettings = new System.Windows.Forms.Label();
            this.PnlConnection = new System.Windows.Forms.Panel();
            this.LblConnection = new System.Windows.Forms.Label();
            this.PnlHeader.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PnlDashbord.SuspendLayout();
            this.PnlReport.SuspendLayout();
            this.PnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbDashbord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbSettings)).BeginInit();
            this.PnlConnection.SuspendLayout();
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
            this.toolStripStatusLabel1});
            this.StatusStrip.Location = new System.Drawing.Point(0, 509);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(984, 22);
            this.StatusStrip.TabIndex = 2;
            this.StatusStrip.Text = "Status";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(141, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.Controls.Add(this.PnlDashbord, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PnlReport, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PnlSettings, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(648, 47);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 47);
            this.panel1.TabIndex = 0;
            // 
            // PnlDashbord
            // 
            this.PnlDashbord.Controls.Add(this.LblDashbord);
            this.PnlDashbord.Controls.Add(this.PcbDashbord);
            this.PnlDashbord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDashbord.Location = new System.Drawing.Point(3, 3);
            this.PnlDashbord.Name = "PnlDashbord";
            this.PnlDashbord.Size = new System.Drawing.Size(208, 41);
            this.PnlDashbord.TabIndex = 0;
            this.PnlDashbord.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // PnlReport
            // 
            this.PnlReport.Controls.Add(this.LblReport);
            this.PnlReport.Controls.Add(this.PcbReport);
            this.PnlReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlReport.Location = new System.Drawing.Point(217, 3);
            this.PnlReport.Name = "PnlReport";
            this.PnlReport.Size = new System.Drawing.Size(208, 41);
            this.PnlReport.TabIndex = 1;
            this.PnlReport.Click += new System.EventHandler(this.NavigationControles_Click);
            // 
            // PnlSettings
            // 
            this.PnlSettings.Controls.Add(this.LblSettings);
            this.PnlSettings.Controls.Add(this.PcbSettings);
            this.PnlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSettings.Location = new System.Drawing.Point(431, 3);
            this.PnlSettings.Name = "PnlSettings";
            this.PnlSettings.Size = new System.Drawing.Size(214, 41);
            this.PnlSettings.TabIndex = 2;
            this.PnlSettings.Click += new System.EventHandler(this.NavigationControles_Click);
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
            // PcbSettings
            // 
            this.PcbSettings.Image = global::EasyToGoBq.Properties.Resources.settings;
            this.PcbSettings.Location = new System.Drawing.Point(10, 3);
            this.PcbSettings.Name = "PcbSettings";
            this.PcbSettings.Size = new System.Drawing.Size(35, 35);
            this.PcbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbSettings.TabIndex = 1;
            this.PcbSettings.TabStop = false;
            this.PcbSettings.Click += new System.EventHandler(this.NavigationControles_Click);
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
            // LblSettings
            // 
            this.LblSettings.AutoSize = true;
            this.LblSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSettings.ForeColor = System.Drawing.Color.Black;
            this.LblSettings.Location = new System.Drawing.Point(59, 10);
            this.LblSettings.Name = "LblSettings";
            this.LblSettings.Size = new System.Drawing.Size(86, 20);
            this.LblSettings.TabIndex = 2;
            this.LblSettings.Text = "Paramètre";
            this.LblSettings.Click += new System.EventHandler(this.NavigationControles_Click);
            this.LblSettings.MouseEnter += new System.EventHandler(this.Menu_MouseEnter);
            this.LblSettings.MouseLeave += new System.EventHandler(this.Menu_MouseLeave);
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
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 531);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.PnlHeader);
            this.Controls.Add(this.StatusStrip);
            this.MinimumSize = new System.Drawing.Size(1000, 550);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy To Go Banque";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.PnlHeader.ResumeLayout(false);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PnlDashbord.ResumeLayout(false);
            this.PnlDashbord.PerformLayout();
            this.PnlReport.ResumeLayout(false);
            this.PnlReport.PerformLayout();
            this.PnlSettings.ResumeLayout(false);
            this.PnlSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbDashbord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbSettings)).EndInit();
            this.PnlConnection.ResumeLayout(false);
            this.PnlConnection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PnlDashbord;
        private System.Windows.Forms.Panel PnlReport;
        private System.Windows.Forms.Panel PnlSettings;
        private System.Windows.Forms.PictureBox PcbDashbord;
        private System.Windows.Forms.PictureBox PcbReport;
        private System.Windows.Forms.PictureBox PcbSettings;
        private System.Windows.Forms.Label LblDashbord;
        private System.Windows.Forms.Label LblReport;
        private System.Windows.Forms.Label LblSettings;
        private System.Windows.Forms.Panel PnlConnection;
        private System.Windows.Forms.Label LblConnection;
    }
}
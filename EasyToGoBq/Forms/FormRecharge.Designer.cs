namespace EasyToGoBq.Forms
{
    partial class FormRecharge
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PnlRecharge = new System.Windows.Forms.Panel();
            this.LblRecharge = new System.Windows.Forms.Label();
            this.TxtSolde = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTelephone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtAdresse = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtPrenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPostnom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMatricule = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PnlValider = new System.Windows.Forms.Panel();
            this.LblValider = new System.Windows.Forms.Label();
            this.TxtRecherche = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.PnlRecharge.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.PnlValider.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PnlRecharge);
            this.groupBox1.Controls.Add(this.TxtSolde);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtTelephone);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtAdresse);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtPrenom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtPostnom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtNom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtMatricule);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recharge de l\'agent";
            // 
            // PnlRecharge
            // 
            this.PnlRecharge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlRecharge.BackColor = System.Drawing.Color.White;
            this.PnlRecharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlRecharge.Controls.Add(this.LblRecharge);
            this.PnlRecharge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlRecharge.Location = new System.Drawing.Point(417, 122);
            this.PnlRecharge.Name = "PnlRecharge";
            this.PnlRecharge.Size = new System.Drawing.Size(200, 35);
            this.PnlRecharge.TabIndex = 18;
            this.PnlRecharge.Click += new System.EventHandler(this.RechargeControles_Click);
            // 
            // LblRecharge
            // 
            this.LblRecharge.AutoSize = true;
            this.LblRecharge.BackColor = System.Drawing.Color.Transparent;
            this.LblRecharge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblRecharge.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecharge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.LblRecharge.Location = new System.Drawing.Point(55, 7);
            this.LblRecharge.Name = "LblRecharge";
            this.LblRecharge.Size = new System.Drawing.Size(86, 18);
            this.LblRecharge.TabIndex = 0;
            this.LblRecharge.Text = "Recharger";
            this.LblRecharge.Click += new System.EventHandler(this.RechargeControles_Click);
            // 
            // TxtSolde
            // 
            this.TxtSolde.Location = new System.Drawing.Point(470, 85);
            this.TxtSolde.Name = "TxtSolde";
            this.TxtSolde.Size = new System.Drawing.Size(164, 22);
            this.TxtSolde.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Solde : ";
            // 
            // TxtTelephone
            // 
            this.TxtTelephone.Location = new System.Drawing.Point(470, 57);
            this.TxtTelephone.Name = "TxtTelephone";
            this.TxtTelephone.ReadOnly = true;
            this.TxtTelephone.Size = new System.Drawing.Size(164, 22);
            this.TxtTelephone.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Téléphone : ";
            // 
            // TxtAdresse
            // 
            this.TxtAdresse.Location = new System.Drawing.Point(470, 29);
            this.TxtAdresse.Name = "TxtAdresse";
            this.TxtAdresse.ReadOnly = true;
            this.TxtAdresse.Size = new System.Drawing.Size(164, 22);
            this.TxtAdresse.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Adresse : ";
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.Location = new System.Drawing.Point(163, 122);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.ReadOnly = true;
            this.TxtPrenom.Size = new System.Drawing.Size(164, 22);
            this.TxtPrenom.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prenom : ";
            // 
            // TxtPostnom
            // 
            this.TxtPostnom.Location = new System.Drawing.Point(163, 91);
            this.TxtPostnom.Name = "TxtPostnom";
            this.TxtPostnom.ReadOnly = true;
            this.TxtPostnom.Size = new System.Drawing.Size(164, 22);
            this.TxtPostnom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Postnom : ";
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(163, 60);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.ReadOnly = true;
            this.TxtNom.Size = new System.Drawing.Size(164, 22);
            this.TxtNom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom : ";
            // 
            // TxtMatricule
            // 
            this.TxtMatricule.Location = new System.Drawing.Point(163, 29);
            this.TxtMatricule.Name = "TxtMatricule";
            this.TxtMatricule.ReadOnly = true;
            this.TxtMatricule.Size = new System.Drawing.Size(164, 22);
            this.TxtMatricule.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricule : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GridView);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(744, 298);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToOrderColumns = true;
            this.GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(138)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView.Location = new System.Drawing.Point(3, 85);
            this.GridView.Name = "GridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(138)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(138)))), ((int)(((byte)(85)))));
            this.GridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(738, 210);
            this.GridView.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PnlValider);
            this.groupBox3.Controls.Add(this.TxtRecherche);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(738, 67);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // PnlValider
            // 
            this.PnlValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlValider.BackColor = System.Drawing.Color.White;
            this.PnlValider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlValider.Controls.Add(this.LblValider);
            this.PnlValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlValider.Location = new System.Drawing.Point(497, 16);
            this.PnlValider.Name = "PnlValider";
            this.PnlValider.Size = new System.Drawing.Size(117, 27);
            this.PnlValider.TabIndex = 19;
            this.PnlValider.Click += new System.EventHandler(this.RechargeControles_Click);
            // 
            // LblValider
            // 
            this.LblValider.AutoSize = true;
            this.LblValider.BackColor = System.Drawing.Color.Transparent;
            this.LblValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblValider.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.LblValider.Location = new System.Drawing.Point(25, 3);
            this.LblValider.Name = "LblValider";
            this.LblValider.Size = new System.Drawing.Size(62, 18);
            this.LblValider.TabIndex = 0;
            this.LblValider.Text = "Valider";
            this.LblValider.Click += new System.EventHandler(this.RechargeControles_Click);
            // 
            // TxtRecherche
            // 
            this.TxtRecherche.Location = new System.Drawing.Point(112, 18);
            this.TxtRecherche.Name = "TxtRecherche";
            this.TxtRecherche.Size = new System.Drawing.Size(359, 22);
            this.TxtRecherche.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Rechercher : ";
            // 
            // FormRecharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 481);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(760, 520);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(760, 520);
            this.Name = "FormRecharge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recharge";
            this.Load += new System.EventHandler(this.FormRecharge_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PnlRecharge.ResumeLayout(false);
            this.PnlRecharge.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.PnlValider.ResumeLayout(false);
            this.PnlValider.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtSolde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTelephone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtAdresse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtPrenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPostnom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMatricule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Panel PnlRecharge;
        private System.Windows.Forms.Label LblRecharge;
        private System.Windows.Forms.TextBox TxtRecherche;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel PnlValider;
        private System.Windows.Forms.Label LblValider;
    }
}
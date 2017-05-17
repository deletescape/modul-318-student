namespace UI
{
    partial class MainUI
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tpVerbindung = new System.Windows.Forms.TabPage();
            this.lstResult = new MaterialSkin.Controls.MaterialListView();
            this.txtZielort = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAbfahrtsort = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblZielort = new MaterialSkin.Controls.MaterialLabel();
            this.lblAbfahrtsort = new MaterialSkin.Controls.MaterialLabel();
            this.btnSuchen = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tpAbfahrtsmonitor = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.chPlatform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAnkunftszeit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDauer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAbfahrtszeit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialTabControl1.SuspendLayout();
            this.tpVerbindung.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tpVerbindung);
            this.materialTabControl1.Controls.Add(this.tpAbfahrtsmonitor);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-2, 93);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(656, 480);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tpVerbindung
            // 
            this.tpVerbindung.BackColor = System.Drawing.SystemColors.Control;
            this.tpVerbindung.Controls.Add(this.lstResult);
            this.tpVerbindung.Controls.Add(this.txtZielort);
            this.tpVerbindung.Controls.Add(this.txtAbfahrtsort);
            this.tpVerbindung.Controls.Add(this.lblZielort);
            this.tpVerbindung.Controls.Add(this.lblAbfahrtsort);
            this.tpVerbindung.Controls.Add(this.btnSuchen);
            this.tpVerbindung.Location = new System.Drawing.Point(4, 22);
            this.tpVerbindung.Name = "tpVerbindung";
            this.tpVerbindung.Padding = new System.Windows.Forms.Padding(3);
            this.tpVerbindung.Size = new System.Drawing.Size(648, 454);
            this.tpVerbindung.TabIndex = 0;
            this.tpVerbindung.Text = "Verbindung";
            // 
            // lstResult
            // 
            this.lstResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPlatform,
            this.chAbfahrtszeit,
            this.chAnkunftszeit,
            this.chDauer});
            this.lstResult.Depth = 0;
            this.lstResult.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.lstResult.FullRowSelect = true;
            this.lstResult.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstResult.Location = new System.Drawing.Point(14, 131);
            this.lstResult.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstResult.MouseState = MaterialSkin.MouseState.OUT;
            this.lstResult.Name = "lstResult";
            this.lstResult.OwnerDraw = true;
            this.lstResult.Size = new System.Drawing.Size(626, 317);
            this.lstResult.TabIndex = 4;
            this.lstResult.UseCompatibleStateImageBehavior = false;
            this.lstResult.View = System.Windows.Forms.View.Details;
            // 
            // txtZielort
            // 
            this.txtZielort.Depth = 0;
            this.txtZielort.Hint = "";
            this.txtZielort.Location = new System.Drawing.Point(101, 35);
            this.txtZielort.MaxLength = 32767;
            this.txtZielort.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtZielort.Name = "txtZielort";
            this.txtZielort.PasswordChar = '\0';
            this.txtZielort.SelectedText = "";
            this.txtZielort.SelectionLength = 0;
            this.txtZielort.SelectionStart = 0;
            this.txtZielort.Size = new System.Drawing.Size(212, 23);
            this.txtZielort.TabIndex = 3;
            this.txtZielort.TabStop = false;
            this.txtZielort.UseSystemPasswordChar = false;
            // 
            // txtAbfahrtsort
            // 
            this.txtAbfahrtsort.Depth = 0;
            this.txtAbfahrtsort.Hint = "";
            this.txtAbfahrtsort.Location = new System.Drawing.Point(101, 3);
            this.txtAbfahrtsort.MaxLength = 32767;
            this.txtAbfahrtsort.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAbfahrtsort.Name = "txtAbfahrtsort";
            this.txtAbfahrtsort.PasswordChar = '\0';
            this.txtAbfahrtsort.SelectedText = "";
            this.txtAbfahrtsort.SelectionLength = 0;
            this.txtAbfahrtsort.SelectionStart = 0;
            this.txtAbfahrtsort.Size = new System.Drawing.Size(212, 23);
            this.txtAbfahrtsort.TabIndex = 2;
            this.txtAbfahrtsort.TabStop = false;
            this.txtAbfahrtsort.UseSystemPasswordChar = false;
            // 
            // lblZielort
            // 
            this.lblZielort.AutoSize = true;
            this.lblZielort.Depth = 0;
            this.lblZielort.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblZielort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblZielort.Location = new System.Drawing.Point(10, 35);
            this.lblZielort.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblZielort.Name = "lblZielort";
            this.lblZielort.Size = new System.Drawing.Size(53, 19);
            this.lblZielort.TabIndex = 2;
            this.lblZielort.Text = "Zielort";
            // 
            // lblAbfahrtsort
            // 
            this.lblAbfahrtsort.AutoSize = true;
            this.lblAbfahrtsort.Depth = 0;
            this.lblAbfahrtsort.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAbfahrtsort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAbfahrtsort.Location = new System.Drawing.Point(10, 3);
            this.lblAbfahrtsort.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAbfahrtsort.Name = "lblAbfahrtsort";
            this.lblAbfahrtsort.Size = new System.Drawing.Size(85, 19);
            this.lblAbfahrtsort.TabIndex = 1;
            this.lblAbfahrtsort.Text = "Abfahrtsort";
            // 
            // btnSuchen
            // 
            this.btnSuchen.AutoSize = true;
            this.btnSuchen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSuchen.Depth = 0;
            this.btnSuchen.Icon = null;
            this.btnSuchen.Location = new System.Drawing.Point(565, 89);
            this.btnSuchen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Primary = true;
            this.btnSuchen.Size = new System.Drawing.Size(74, 36);
            this.btnSuchen.TabIndex = 0;
            this.btnSuchen.Text = "Suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // tpAbfahrtsmonitor
            // 
            this.tpAbfahrtsmonitor.Location = new System.Drawing.Point(4, 22);
            this.tpAbfahrtsmonitor.Name = "tpAbfahrtsmonitor";
            this.tpAbfahrtsmonitor.Padding = new System.Windows.Forms.Padding(3);
            this.tpAbfahrtsmonitor.Size = new System.Drawing.Size(533, 404);
            this.tpAbfahrtsmonitor.TabIndex = 1;
            this.tpAbfahrtsmonitor.Text = "Abfahrtsmonitor";
            this.tpAbfahrtsmonitor.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-2, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(655, 23);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "tabSelector";
            // 
            // chPlatform
            // 
            this.chPlatform.Text = "Platform";
            this.chPlatform.Width = 135;
            // 
            // chAnkunftszeit
            // 
            this.chAnkunftszeit.Text = "Ankunftszeit";
            this.chAnkunftszeit.Width = 192;
            // 
            // chDauer
            // 
            this.chDauer.Text = "Dauer";
            this.chDauer.Width = 113;
            // 
            // chAbfahrtszeit
            // 
            this.chAbfahrtszeit.Text = "Abfahrtszeit";
            this.chAbfahrtszeit.Width = 186;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 573);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "MainUI";
            this.Text = "ÖVÖ";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tpVerbindung.ResumeLayout(false);
            this.tpVerbindung.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tpVerbindung;
        private System.Windows.Forms.TabPage tpAbfahrtsmonitor;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSuchen;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAbfahrtsort;
        private MaterialSkin.Controls.MaterialLabel lblZielort;
        private MaterialSkin.Controls.MaterialLabel lblAbfahrtsort;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtZielort;
        private MaterialSkin.Controls.MaterialListView lstResult;
        private System.Windows.Forms.ColumnHeader chPlatform;
        private System.Windows.Forms.ColumnHeader chAnkunftszeit;
        private System.Windows.Forms.ColumnHeader chDauer;
        private System.Windows.Forms.ColumnHeader chAbfahrtszeit;
    }
}


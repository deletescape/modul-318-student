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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tpVerbindung = new System.Windows.Forms.TabPage();
            this.lstAutocompleteZiel = new System.Windows.Forms.ListBox();
            this.lstAutocompleteAbfahrt = new System.Windows.Forms.ListBox();
            this.lstResult = new MaterialSkin.Controls.MaterialListView();
            this.chPlatform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAbfahrtszeit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAnkunftszeit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDauer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtZielort = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAbfahrtsort = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblZielort = new MaterialSkin.Controls.MaterialLabel();
            this.lblAbfahrtsort = new MaterialSkin.Controls.MaterialLabel();
            this.btnSuchen = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tpAbfahrtsmonitor = new System.Windows.Forms.TabPage();
            this.lstAutocompleteStation = new System.Windows.Forms.ListBox();
            this.btnSuchen2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtStation = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblStation = new MaterialSkin.Controls.MaterialLabel();
            this.lstResult2 = new MaterialSkin.Controls.MaterialListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAbfahrt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOperator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.ttpLocation = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl.SuspendLayout();
            this.tpVerbindung.SuspendLayout();
            this.tpAbfahrtsmonitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tpVerbindung);
            this.tabControl.Controls.Add(this.tpAbfahrtsmonitor);
            this.tabControl.Depth = 0;
            this.tabControl.Location = new System.Drawing.Point(-2, 106);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(656, 469);
            this.tabControl.TabIndex = 0;
            // 
            // tpVerbindung
            // 
            this.tpVerbindung.BackColor = System.Drawing.SystemColors.Control;
            this.tpVerbindung.Controls.Add(this.lstAutocompleteZiel);
            this.tpVerbindung.Controls.Add(this.lstAutocompleteAbfahrt);
            this.tpVerbindung.Controls.Add(this.lstResult);
            this.tpVerbindung.Controls.Add(this.txtZielort);
            this.tpVerbindung.Controls.Add(this.txtAbfahrtsort);
            this.tpVerbindung.Controls.Add(this.lblZielort);
            this.tpVerbindung.Controls.Add(this.lblAbfahrtsort);
            this.tpVerbindung.Controls.Add(this.btnSuchen);
            this.tpVerbindung.Location = new System.Drawing.Point(4, 22);
            this.tpVerbindung.Name = "tpVerbindung";
            this.tpVerbindung.Padding = new System.Windows.Forms.Padding(3);
            this.tpVerbindung.Size = new System.Drawing.Size(648, 443);
            this.tpVerbindung.TabIndex = 0;
            this.tpVerbindung.Text = "Verbindung";
            // 
            // lstAutocompleteZiel
            // 
            this.lstAutocompleteZiel.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAutocompleteZiel.FormattingEnabled = true;
            this.lstAutocompleteZiel.ItemHeight = 19;
            this.lstAutocompleteZiel.Location = new System.Drawing.Point(101, 64);
            this.lstAutocompleteZiel.Name = "lstAutocompleteZiel";
            this.lstAutocompleteZiel.Size = new System.Drawing.Size(212, 80);
            this.lstAutocompleteZiel.TabIndex = 6;
            this.lstAutocompleteZiel.Visible = false;
            this.lstAutocompleteZiel.DoubleClick += new System.EventHandler(this.lstAutocompleteZiel_DoubleClick);
            this.lstAutocompleteZiel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstAutocompleteZiel_KeyDown);
            this.lstAutocompleteZiel.Leave += new System.EventHandler(this.lstAutocompleteZiel_Leave);
            // 
            // lstAutocompleteAbfahrt
            // 
            this.lstAutocompleteAbfahrt.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAutocompleteAbfahrt.FormattingEnabled = true;
            this.lstAutocompleteAbfahrt.ItemHeight = 19;
            this.lstAutocompleteAbfahrt.Location = new System.Drawing.Point(101, 32);
            this.lstAutocompleteAbfahrt.Name = "lstAutocompleteAbfahrt";
            this.lstAutocompleteAbfahrt.Size = new System.Drawing.Size(212, 80);
            this.lstAutocompleteAbfahrt.TabIndex = 5;
            this.lstAutocompleteAbfahrt.Visible = false;
            this.lstAutocompleteAbfahrt.DoubleClick += new System.EventHandler(this.lstAutocompleteAbfahrt_DoubleClick);
            this.lstAutocompleteAbfahrt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstAutocompleteAbfahrt_KeyDown);
            this.lstAutocompleteAbfahrt.Leave += new System.EventHandler(this.lstAutocompleteAbfahrt_Leave);
            // 
            // lstResult
            // 
            this.lstResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstResult.BackColor = System.Drawing.SystemColors.Window;
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
            this.lstResult.Location = new System.Drawing.Point(-4, 131);
            this.lstResult.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstResult.MouseState = MaterialSkin.MouseState.OUT;
            this.lstResult.Name = "lstResult";
            this.lstResult.OwnerDraw = true;
            this.lstResult.Size = new System.Drawing.Size(655, 316);
            this.lstResult.TabIndex = 4;
            this.lstResult.UseCompatibleStateImageBehavior = false;
            this.lstResult.View = System.Windows.Forms.View.Details;
            // 
            // chPlatform
            // 
            this.chPlatform.Text = "Platform";
            this.chPlatform.Width = 135;
            // 
            // chAbfahrtszeit
            // 
            this.chAbfahrtszeit.Text = "Abfahrtszeit";
            this.chAbfahrtszeit.Width = 186;
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
            this.txtZielort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtZielort_KeyDown);
            this.txtZielort.Leave += new System.EventHandler(this.txtZielort_Leave);
            this.txtZielort.TextChanged += new System.EventHandler(this.txtZielort_TextChanged);
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
            this.txtAbfahrtsort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAbfahrtsort_KeyDown);
            this.txtAbfahrtsort.Leave += new System.EventHandler(this.txtAbfahrtsort_Leave);
            this.txtAbfahrtsort.TextChanged += new System.EventHandler(this.txtAbfahrtsort_TextChanged);
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
            this.ttpLocation.SetToolTip(this.lblZielort, "Zeige den Zielort auf Google Maps\r\n");
            this.lblZielort.Click += new System.EventHandler(this.lblZielort_Click);
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
            this.ttpLocation.SetToolTip(this.lblAbfahrtsort, "Zeige den Abfahrtsort auf Google Maps");
            this.lblAbfahrtsort.Click += new System.EventHandler(this.lblAbfahrtsort_Click);
            // 
            // btnSuchen
            // 
            this.btnSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tpAbfahrtsmonitor.BackColor = System.Drawing.SystemColors.Control;
            this.tpAbfahrtsmonitor.Controls.Add(this.lstAutocompleteStation);
            this.tpAbfahrtsmonitor.Controls.Add(this.btnSuchen2);
            this.tpAbfahrtsmonitor.Controls.Add(this.txtStation);
            this.tpAbfahrtsmonitor.Controls.Add(this.lblStation);
            this.tpAbfahrtsmonitor.Controls.Add(this.lstResult2);
            this.tpAbfahrtsmonitor.Location = new System.Drawing.Point(4, 22);
            this.tpAbfahrtsmonitor.Name = "tpAbfahrtsmonitor";
            this.tpAbfahrtsmonitor.Padding = new System.Windows.Forms.Padding(3);
            this.tpAbfahrtsmonitor.Size = new System.Drawing.Size(648, 443);
            this.tpAbfahrtsmonitor.TabIndex = 1;
            this.tpAbfahrtsmonitor.Text = "Abfahrtsmonitor";
            // 
            // lstAutocompleteStation
            // 
            this.lstAutocompleteStation.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAutocompleteStation.FormattingEnabled = true;
            this.lstAutocompleteStation.ItemHeight = 19;
            this.lstAutocompleteStation.Location = new System.Drawing.Point(69, 32);
            this.lstAutocompleteStation.Name = "lstAutocompleteStation";
            this.lstAutocompleteStation.Size = new System.Drawing.Size(212, 80);
            this.lstAutocompleteStation.TabIndex = 6;
            this.lstAutocompleteStation.Visible = false;
            this.lstAutocompleteStation.DoubleClick += new System.EventHandler(this.lstAutocompleteStation_DoubleClick);
            this.lstAutocompleteStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstAutocompleteStation_KeyDown);
            this.lstAutocompleteStation.Leave += new System.EventHandler(this.lstAutocompleteStation_Leave);
            // 
            // btnSuchen2
            // 
            this.btnSuchen2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuchen2.AutoSize = true;
            this.btnSuchen2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSuchen2.Depth = 0;
            this.btnSuchen2.Icon = null;
            this.btnSuchen2.Location = new System.Drawing.Point(565, 35);
            this.btnSuchen2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSuchen2.Name = "btnSuchen2";
            this.btnSuchen2.Primary = true;
            this.btnSuchen2.Size = new System.Drawing.Size(74, 36);
            this.btnSuchen2.TabIndex = 3;
            this.btnSuchen2.Text = "Suchen";
            this.btnSuchen2.UseVisualStyleBackColor = true;
            this.btnSuchen2.Click += new System.EventHandler(this.btnSuchen2_Click);
            // 
            // txtStation
            // 
            this.txtStation.Depth = 0;
            this.txtStation.Hint = "";
            this.txtStation.Location = new System.Drawing.Point(69, 3);
            this.txtStation.MaxLength = 32767;
            this.txtStation.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtStation.Name = "txtStation";
            this.txtStation.PasswordChar = '\0';
            this.txtStation.SelectedText = "";
            this.txtStation.SelectionLength = 0;
            this.txtStation.SelectionStart = 0;
            this.txtStation.Size = new System.Drawing.Size(212, 23);
            this.txtStation.TabIndex = 2;
            this.txtStation.TabStop = false;
            this.txtStation.UseSystemPasswordChar = false;
            this.txtStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStation_KeyDown);
            this.txtStation.Leave += new System.EventHandler(this.txtStation_Leave);
            this.txtStation.TextChanged += new System.EventHandler(this.txtStation_TextChanged);
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Depth = 0;
            this.lblStation.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblStation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStation.Location = new System.Drawing.Point(6, 3);
            this.lblStation.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(57, 19);
            this.lblStation.TabIndex = 1;
            this.lblStation.Text = "Station";
            this.ttpLocation.SetToolTip(this.lblStation, "Zeige die Station auf Google Maps\r\n");
            this.lblStation.Click += new System.EventHandler(this.lblStation_Click);
            // 
            // lstResult2
            // 
            this.lstResult2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstResult2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstResult2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chNach,
            this.chAbfahrt,
            this.chOperator});
            this.lstResult2.Depth = 0;
            this.lstResult2.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.lstResult2.FullRowSelect = true;
            this.lstResult2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstResult2.Location = new System.Drawing.Point(0, 77);
            this.lstResult2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstResult2.MouseState = MaterialSkin.MouseState.OUT;
            this.lstResult2.Name = "lstResult2";
            this.lstResult2.OwnerDraw = true;
            this.lstResult2.Size = new System.Drawing.Size(652, 381);
            this.lstResult2.TabIndex = 0;
            this.lstResult2.UseCompatibleStateImageBehavior = false;
            this.lstResult2.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 97;
            // 
            // chNach
            // 
            this.chNach.Text = "Nach";
            this.chNach.Width = 87;
            // 
            // chAbfahrt
            // 
            this.chAbfahrt.Text = "Abfahrt";
            this.chAbfahrt.Width = 118;
            // 
            // chOperator
            // 
            this.chOperator.Text = "Operator";
            this.chOperator.Width = 343;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.tabControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-2, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(655, 36);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "tabSelector";
            // 
            // ttpLocation
            // 
            this.ttpLocation.ToolTipTitle = "Standort";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 575);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUI";
            this.Text = "ÖVÖ";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.tabControl.ResumeLayout(false);
            this.tpVerbindung.ResumeLayout(false);
            this.tpVerbindung.PerformLayout();
            this.tpAbfahrtsmonitor.ResumeLayout(false);
            this.tpAbfahrtsmonitor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabControl;
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
        private System.Windows.Forms.ListBox lstAutocompleteAbfahrt;
        private System.Windows.Forms.ListBox lstAutocompleteZiel;
        private MaterialSkin.Controls.MaterialLabel lblStation;
        private MaterialSkin.Controls.MaterialListView lstResult2;
        private System.Windows.Forms.ListBox lstAutocompleteStation;
        private MaterialSkin.Controls.MaterialRaisedButton btnSuchen2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtStation;
        private System.Windows.Forms.ColumnHeader chNach;
        private System.Windows.Forms.ColumnHeader chAbfahrt;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chOperator;
        private System.Windows.Forms.ToolTip ttpLocation;
    }
}


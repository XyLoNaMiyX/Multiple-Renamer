namespace Multiple_Renamer
{
    partial class MainF
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainF));
            this.startFrom = new System.Windows.Forms.NumericUpDown();
            this.folderB = new System.Windows.Forms.Button();
            this.renameB = new System.Windows.Forms.Button();
            this.folderTB = new System.Windows.Forms.TextBox();
            this.spamL = new System.Windows.Forms.Label();
            this.prefixL = new System.Windows.Forms.Label();
            this.prefixTB = new System.Windows.Forms.TextBox();
            this.suffixTB = new System.Windows.Forms.TextBox();
            this.suffixL = new System.Windows.Forms.Label();
            this.checkUpdatesB = new System.Windows.Forms.Button();
            this.folderRB = new System.Windows.Forms.RadioButton();
            this.customFilesRB = new System.Windows.Forms.RadioButton();
            this.filesLB = new System.Windows.Forms.ListBox();
            this.addFilesB = new System.Windows.Forms.Button();
            this.clearListB = new System.Windows.Forms.Button();
            this.removeSelectedB = new System.Windows.Forms.Button();
            this.addFilesOFD = new System.Windows.Forms.OpenFileDialog();
            this.numerateGB = new System.Windows.Forms.GroupBox();
            this.nHexRB = new System.Windows.Forms.RadioButton();
            this.nRomanLowerRB = new System.Windows.Forms.RadioButton();
            this.nRomanRB = new System.Windows.Forms.RadioButton();
            this.nDecimalRB = new System.Windows.Forms.RadioButton();
            this.startFromL = new System.Windows.Forms.Label();
            this.spamLL = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.startFrom)).BeginInit();
            this.numerateGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // startFrom
            // 
            this.startFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startFrom.Location = new System.Drawing.Point(110, 181);
            this.startFrom.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.startFrom.Name = "startFrom";
            this.startFrom.Size = new System.Drawing.Size(82, 20);
            this.startFrom.TabIndex = 0;
            // 
            // folderB
            // 
            this.folderB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.folderB.Location = new System.Drawing.Point(405, 8);
            this.folderB.Name = "folderB";
            this.folderB.Size = new System.Drawing.Size(83, 23);
            this.folderB.TabIndex = 1;
            this.folderB.Text = "Elegir carpeta";
            this.folderB.UseVisualStyleBackColor = true;
            this.folderB.Click += new System.EventHandler(this.folderB_Click);
            // 
            // renameB
            // 
            this.renameB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.renameB.Enabled = false;
            this.renameB.Location = new System.Drawing.Point(198, 168);
            this.renameB.Name = "renameB";
            this.renameB.Size = new System.Drawing.Size(282, 31);
            this.renameB.TabIndex = 2;
            this.renameB.Text = "¡Renombrar!";
            this.renameB.UseVisualStyleBackColor = true;
            this.renameB.Click += new System.EventHandler(this.renameB_Click);
            // 
            // folderTB
            // 
            this.folderTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderTB.Location = new System.Drawing.Point(212, 11);
            this.folderTB.Name = "folderTB";
            this.folderTB.Size = new System.Drawing.Size(187, 20);
            this.folderTB.TabIndex = 3;
            this.folderTB.TextChanged += new System.EventHandler(this.folderTB_TextChanged);
            // 
            // spamL
            // 
            this.spamL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spamL.AutoSize = true;
            this.spamL.Location = new System.Drawing.Point(12, 212);
            this.spamL.Name = "spamL";
            this.spamL.Size = new System.Drawing.Size(96, 13);
            this.spamL.TabIndex = 8;
            this.spamL.Text = "Creado por Lonami";
            // 
            // prefixL
            // 
            this.prefixL.AutoSize = true;
            this.prefixL.Location = new System.Drawing.Point(8, 72);
            this.prefixL.Name = "prefixL";
            this.prefixL.Size = new System.Drawing.Size(39, 13);
            this.prefixL.TabIndex = 9;
            this.prefixL.Text = "Prefijo:";
            // 
            // prefixTB
            // 
            this.prefixTB.Location = new System.Drawing.Point(53, 69);
            this.prefixTB.Name = "prefixTB";
            this.prefixTB.Size = new System.Drawing.Size(153, 20);
            this.prefixTB.TabIndex = 10;
            // 
            // suffixTB
            // 
            this.suffixTB.Location = new System.Drawing.Point(53, 95);
            this.suffixTB.Name = "suffixTB";
            this.suffixTB.Size = new System.Drawing.Size(153, 20);
            this.suffixTB.TabIndex = 12;
            // 
            // suffixL
            // 
            this.suffixL.AutoSize = true;
            this.suffixL.Location = new System.Drawing.Point(11, 98);
            this.suffixL.Name = "suffixL";
            this.suffixL.Size = new System.Drawing.Size(36, 13);
            this.suffixL.TabIndex = 11;
            this.suffixL.Text = "Sufijo:";
            // 
            // checkUpdatesB
            // 
            this.checkUpdatesB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkUpdatesB.Location = new System.Drawing.Point(335, 205);
            this.checkUpdatesB.Name = "checkUpdatesB";
            this.checkUpdatesB.Size = new System.Drawing.Size(145, 23);
            this.checkUpdatesB.TabIndex = 13;
            this.checkUpdatesB.Text = "Comprobar actualizaciones";
            this.checkUpdatesB.UseVisualStyleBackColor = true;
            this.checkUpdatesB.Click += new System.EventHandler(this.checkUpdatesB_Click);
            // 
            // folderRB
            // 
            this.folderRB.AutoSize = true;
            this.folderRB.Checked = true;
            this.folderRB.Location = new System.Drawing.Point(11, 12);
            this.folderRB.Name = "folderRB";
            this.folderRB.Size = new System.Drawing.Size(195, 17);
            this.folderRB.TabIndex = 14;
            this.folderRB.TabStop = true;
            this.folderRB.Text = "Renombrar archivos en una carpeta";
            this.folderRB.UseVisualStyleBackColor = true;
            // 
            // customFilesRB
            // 
            this.customFilesRB.AutoSize = true;
            this.customFilesRB.Location = new System.Drawing.Point(11, 35);
            this.customFilesRB.Name = "customFilesRB";
            this.customFilesRB.Size = new System.Drawing.Size(191, 17);
            this.customFilesRB.TabIndex = 15;
            this.customFilesRB.Text = "Elegir sólo los archivos a renombrar";
            this.customFilesRB.UseVisualStyleBackColor = true;
            this.customFilesRB.CheckedChanged += new System.EventHandler(this.customFilesRB_CheckedChanged);
            // 
            // filesLB
            // 
            this.filesLB.AllowDrop = true;
            this.filesLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesLB.Enabled = false;
            this.filesLB.FormattingEnabled = true;
            this.filesLB.HorizontalScrollbar = true;
            this.filesLB.Location = new System.Drawing.Point(212, 35);
            this.filesLB.Name = "filesLB";
            this.filesLB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.filesLB.Size = new System.Drawing.Size(187, 69);
            this.filesLB.TabIndex = 16;
            this.filesLB.SelectedIndexChanged += new System.EventHandler(this.filesLB_SelectedIndexChanged);
            this.filesLB.DragDrop += new System.Windows.Forms.DragEventHandler(this.filesLB_DragDrop);
            this.filesLB.DragEnter += new System.Windows.Forms.DragEventHandler(this.filesLB_DragEnter);
            // 
            // addFilesB
            // 
            this.addFilesB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addFilesB.Enabled = false;
            this.addFilesB.Location = new System.Drawing.Point(405, 93);
            this.addFilesB.Name = "addFilesB";
            this.addFilesB.Size = new System.Drawing.Size(83, 23);
            this.addFilesB.TabIndex = 17;
            this.addFilesB.Text = "+ archivos";
            this.addFilesB.UseVisualStyleBackColor = true;
            this.addFilesB.Click += new System.EventHandler(this.addFilesB_Click);
            // 
            // clearListB
            // 
            this.clearListB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearListB.Enabled = false;
            this.clearListB.Location = new System.Drawing.Point(405, 35);
            this.clearListB.Name = "clearListB";
            this.clearListB.Size = new System.Drawing.Size(83, 23);
            this.clearListB.TabIndex = 18;
            this.clearListB.Text = "Vaciar lista";
            this.clearListB.UseVisualStyleBackColor = true;
            this.clearListB.Click += new System.EventHandler(this.clearListB_Click);
            // 
            // removeSelectedB
            // 
            this.removeSelectedB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeSelectedB.Enabled = false;
            this.removeSelectedB.Location = new System.Drawing.Point(405, 64);
            this.removeSelectedB.Name = "removeSelectedB";
            this.removeSelectedB.Size = new System.Drawing.Size(83, 23);
            this.removeSelectedB.TabIndex = 19;
            this.removeSelectedB.Text = "Elim. selec.";
            this.removeSelectedB.UseVisualStyleBackColor = true;
            this.removeSelectedB.Click += new System.EventHandler(this.removeSelectedB_Click);
            // 
            // addFilesOFD
            // 
            this.addFilesOFD.Filter = "Todos los archivos|*";
            this.addFilesOFD.Multiselect = true;
            this.addFilesOFD.Title = "Añadir archivos";
            // 
            // numerateGB
            // 
            this.numerateGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numerateGB.Controls.Add(this.nHexRB);
            this.numerateGB.Controls.Add(this.nRomanLowerRB);
            this.numerateGB.Controls.Add(this.nRomanRB);
            this.numerateGB.Controls.Add(this.nDecimalRB);
            this.numerateGB.Location = new System.Drawing.Point(12, 119);
            this.numerateGB.Name = "numerateGB";
            this.numerateGB.Size = new System.Drawing.Size(468, 46);
            this.numerateGB.TabIndex = 20;
            this.numerateGB.TabStop = false;
            this.numerateGB.Text = "Numerar en";
            // 
            // nHexRB
            // 
            this.nHexRB.AutoSize = true;
            this.nHexRB.Location = new System.Drawing.Point(75, 19);
            this.nHexRB.Name = "nHexRB";
            this.nHexRB.Size = new System.Drawing.Size(86, 17);
            this.nHexRB.TabIndex = 3;
            this.nHexRB.Text = "Hexadecimal";
            this.nHexRB.UseVisualStyleBackColor = true;
            // 
            // nRomanLowerRB
            // 
            this.nRomanLowerRB.AutoSize = true;
            this.nRomanLowerRB.Location = new System.Drawing.Point(283, 19);
            this.nRomanLowerRB.Name = "nRomanLowerRB";
            this.nRomanLowerRB.Size = new System.Drawing.Size(171, 17);
            this.nRomanLowerRB.TabIndex = 2;
            this.nRomanLowerRB.Text = "Números romanos (minúsculas)";
            this.nRomanLowerRB.UseVisualStyleBackColor = true;
            // 
            // nRomanRB
            // 
            this.nRomanRB.AutoSize = true;
            this.nRomanRB.Location = new System.Drawing.Point(167, 19);
            this.nRomanRB.Name = "nRomanRB";
            this.nRomanRB.Size = new System.Drawing.Size(110, 17);
            this.nRomanRB.TabIndex = 1;
            this.nRomanRB.Text = "Números romanos";
            this.nRomanRB.UseVisualStyleBackColor = true;
            // 
            // nDecimalRB
            // 
            this.nDecimalRB.AutoSize = true;
            this.nDecimalRB.Checked = true;
            this.nDecimalRB.Location = new System.Drawing.Point(6, 19);
            this.nDecimalRB.Name = "nDecimalRB";
            this.nDecimalRB.Size = new System.Drawing.Size(63, 17);
            this.nDecimalRB.TabIndex = 0;
            this.nDecimalRB.TabStop = true;
            this.nDecimalRB.Text = "Decimal";
            this.nDecimalRB.UseVisualStyleBackColor = true;
            // 
            // startFromL
            // 
            this.startFromL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startFromL.AutoSize = true;
            this.startFromL.Location = new System.Drawing.Point(12, 175);
            this.startFromL.Name = "startFromL";
            this.startFromL.Size = new System.Drawing.Size(97, 26);
            this.startFromL.TabIndex = 21;
            this.startFromL.Text = "Comenzar la\r\nnumeración desde:";
            // 
            // spamLL
            // 
            this.spamLL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spamLL.AutoSize = true;
            this.spamLL.Location = new System.Drawing.Point(114, 212);
            this.spamLL.Name = "spamLL";
            this.spamLL.Size = new System.Drawing.Size(86, 13);
            this.spamLL.TabIndex = 22;
            this.spamLL.TabStop = true;
            this.spamLL.Text = "lonamiwebs.github.io";
            this.spamLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.spamLL_LinkClicked);
            // 
            // MainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 231);
            this.Controls.Add(this.spamLL);
            this.Controls.Add(this.startFromL);
            this.Controls.Add(this.numerateGB);
            this.Controls.Add(this.removeSelectedB);
            this.Controls.Add(this.clearListB);
            this.Controls.Add(this.addFilesB);
            this.Controls.Add(this.filesLB);
            this.Controls.Add(this.customFilesRB);
            this.Controls.Add(this.folderRB);
            this.Controls.Add(this.checkUpdatesB);
            this.Controls.Add(this.suffixTB);
            this.Controls.Add(this.suffixL);
            this.Controls.Add(this.prefixTB);
            this.Controls.Add(this.prefixL);
            this.Controls.Add(this.spamL);
            this.Controls.Add(this.folderTB);
            this.Controls.Add(this.renameB);
            this.Controls.Add(this.folderB);
            this.Controls.Add(this.startFrom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(510, 270);
            this.Name = "MainF";
            this.Text = "Renombrador múltiple";
            ((System.ComponentModel.ISupportInitialize)(this.startFrom)).EndInit();
            this.numerateGB.ResumeLayout(false);
            this.numerateGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown startFrom;
        private System.Windows.Forms.Button folderB;
        private System.Windows.Forms.Button renameB;
        private System.Windows.Forms.TextBox folderTB;
        private System.Windows.Forms.Label spamL;
        private System.Windows.Forms.Label prefixL;
        private System.Windows.Forms.TextBox prefixTB;
        private System.Windows.Forms.TextBox suffixTB;
        private System.Windows.Forms.Label suffixL;
        private System.Windows.Forms.Button checkUpdatesB;
        private System.Windows.Forms.RadioButton folderRB;
        private System.Windows.Forms.RadioButton customFilesRB;
        private System.Windows.Forms.ListBox filesLB;
        private System.Windows.Forms.Button addFilesB;
        private System.Windows.Forms.Button clearListB;
        private System.Windows.Forms.Button removeSelectedB;
        private System.Windows.Forms.OpenFileDialog addFilesOFD;
        private System.Windows.Forms.GroupBox numerateGB;
        private System.Windows.Forms.RadioButton nRomanRB;
        private System.Windows.Forms.RadioButton nDecimalRB;
        private System.Windows.Forms.RadioButton nRomanLowerRB;
        private System.Windows.Forms.RadioButton nHexRB;
        private System.Windows.Forms.Label startFromL;
        private System.Windows.Forms.LinkLabel spamLL;
    }
}


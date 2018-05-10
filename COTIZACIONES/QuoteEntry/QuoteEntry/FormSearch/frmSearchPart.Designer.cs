namespace QuoteEntry.FormSearch
{
    partial class frmSearchPart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchPart));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mgResultados = new MetroFramework.Controls.MetroGrid();
            this.mtBuscar = new MetroFramework.Controls.MetroTile();
            this.mtOK = new MetroFramework.Controls.MetroTile();
            this.txtPartNum = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mgResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nº Parte:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 113);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Nombre:";
            // 
            // mgResultados
            // 
            this.mgResultados.AllowUserToAddRows = false;
            this.mgResultados.AllowUserToDeleteRows = false;
            this.mgResultados.AllowUserToResizeRows = false;
            this.mgResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mgResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mgResultados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mgResultados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgResultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgResultados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgResultados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgResultados.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgResultados.EnableHeadersVisualStyles = false;
            this.mgResultados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgResultados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgResultados.Location = new System.Drawing.Point(23, 146);
            this.mgResultados.Name = "mgResultados";
            this.mgResultados.ReadOnly = true;
            this.mgResultados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgResultados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgResultados.RowHeadersWidth = 4;
            this.mgResultados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgResultados.Size = new System.Drawing.Size(599, 275);
            this.mgResultados.Style = MetroFramework.MetroColorStyle.Silver;
            this.mgResultados.TabIndex = 2;
            this.mgResultados.DoubleClick += new System.EventHandler(this.mgResultados_DoubleClick);
            // 
            // mtBuscar
            // 
            this.mtBuscar.ActiveControl = null;
            this.mtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtBuscar.Location = new System.Drawing.Point(493, 75);
            this.mtBuscar.Name = "mtBuscar";
            this.mtBuscar.Size = new System.Drawing.Size(129, 57);
            this.mtBuscar.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtBuscar.TabIndex = 5;
            this.mtBuscar.Text = "Buscar";
            this.mtBuscar.TileImage = global::QuoteEntry.Properties.Resources.if_search;
            this.mtBuscar.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.mtBuscar.UseSelectable = true;
            this.mtBuscar.UseTileImage = true;
            this.mtBuscar.Click += new System.EventHandler(this.mtBuscar_Click);
            // 
            // mtOK
            // 
            this.mtOK.ActiveControl = null;
            this.mtOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mtOK.Location = new System.Drawing.Point(493, 427);
            this.mtOK.Name = "mtOK";
            this.mtOK.Size = new System.Drawing.Size(129, 57);
            this.mtOK.TabIndex = 7;
            this.mtOK.Text = "OK";
            this.mtOK.TileImage = global::QuoteEntry.Properties.Resources.if_Process;
            this.mtOK.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mtOK.UseSelectable = true;
            this.mtOK.UseTileImage = true;
            this.mtOK.Click += new System.EventHandler(this.mtOK_Click);
            // 
            // txtPartNum
            // 
            // 
            // 
            // 
            this.txtPartNum.CustomButton.Image = null;
            this.txtPartNum.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.txtPartNum.CustomButton.Name = "";
            this.txtPartNum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPartNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPartNum.CustomButton.TabIndex = 1;
            this.txtPartNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPartNum.CustomButton.UseSelectable = true;
            this.txtPartNum.CustomButton.Visible = false;
            this.txtPartNum.Lines = new string[0];
            this.txtPartNum.Location = new System.Drawing.Point(124, 67);
            this.txtPartNum.MaxLength = 32767;
            this.txtPartNum.Name = "txtPartNum";
            this.txtPartNum.PasswordChar = '\0';
            this.txtPartNum.PromptText = "Ingrese el número de la parte";
            this.txtPartNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPartNum.SelectedText = "";
            this.txtPartNum.SelectionLength = 0;
            this.txtPartNum.SelectionStart = 0;
            this.txtPartNum.ShortcutsEnabled = true;
            this.txtPartNum.Size = new System.Drawing.Size(192, 23);
            this.txtPartNum.TabIndex = 0;
            this.txtPartNum.UseSelectable = true;
            this.txtPartNum.WaterMark = "Ingrese el número de la parte";
            this.txtPartNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPartNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPartNum.TextChanged += new System.EventHandler(this.txtPartNum_TextChanged);
            this.txtPartNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPartNum_KeyPress);
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(331, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(124, 109);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PromptText = "Ingrese el nombre de la parte";
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(353, 23);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMark = "Ingrese el nombre de la parte";
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // frmSearchPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 502);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPartNum);
            this.Controls.Add(this.mtOK);
            this.Controls.Add(this.mtBuscar);
            this.Controls.Add(this.mgResultados);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearchPart";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Buscar parte";
            this.Load += new System.EventHandler(this.frmSearchPart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid mgResultados;
        private MetroFramework.Controls.MetroTile mtBuscar;
        private MetroFramework.Controls.MetroTile mtOK;
        private MetroFramework.Controls.MetroTextBox txtPartNum;
        private MetroFramework.Controls.MetroTextBox txtNombre;
    }
}
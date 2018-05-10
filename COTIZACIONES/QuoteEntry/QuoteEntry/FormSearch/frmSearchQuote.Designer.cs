namespace QuoteEntry.FormSearch
{
    partial class frmSearchQuote
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchQuote));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtQuoteNum = new MetroFramework.Controls.MetroTextBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.txtIDCliente = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtpfechaI = new MetroFramework.Controls.MetroDateTime();
            this.dtpfechaF = new MetroFramework.Controls.MetroDateTime();
            this.mtBuscar = new MetroFramework.Controls.MetroTile();
            this.mtOK = new MetroFramework.Controls.MetroTile();
            this.mgResultados = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.mgResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Oferta N°:";
            // 
            // txtQuoteNum
            // 
            // 
            // 
            // 
            this.txtQuoteNum.CustomButton.Image = null;
            this.txtQuoteNum.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.txtQuoteNum.CustomButton.Name = "";
            this.txtQuoteNum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQuoteNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuoteNum.CustomButton.TabIndex = 1;
            this.txtQuoteNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuoteNum.CustomButton.UseSelectable = true;
            this.txtQuoteNum.CustomButton.Visible = false;
            this.txtQuoteNum.Lines = new string[0];
            this.txtQuoteNum.Location = new System.Drawing.Point(146, 68);
            this.txtQuoteNum.MaxLength = 32767;
            this.txtQuoteNum.Name = "txtQuoteNum";
            this.txtQuoteNum.PasswordChar = '\0';
            this.txtQuoteNum.PromptText = "Ingrese el Nº de cotización";
            this.txtQuoteNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuoteNum.SelectedText = "";
            this.txtQuoteNum.SelectionLength = 0;
            this.txtQuoteNum.SelectionStart = 0;
            this.txtQuoteNum.ShortcutsEnabled = true;
            this.txtQuoteNum.Size = new System.Drawing.Size(214, 23);
            this.txtQuoteNum.TabIndex = 1;
            this.txtQuoteNum.UseSelectable = true;
            this.txtQuoteNum.WaterMark = "Ingrese el Nº de cotización";
            this.txtQuoteNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuoteNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuoteNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuoteNum_KeyPress);
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(23, 101);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 23);
            this.metroLink1.TabIndex = 2;
            this.metroLink1.Text = "Cliente:";
            this.metroLink1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // txtIDCliente
            // 
            // 
            // 
            // 
            this.txtIDCliente.CustomButton.Image = null;
            this.txtIDCliente.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.txtIDCliente.CustomButton.Name = "";
            this.txtIDCliente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIDCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIDCliente.CustomButton.TabIndex = 1;
            this.txtIDCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIDCliente.CustomButton.UseSelectable = true;
            this.txtIDCliente.CustomButton.Visible = false;
            this.txtIDCliente.Lines = new string[0];
            this.txtIDCliente.Location = new System.Drawing.Point(146, 101);
            this.txtIDCliente.MaxLength = 32767;
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.PasswordChar = '\0';
            this.txtIDCliente.PromptText = "Ingrese ID del cliente";
            this.txtIDCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIDCliente.SelectedText = "";
            this.txtIDCliente.SelectionLength = 0;
            this.txtIDCliente.SelectionStart = 0;
            this.txtIDCliente.ShortcutsEnabled = true;
            this.txtIDCliente.Size = new System.Drawing.Size(214, 23);
            this.txtIDCliente.TabIndex = 3;
            this.txtIDCliente.UseSelectable = true;
            this.txtIDCliente.WaterMark = "Ingrese ID del cliente";
            this.txtIDCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIDCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIDCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDCliente_KeyPress);
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(307, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(366, 101);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ReadOnly = true;
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(329, 23);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 139);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Fecha:";
            // 
            // dtpfechaI
            // 
            this.dtpfechaI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaI.Location = new System.Drawing.Point(146, 129);
            this.dtpfechaI.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpfechaI.Name = "dtpfechaI";
            this.dtpfechaI.Size = new System.Drawing.Size(214, 29);
            this.dtpfechaI.TabIndex = 6;
            // 
            // dtpfechaF
            // 
            this.dtpfechaF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaF.Location = new System.Drawing.Point(366, 129);
            this.dtpfechaF.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpfechaF.Name = "dtpfechaF";
            this.dtpfechaF.Size = new System.Drawing.Size(214, 29);
            this.dtpfechaF.TabIndex = 7;
            // 
            // mtBuscar
            // 
            this.mtBuscar.ActiveControl = null;
            this.mtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtBuscar.Location = new System.Drawing.Point(566, 38);
            this.mtBuscar.Name = "mtBuscar";
            this.mtBuscar.Size = new System.Drawing.Size(129, 57);
            this.mtBuscar.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtBuscar.TabIndex = 8;
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
            this.mtOK.Location = new System.Drawing.Point(566, 386);
            this.mtOK.Name = "mtOK";
            this.mtOK.Size = new System.Drawing.Size(129, 57);
            this.mtOK.TabIndex = 9;
            this.mtOK.Text = "OK";
            this.mtOK.TileImage = global::QuoteEntry.Properties.Resources.if_Process;
            this.mtOK.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mtOK.UseSelectable = true;
            this.mtOK.UseTileImage = true;
            this.mtOK.Click += new System.EventHandler(this.mtOK_Click);
            // 
            // mgResultados
            // 
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mgResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgResultados.DefaultCellStyle = dataGridViewCellStyle5;
            this.mgResultados.EnableHeadersVisualStyles = false;
            this.mgResultados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgResultados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgResultados.Location = new System.Drawing.Point(23, 164);
            this.mgResultados.Name = "mgResultados";
            this.mgResultados.ReadOnly = true;
            this.mgResultados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgResultados.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mgResultados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgResultados.Size = new System.Drawing.Size(672, 216);
            this.mgResultados.Style = MetroFramework.MetroColorStyle.White;
            this.mgResultados.TabIndex = 10;
            this.mgResultados.DoubleClick += new System.EventHandler(this.mgResultados_DoubleClick);
            // 
            // frmSearchQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.mgResultados);
            this.Controls.Add(this.mtOK);
            this.Controls.Add(this.mtBuscar);
            this.Controls.Add(this.dtpfechaF);
            this.Controls.Add(this.dtpfechaI);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.txtQuoteNum);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearchQuote";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Buscar cotizaciones";
            this.Load += new System.EventHandler(this.frmSearchQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtQuoteNum;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroTextBox txtIDCliente;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime dtpfechaI;
        private MetroFramework.Controls.MetroDateTime dtpfechaF;
        private MetroFramework.Controls.MetroTile mtBuscar;
        private MetroFramework.Controls.MetroTile mtOK;
        private MetroFramework.Controls.MetroGrid mgResultados;
    }
}
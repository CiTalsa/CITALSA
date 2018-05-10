namespace QuoteEntry.FormSearch
{
    partial class frmSearchCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchCustomer));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtNit = new MetroFramework.Controls.MetroTextBox();
            this.txtIDCustomer = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.txtTelefono = new MetroFramework.Controls.MetroTextBox();
            this.mtBuscar = new MetroFramework.Controls.MetroTile();
            this.mgResultados = new MetroFramework.Controls.MetroGrid();
            this.mtOK = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.mgResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(29, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nit:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 102);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "ID Cliente:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 136);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Nombre:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 170);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(61, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Teléfono:";
            // 
            // txtNit
            // 
            // 
            // 
            // 
            this.txtNit.CustomButton.Image = null;
            this.txtNit.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.txtNit.CustomButton.Name = "";
            this.txtNit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNit.CustomButton.TabIndex = 1;
            this.txtNit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNit.CustomButton.UseSelectable = true;
            this.txtNit.CustomButton.Visible = false;
            this.txtNit.Lines = new string[0];
            this.txtNit.Location = new System.Drawing.Point(136, 68);
            this.txtNit.MaxLength = 32767;
            this.txtNit.Name = "txtNit";
            this.txtNit.PasswordChar = '\0';
            this.txtNit.PromptText = "Ingrese el nit del cliente";
            this.txtNit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNit.SelectedText = "";
            this.txtNit.SelectionLength = 0;
            this.txtNit.SelectionStart = 0;
            this.txtNit.ShortcutsEnabled = true;
            this.txtNit.Size = new System.Drawing.Size(178, 23);
            this.txtNit.TabIndex = 0;
            this.txtNit.UseSelectable = true;
            this.txtNit.WaterMark = "Ingrese el nit del cliente";
            this.txtNit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNit.TextChanged += new System.EventHandler(this.txtNit_TextChanged);
            this.txtNit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNit_KeyPress);
            // 
            // txtIDCustomer
            // 
            // 
            // 
            // 
            this.txtIDCustomer.CustomButton.Image = null;
            this.txtIDCustomer.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.txtIDCustomer.CustomButton.Name = "";
            this.txtIDCustomer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIDCustomer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIDCustomer.CustomButton.TabIndex = 1;
            this.txtIDCustomer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIDCustomer.CustomButton.UseSelectable = true;
            this.txtIDCustomer.CustomButton.Visible = false;
            this.txtIDCustomer.Lines = new string[0];
            this.txtIDCustomer.Location = new System.Drawing.Point(136, 98);
            this.txtIDCustomer.MaxLength = 32767;
            this.txtIDCustomer.Name = "txtIDCustomer";
            this.txtIDCustomer.PasswordChar = '\0';
            this.txtIDCustomer.PromptText = "Ingrese el id del cliente";
            this.txtIDCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIDCustomer.SelectedText = "";
            this.txtIDCustomer.SelectionLength = 0;
            this.txtIDCustomer.SelectionStart = 0;
            this.txtIDCustomer.ShortcutsEnabled = true;
            this.txtIDCustomer.Size = new System.Drawing.Size(178, 23);
            this.txtIDCustomer.TabIndex = 4;
            this.txtIDCustomer.UseSelectable = true;
            this.txtIDCustomer.WaterMark = "Ingrese el id del cliente";
            this.txtIDCustomer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIDCustomer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIDCustomer.TextChanged += new System.EventHandler(this.txtIDCustomer_TextChanged);
            this.txtIDCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDCustomer_KeyPress);
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(308, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(136, 132);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PromptText = "Ingrese el nombre del cliente";
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(330, 23);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMark = "Ingrese el nombre del cliente";
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtTelefono
            // 
            // 
            // 
            // 
            this.txtTelefono.CustomButton.Image = null;
            this.txtTelefono.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.txtTelefono.CustomButton.Name = "";
            this.txtTelefono.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelefono.CustomButton.TabIndex = 1;
            this.txtTelefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelefono.CustomButton.UseSelectable = true;
            this.txtTelefono.CustomButton.Visible = false;
            this.txtTelefono.Lines = new string[0];
            this.txtTelefono.Location = new System.Drawing.Point(136, 166);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.PromptText = "Ingrese el número de teléfono";
            this.txtTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.ShortcutsEnabled = true;
            this.txtTelefono.Size = new System.Drawing.Size(178, 23);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.UseSelectable = true;
            this.txtTelefono.WaterMark = "Ingrese el número de teléfono";
            this.txtTelefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // mtBuscar
            // 
            this.mtBuscar.ActiveControl = null;
            this.mtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtBuscar.Location = new System.Drawing.Point(505, 134);
            this.mtBuscar.Name = "mtBuscar";
            this.mtBuscar.Size = new System.Drawing.Size(129, 57);
            this.mtBuscar.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtBuscar.TabIndex = 7;
            this.mtBuscar.Text = "Buscar";
            this.mtBuscar.TileImage = global::QuoteEntry.Properties.Resources.if_search;
            this.mtBuscar.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.mtBuscar.UseSelectable = true;
            this.mtBuscar.UseTileImage = true;
            this.mtBuscar.Click += new System.EventHandler(this.mtBuscar_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgResultados.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgResultados.EnableHeadersVisualStyles = false;
            this.mgResultados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgResultados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgResultados.Location = new System.Drawing.Point(23, 206);
            this.mgResultados.Name = "mgResultados";
            this.mgResultados.ReadOnly = true;
            this.mgResultados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgResultados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgResultados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgResultados.Size = new System.Drawing.Size(611, 302);
            this.mgResultados.Style = MetroFramework.MetroColorStyle.White;
            this.mgResultados.TabIndex = 8;
            this.mgResultados.DoubleClick += new System.EventHandler(this.mgResultados_DoubleClick);
            // 
            // mtOK
            // 
            this.mtOK.ActiveControl = null;
            this.mtOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mtOK.Location = new System.Drawing.Point(505, 521);
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
            // frmSearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 594);
            this.Controls.Add(this.mtOK);
            this.Controls.Add(this.mgResultados);
            this.Controls.Add(this.mtBuscar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIDCustomer);
            this.Controls.Add(this.txtNit);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSearchCustomer";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Buscar cliente";
            this.Load += new System.EventHandler(this.frmSearchCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtNit;
        private MetroFramework.Controls.MetroTextBox txtIDCustomer;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroTextBox txtTelefono;
        private MetroFramework.Controls.MetroTile mtBuscar;
        private MetroFramework.Controls.MetroGrid mgResultados;
        private MetroFramework.Controls.MetroTile mtOK;
    }
}
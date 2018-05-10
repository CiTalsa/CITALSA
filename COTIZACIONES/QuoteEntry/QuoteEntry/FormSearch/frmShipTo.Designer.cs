namespace QuoteEntry.FormSearch
{
    partial class frmShipTo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShipTo));
            this.mgResultados = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtIDSucursal = new MetroFramework.Controls.MetroTextBox();
            this.mtBuscar = new MetroFramework.Controls.MetroTile();
            this.mtOK = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.mgResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // mgResultados
            // 
            this.mgResultados.AllowUserToAddRows = false;
            this.mgResultados.AllowUserToDeleteRows = false;
            this.mgResultados.AllowUserToResizeRows = false;
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
            this.mgResultados.Location = new System.Drawing.Point(23, 105);
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
            this.mgResultados.Size = new System.Drawing.Size(754, 258);
            this.mgResultados.Style = MetroFramework.MetroColorStyle.Silver;
            this.mgResultados.TabIndex = 0;
            this.mgResultados.DoubleClick += new System.EventHandler(this.mgResultados_DoubleClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "ID Sucursal:";
            // 
            // txtIDSucursal
            // 
            // 
            // 
            // 
            this.txtIDSucursal.CustomButton.Image = null;
            this.txtIDSucursal.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.txtIDSucursal.CustomButton.Name = "";
            this.txtIDSucursal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIDSucursal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIDSucursal.CustomButton.TabIndex = 1;
            this.txtIDSucursal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIDSucursal.CustomButton.UseSelectable = true;
            this.txtIDSucursal.CustomButton.Visible = false;
            this.txtIDSucursal.Lines = new string[0];
            this.txtIDSucursal.Location = new System.Drawing.Point(120, 56);
            this.txtIDSucursal.MaxLength = 32767;
            this.txtIDSucursal.Name = "txtIDSucursal";
            this.txtIDSucursal.PasswordChar = '\0';
            this.txtIDSucursal.PromptText = "Ingrese el id de la sucursal";
            this.txtIDSucursal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIDSucursal.SelectedText = "";
            this.txtIDSucursal.SelectionLength = 0;
            this.txtIDSucursal.SelectionStart = 0;
            this.txtIDSucursal.ShortcutsEnabled = true;
            this.txtIDSucursal.Size = new System.Drawing.Size(241, 23);
            this.txtIDSucursal.TabIndex = 0;
            this.txtIDSucursal.UseSelectable = true;
            this.txtIDSucursal.WaterMark = "Ingrese el id de la sucursal";
            this.txtIDSucursal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIDSucursal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIDSucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDSucursal_KeyPress);
            // 
            // mtBuscar
            // 
            this.mtBuscar.ActiveControl = null;
            this.mtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mtBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtBuscar.Location = new System.Drawing.Point(648, 22);
            this.mtBuscar.Name = "mtBuscar";
            this.mtBuscar.Size = new System.Drawing.Size(129, 57);
            this.mtBuscar.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtBuscar.TabIndex = 9;
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
            this.mtOK.Location = new System.Drawing.Point(648, 380);
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
            // frmShipTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtBuscar);
            this.Controls.Add(this.txtIDSucursal);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mtOK);
            this.Controls.Add(this.mgResultados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmShipTo";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Sucursales";
            this.Load += new System.EventHandler(this.frmShipTo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid mgResultados;
        private MetroFramework.Controls.MetroTile mtOK;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtIDSucursal;
        private MetroFramework.Controls.MetroTile mtBuscar;
    }
}
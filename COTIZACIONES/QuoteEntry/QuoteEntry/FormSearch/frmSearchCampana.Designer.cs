namespace QuoteEntry.FormSearch
{
    partial class frmSearchCampana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchCampana));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtIDCampana = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.mgResultados = new MetroFramework.Controls.MetroGrid();
            this.mtOK = new MetroFramework.Controls.MetroTile();
            this.mtBuscar = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.mgResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(38, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ID Campaña:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(38, 120);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Nombre:";
            // 
            // txtIDCampana
            // 
            // 
            // 
            // 
            this.txtIDCampana.CustomButton.Image = null;
            this.txtIDCampana.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtIDCampana.CustomButton.Name = "";
            this.txtIDCampana.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIDCampana.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIDCampana.CustomButton.TabIndex = 1;
            this.txtIDCampana.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIDCampana.CustomButton.UseSelectable = true;
            this.txtIDCampana.CustomButton.Visible = false;
            this.txtIDCampana.Lines = new string[0];
            this.txtIDCampana.Location = new System.Drawing.Point(146, 82);
            this.txtIDCampana.MaxLength = 32767;
            this.txtIDCampana.Name = "txtIDCampana";
            this.txtIDCampana.PasswordChar = '\0';
            this.txtIDCampana.PromptText = "Ingrese el ID de la campaña";
            this.txtIDCampana.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIDCampana.SelectedText = "";
            this.txtIDCampana.SelectionLength = 0;
            this.txtIDCampana.SelectionStart = 0;
            this.txtIDCampana.ShortcutsEnabled = true;
            this.txtIDCampana.Size = new System.Drawing.Size(165, 23);
            this.txtIDCampana.TabIndex = 2;
            this.txtIDCampana.UseSelectable = true;
            this.txtIDCampana.WaterMark = "Ingrese el ID de la campaña";
            this.txtIDCampana.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIDCampana.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIDCampana.TextChanged += new System.EventHandler(this.txtIDCampana_TextChanged);
            this.txtIDCampana.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDCampana_KeyPress);
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(146, 116);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PromptText = "Ingrese parte del nombre de la campaña";
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(257, 23);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMark = "Ingrese parte del nombre de la campaña";
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
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
            this.mgResultados.Location = new System.Drawing.Point(38, 151);
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
            this.mgResultados.Size = new System.Drawing.Size(512, 168);
            this.mgResultados.Style = MetroFramework.MetroColorStyle.White;
            this.mgResultados.TabIndex = 5;
            this.mgResultados.DoubleClick += new System.EventHandler(this.mgResultados_DoubleClick);
            // 
            // mtOK
            // 
            this.mtOK.ActiveControl = null;
            this.mtOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mtOK.Location = new System.Drawing.Point(421, 325);
            this.mtOK.Name = "mtOK";
            this.mtOK.Size = new System.Drawing.Size(129, 57);
            this.mtOK.TabIndex = 6;
            this.mtOK.Text = "OK";
            this.mtOK.TileImage = global::QuoteEntry.Properties.Resources.if_Process;
            this.mtOK.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mtOK.UseSelectable = true;
            this.mtOK.UseTileImage = true;
            this.mtOK.Click += new System.EventHandler(this.mtOK_Click);
            // 
            // mtBuscar
            // 
            this.mtBuscar.ActiveControl = null;
            this.mtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtBuscar.Location = new System.Drawing.Point(421, 88);
            this.mtBuscar.Name = "mtBuscar";
            this.mtBuscar.Size = new System.Drawing.Size(129, 57);
            this.mtBuscar.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtBuscar.TabIndex = 4;
            this.mtBuscar.Text = "Buscar";
            this.mtBuscar.TileImage = global::QuoteEntry.Properties.Resources.if_search;
            this.mtBuscar.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.mtBuscar.UseSelectable = true;
            this.mtBuscar.UseTileImage = true;
            this.mtBuscar.Click += new System.EventHandler(this.mtBuscar_Click);
            // 
            // frmSearchCampana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 392);
            this.Controls.Add(this.mtOK);
            this.Controls.Add(this.mgResultados);
            this.Controls.Add(this.mtBuscar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIDCampana);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchCampana";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Buscar campaña";
            this.Load += new System.EventHandler(this.frmSearchCampana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtIDCampana;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroTile mtBuscar;
        private MetroFramework.Controls.MetroGrid mgResultados;
        private MetroFramework.Controls.MetroTile mtOK;
    }
}
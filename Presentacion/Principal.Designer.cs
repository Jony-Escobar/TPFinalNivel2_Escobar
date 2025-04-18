﻿namespace Presentacion
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCampo = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbCriterio = new MaterialSkin.Controls.MaterialComboBox();
            this.txtBuscar = new MaterialSkin.Controls.MaterialTextBox();
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.btnVerDetalle = new MaterialSkin.Controls.MaterialButton();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.btnEditar = new MaterialSkin.Controls.MaterialButton();
            this.gbGestion = new System.Windows.Forms.GroupBox();
            this.gbBusquedaAvanzada = new System.Windows.Forms.GroupBox();
            this.gbBusquedaRapida = new System.Windows.Forms.GroupBox();
            this.txtBusquedaRapida = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.gbGestion.SuspendLayout();
            this.gbBusquedaAvanzada.SuspendLayout();
            this.gbBusquedaRapida.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvArticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Marca,
            this.Categoria,
            this.Precio});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvArticulos.Location = new System.Drawing.Point(4, 150);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.RowHeadersWidth = 62;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dgvArticulos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvArticulos.RowTemplate.Height = 40;
            this.dgvArticulos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(563, 373);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Codigo.DataPropertyName = "Codigo";
            dataGridViewCellStyle2.NullValue = "True";
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Codigo.FillWeight = 103.2728F;
            this.Codigo.HeaderText = "Código";
            this.Codigo.MaxInputLength = 50;
            this.Codigo.MinimumWidth = 40;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 65;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            dataGridViewCellStyle3.NullValue = "True";
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nombre.FillWeight = 108.7094F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MaxInputLength = 50;
            this.Nombre.MinimumWidth = 50;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Marca.DataPropertyName = "Marca";
            dataGridViewCellStyle4.NullValue = "True";
            this.Marca.DefaultCellStyle = dataGridViewCellStyle4;
            this.Marca.FillWeight = 126.9036F;
            this.Marca.HeaderText = "Marca";
            this.Marca.MaxInputLength = 50;
            this.Marca.MinimumWidth = 50;
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 50;
            // 
            // Categoria
            // 
            this.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Categoria.DataPropertyName = "Categoria";
            dataGridViewCellStyle5.NullValue = "True";
            this.Categoria.DefaultCellStyle = dataGridViewCellStyle5;
            this.Categoria.FillWeight = 69.66585F;
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.MaxInputLength = 50;
            this.Categoria.MinimumWidth = 50;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 50;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = "True";
            this.Precio.DefaultCellStyle = dataGridViewCellStyle6;
            this.Precio.FillWeight = 91.44859F;
            this.Precio.HeaderText = "Precio";
            this.Precio.MaxInputLength = 10;
            this.Precio.MinimumWidth = 50;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 50;
            // 
            // cmbCampo
            // 
            this.cmbCampo.AutoResize = false;
            this.cmbCampo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCampo.Depth = 0;
            this.cmbCampo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCampo.DropDownHeight = 174;
            this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampo.DropDownWidth = 121;
            this.cmbCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCampo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Hint = "Campo";
            this.cmbCampo.IntegralHeight = false;
            this.cmbCampo.ItemHeight = 43;
            this.cmbCampo.Location = new System.Drawing.Point(5, 18);
            this.cmbCampo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCampo.MaxDropDownItems = 4;
            this.cmbCampo.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(139, 49);
            this.cmbCampo.StartIndex = 0;
            this.cmbCampo.TabIndex = 1;
            this.cmbCampo.SelectedIndexChanged += new System.EventHandler(this.cmbCampo_SelectedIndexChanged);
            // 
            // cmbCriterio
            // 
            this.cmbCriterio.AutoResize = false;
            this.cmbCriterio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCriterio.Depth = 0;
            this.cmbCriterio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCriterio.DropDownHeight = 174;
            this.cmbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriterio.DropDownWidth = 121;
            this.cmbCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCriterio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCriterio.FormattingEnabled = true;
            this.cmbCriterio.Hint = "Criterio";
            this.cmbCriterio.IntegralHeight = false;
            this.cmbCriterio.ItemHeight = 43;
            this.cmbCriterio.Location = new System.Drawing.Point(164, 18);
            this.cmbCriterio.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCriterio.MaxDropDownItems = 4;
            this.cmbCriterio.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCriterio.Name = "cmbCriterio";
            this.cmbCriterio.Size = new System.Drawing.Size(132, 49);
            this.cmbCriterio.StartIndex = 0;
            this.cmbCriterio.TabIndex = 2;
            // 
            // txtBuscar
            // 
            this.txtBuscar.AnimateReadOnly = false;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar.Hint = "Buscar";
            this.txtBuscar.LeadingIcon = null;
            this.txtBuscar.Location = new System.Drawing.Point(317, 17);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.MaxLength = 50;
            this.txtBuscar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(124, 50);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.Text = "";
            this.txtBuscar.TrailingIcon = null;
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = false;
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Icon")));
            this.btnBuscar.Location = new System.Drawing.Point(455, 16);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscar.Size = new System.Drawing.Size(102, 50);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar.UseAccentColor = false;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.AutoSize = false;
            this.btnVerDetalle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerDetalle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVerDetalle.Depth = 0;
            this.btnVerDetalle.HighEmphasis = true;
            this.btnVerDetalle.Icon = ((System.Drawing.Image)(resources.GetObject("btnVerDetalle.Icon")));
            this.btnVerDetalle.Location = new System.Drawing.Point(623, 22);
            this.btnVerDetalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVerDetalle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVerDetalle.Size = new System.Drawing.Size(109, 38);
            this.btnVerDetalle.TabIndex = 7;
            this.btnVerDetalle.Text = "Ver Detalle";
            this.btnVerDetalle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVerDetalle.UseAccentColor = false;
            this.btnVerDetalle.UseVisualStyleBackColor = true;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(572, 150);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(223, 373);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArticulo.TabIndex = 9;
            this.pbxArticulo.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = false;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Icon")));
            this.btnAgregar.Location = new System.Drawing.Point(6, 22);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(109, 38);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = false;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = false;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.HighEmphasis = true;
            this.btnEliminar.Icon = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Icon")));
            this.btnEliminar.Location = new System.Drawing.Point(417, 22);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminar.Size = new System.Drawing.Size(109, 38);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminar.UseAccentColor = false;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSize = false;
            this.btnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditar.Depth = 0;
            this.btnEditar.HighEmphasis = true;
            this.btnEditar.Icon = ((System.Drawing.Image)(resources.GetObject("btnEditar.Icon")));
            this.btnEditar.Location = new System.Drawing.Point(219, 22);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditar.Size = new System.Drawing.Size(109, 38);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditar.UseAccentColor = false;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // gbGestion
            // 
            this.gbGestion.BackColor = System.Drawing.Color.White;
            this.gbGestion.Controls.Add(this.btnAgregar);
            this.gbGestion.Controls.Add(this.btnEliminar);
            this.gbGestion.Controls.Add(this.btnEditar);
            this.gbGestion.Controls.Add(this.btnVerDetalle);
            this.gbGestion.ForeColor = System.Drawing.Color.SlateBlue;
            this.gbGestion.Location = new System.Drawing.Point(4, 528);
            this.gbGestion.Name = "gbGestion";
            this.gbGestion.Size = new System.Drawing.Size(791, 67);
            this.gbGestion.TabIndex = 10;
            this.gbGestion.TabStop = false;
            this.gbGestion.Text = "Gestionar Artículos";
            // 
            // gbBusquedaAvanzada
            // 
            this.gbBusquedaAvanzada.Controls.Add(this.cmbCampo);
            this.gbBusquedaAvanzada.Controls.Add(this.cmbCriterio);
            this.gbBusquedaAvanzada.Controls.Add(this.txtBuscar);
            this.gbBusquedaAvanzada.Controls.Add(this.btnBuscar);
            this.gbBusquedaAvanzada.ForeColor = System.Drawing.Color.SlateBlue;
            this.gbBusquedaAvanzada.Location = new System.Drawing.Point(4, 73);
            this.gbBusquedaAvanzada.Name = "gbBusquedaAvanzada";
            this.gbBusquedaAvanzada.Size = new System.Drawing.Size(563, 72);
            this.gbBusquedaAvanzada.TabIndex = 11;
            this.gbBusquedaAvanzada.TabStop = false;
            this.gbBusquedaAvanzada.Text = "Búsqueda Avanzada";
            // 
            // gbBusquedaRapida
            // 
            this.gbBusquedaRapida.Controls.Add(this.txtBusquedaRapida);
            this.gbBusquedaRapida.ForeColor = System.Drawing.Color.SlateBlue;
            this.gbBusquedaRapida.Location = new System.Drawing.Point(584, 73);
            this.gbBusquedaRapida.Name = "gbBusquedaRapida";
            this.gbBusquedaRapida.Size = new System.Drawing.Size(211, 72);
            this.gbBusquedaRapida.TabIndex = 12;
            this.gbBusquedaRapida.TabStop = false;
            this.gbBusquedaRapida.Text = "Búsqueda rápida";
            // 
            // txtBusquedaRapida
            // 
            this.txtBusquedaRapida.AnimateReadOnly = false;
            this.txtBusquedaRapida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusquedaRapida.Depth = 0;
            this.txtBusquedaRapida.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBusquedaRapida.Hint = "Buscar";
            this.txtBusquedaRapida.LeadingIcon = null;
            this.txtBusquedaRapida.Location = new System.Drawing.Point(5, 16);
            this.txtBusquedaRapida.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusquedaRapida.MaxLength = 50;
            this.txtBusquedaRapida.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBusquedaRapida.Multiline = false;
            this.txtBusquedaRapida.Name = "txtBusquedaRapida";
            this.txtBusquedaRapida.Size = new System.Drawing.Size(201, 50);
            this.txtBusquedaRapida.TabIndex = 4;
            this.txtBusquedaRapida.Text = "";
            this.txtBusquedaRapida.TrailingIcon = null;
            this.txtBusquedaRapida.TextChanged += new System.EventHandler(this.txtBusquedaRapida_TextChanged);
            this.txtBusquedaRapida.Enter += new System.EventHandler(this.txtBusquedaRapida_Enter);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.gbBusquedaRapida);
            this.Controls.Add(this.gbBusquedaAvanzada);
            this.Controls.Add(this.gbGestion);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Principal";
            this.Padding = new System.Windows.Forms.Padding(2, 42, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de Artículos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.gbGestion.ResumeLayout(false);
            this.gbBusquedaAvanzada.ResumeLayout(false);
            this.gbBusquedaRapida.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private MaterialSkin.Controls.MaterialComboBox cmbCampo;
        private MaterialSkin.Controls.MaterialComboBox cmbCriterio;
        private MaterialSkin.Controls.MaterialTextBox txtBuscar;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
        private MaterialSkin.Controls.MaterialButton btnVerDetalle;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialButton btnEditar;
        private System.Windows.Forms.GroupBox gbGestion;
        private System.Windows.Forms.GroupBox gbBusquedaAvanzada;
        private System.Windows.Forms.GroupBox gbBusquedaRapida;
        private MaterialSkin.Controls.MaterialTextBox txtBusquedaRapida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}


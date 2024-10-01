/*
 * Creado por SharpDevelop.
 * Usuario: JUANES
 * Fecha: 17/09/2024
 * Hora: 4:27 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace RegistroUsuario
{
	partial class FrmUsuario
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TxtId;
		private System.Windows.Forms.TextBox TxtUsuario;
		private System.Windows.Forms.TextBox TxtContraseña;
		private System.Windows.Forms.Button BtnNuevo;
		private System.Windows.Forms.Button BtnGuardar;
		private System.Windows.Forms.Button BtnCancelar;
		private System.Windows.Forms.Button BtnEditar;
		private System.Windows.Forms.DataGridView DgvUsuario;
		private System.Windows.Forms.Button BtnSalir;
		private System.Windows.Forms.Button BtnEliminar;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.TxtId = new System.Windows.Forms.TextBox();
			this.TxtUsuario = new System.Windows.Forms.TextBox();
			this.TxtContraseña = new System.Windows.Forms.TextBox();
			this.BtnNuevo = new System.Windows.Forms.Button();
			this.BtnGuardar = new System.Windows.Forms.Button();
			this.BtnCancelar = new System.Windows.Forms.Button();
			this.BtnSalir = new System.Windows.Forms.Button();
			this.BtnEliminar = new System.Windows.Forms.Button();
			this.BtnEditar = new System.Windows.Forms.Button();
			this.DgvUsuario = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.DgvUsuario)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(36, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(36, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Usuario";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(36, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Contraseña";
			// 
			// TxtId
			// 
			this.TxtId.Enabled = false;
			this.TxtId.Location = new System.Drawing.Point(117, 27);
			this.TxtId.Name = "TxtId";
			this.TxtId.Size = new System.Drawing.Size(169, 20);
			this.TxtId.TabIndex = 3;
			// 
			// TxtUsuario
			// 
			this.TxtUsuario.Enabled = false;
			this.TxtUsuario.Location = new System.Drawing.Point(117, 67);
			this.TxtUsuario.Name = "TxtUsuario";
			this.TxtUsuario.Size = new System.Drawing.Size(169, 20);
			this.TxtUsuario.TabIndex = 4;
			// 
			// TxtContraseña
			// 
			this.TxtContraseña.Enabled = false;
			this.TxtContraseña.Location = new System.Drawing.Point(117, 107);
			this.TxtContraseña.Name = "TxtContraseña";
			this.TxtContraseña.Size = new System.Drawing.Size(169, 20);
			this.TxtContraseña.TabIndex = 5;
			// 
			// BtnNuevo
			// 
			this.BtnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.BackgroundImage")));
			this.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnNuevo.Location = new System.Drawing.Point(2, 151);
			this.BtnNuevo.Name = "BtnNuevo";
			this.BtnNuevo.Size = new System.Drawing.Size(85, 38);
			this.BtnNuevo.TabIndex = 6;
			this.BtnNuevo.Text = "Nuevo";
			this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.BtnNuevo.UseVisualStyleBackColor = true;
			this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
			// 
			// BtnGuardar
			// 
			this.BtnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.BackgroundImage")));
			this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.BtnGuardar.Enabled = false;
			this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnGuardar.Location = new System.Drawing.Point(93, 151);
			this.BtnGuardar.Name = "BtnGuardar";
			this.BtnGuardar.Size = new System.Drawing.Size(89, 38);
			this.BtnGuardar.TabIndex = 7;
			this.BtnGuardar.Text = "Guardar";
			this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.BtnGuardar.UseVisualStyleBackColor = true;
			this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// BtnCancelar
			// 
			this.BtnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.BackgroundImage")));
			this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.BtnCancelar.Enabled = false;
			this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnCancelar.Location = new System.Drawing.Point(188, 151);
			this.BtnCancelar.Name = "BtnCancelar";
			this.BtnCancelar.Size = new System.Drawing.Size(86, 38);
			this.BtnCancelar.TabIndex = 8;
			this.BtnCancelar.Text = "Cancelar";
			this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.BtnCancelar.UseVisualStyleBackColor = true;
			this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// BtnSalir
			// 
			this.BtnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSalir.BackgroundImage")));
			this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnSalir.Location = new System.Drawing.Point(461, 151);
			this.BtnSalir.Name = "BtnSalir";
			this.BtnSalir.Size = new System.Drawing.Size(75, 38);
			this.BtnSalir.TabIndex = 9;
			this.BtnSalir.Text = "Salir";
			this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.BtnSalir.UseVisualStyleBackColor = true;
			this.BtnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// BtnEliminar
			// 
			this.BtnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.BackgroundImage")));
			this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnEliminar.Location = new System.Drawing.Point(361, 151);
			this.BtnEliminar.Name = "BtnEliminar";
			this.BtnEliminar.Size = new System.Drawing.Size(83, 38);
			this.BtnEliminar.TabIndex = 10;
			this.BtnEliminar.Text = "Eliminar";
			this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.BtnEliminar.UseVisualStyleBackColor = true;
			this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// BtnEditar
			// 
			this.BtnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEditar.BackgroundImage")));
			this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnEditar.Location = new System.Drawing.Point(280, 154);
			this.BtnEditar.Name = "BtnEditar";
			this.BtnEditar.Size = new System.Drawing.Size(75, 35);
			this.BtnEditar.TabIndex = 11;
			this.BtnEditar.Text = "Editar";
			this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.BtnEditar.UseVisualStyleBackColor = true;
			this.BtnEditar.Click += new System.EventHandler(this.BtnEditarClick);
			// 
			// DgvUsuario
			// 
			this.DgvUsuario.AllowUserToAddRows = false;
			this.DgvUsuario.AllowUserToDeleteRows = false;
			this.DgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.ID,
			this.Usuario,
			this.Contraseña});
			this.DgvUsuario.Location = new System.Drawing.Point(26, 221);
			this.DgvUsuario.Name = "DgvUsuario";
			this.DgvUsuario.ReadOnly = true;
			this.DgvUsuario.Size = new System.Drawing.Size(510, 211);
			this.DgvUsuario.TabIndex = 12;
			this.DgvUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuarioCellDoubleClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			// 
			// Usuario
			// 
			this.Usuario.HeaderText = "Usuario";
			this.Usuario.Name = "Usuario";
			this.Usuario.ReadOnly = true;
			// 
			// Contraseña
			// 
			this.Contraseña.HeaderText = "Contraseña";
			this.Contraseña.Name = "Contraseña";
			this.Contraseña.ReadOnly = true;
			// 
			// FrmUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(563, 444);
			this.ControlBox = false;
			this.Controls.Add(this.DgvUsuario);
			this.Controls.Add(this.BtnEditar);
			this.Controls.Add(this.BtnEliminar);
			this.Controls.Add(this.BtnSalir);
			this.Controls.Add(this.BtnCancelar);
			this.Controls.Add(this.BtnGuardar);
			this.Controls.Add(this.BtnNuevo);
			this.Controls.Add(this.TxtContraseña);
			this.Controls.Add(this.TxtUsuario);
			this.Controls.Add(this.TxtId);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gestion Usuarios";
			this.Load += new System.EventHandler(this.FrmUsuarioLoad);
			((System.ComponentModel.ISupportInitialize)(this.DgvUsuario)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

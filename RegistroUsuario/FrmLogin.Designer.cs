/*
 * Creado por SharpDevelop.
 * Usuario: JUANES
 * Fecha: 17/09/2024
 * Hora: 4:22 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace RegistroUsuario
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button BtnIniciar;
		private System.Windows.Forms.Button BtnSalir;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox TxtUsuario;
		private System.Windows.Forms.TextBox TxtContraseña;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.BtnIniciar = new System.Windows.Forms.Button();
			this.BtnSalir = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.TxtUsuario = new System.Windows.Forms.TextBox();
			this.TxtContraseña = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnIniciar
			// 
			this.BtnIniciar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BtnIniciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnIniciar.BackgroundImage")));
			this.BtnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.BtnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnIniciar.Location = new System.Drawing.Point(169, 158);
			this.BtnIniciar.Name = "BtnIniciar";
			this.BtnIniciar.Size = new System.Drawing.Size(80, 42);
			this.BtnIniciar.TabIndex = 0;
			this.BtnIniciar.Text = "Iniciar";
			this.BtnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.BtnIniciar.UseVisualStyleBackColor = false;
			this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciarClick);
			// 
			// BtnSalir
			// 
			this.BtnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSalir.BackgroundImage")));
			this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnSalir.Location = new System.Drawing.Point(276, 158);
			this.BtnSalir.Name = "BtnSalir";
			this.BtnSalir.Size = new System.Drawing.Size(75, 42);
			this.BtnSalir.TabIndex = 1;
			this.BtnSalir.Text = "Salir";
			this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.BtnSalir.UseVisualStyleBackColor = true;
			this.BtnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(169, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Usuario";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(169, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Contraseña";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 43);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(128, 128);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// TxtUsuario
			// 
			this.TxtUsuario.Location = new System.Drawing.Point(251, 46);
			this.TxtUsuario.MaxLength = 20;
			this.TxtUsuario.Name = "TxtUsuario";
			this.TxtUsuario.Size = new System.Drawing.Size(117, 20);
			this.TxtUsuario.TabIndex = 5;
			// 
			// TxtContraseña
			// 
			this.TxtContraseña.Location = new System.Drawing.Point(251, 112);
			this.TxtContraseña.MaxLength = 20;
			this.TxtContraseña.Name = "TxtContraseña";
			this.TxtContraseña.PasswordChar = '*';
			this.TxtContraseña.Size = new System.Drawing.Size(117, 20);
			this.TxtContraseña.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 227);
			this.ControlBox = false;
			this.Controls.Add(this.TxtContraseña);
			this.Controls.Add(this.TxtUsuario);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BtnSalir);
			this.Controls.Add(this.BtnIniciar);
			this.Name = "MainForm";
			this.Text = "RegistroUsuario";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

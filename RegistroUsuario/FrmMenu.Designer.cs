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
	partial class FrmMenu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem crearUsuarioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem buscarUsuarioToolStripMenuItem;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.crearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buscarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.archivoToolStripMenuItem,
			this.usuariosToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(412, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.salirToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.BackgroundImage")));
			this.salirToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.salirToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// usuariosToolStripMenuItem
			// 
			this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.crearUsuarioToolStripMenuItem,
			this.buscarUsuarioToolStripMenuItem});
			this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
			this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.usuariosToolStripMenuItem.Text = "Usuarios";
			// 
			// crearUsuarioToolStripMenuItem
			// 
			this.crearUsuarioToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("crearUsuarioToolStripMenuItem.BackgroundImage")));
			this.crearUsuarioToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
			this.crearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.crearUsuarioToolStripMenuItem.Text = "Crear Usuario";
			this.crearUsuarioToolStripMenuItem.Click += new System.EventHandler(this.CrearUsuarioToolStripMenuItemClick);
			// 
			// buscarUsuarioToolStripMenuItem
			// 
			this.buscarUsuarioToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buscarUsuarioToolStripMenuItem.BackgroundImage")));
			this.buscarUsuarioToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buscarUsuarioToolStripMenuItem.Name = "buscarUsuarioToolStripMenuItem";
			this.buscarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.buscarUsuarioToolStripMenuItem.Text = "Buscar Usuario";
			// 
			// FrmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(412, 261);
			this.ControlBox = false;
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Menu";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

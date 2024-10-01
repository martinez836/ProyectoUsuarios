/*
 * Creado por SharpDevelop.
 * Usuario: JUANES
 * Fecha: 17/09/2024
 * Hora: 4:27 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RegistroUsuario
{
	/// <summary>
	/// Description of FrmMenu.
	/// </summary>
	public partial class FrmMenu : Form
	{
		public FrmMenu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void CrearUsuarioToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmUsuario frm = new FrmUsuario();
			frm.ShowDialog();
		}
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			DialogResult rpta = new DialogResult();
			rpta = MessageBox.Show("Desea salir ?","Pregunta",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
			if (rpta== DialogResult.OK) 
			{
				Application.Exit();
			}
				
		}
	}
}

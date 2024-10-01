/*
 * Creado por SharpDevelop.
 * Usuario: JUANES
 * Fecha: 17/09/2024
 * Hora: 4:22 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RegistroUsuario
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnIniciarClick(object sender, EventArgs e)
		{
			//valido si la persona ingresa los datos
			
			
			//valido si el archivo existe
			
			if (ClaseUsuarios.Func_Existe()==true)
			{
				if (TxtUsuario.Text.Trim().Length>0 && TxtContraseña.Text.Trim().Length>0) 
			{
				string[] arre = ClaseUsuarios.Func_DatosUsuario(TxtUsuario.Text);
				//pregunto si el usuario es igual
				if (TxtUsuario.Text==arre[0]) 
				{
				if (TxtContraseña.Text==arre[1]) 
				{
					//oculto el formulario
					this.Hide();
					// creo una instancia del formulario que voy a llamar
			
					FrmMenu frm = new FrmMenu();
					//muestro el formulario
					frm.ShowDialog();	
				}
				else
				{
					MessageBox.Show("Contraseña Errada","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Usuario no existe","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			}
			else
			{
				MessageBox.Show("Ingrese los datos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			}
			else
			{
				MessageBox.Show("Archivo TXT no existe","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
			
			
			
			
			
			
		}
		void BtnSalirClick(object sender, EventArgs e)
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

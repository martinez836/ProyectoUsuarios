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
using System.IO;

namespace RegistroUsuario
{
	/// <summary>
	/// Description of FrmUsuario.
	/// </summary>
	public partial class FrmUsuario : Form
	{
		public FrmUsuario()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnSalirClick(object sender, EventArgs e)
		{
			DialogResult rpta = new DialogResult();
			rpta = MessageBox.Show("Desea salir ?","Pregunta",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
			if (rpta== DialogResult.OK) 
			{
				//cerrar el formulario
				this.Close();
			}
			
		}
		void BtnNuevoClick(object sender, EventArgs e)
		{
			//habilita 
			TxtId.Enabled=true;
			TxtContraseña.Enabled=true;
			TxtUsuario.Enabled=true;
			BtnGuardar.Enabled=true;
			BtnCancelar.Enabled=true;
			//deshabilita
			BtnNuevo.Enabled=false;
			BtnEditar.Enabled=false;
			BtnEliminar.Enabled=false;
			BtnSalir.Enabled=false;
		}
		void BtnCancelarClick(object sender, EventArgs e)
		{
			//deshabilita 
			TxtId.Enabled=false;
			TxtContraseña.Enabled=false;
			TxtUsuario.Enabled=false;
			BtnGuardar.Enabled=false;
			BtnGuardar.Enabled=false;
			//habilita
			BtnNuevo.Enabled=true;
			BtnEditar.Enabled=true;
			BtnEliminar.Enabled=true;
			BtnSalir.Enabled=true;
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			
			string id = TxtId.Text;
			string usuario = TxtUsuario.Text;
			string contraseña = TxtContraseña.Text;
			
			
			
			DgvUsuario.Rows.Add(id,usuario,contraseña);
			
			using (StreamWriter guardar = new StreamWriter(ClaseUsuarios.ruta,true)) 
			{
				guardar.WriteLine(id + "," + usuario + "," + contraseña);
			}
			
			
			
			
			//deshabilita 
			TxtId.Enabled=false;
			TxtContraseña.Enabled=false;
			TxtUsuario.Enabled=false;
			BtnGuardar.Enabled=false;
			BtnGuardar.Enabled=false;
			//habilita
			BtnNuevo.Enabled=true;
			BtnEditar.Enabled=true;
			BtnEliminar.Enabled=true;
			BtnSalir.Enabled=true;
			
			
			MessageBox.Show("Usuario guardado exitosamente");
		}
		void FrmUsuarioLoad(object sender, EventArgs e)
		{
			string[] arreglo = ClaseUsuarios.Func_LeerArchivo();
			
			for (int i = 0; i < arreglo.Length; i++) 
    		{
        
        		string linea = arreglo[i].Trim();
        		if (string.IsNullOrWhiteSpace(linea))
        		{
            		continue; 
        		}

        
        		string[] usuario = linea.Split(',');

        
        		if (usuario.Length >= 3)
        		{
           		 	DgvUsuario.Rows.Insert(i, usuario[0], usuario[1], usuario[2]);
        		}
        		else
        		{
            		MessageBox.Show("Línea con formato incorrecto: " + linea);
        		}
    		}
		}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			
			DialogResult rpta = new DialogResult();
			rpta = MessageBox.Show("Desea eliminar el usuario?","Pregunta",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if (rpta== DialogResult.Yes) 
			{
				if (DgvUsuario.SelectedRows.Count > 0) 
				{
					string id = DgvUsuario.SelectedRows[0].Cells[0].Value.ToString();	
					
					if (ClaseUsuarios.Func_EliminarUsuario(id)) 
					{
						DgvUsuario.Rows.RemoveAt(DgvUsuario.SelectedRows[0].Index);

        				MessageBox.Show("Usuario eliminado correctamente");	
					}
					
					
				}
			}
			
			
		}	
			
	}
}



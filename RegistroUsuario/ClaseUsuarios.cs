/*
 * Creado por SharpDevelop.
 * Usuario: JUANES
 * Fecha: 19/09/2024
 * Hora: 12:51 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Windows.Forms;
using System.IO;

namespace RegistroUsuario
{
	/// <summary>
	/// Description of ClaseUsuarios.
	/// </summary>
	public class ClaseUsuarios
	{
		public static string ruta = Application.StartupPath + @"\..\..\Usuario.txt";
			
		public static bool Func_Existe()
			{
				if (File.Exists(ruta)) 
				{
					return true	;
				}
				else
				{
					return false;
				}
				
			}
		public static string[] Func_LeerArchivo()
		{
			
			string[] linea = File.ReadAllLines(ruta);
			return linea;
		}
		public static bool Func_EscribirArchivo(string[] arreglo)
		{
			
		    File.WriteAllLines(ruta,arreglo);
			return true;
		}
		
		
		public static string[] Func_DatosUsuario(string user)
		{
			string[] usuario = null;
			string[] retorno = new string[2];
			string[] linea = Func_LeerArchivo();
			//recorro todas las lineas del txt
			for (int i = 0; i < linea.Length; i++) 
			{
				//split con comas
				usuario=linea[i].Split(',');
				//0 id 1 usuario 2 contraseña
				if (usuario[1]==user)
				{
					//retorno usuario y contraseña
					retorno[0]=user;
					retorno[1]=usuario[2];
					break;
				}	
			}
			
			return retorno;
		}
		public static bool Func_EliminarUsuario(string id)
		{
			string[] usuarios = ClaseUsuarios.Func_LeerArchivo();
			using (StreamWriter escribir = new StreamWriter(ClaseUsuarios.ruta,false)) 
			{
				foreach (string usuario in usuarios) 
				{
					string[] datos = usuario.Split(',');
						
					if (datos[0] !=id) 
					{
						escribir.WriteLine(usuario);
					}
				}
			}
			
			return true;
		}
		
		//Busca un id en el archivo de texto
		//parametro id
		//retorna true si son iguales
		
		public static bool Func_BuscarIdExiste(string id)
		{
			bool rpta = false;
			string[] usuario = null;
			string[] linea = Func_LeerArchivo();
			//recorro todas las lineas del txt
			for (int i = 0; i < linea.Length; i++) 
			{
				//split con comas
				usuario=linea[i].Split(',');
				//0 id 1 usuario 2 contraseña
				if (usuario[0]==id)
				{
					//retorno true
					rpta = true;
					break;
				}	
			}
			
			return rpta;
		}
		
		public static string[] Func_EditarUsuario(string id, string user,string contraseña)
		{
			string[] usuario = null;
			string[] linea = Func_LeerArchivo();
			//recorro todas las lineas del txt
			for (int i = 0; i < linea.Length; i++) 
			{
				//split con comas
				usuario=linea[i].Split(',');
				//0 id 1 usuario 2 contraseña
				if (usuario[0]==id)
				{
					//quito la linea y agrego la nueva
					linea[i]=id+","+user+","+contraseña;
					break;
					
				}	
			}
			
			return linea;
		}
	}
}

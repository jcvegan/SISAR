using System;

namespace SISAR.Entidades
{
	public class T_Local
	{
		#region Fields

		private int id_Local;
		private string nombre;
		private string direccion;
		private int telefono;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_Local class.
		/// </summary>
		public T_Local()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_Local class.
		/// </summary>
		public T_Local(string nombre, string direccion, int telefono)
		{
			this.nombre = nombre;
			this.direccion = direccion;
			this.telefono = telefono;
		}

		/// <summary>
		/// Initializes a new instance of the T_Local class.
		/// </summary>
		public T_Local(int id_Local, string nombre, string direccion, int telefono)
		{
			this.id_Local = id_Local;
			this.nombre = nombre;
			this.direccion = direccion;
			this.telefono = telefono;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Local value.
		/// </summary>
		public virtual int Id_Local
		{
			get { return id_Local; }
			set { id_Local = value; }
		}

		/// <summary>
		/// Gets or sets the Nombre value.
		/// </summary>
		public virtual string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		/// <summary>
		/// Gets or sets the Direccion value.
		/// </summary>
		public virtual string Direccion
		{
			get { return direccion; }
			set { direccion = value; }
		}

		/// <summary>
		/// Gets or sets the Telefono value.
		/// </summary>
		public virtual int Telefono
		{
			get { return telefono; }
			set { telefono = value; }
		}

		#endregion
	}
}

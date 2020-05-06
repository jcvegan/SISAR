using System;

namespace SISAR.Entidades
{
	public class T_Distribucion
	{
		#region Fields

		private int id_Distribucion;
		private string nombre;
		private string descripcion;
		private int id_Zona;
		private bool estado;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_Distribucion class.
		/// </summary>
		public T_Distribucion()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_Distribucion class.
		/// </summary>
		public T_Distribucion(string nombre, string descripcion, int id_Zona, bool estado)
		{
			this.nombre = nombre;
			this.descripcion = descripcion;
			this.id_Zona = id_Zona;
			this.estado = estado;
		}

		/// <summary>
		/// Initializes a new instance of the T_Distribucion class.
		/// </summary>
		public T_Distribucion(int id_Distribucion, string nombre, string descripcion, int id_Zona, bool estado)
		{
			this.id_Distribucion = id_Distribucion;
			this.nombre = nombre;
			this.descripcion = descripcion;
			this.id_Zona = id_Zona;
			this.estado = estado;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Distribucion value.
		/// </summary>
		public virtual int Id_Distribucion
		{
			get { return id_Distribucion; }
			set { id_Distribucion = value; }
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
		/// Gets or sets the Descripcion value.
		/// </summary>
		public virtual string Descripcion
		{
			get { return descripcion; }
			set { descripcion = value; }
		}

		/// <summary>
		/// Gets or sets the Id_Zona value.
		/// </summary>
		public virtual int Id_Zona
		{
			get { return id_Zona; }
			set { id_Zona = value; }
		}

		/// <summary>
		/// Gets or sets the Estado value.
		/// </summary>
		public virtual bool Estado
		{
			get { return estado; }
			set { estado = value; }
		}

		#endregion
	}
}

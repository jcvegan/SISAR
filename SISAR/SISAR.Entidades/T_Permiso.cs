using System;

namespace SISAR.Entidades
{
	public class T_Permiso
	{
		#region Fields

		private int id_Permiso;
		private string permiso;
		private string paquete;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_Permiso class.
		/// </summary>
		public T_Permiso()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_Permiso class.
		/// </summary>
		public T_Permiso(string permiso, string paquete)
		{
			this.permiso = permiso;
			this.paquete = paquete;
		}

		/// <summary>
		/// Initializes a new instance of the T_Permiso class.
		/// </summary>
		public T_Permiso(int id_Permiso, string permiso, string paquete)
		{
			this.id_Permiso = id_Permiso;
			this.permiso = permiso;
			this.paquete = paquete;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Permiso value.
		/// </summary>
		public virtual int Id_Permiso
		{
			get { return id_Permiso; }
			set { id_Permiso = value; }
		}

		/// <summary>
		/// Gets or sets the Permiso value.
		/// </summary>
		public virtual string Permiso
		{
			get { return permiso; }
			set { permiso = value; }
		}

		/// <summary>
		/// Gets or sets the Paquete value.
		/// </summary>
		public virtual string Paquete
		{
			get { return paquete; }
			set { paquete = value; }
		}

		#endregion
	}
}

using System;

namespace SISAR.Entidades
{
	public class T_Detalle_Menu
	{
		#region Fields

		private int id_Producto;
		private int id_Menu;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_Detalle_Menu class.
		/// </summary>
		public T_Detalle_Menu()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_Detalle_Menu class.
		/// </summary>
		public T_Detalle_Menu(int id_Producto, int id_Menu)
		{
			this.id_Producto = id_Producto;
			this.id_Menu = id_Menu;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Producto value.
		/// </summary>
		public virtual int Id_Producto
		{
			get { return id_Producto; }
			set { id_Producto = value; }
		}

		/// <summary>
		/// Gets or sets the Id_Menu value.
		/// </summary>
		public virtual int Id_Menu
		{
			get { return id_Menu; }
			set { id_Menu = value; }
		}

		#endregion
	}
}

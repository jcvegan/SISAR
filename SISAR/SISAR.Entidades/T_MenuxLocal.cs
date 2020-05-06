using System;

namespace SISAR.Entidades
{
	public class T_MenuxLocal
	{
		#region Fields

		private int id_Local;
		private int id_Menu;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_MenuxLocal class.
		/// </summary>
		public T_MenuxLocal()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_MenuxLocal class.
		/// </summary>
		public T_MenuxLocal(int id_Local, int id_Menu)
		{
			this.id_Local = id_Local;
			this.id_Menu = id_Menu;
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

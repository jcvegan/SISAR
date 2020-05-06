using System;

namespace SISAR.Entidades
{
	public class T_ProductoxLocal
	{
		#region Fields

		private int id_Local;
		private int id_Producto;
		private string estado;
		private int stock;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_ProductoxLocal class.
		/// </summary>
		public T_ProductoxLocal()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_ProductoxLocal class.
		/// </summary>
		public T_ProductoxLocal(int id_Local, int id_Producto, string estado, int stock)
		{
			this.id_Local = id_Local;
			this.id_Producto = id_Producto;
			this.estado = estado;
			this.stock = stock;
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
		/// Gets or sets the Id_Producto value.
		/// </summary>
		public virtual int Id_Producto
		{
			get { return id_Producto; }
			set { id_Producto = value; }
		}

		/// <summary>
		/// Gets or sets the Estado value.
		/// </summary>
		public virtual string Estado
		{
			get { return estado; }
			set { estado = value; }
		}

		/// <summary>
		/// Gets or sets the Stock value.
		/// </summary>
		public virtual int Stock
		{
			get { return stock; }
			set { stock = value; }
		}

		#endregion
	}
}

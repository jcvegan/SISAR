using System;

namespace SISAR.Entidades
{
	public class T_Detalle_Movimiento_Caja
	{
		#region Fields

		private int id_Detalle_Movimiento_Caja;
		private int cantidad;
		private decimal subTotal;
		private int id_Producto;
		private int id_Movimiento_Caja;
		private string tipo_Producto;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_Detalle_Movimiento_Caja class.
		/// </summary>
		public T_Detalle_Movimiento_Caja()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_Detalle_Movimiento_Caja class.
		/// </summary>
		public T_Detalle_Movimiento_Caja(int cantidad, decimal subTotal, int id_Producto, int id_Movimiento_Caja, string tipo_Producto)
		{
			this.cantidad = cantidad;
			this.subTotal = subTotal;
			this.id_Producto = id_Producto;
			this.id_Movimiento_Caja = id_Movimiento_Caja;
			this.tipo_Producto = tipo_Producto;
		}

		/// <summary>
		/// Initializes a new instance of the T_Detalle_Movimiento_Caja class.
		/// </summary>
		public T_Detalle_Movimiento_Caja(int id_Detalle_Movimiento_Caja, int cantidad, decimal subTotal, int id_Producto, int id_Movimiento_Caja, string tipo_Producto)
		{
			this.id_Detalle_Movimiento_Caja = id_Detalle_Movimiento_Caja;
			this.cantidad = cantidad;
			this.subTotal = subTotal;
			this.id_Producto = id_Producto;
			this.id_Movimiento_Caja = id_Movimiento_Caja;
			this.tipo_Producto = tipo_Producto;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Detalle_Movimiento_Caja value.
		/// </summary>
		public virtual int Id_Detalle_Movimiento_Caja
		{
			get { return id_Detalle_Movimiento_Caja; }
			set { id_Detalle_Movimiento_Caja = value; }
		}

		/// <summary>
		/// Gets or sets the Cantidad value.
		/// </summary>
		public virtual int Cantidad
		{
			get { return cantidad; }
			set { cantidad = value; }
		}

		/// <summary>
		/// Gets or sets the SubTotal value.
		/// </summary>
		public virtual decimal SubTotal
		{
			get { return subTotal; }
			set { subTotal = value; }
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
		/// Gets or sets the Id_Movimiento_Caja value.
		/// </summary>
		public virtual int Id_Movimiento_Caja
		{
			get { return id_Movimiento_Caja; }
			set { id_Movimiento_Caja = value; }
		}

		/// <summary>
		/// Gets or sets the Tipo_Producto value.
		/// </summary>
		public virtual string Tipo_Producto
		{
			get { return tipo_Producto; }
			set { tipo_Producto = value; }
		}

		#endregion
	}
}

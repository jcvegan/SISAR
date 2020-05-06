using System;

namespace SISAR.Entidades
{
	public class T_Detalle_Pedido
	{
        #region Const

        public const string SOLICITADO = "SOLICITADO";
        public const string PREPARADO = "PREPARADO";
        public const string ATENDIDO = "ATENDIDO";
        public const string CANCELADO = "CANCELADO";

        #endregion

		#region Fields

		private int id_Detalle_Pedido;
		private string observacion;
		private int id_Producto;
		private int id_Pedido;
		private string estado;
		private int cantidad;
		private string tipo_Producto;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_Detalle_Pedido class.
		/// </summary>
		public T_Detalle_Pedido()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_Detalle_Pedido class.
		/// </summary>
		public T_Detalle_Pedido(string observacion, int id_Producto, int id_Pedido, string estado, int cantidad, string tipo_Producto)
		{
			this.observacion = observacion;
			this.id_Producto = id_Producto;
			this.id_Pedido = id_Pedido;
			this.estado = estado;
			this.cantidad = cantidad;
			this.tipo_Producto = tipo_Producto;
		}

		/// <summary>
		/// Initializes a new instance of the T_Detalle_Pedido class.
		/// </summary>
		public T_Detalle_Pedido(int id_Detalle_Pedido, string observacion, int id_Producto, int id_Pedido, string estado, int cantidad, string tipo_Producto)
		{
			this.id_Detalle_Pedido = id_Detalle_Pedido;
			this.observacion = observacion;
			this.id_Producto = id_Producto;
			this.id_Pedido = id_Pedido;
			this.estado = estado;
			this.cantidad = cantidad;
			this.tipo_Producto = tipo_Producto;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Detalle_Pedido value.
		/// </summary>
		public virtual int Id_Detalle_Pedido
		{
			get { return id_Detalle_Pedido; }
			set { id_Detalle_Pedido = value; }
		}

		/// <summary>
		/// Gets or sets the Observacion value.
		/// </summary>
		public virtual string Observacion
		{
			get { return observacion; }
			set { observacion = value; }
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
		/// Gets or sets the Id_Pedido value.
		/// </summary>
		public virtual int Id_Pedido
		{
			get { return id_Pedido; }
			set { id_Pedido = value; }
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
		/// Gets or sets the Cantidad value.
		/// </summary>
		public virtual int Cantidad
		{
			get { return cantidad; }
			set { cantidad = value; }
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

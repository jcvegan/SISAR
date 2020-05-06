using System;

namespace SISAR.Entidades
{
	public class T_Pedido
	{
		#region Fields

		private int id_Pedido;
		private string estado;
		private int id_Usuario;
		private int id_Codigo_Mesa;
		private DateTime fecha;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_Pedido class.
		/// </summary>
		public T_Pedido()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_Pedido class.
		/// </summary>
		public T_Pedido(string estado, int id_Usuario, int id_Codigo_Mesa, DateTime fecha)
		{
			this.estado = estado;
			this.id_Usuario = id_Usuario;
			this.id_Codigo_Mesa = id_Codigo_Mesa;
			this.fecha = fecha;
		}

		/// <summary>
		/// Initializes a new instance of the T_Pedido class.
		/// </summary>
		public T_Pedido(int id_Pedido, string estado, int id_Usuario, int id_Codigo_Mesa, DateTime fecha)
		{
			this.id_Pedido = id_Pedido;
			this.estado = estado;
			this.id_Usuario = id_Usuario;
			this.id_Codigo_Mesa = id_Codigo_Mesa;
			this.fecha = fecha;
		}

		#endregion

		#region Properties
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
		/// Gets or sets the Id_Usuario value.
		/// </summary>
		public virtual int Id_Usuario
		{
			get { return id_Usuario; }
			set { id_Usuario = value; }
		}

		/// <summary>
		/// Gets or sets the Id_Codigo_Mesa value.
		/// </summary>
		public virtual int Id_Codigo_Mesa
		{
			get { return id_Codigo_Mesa; }
			set { id_Codigo_Mesa = value; }
		}

		/// <summary>
		/// Gets or sets the Fecha value.
		/// </summary>
		public virtual DateTime Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}

		#endregion
	}
}

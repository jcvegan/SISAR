using System;

namespace SISAR.Entidades
{
	public class T_Tipo_Cambio
	{
		#region Fields

		private int id_Tipo_Cambio;
		private decimal cantidad;
		private DateTime fecha_TC;
		private int id_Moneda;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_Tipo_Cambio class.
		/// </summary>
		public T_Tipo_Cambio()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_Tipo_Cambio class.
		/// </summary>
		public T_Tipo_Cambio(decimal cantidad, DateTime fecha_TC, int id_Moneda)
		{
			this.cantidad = cantidad;
			this.fecha_TC = fecha_TC;
			this.id_Moneda = id_Moneda;
		}

		/// <summary>
		/// Initializes a new instance of the T_Tipo_Cambio class.
		/// </summary>
		public T_Tipo_Cambio(int id_Tipo_Cambio, decimal cantidad, DateTime fecha_TC, int id_Moneda)
		{
			this.id_Tipo_Cambio = id_Tipo_Cambio;
			this.cantidad = cantidad;
			this.fecha_TC = fecha_TC;
			this.id_Moneda = id_Moneda;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Tipo_Cambio value.
		/// </summary>
		public virtual int Id_Tipo_Cambio
		{
			get { return id_Tipo_Cambio; }
			set { id_Tipo_Cambio = value; }
		}

		/// <summary>
		/// Gets or sets the Cantidad value.
		/// </summary>
		public virtual decimal Cantidad
		{
			get { return cantidad; }
			set { cantidad = value; }
		}

		/// <summary>
		/// Gets or sets the Fecha_TC value.
		/// </summary>
		public virtual DateTime Fecha_TC
		{
			get { return fecha_TC; }
			set { fecha_TC = value; }
		}

		/// <summary>
		/// Gets or sets the Id_Moneda value.
		/// </summary>
		public virtual int Id_Moneda
		{
			get { return id_Moneda; }
			set { id_Moneda = value; }
		}

		#endregion
	}
}

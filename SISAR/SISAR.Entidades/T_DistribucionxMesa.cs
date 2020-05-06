using System;

namespace SISAR.Entidades
{
	public class T_DistribucionxMesa
	{
		#region Fields

		private int id_Codigo_Mesa;
		private decimal posicion_X;
		private decimal posicion_Y;
		private int numero_Mesa;
		private int id_Distribucion;
		private int id_Mesa;
		private string estado;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_DistribucionxMesa class.
		/// </summary>
		public T_DistribucionxMesa()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_DistribucionxMesa class.
		/// </summary>
		public T_DistribucionxMesa(decimal posicion_X, decimal posicion_Y, int numero_Mesa, int id_Distribucion, int id_Mesa, string estado)
		{
			this.posicion_X = posicion_X;
			this.posicion_Y = posicion_Y;
			this.numero_Mesa = numero_Mesa;
			this.id_Distribucion = id_Distribucion;
			this.id_Mesa = id_Mesa;
			this.estado = estado;
		}

		/// <summary>
		/// Initializes a new instance of the T_DistribucionxMesa class.
		/// </summary>
		public T_DistribucionxMesa(int id_Codigo_Mesa, decimal posicion_X, decimal posicion_Y, int numero_Mesa, int id_Distribucion, int id_Mesa, string estado)
		{
			this.id_Codigo_Mesa = id_Codigo_Mesa;
			this.posicion_X = posicion_X;
			this.posicion_Y = posicion_Y;
			this.numero_Mesa = numero_Mesa;
			this.id_Distribucion = id_Distribucion;
			this.id_Mesa = id_Mesa;
			this.estado = estado;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Codigo_Mesa value.
		/// </summary>
		public virtual int Id_Codigo_Mesa
		{
			get { return id_Codigo_Mesa; }
			set { id_Codigo_Mesa = value; }
		}

		/// <summary>
		/// Gets or sets the Posicion_X value.
		/// </summary>
		public virtual decimal Posicion_X
		{
			get { return posicion_X; }
			set { posicion_X = value; }
		}

		/// <summary>
		/// Gets or sets the Posicion_Y value.
		/// </summary>
		public virtual decimal Posicion_Y
		{
			get { return posicion_Y; }
			set { posicion_Y = value; }
		}

		/// <summary>
		/// Gets or sets the Numero_Mesa value.
		/// </summary>
		public virtual int Numero_Mesa
		{
			get { return numero_Mesa; }
			set { numero_Mesa = value; }
		}

		/// <summary>
		/// Gets or sets the Id_Distribucion value.
		/// </summary>
		public virtual int Id_Distribucion
		{
			get { return id_Distribucion; }
			set { id_Distribucion = value; }
		}

		/// <summary>
		/// Gets or sets the Id_Mesa value.
		/// </summary>
		public virtual int Id_Mesa
		{
			get { return id_Mesa; }
			set { id_Mesa = value; }
		}

		/// <summary>
		/// Gets or sets the Estado value.
		/// </summary>
		public virtual string Estado
		{
			get { return estado; }
			set { estado = value; }
		}

		#endregion
	}
}

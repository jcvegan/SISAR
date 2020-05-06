using System;

namespace SISAR.Entidades
{
	public class T_Moneda
	{
		#region Fields

		private int id_Moneda;
		private string nombre;
		private string simbolo;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_Moneda class.
		/// </summary>
		public T_Moneda()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_Moneda class.
		/// </summary>
		public T_Moneda(string nombre, string simbolo)
		{
			this.nombre = nombre;
			this.simbolo = simbolo;
		}

		/// <summary>
		/// Initializes a new instance of the T_Moneda class.
		/// </summary>
		public T_Moneda(int id_Moneda, string nombre, string simbolo)
		{
			this.id_Moneda = id_Moneda;
			this.nombre = nombre;
			this.simbolo = simbolo;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Moneda value.
		/// </summary>
		public virtual int Id_Moneda
		{
			get { return id_Moneda; }
			set { id_Moneda = value; }
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
		/// Gets or sets the Simbolo value.
		/// </summary>
		public virtual string Simbolo
		{
			get { return simbolo; }
			set { simbolo = value; }
		}

		#endregion
	}
}

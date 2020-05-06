using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SISAR.Logica;
using System.Data;
using SISAR.Entidades;

/// <summary>
/// Descripción breve de SW_DistribucionxMesa
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la lónea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class SW_DistribucionxMesa : System.Web.Services.WebService
{
    L_DistribucionxMesa _distribucionxMesa;
    public SW_DistribucionxMesa()
    {
        _distribucionxMesa = new L_DistribucionxMesa();
    }

    [WebMethod]
    public virtual DataSet SelectAll()
    {
        return this._distribucionxMesa.SelectAll();
    }
    [WebMethod]
    public virtual string Insert(T_DistribucionxMesa _distribucionxMesa)
    {
        return this._distribucionxMesa.Insert(_distribucionxMesa);
    }
    [WebMethod]
    public virtual string Update(T_DistribucionxMesa _distribucionxMesa)
    {
        return this._distribucionxMesa.Update(_distribucionxMesa);
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SISAR.Logica;
using System.Data;
using SISAR.Entidades;

/// <summary>
/// Descripción breve de SW_Permiso
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la lónea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class SW_Permiso : System.Web.Services.WebService
{
    L_Permiso _permiso;
    public SW_Permiso()
    {
        _permiso = new L_Permiso();
    }

    [WebMethod]
    public virtual DataSet SelectAll()
    {
        return this._permiso.SelectAll();
    }
    [WebMethod]
    public virtual string Insert(T_Permiso _permiso)
    {
        return this._permiso.Insert(_permiso);
    }
    [WebMethod]
    public virtual string Update(T_Permiso _permiso)
    {
        return this._permiso.Update(_permiso);
    }
    [WebMethod]
    public virtual string Delete(int _idPermiso)
    {
        return this._permiso.Delete(_idPermiso);
    }
}



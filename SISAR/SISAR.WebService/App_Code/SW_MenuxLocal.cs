using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SISAR.Logica;
using System.Data;
using SISAR.Entidades;

/// <summary>
/// Descripción breve de SW_MenuxLocal
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class SW_MenuxLocal : System.Web.Services.WebService
{
    L_MenuxLocal _menuxLocal;
    public SW_MenuxLocal()
    {
        _menuxLocal = new L_MenuxLocal();
    }

    [WebMethod]
    public virtual DataSet SelectAll()
    {
        return this._menuxLocal.SelectAll();
    }
    [WebMethod]
    public virtual string Insert(T_MenuxLocal _menuxLocal)
    {
        return this._menuxLocal.Insert(_menuxLocal);
    }
    [WebMethod]
    public virtual string Update(T_MenuxLocal _menuxLocal)
    {
        return this._menuxLocal.Update(_menuxLocal);
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SISAR.Logica;
using System.Data;
using SISAR.Entidades;

/// <summary>
/// Descripción breve de SW_Menu
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la lónea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class SW_Menu : System.Web.Services.WebService
{
    L_Menu _menu;
    public SW_Menu()
    {
        _menu = new L_Menu();
    }

    [WebMethod]
    public virtual DataSet SelectAll()
    {
        return this._menu.SelectAll();
    }
    [WebMethod]
    public virtual string Insert(T_Menu _menu)
    {
        return this._menu.Insert(_menu);
    }
    [WebMethod]
    public virtual string Update(T_Menu _menu)
    {
        return this._menu.Update(_menu);
    }
    [WebMethod]
    public virtual string Delete(int _idMenu)
    {
        return this._menu.Delete(_idMenu);
    }
}



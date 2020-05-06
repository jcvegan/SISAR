using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SISAR.Logica;
using System.Data;
using SISAR.Entidades;

/// <summary>
/// Descripción breve de SW_Detalle_Menu
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la lónea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class SW_Detalle_Menu : System.Web.Services.WebService
{
    L_Detalle_Menu _detalle_Menu;
    public SW_Detalle_Menu()
    {
        _detalle_Menu = new L_Detalle_Menu();
    }

    [WebMethod]
    public virtual DataSet SelectAll()
    {
        return this._detalle_Menu.SelectAll();
    }
    [WebMethod]
    public virtual string Insert(T_Detalle_Menu _detalle_Menu)
    {
        return this._detalle_Menu.Insert(_detalle_Menu);
    }
    [WebMethod]
    public virtual string DeleteAllById_Menu(int _idDetalle_Menu)
    {
        return this._detalle_Menu.DeleteAllById_Menu(_idDetalle_Menu);
    }
}



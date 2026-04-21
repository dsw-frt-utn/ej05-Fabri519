using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej5.Domain;

public class Sucursal
{
    private string codigo;
    private string direccion;
    private string ciudad;
    private Responsable responsable;

    public Sucursal(string codigo, string direccion, string ciudad, Responsable responsable)
    {
        this.codigo = codigo;
        this.direccion = direccion;
        this.ciudad = ciudad;
        this.responsable = responsable;
    }


   
    public string GetCodigo()
    {
        return codigo;
    }

    public string GetDireccion()
    {
        return direccion;
    }

    public string GetCiudad()
    {
        return ciudad;
    }

    public Responsable GetResponsable()
    {
        return responsable;
    }
}

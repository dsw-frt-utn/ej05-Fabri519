using Dsw2026Ej5.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej5.Data;

public class Persistencia
{
    private static readonly List<Sucursal> Sucursales = new List<Sucursal>();
    private static readonly List<Vehiculo> Vehiculos = new List<Vehiculo>();
    private static readonly List<Responsable> Responsables = new List<Responsable>();

    private static void InicializarResponsables()
    {
        Responsable r1 = new Responsable("Carlos Gómez", "25444111", "3815551111");
        Responsable r2 = new Responsable("Laura Pérez", "30111222", "3815552222");
        Responsables.Add(r1);
        Responsables.Add(r2);
    }

    private static void InicializarSucursales()
    {
        Sucursal s1 = new Sucursal("SUC01", "Av. Belgrano 1200", "Tucumán", Responsables[0]);
        Sucursal s2 = new Sucursal("SUC02", "San Martín 450", "Yerba Buena", Responsables[1]);

        Sucursales.Add(s1);
        Sucursales.Add(s2);
    }

    private static void InicializarVehiculos()
    {
        Sucursal s1 = Sucursales[0];
        Sucursal s2 = Sucursales[1];

        VehiculoElectrico v1 = new VehiculoElectrico("AE123FG", "Renault", "Kangoo E-Tech", 2020, 1000, s1, 16);
        VehiculoElectrico v2 = new VehiculoElectrico("AF456HI", "Ford", "E-Transit", 2021, 1300, s2, 16);

        VehiculoCombustible v3 = new VehiculoCombustible("AC789JK", "Iveco", "Daily", 2023, 1200, s1, 8, 1.5);
        VehiculoCombustible v4 = new VehiculoCombustible("AD321LM", "Mercedes", "Sprinter", 2020, 1200, s2, 7, 1);

        Vehiculos.Add(v1);
        Vehiculos.Add(v2);
        Vehiculos.Add(v3);
        Vehiculos.Add(v4);
    }

   

    public static void AgregarVehiculo(Vehiculo vehiculo)
    {
        Vehiculos.Add(vehiculo);
    }
    public static List<Vehiculo> GetVehiculos()
    {
        return Vehiculos;
    }

    public static List<Sucursal> GetSucursales()
    {
        return Sucursales;
    }

    public static Sucursal? GetSucursalPorCodigo(string codigo)
    {
        return Sucursales.Find(s => s.GetCodigo() == codigo);
    }


    public static Vehiculo? GetVehiculo(string patente)
    {
        return Vehiculos.Find(v => v.GetPatente() == patente);
    }

    public static void InicializarDatos()
    {
        InicializarResponsables();
        InicializarSucursales();
        InicializarVehiculos();
    }
}

using System;
class Producto
{
    private double precio;

    public void SetPrecio(double valor)
    {
        precio = valor;
    }

    public double GetPrecio()
    {
        if (precio >= 0)
            return precio;
        else
            return 0;
    }
}

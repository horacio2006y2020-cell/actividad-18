using System;
class Estudiante
{
    private int edad;

    public void SetEdad(int valor)
    {
        edad = valor;
    }

    public int GetEdad()
    {
        if (edad >= 0 && edad <= 100)
            return edad;
        else
            return 0;
    }
}
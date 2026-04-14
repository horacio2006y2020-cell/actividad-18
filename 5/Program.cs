using System;

class Usuario
{
    private string contraseña = ""; 

    public void SetContraseña(string valor)
    {
        contraseña = valor;
    }

    public string GetContraseña()
    {
        if (contraseña.Length >= 8)
            return "****";
        else
            return "Contraseña insegura";
    }
}

class Program
{
    static void Main()
    {
        Usuario u = new Usuario();
        u.SetContraseña("1234");
        Console.WriteLine(u.GetContraseña());
    }
}
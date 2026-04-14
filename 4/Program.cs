using System;
class Empleado
{
    private double salario;
    private const double salarioMinimo = 3000; // puedes cambiarlo

    public void SetSalario(double valor)
    {
        salario = valor;
    }

    public string GetSalario()
    {
        if (salario > salarioMinimo)
            return "Salario: " + salario;
        else
            return "Salario inválido";
    }
}
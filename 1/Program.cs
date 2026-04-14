using System;

class CuentaBancaria
{
    private double saldo;

    public void SetSaldo(double valor)
    {
        saldo = valor;
    }

    public string GetSaldo()
    {
        if (saldo > 0)
            return "Saldo: " + saldo;
        else
            return "Saldo no disponible";
    }
}
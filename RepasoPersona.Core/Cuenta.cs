namespace RepasoPersona.Core;

public class Cuenta
{
    private static int _contador = 0;
    public int CBU {get; private set;}
    public Cuenta()
    {
        CBU = ++_contador;
    }

    public void Debitar(double monto)
    {

    }
}

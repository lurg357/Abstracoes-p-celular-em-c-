public class CelularSamsung : Celular
{
    public override void Ligar()
    {
        Console.WriteLine("Celular Samsung ligado.");
    }

    public override void Desligar()
    {
        Console.WriteLine("Celular Samsung desligado.");
    }

    public override void FazerChamada(string numero)
    {
        Console.WriteLine($"Chamando {numero} do Samsung.");
    }

    public override void EnviarMensagem(string numero, string mensagem)
    {
        Console.WriteLine($"Enviando mensagem para {numero} do Samsung: {mensagem}");
    }
}

public class CelularApple : Celular
{
    public override void Ligar()
    {
        Console.WriteLine("Celular Apple ligado.");
    }

    public override void Desligar()
    {
        Console.WriteLine("Celular Apple desligado.");
    }

    public override void FazerChamada(string numero)
    {
        Console.WriteLine($"Chamando {numero} do Apple.");
    }

    public override void EnviarMensagem(string numero, string mensagem)
    {
        Console.WriteLine($"Enviando mensagem para {numero} do Apple: {mensagem}");
    }
}

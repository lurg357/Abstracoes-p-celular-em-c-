class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a marca do celular (Samsung/Apple): ");
        string marca = Console.ReadLine();
        
        Celular celular = CelularFactory.CriarCelular(marca);
        
        celular.Ligar();
        celular.FazerChamada("123-456-7890");
        celular.EnviarMensagem("123-456-7890", "Olá, tudo bem?");
        celular.Desligar();
    }
}

public static class CelularFactory
{
    public static Celular CriarCelular(string marca)
    {
        switch (marca)
        {
            case "Samsung":
                return new CelularSamsung();
            case "Apple":
                return new CelularApple();
            default:
                throw new ArgumentException("Marca desconhecida.");
        }
    }
}

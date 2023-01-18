namespace SmartphoneClasseAbstrata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motorola motorola = new Motorola()
            {
                Numero = "(11) 95525-5525",
                Modelo = "Moto E22",
                Imei = "00000000",
                Memoria = 128
            };

            Iphone iphone = new Iphone()
            {
                Numero = "(11) 92252-2252",
                Modelo = "Iphone 11",
                Imei = "0000000",
                Memoria = 128
            };

            motorola.InstalarAplicativo("Whatsapp");

            iphone.InstalarAplicativo("Instagram");
        }
    }
}
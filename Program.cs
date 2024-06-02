using DesafioPOO.Models;

namespace DesafioPOO.Services
{

    public class Teste
    {
        

        public static void Main(string[] args)
        {
            Nokia NokiaC30 = new Nokia("554651651", "C30", "123456789", 64);
            Iphone Iphone14 = new Iphone("1515165", "14", "987654321", 128);

            NokiaC30.InstalarAplicativo("WhatsApp");
            Iphone14.InstalarAplicativo("Android Services");
        }
        

    
    }

}  



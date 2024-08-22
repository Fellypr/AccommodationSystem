using pastaprinc;


class Program{
    static void Main(string[] args){
        SistemaDeHospedagem hospe = new SistemaDeHospedagem();

        bool exibir = true;
        while(exibir){
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("bem vindo ao hotel royal , oque voce desejar?");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\t1- ver preços de hospedagem\n\t2- se hospedar\n\t3- ver se estar hospedado");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t4- encerra o programa");
            Console.ResetColor();
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch(opcao){
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    hospe.VerPrecos();

                break;
                
                case 2:
                    hospe.SeHospedar();

                break;
                case 3:
                    hospe.VerListasDeHospede();

                break;
                case 4:
                    exibir = false;

                break;

                default:
                    Console.WriteLine("erro de opção");
                break;
                
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("clique pra CONTINUAR");
            Console.ReadKey();

        }
        Console.ResetColor();
        Console.WriteLine("/////////////////////////////////////");
        Console.WriteLine("//////////PROGRAMA ENCERRADO/////////");
        Console.WriteLine("/////////////////////////////////////");
}   }
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace pastaprinc
{
    public class SistemaDeHospedagem
    {
        List<string> listaDeHospedes = new List<string>();

        public void VerPrecos(){
            Console.WriteLine("aqui estão os preços dos quartos por noite \n\tQuarto com cama de casal: R$ 179.99\n\tQuarto com duas cama de soteiro:R$ 120.00\n\tQuarto com uma cama de casal e uma de soteiro:R$250.99");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ATENÇÃO!!! CASO VOCE ESCOLHER FICA 10 DIAS OU MAIS , IRA GANHA UM DESCONTO DE 10%");
        }
        public void SeHospedar(){
            Console.WriteLine("Coloque seu nome");
            string addnome = Console.ReadLine();
            Console.WriteLine("escolha uma das opções\n\t1-Quarto com cama de casal: R$ 179.99\n\t2-Quarto com duas cama de soteiro:R$ 120.00\n\t3-Quarto com uma cama de casal e uma de soteiro:R$250.99");
            int opcaoDeQuarto = Convert.ToInt32(Console.ReadLine());
            switch(opcaoDeQuarto){
                case 1:
                    Console.WriteLine("quantas noite voce que ficar no Quarto com cama de casal? ");
                    int noites = Convert.ToInt32(Console.ReadLine());
                    decimal valor = Convert.ToDecimal(noites * 179.99);
                    if(noites >= 10){
                        decimal porcen = 0.10M;
                        decimal valorDeDesconto = valor * porcen; 
                        Console.WriteLine($"ja que voce escolheu {noites} entao voce vai ter desconto de 10% , então o valor total vai ser de R${valorDeDesconto}\nAPERTE ENTER PARA CONTINUAR");
                        Console.ReadLine();
                        Stopwatch relogio = new Stopwatch();
                        relogio.Start();
                        Console.WriteLine("enviando suas infomações...");
                        System.Threading.Thread.Sleep(5000);
                        relogio.Stop();
                        Console.WriteLine($"{addnome} suas informação foi mandado para o sistema com sucesso");
                        

                        string lista1 = $"NOME:{addnome}\nQUARTO:Quarto com cama de casal\nNOITES:{noites} Noites";
                        listaDeHospedes.Add(lista1);
                    }
                    else{
                        Console.WriteLine($"o valor total de {noites} noites vai ser de ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"R${valor}\n\tAPERTE ENTER");
                        Console.ReadLine();
                        Stopwatch relogio = new Stopwatch();
                        relogio.Start();
                        Console.WriteLine("enviando suas infomações...");
                        System.Threading.Thread.Sleep(5000);
                        relogio.Stop();
                        Console.WriteLine($"{addnome} suas informação foi mandado para o sistema com sucesso");
                        string lista1 = $"NOME:{addnome}\nQUARTO:Quarto com cama de casal\nNOITES:{noites} Noites";
                        listaDeHospedes.Add(lista1);
                    }

                break;
                case 2:
                    Console.WriteLine("quantas noite voce que ficar no Quarto com duas cama de soteiro ");
                    int noites1 = Convert.ToInt32(Console.ReadLine());
                    decimal valor1 = Convert.ToDecimal(noites1 * 120.0);
                    if(noites1 >= 10){
                        decimal porcen = 0.10M;
                        decimal valorDeDesconto = valor1 * porcen; 
                        Console.WriteLine($"ja que voce escolheu {noites1} entao voce vai ter desconto de 10% , então o valor total vai ser de R${valorDeDesconto}\n APERTE ENTER");
                        Console.ReadLine();
                        Stopwatch relogio = new Stopwatch();
                        relogio.Start();
                        Console.WriteLine("enviando suas infomações...");
                        System.Threading.Thread.Sleep(5000);
                        relogio.Stop();
                        Console.WriteLine($"{addnome} suas informação foi mandado para o sistema com sucesso");
                        string lista1 = $"NOME:{addnome}\nQUARTO:Quarto com duas cama de soteiro\nNOITES:{noites1} Noites";
                        listaDeHospedes.Add(lista1); 
                    }
                    else{
                        Console.WriteLine($"o valor total de {noites1} noites vai ser de ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"R${valor1} APERTE ENTER");
                        Console.ReadLine();
                        Stopwatch relogio = new Stopwatch();
                        relogio.Start();
                        Console.WriteLine("enviando suas infomações...");
                        System.Threading.Thread.Sleep(5000);
                        relogio.Stop();
                        Console.WriteLine($"{addnome} suas informação foi mandado para o sistema com sucesso");
                        string lista1 = $"NOME:{addnome}\nQUARTO:Quarto com duas cama de soteiro\nNOITES:{noites1} Noites";
                        listaDeHospedes.Add(lista1);  
                    }

                break;
                case 3:
                    Console.WriteLine("quantas noite voce que ficar no Quarto com uma cama de casal e uma de soteiro");
                    int noites2 = Convert.ToInt32(Console.ReadLine());
                    decimal valor2 = Convert.ToDecimal(noites2 * 250.99);
                    if(noites2 >= 10){
                        decimal porcen = 0.10M;
                        decimal valorDeDesconto = valor2 * porcen; 
                        Console.WriteLine($"ja que voce escolheu {noites2} entao voce vai ter desconto de 10% , então o valor total vai ser de R${valorDeDesconto}\n APERTE ENTER");
                        Console.ReadLine();
                        Stopwatch relogio = new Stopwatch();
                        relogio.Start();
                        Console.WriteLine("enviando suas infomações...");
                        System.Threading.Thread.Sleep(5000);
                        relogio.Stop();
                        Console.WriteLine($"{addnome} suas informação foi mandado para o sistema com sucesso");
                        string lista1 = $"NOME:{addnome}\nQUARTO:Quarto com uma cama de casal e uma de soteiro\nNOITES:{noites2} Noites";
                        listaDeHospedes.Add(lista1);
                    }
                    else{
                        Console.WriteLine($"o valor total de {noites2} noites vai ser de ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"R${valor2} APERTE ENTER");

                        Console.ReadLine();
                        Stopwatch relogio = new Stopwatch();
                        relogio.Start();
                        Console.WriteLine("enviando suas infomações...");
                        System.Threading.Thread.Sleep(5000);
                        relogio.Stop();
                        Console.WriteLine($"{addnome} suas informação foi mandado para o sistema com sucesso");
                        string lista1 = $"NOME:{addnome}\nQUARTO:Quarto com duas cama de soteiro\nNOITES:{noites2} Noites";
                        listaDeHospedes.Add(lista1);  
                    }

                break;


            
            
            
            
            }
        }
        public void VerListasDeHospede(){
            Console.WriteLine("Qual o nome que voce colocou para fazer a hospedagem?");
            string verLista = Console.ReadLine();
            var nomeEncontrado = listaDeHospedes
                .Where(h => h.Contains(verLista,StringComparison.OrdinalIgnoreCase))
                .ToList();
            if(nomeEncontrado.Any()){
                foreach(var hospede in nomeEncontrado)
                {
                    Console.WriteLine($"ola {verLista} aqui estão os dados da hospedagem");
                    Console.WriteLine(hospede);
                }
                    
                
                
            }
            
            else{
                    Console.WriteLine($"o nome {verLista} não foi encontrado");
            }
        }
    }
}
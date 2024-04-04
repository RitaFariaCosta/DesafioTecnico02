/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      
      
      while(true){
          
          int opcao, numero_digitado, numero_comp_idade;
          int idade = 16;
          int horas = 0;
          int ano_nascimento_usuario;
          
          Console.WriteLine("\nEscolha uma opção: ");
          Console.WriteLine("1-Breve apresentação do personagem");
          Console.WriteLine("2-Breve apresentação da entidade filantrópica ou assistencial");
          Console.WriteLine("3-Interação do personagem com a entidade");
          opcao = int.Parse(Console.ReadLine());
          
          switch(opcao){
          case 1:
          Console.WriteLine("Nome da personagem: Inej Ghafa, mas também é conhecida como Espectro");
          Console.WriteLine("Habilidades: Excelentes habilidades de escalada, agilidade, coordenação corporal e dom para furtividade");
          Console.WriteLine("Naturalidade: Kerch");
          Console.WriteLine("Tente adivinhar sua idade: ");
          numero_digitado = int.Parse(Console.ReadLine());
          
          do{
              if(numero_digitado > idade){
                Console.WriteLine("Você chutou alto!");  
              }
              else if(numero_digitado < idade){
                Console.WriteLine("Você chutou baixo!"); 
              }
               Console.WriteLine("Tente adivinhar o número novamente: ");
               numero_digitado = int.Parse(Console.ReadLine());
          }while(numero_digitado != idade);    
          Console.WriteLine("Você acertou!Ela tem 16 anos!");
          break;
          
          case 2:
          Console.WriteLine("O orfanato Raio de Luz foi fundado em 1988 na cidade de Rakva por Nikolai Lantsov");
          Console.WriteLine("Vamos comparar sua idade com a do orfanato. \nPara isso digite o seu ano de nascimento: ");
          ano_nascimento_usuario = int.Parse(Console.ReadLine());
          
          if(ano_nascimento_usuario > 1988){
            numero_comp_idade = ano_nascimento_usuario - 1988;
            Console.WriteLine($"O orfanato é {numero_comp_idade} anos mais velho que você");
          }
          else if(ano_nascimento_usuario < 1988){
            numero_comp_idade = 1988 - ano_nascimento_usuario;
            Console.WriteLine($"Você é {numero_comp_idade} anos mais velho que o orfanato");
          }
          else {
            Console.WriteLine("Ambos possuem 36 anos.");  
          }
          break;
          
          case 3:
          Console.WriteLine("Inej resolveu ir visitar seu amigo Nikolai no orfanato Raio de Luz. ");
          Console.WriteLine("Ela saiu às 8 da manhã de sua casa e chegou no orfanato às 11 da manhã. ");
          
          for(int i=1; i<=4;i++)
          {
            horas = i;
          }
          Console.WriteLine($"Ela gastou {horas} horas para chegar no orfanato.");
          break;
          }
      }
  }
}
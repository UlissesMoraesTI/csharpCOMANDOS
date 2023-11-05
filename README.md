

# csharpbCalculator
C# Console - Projeto COMANDOS

<h1>   
     <img align="center" width="40px">
    <span> Comandos da Linguagem de Programação C#</span>
</h1>


## Ferramentas
[![GitHub](https://img.shields.io/badge/GitHub-000?style=for-the-badge&logo=github&logoColor=30A3DC)](https://docs.github.com/)
[![Git](https://img.shields.io/badge/Git-000?style=for-the-badge&logo=git&logoColor=E94D5F)](https://git-scm.com/doc) 

01. Criar repositório no GIT

02. Copiar URL

03. git init no seu projeto via terminal

04. git remote <enter>  (Não aparecendo nada está certo, significa que não existe nenhum repositório remoto amarrado a esta pasta)

05. git remote add origin URL

06. git status

07. git add * ou .

08. git commit -m ""

09. git push origin master


## Objetivo
     Aprender o básico sobre a linguagem C#.

## Array
     int[] arrayInteiros = new int[3];
     
     arrayInteiros[0] = 72;
     arrayInteiros[1] = 64;
     arrayInteiros[2] = 50;
     
     for (int i = 0; i <= arrayInteiros.Length; i++)
     {
         Console.WriteLine($"Posição nº {i} = {arrayInteiros[i]}");
     }

## Console
     Console.WriteLine("Linguagem C#");
     Console.ReadLine();
     Console.Clear();
     Console.ReadKey();


## Convert
     int ano = Convert.ToInt32("74");

## Decremento
     currentTime--;


## IF
     if (data.Length != 0)
      {
          type = char.Parse(data.Substring(data.Length - 1, 1));
          time = int.Parse(data.Substring(0, data.Length - 1));
      }
      else
      {
          type = char.Parse(data.Substring(data.Length, 1));
          time = int.Parse(data.Substring(0, data.Length));
      }

## Incremento
     currentTime++;

## Interpolação
     Console.WriteLine($"{x} - {y} = {x - y}");

## FOR
     bool cabec = false;

     for (int i = 0; i < 10; i++)
     {
         if (cabec == false)
         {
             Console.WriteLine($"Tabuada {i}");
             cabec = true;
         }
         Console.WriteLine($" 1 x {i} = {1 * i}");
         Console.WriteLine($" 2 x {i} = {2 * i}");
         Console.WriteLine($" 3 x {i} = {3 * i}");
         Console.WriteLine($" 4 x {i} = {4 * i}");
         Console.WriteLine($" 5 x {i} = {5 * i}");
         Console.WriteLine($" 6 x {i} = {6 * i}");
         Console.WriteLine($" 7 x {i} = {7 * i}");
         Console.WriteLine($" 8 x {i} = {8 * i}");
         Console.WriteLine($" 9 x {i} = {9 * i}");
         Console.WriteLine($" 10 x {i} = {10 * i}");
         Console.WriteLine("############################");
         cabec = false;
     }

## FOREACH

     int[] arrayInteiros = new int[3];

     arrayInteiros[0] = 72;
     arrayInteiros[1] = 64;
     arrayInteiros[2] = 50;
     
     Console.WriteLine("Array com FOR");
     for (int i = 0; i <= arrayInteiros.Length; i++)
     {
         Console.WriteLine($"Posição nº {i} = {arrayInteiros[i]}");
     }
     
     Console.WriteLine("Array com FOREACH");
     foreach (int valor in arrayInteiros)
     {
         Console.WriteLine(valor);
     }

## Length
     time = int.Parse(data.Substring(0, data.Length - 1));

## Math
     double radiano = angulo * Math.PI / 180;
     Console.WriteLine($"Tangente de {angulo}º = {Math.Round(tangente, 4)}");

## Parse
     ano = int.Parse("47");     
     time = int.Parse(data.Substring(0, data.Length - 1));
     float v1 = float.Parse(Console.ReadLine());
     type = char.Parse(data.Substring(data.Length, 1));

## PI
     double radiano = angulo * Math.PI / 180;

## Round
     Console.WriteLine($"Tangente de {angulo}º = {Math.Round(tangente, 4)}");

## System
     System.Environment.Exit(0);

## Substring
     time = int.Parse(data.Substring(0, data.Length - 1));

## switch
      switch (type)
      {
          case 's': TemporizadorEmSegundos(time); break;
          case 'm': TemporizadorEmMinutos(time); break;
          case '0': Sair(); break;
          default: OpcaoInvalida(); break;
      }
      switch (letra)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("Vogal: " + letra);
                    break;

                default:
                    Console.WriteLine($"Esta letra [{letra}] não é vogal.");
                    break;
            }

## Thead
     Thread.Sleep(1000);

## ToLower
     data = Console.ReadLine().ToLower();

## While
          int contador = 0;
          
          while (contador <= 10)
          {
              Console.WriteLine("Show!");
              contador++;
          }

       while (currentTime != time * 60)
       {
           Console.Clear();
           currentTime++;
           Console.WriteLine(currentTime);
           Thread.Sleep(1000);
       }

  ## do While
     int numero = 0;
     int soma = 0;
     
     do
     {
         Console.WriteLine("Digite um número <0=Encerrar>");
         numero = Convert.ToInt32(Console.ReadLine());
     
         soma += numero;
     
     } while (numero != 0);
     
     Console.WriteLine($"Total da Soma é {soma}.");

     do
     {
           Console.Clear();
           Console.WriteLine("#-----------------------------#");
           Console.WriteLine("#     Menu  Temporizador      #");
           Console.WriteLine("#-----------------------------#");
           Console.WriteLine("[S] = Segundo => 10s(Segundos)#");
           Console.WriteLine("[M] = Minuto  =>  1m(Minutos) #");
           Console.WriteLine("[0] = Sair    =>  00(Sair)    #");
           Console.WriteLine("#-----------------------------#");
          
           Console.WriteLine("Quanto tempo deseja contar?");
          
           data = Console.ReadLine().ToLower();
     
           if (data.Length != 0)
           {
               type = char.Parse(data.Substring(data.Length - 1, 1));
               time = int.Parse(data.Substring(0, data.Length - 1));
           }
           else
           {
               type = char.Parse(data.Substring(data.Length, 1));
               time = int.Parse(data.Substring(0, data.Length));
           }
          
           switch (type)
           {
               case 's': TemporizadorEmSegundos(time); break;
               case 'm': TemporizadorEmMinutos(time); break;
               case '0': Sair(); break;
               default: OpcaoInvalida(); break;
           }

     } while (data != "0");

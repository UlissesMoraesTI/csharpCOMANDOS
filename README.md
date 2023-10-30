# csharpbCalculator
C# Console - Projeto Calculadora

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

## Console
Console.WriteLine("Linguagem C#");
Console.ReadLine();
Console.Clear();
Console.ReadKey();

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

 ## Length
 time = int.Parse(data.Substring(0, data.Length - 1));

 ## Parse
time = int.Parse(data.Substring(0, data.Length - 1));

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

## Thead
Thread.Sleep(1000);

## ToLower
data = Console.ReadLine().ToLower();

## While
       while (currentTime != time * 60)
       {
           Console.Clear();
           currentTime++;
           Console.WriteLine(currentTime);
           Thread.Sleep(1000);
       }

  ## do While

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

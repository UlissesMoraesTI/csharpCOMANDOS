

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

## Array.Resize
     Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);


## Array.Copy
     int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
     Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


## Console
     Console.WriteLine("Linguagem C#");
     Console.ReadLine();
     Console.Clear();
     Console.ReadKey();


## Convert
     int ano = Convert.ToInt32("74");

## Decremento
     currentTime--;

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

## GET
     public int Idade
        {
            get
            {
                return _idade;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade Não pode ser negativa");
                }

                _idade = value;
            }
        }

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
     public string NomeCompleto => $"{Nome} {SobreNome}".ToUpper();

## List
     List<string> listaString = new List<string>();
     
     listaString.Add("SP");
     listaString.Add("BA");
     listaString.Add("MG");
     
     Console.WriteLine("Com FOR");
     for (int i = 0; i < listaString.Count; i++)
     {
         Console.WriteLine($"{listaString[i]}");
     }
     
     Console.WriteLine("Com FOREACH");
     foreach (string estado in listaString)
     {
         Console.WriteLine(estado);
     }

## List ADD | COUNT | REMOVE
     using System;
     using System.Collections.Generic;
     using System.Linq;
     using System.Threading.Tasks;
     
     namespace ExemploMetodosConstrutores.Models
     {
         public class Curso
         {
             public string Nome { get; set; }
             public List<Pessoa> Alunos { get; set; }
     
             public void AdicionarAluno(Pessoa aluno)
             {
                 Alunos.Add(aluno);
             }
     
             public int ObterQuantidadeDeAlunosMatriculados()
             {
                 int quantidade = Alunos.Count;
                 return quantidade;
             }
     
             public bool RemoverAluno(Pessoa aluno)
             {
                 return Alunos.Remove(aluno);
                 // return true;
             }
     
             public void ListarAlunos()
             {
                 foreach (Pessoa aluno in Alunos)
                 {
                     Console.WriteLine(aluno.NomeCompleto);
                 }
             }
         }
     }

## Length
     time = int.Parse(data.Substring(0, data.Length - 1));

## Math
     double radiano = angulo * Math.PI / 180;
     Console.WriteLine($"Tangente de {angulo}º = {Math.Round(tangente, 4)}");

## Métodos CONSTRUTORES
     using System;
     using System.Collections.Generic;
     using System.Linq;
     using System.Threading.Tasks;
     
     namespace ExemploMetodosConstrutores.Models
     {
         public class Pessoa
         {
             public Pessoa()
             {
     
             }
     
             public Pessoa(string nome, string sobrenome)
             {
                 Nome = nome;
                 SobreNome = sobrenome;
             }
     
             private string _nome;
             private int _idade;
             public string Nome
             {
     
                 get
                 {
                     return _nome.ToUpper();
                 }
     
                 set
                 {
                     if (value == "")
                     {
                         throw new ArgumentException("Nome é Obrigatório");
                     }
     
                     _nome = value;
                 }
             }
     
             public string SobreNome { get; set; }
     
             public string NomeCompleto => $"{Nome} {SobreNome}".ToUpper();
     
             public int Idade
             {
                 get
                 {
                     return _idade;
                 }
     
                 set
                 {
                     if (value < 0)
                     {
                         throw new ArgumentException("Idade Não pode ser negativa");
                     }
     
                     _idade = value;
                 }
             }
     
             public void Apresentar()
             {
                 Console.WriteLine($"Nome: {NomeCompleto}, Idade {Idade} anos.");
             }
         }
     }

## Parse
     ano = int.Parse("47");     
     time = int.Parse(data.Substring(0, data.Length - 1));
     float v1 = float.Parse(Console.ReadLine());
     type = char.Parse(data.Substring(data.Length, 1));

## PI
     double radiano = angulo * Math.PI / 180;

## Round
     Console.WriteLine($"Tangente de {angulo}º = {Math.Round(tangente, 4)}");

## SET
     public int Idade
        {
            get
            {
                return _idade;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade Não pode ser negativa");
                }

                _idade = value;
            }
        }

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

## THROW
     public int Idade
        {
            get
            {
                return _idade;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade Não pode ser negativa");
                }

                _idade = value;
            }
        }

## ToLower
     data = Console.ReadLine().ToLower();

## ToUpper
     public string NomeCompleto => $"{Nome} {SobreNome}".ToUpper();

## Valores Monetários
     - VALORES MONETARIOS
     - PORCENTAGEM
     - EDIÇÃO CPF
     - EDIÇÃO CNPJ
     - EDIÇÃO NÚMEROS
     
     using System.Globalization;
     using System.Linq.Expressions;
     
     CultureInfo.DefaultThreadCurrentCulture = new CultureInfo(en-US);
     CultureInfo.DefaultThreadCurrentCulture = new CultureInfo(pt-BR);
     
     internal class Program
     {
         private static void Main(string[] args)
         {
             decimal valorMonetario = 82.40M;
     
             Console.WriteLine(valorMonetario);
     
             Console.WriteLine(${valorMonetarioC});
     
     
             não esqueça do M
             valorMonetario = 1582.48M;
     
             Console.WriteLine(valorMonetario.ToString(C, CultureInfo.CreateSpecificCulture(en-US)));
     
             Representa QTDE de casas decimais
             valorMonetario = 7821.94321M;
     
             Representa em REAL
             Console.WriteLine(${valorMonetarioC});
     
             Representa QTDE de casas decimais
             Console.WriteLine(valorMonetario.ToString(C1));
             Console.WriteLine(valorMonetario.ToString(C2));
             Console.WriteLine(valorMonetario.ToString(C3));
             Console.WriteLine(valorMonetario.ToString(C4));
             Console.WriteLine(valorMonetario.ToString(C5));
     
             Representa Numericamente
             Console.WriteLine(valorMonetario.ToString(N1));
             Console.WriteLine(valorMonetario.ToString(N2));
             Console.WriteLine(valorMonetario.ToString(N3));
             Console.WriteLine(valorMonetario.ToString(N4));
             Console.WriteLine(valorMonetario.ToString(N5));
     
     
             Tratando Porcentagem - resultado 34,22% Atenção Faz Arredondamento
             double porcentagem = .342156;
     
             Console.WriteLine(porcentagem.ToString(P));
     
             long telefone = 991433242;
             Console.WriteLine(telefone.ToString(#-####-####));
     
             long cpf = 15682932838;
             Console.WriteLine(cpf.ToString(XXX.XXX.XXX-XX));
     
             long cnpj = 14218414000138;
             Console.WriteLine(cnpj.ToString(##-###-###-####-##));
     
             int senha = 123456;
             Console.WriteLine(senha.ToString(##-##-##));
     
             string numCpf = cpf.ToString();
     
             Console.WriteLine($Tamanho {numCpf.Length});
     
             FormatCPF(numCpf);
     
             static string FormatCPF(string numCpf)
             {
                 string response = numCpf.Trim();
                 if (response.Length == 11)
                 {
                     response = response.Insert(9, -);
                     response = response.Insert(6, .);
                     response = response.Insert(3, .);
                 }
                 Console.WriteLine(response);
                 return response;
             }
         }
     }

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

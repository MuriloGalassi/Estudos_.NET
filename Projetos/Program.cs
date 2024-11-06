using System.Collections.ObjectModel;
using Projetos.Common.Models;


List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");














// Console.WriteLine("Percorrendo a lista com o FOR");
// for(int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
// }

// Console.WriteLine("Percorrendo a lista com o FOREACH");
// int contadorForeach = 0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posição N° {contadorForeach} - {listaString[contadorForeach]}");
//     contadorForeach++;
// }




























// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;


// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


// // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2 );


// Console.WriteLine("Percorrendo o Array com o FOR");
// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
// }

// Console.WriteLine("Percorrendo o Array com FOREACH");
// int contadorForeach = 0;
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição N° {contadorForeach} - {valor}");
//     contadorForeach++;
// }

























// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "João";
// pessoa1.Idade = 22;
// pessoa1.Apresentar();













// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite sua opção: ");
//     Console.WriteLine("1 - Cadastrar cliente: ");
//     Console.WriteLine("2 - Buscar cliente: ");
//     Console.WriteLine("3 - Apagar cliente: ");
//     Console.WriteLine("4 - Encerrar: ");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro cliente");
//             break;

//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;

//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;

//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             //Environment.Exit(0);
//             break;

//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }
// }

// Console.WriteLine("O programa se encerrou");
















// int soma = 0, numero = 0;



// do
// {
//     Console.WriteLine("Digite um numero (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while(numero != 0);

// Console.WriteLine($"Total de soma dos numeros digitados é: {soma}");




















//int numero = 5;
//int contador = 1;


//while (contador <= 10)
//{
//    Console.WriteLine($"{contador}° Execução: {numero} x {contador} = {numero * contador}");
//    contador++;

//    if (contador == 6)
//    {
//        break;
//    }
//}














//int numero = 5;

//for(int contador = 0; contador <= 10000; contador++)
//{
//    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//}























//Calculadora calc = new Calculadora();

//calc.Potencia(3, 3);
//calc.Somar(10, 30);
//calc.Subtrair(10, 50);
//calc.Multiplicar(15, 45);
//calc.Dividir(2, 2);
//calc.Seno(30);
//calc.Coseno(30);
//calc.Tangente(30);
//calc.RaizQuadrada(9);

//int numeroIncremento = 10;

//Console.WriteLine(numeroIncremento);

//Console.WriteLine("Incrementando o 10");
//numeroIncremento = numeroIncremento + 1;
//numeroIncremento++;

//Console.WriteLine(numeroIncremento);

//int numeroDecremento = 20;
//Console.WriteLine("Decremento o numero 20");
//numeroDecremento = numeroDecremento - 1;
//numeroDecremento--;

//Console.WriteLine(numeroDecremento);






//bool choveu = true;
//bool estaTarde = false;

//if (!choveu && !estaTarde)
//{
//    Console.WriteLine("Vou pedalar");
//}
//else
//{
//   Console.WriteLine("Vou pedalar outro dia");
//}













//bool possuiPresenca = true;
//double media = 6.5;

//if (possuiPresenca && media >= 7)
//{
//    Console.WriteLine("Aprovado");
//}
//else
//{
//    Console.WriteLine("Reprovado");
//}

















//bool ehMaiorDeIdade = false;
//bool possueAutorizacaoDoResponsavel = false;

//if (ehMaiorDeIdade || possueAutorizacaoDoResponsavel)
//{
//    Console.WriteLine("Entrada Liberada!");
//}
//else
//{
//    Console.WriteLine("Entrada não liberada");
//}


























//Console.WriteLine("Digite uma letra");
//string? letra = Console.ReadLine();



//switch (letra)
//{
//    case "a":
//    case "e":
//    case "i":
//    case "o":
//    case "u":
//        Console.WriteLine("volgal");
//        break;
    
//    default:
//        Console.WriteLine("Não é uma volgal");
//        break;
//}











//if (letra == "a" ||
//    letra == "e" ||
//    letra == "i" ||
//    letra == "o" ||
//    letra == "u")
//{
//    Console.WriteLine("Vogal");
//}
//else
//{
//    Console.WriteLine("Não é uma vogal");
//}
















//if (letra == "a")
//{
//    Console.WriteLine("Volgal");
//}
//else if (letra == "e")
//{
//    Console.WriteLine("volgal");
//}
//else if (letra == "i")
//{
//    Console.WriteLine("volgal");
//}
//else if (letra == "o")
//{
//    Console.WriteLine("volgal");
//}
//else if (letra == "u")
//{
//    Console.WriteLine("volgal");
//}
//else
//{
//    Console.WriteLine("Não e uma volgal");
//}













//int quantidadeEmEstoque = 10;
//int quantidadeCompra = 0;
//bool possivelVenda =  quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

//Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
//Console.WriteLine($"Quntidade de compra: {quantidadeCompra}");
//Console.WriteLine($"É possivel realizar a venda: {possivelVenda}");

//if(quantidadeCompra == 0)
//{
//    Console.WriteLine("Venda inválida");
//}
//else if (possivelVenda)
//{
//    Console.WriteLine("Venda realizada");
//}
//else
//{
//    Console.WriteLine("Desculpe. nao temos a quantidade em estoque");
//}





//Console.WriteLine("quntidade de produto em estoque: ");
//int quantidadeEmEstoque = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("quntidade de produto para venda: ");
//int quantidadeCompra = Convert.ToInt32(Console.ReadLine());


//if (quantidadeEmEstoque >= quantidadeCompra)
//{
//    Console.WriteLine("Venda realizada");
//}
//else
//{
//    Console.WriteLine("Desculpe. nao temos a quantidade em estoque");
//}









//string a = "15-";

//int b = 0;

//int.TryParse(a, out int b);


//Console.WriteLine(b);
//Console.WriteLine("Conversão realizada com sucesso!");
















// double a = 4 / (2 + 2);

// Console.WriteLine(a);



// int a = 5;
// double b = a;   

// int a = 5;
// long b = a;

// Console.WriteLine(b);












// int inteiro = 5;
// string a = inteiro.ToString();


// Console.WriteLine(a);









// Cast - Casting
//int a = Convert.ToInt32(null);
//int a = int.Parse(null);

//double.Parse();
//decimal.Parse();

//Convert.ToInt32();

//Console.WriteLine(a);










// int a = 10;
// int b = 20;

// int c = a + b;

// c = c + 5;  // 30 + 5

// c += 5;

//  c = c - 5
// c *= 5;

// Console.WriteLine(c);














// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));



// string apresentacao = "Ola, seja bem vindo";

// int quantidade = 1;

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da varievel quantidade:" + quantidade);
// Console.WriteLine("Valor da varievel altura:" + altura.ToString("0.00"));
// Console.WriteLine("Valor da varievel preco:" + preco);
// Console.WriteLine("Valor da varievel condicao:" + condicao);

//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "João";
//pessoa1.Idade = 22;
//pessoa1.Apresentar();

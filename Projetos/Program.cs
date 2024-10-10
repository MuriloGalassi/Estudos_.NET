using System.Globalization;
using System.Reflection.Metadata;
using Projetos.Models;


int numero = 5;

for(int contador = 0; contador <= 10000; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}























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

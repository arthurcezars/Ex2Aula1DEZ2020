using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    int test = 1;

    // Instanciando a classe
    Data sistema = new Data();
    Data d = new Data(23, 9, 1999);
    List<Data> lista = new List<Data>();

    // Mostrando o construtor vazio funcionando pegando a data do sistema junto com o metodo para mostar na tela como string
    Data.toString(sistema.Dia, sistema.Mes, sistema.Ano);

    // Mostrando o construtor funcionando carregando ele com uma data junto com o metodo para mostar na tela como string
    Data.toString(d.Dia, d.Mes, d.Ano);

    // Mostrando o metodo que recebe uma data e mostra como string
    Data.toString(02, 12, 2020);

    // Metodo que avanca o dia da data que e passada
    Data.passaDia(30, 12, 2019);

    Console.WriteLine("Pressione qualquer tecla para continurar.");
    Console.ReadKey();
    Console.Clear();

    while(test == 1){
      try{
        Console.Write("Informe o dia: ");
        int dy = int.Parse(Console.ReadLine());
        Console.Write("Informe o mês: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Informe o ano: ");
        int y = int.Parse(Console.ReadLine());
        sistema = new Data(dy, m, y);
        lista.Add(sistema);

        Console.WriteLine("Digite 1 para adicionar outra data. Digite 2 para encerrar e mostar a lista com as datas.");
        test = int.Parse(Console.ReadLine());

      }catch(ArgumentException){
        Console.WriteLine("Um ou mais campos podem estar vazios ou com a data fora do padrão!");
      }catch(FormatException){
        Console.WriteLine("Os campos devem ser preenchidos usando numeros!");
      }
    }
    for(int i = 0; i < lista.Count; i++){
      Data.toString(lista[i].Dia, lista[i].Mes, lista[i].Ano);
    }
  }
}
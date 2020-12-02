using System;

class Data{
  int day;
  int month;
  int year;

  public int Dia{
    get{return day;}
    set{if(value<1 & value>30){Console.WriteLine("Valor do dia fora do padrão!");}else{day = value;}}
  }

  public int Mes{
    get{return month;}
    set{if(value<1 & value>12){Console.WriteLine("Valor do mês fora do padrão!");}else{month = value;}}
  }

  public int Ano{
    get{return year;}
    set{year = value;}
  }

  public Data(int d, int m, int y){
    if(d<1 & d>30){
      Console.WriteLine("Valor do dia fora do padrão!");
    }else{
    day = d;
    }
    if(m<1 & m>12){
      Console.WriteLine("Valor do mês fora do padrão!");
    }else{
    month = m;
    }
    year = y;
  }

  public Data(){
    day = DateTime.Now.Day;
    month = DateTime.Now.Month;
    year = DateTime.Now.Year;
  }

  public static void toString(int d, int m, int y){
    Console.WriteLine("{0}/{1}/{2}", d, m, y);
  }

  public static void passaDia(int d, int m, int y){
    if(d==30 & m==12){
      d = 1;
      m = 1;
      y = y + 1;
    }else{
      if(d==30){
        d = 1;
        m = m + 1;
        y = y;
      }else{
        d = d + 1;
        m = m;
        y = y;
      }
    }

    Console.WriteLine("{0}/{1}/{2}", d, m, y);
  }
}
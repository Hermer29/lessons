using System;

class Program
{
  static void Main()
  {
    //Пропусти Main и читай оттуда
    
    int a = 20;
    string b = "SomeString";
    bool c = true;
    FunctionA(a,b,c);
    Console.WriteLine($"{a},{b},{c}"); // 20,SomeString,true
    //Вернись обратно
    
    // При этом параметр нужно передавать также указывая слово ref
    FunctionB(ref a,ref b,ref c);
    Console.WriteLine($"{a},{b},{c}"); // 100,String,false
  }
  
  /* 
  Параметры в функциях могут быть переданы
  по разному:
  1. По значению /
  2. По ссылке
  
  По значению параметры передаются по такому принципу:
  1. В вызове функции в параметры передается переменная
  2. Функция копирует значение этой переменной и работает с новой переменной созданной в функции
  */
  static void FunctionA(int a, string b, bool c)
  {
    a = 100;
    b = "String";
    c = false;
  }
  //Вернись к Main
  
  /*
  А можно передавать параметры по ссылке, по такому принципу:
  1. В вызове функции в параметры передается переменная
  2. Функция использует переданную переменную, и может влиять на нее
  
  чтобы функция принимала параметр по ссылке надо перед параметром указать модификатор ref
  */
  static void FunctionB(ref int a, ref string b, ref bool c)
  {
    a = 100;
    b = "String";
    c = false;
  }
  //Вернись в Main
  
}
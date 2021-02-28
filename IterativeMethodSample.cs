using System;

class Program
{
  
  /*
  
    1.Мы присвоили variable значение позже
    потому что по задумке variable 
    должна быть определена в ходе операции
    2.Значит значение variable зависит от 
    результата операции дальше
    
  */
  
  
  static void Main()
  {
    int variable;
    
    for(int i = 0; i < 100; i++)
    {
      if(i % 50 == 0)
      {
        variable = i;
      }
    }
    
    Console.WriteLine(variable);
    
  }
}
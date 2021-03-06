using System;

namespace RecursiveFunctionSample
{
    /*
        Существует еще один способ повторить некоторый
        код несколько раз кроме без использования циклов.
        
        Этот метод построен на том, что функция возвращающая
        вызов самой себя будет бесконечной:
    */   
    
    
    class Program
    {
        
        static void Main()
        {
            
            var a = RecursiveFunction();
        }
        
        static int RecursiveFunction()
        {
            
            return RecursiveFunction();
        }
        /*
            Как это работает?
            1. Вызываем RecursiveFunction в Main
            2. Эта функция возвращает саму себя
            3. Следующая функция вызывает саму себя
            4. и так далее, так функция никогда не завершит работу
        */  
        
        /*
            Для того чтобы понять принцип работы рекурсии
            надо дать определение понятию стека. 
            Стек это область оперативной памяти, имеющая принцип
            хранения данных LIFO (last in first out), переводится
            как "последний вошел первый вышел", задача попавшая в стек
            будет по этому принципу выполнена первая, если еще задача
            вызывается предыдущей то она попадает в стек и будет выполнена первой
          
            Резюмируя вышесказанное, RecursiveFunction вызывает RecursiveFunction
            и так бесконечно забивает стек, вызывая переполнение стека и завершая
            ход программы, можешь убедиться
        */
        
        // Обсудим как использовать этот принцип
        
        /*
            Это функция, повторяется i раз, 
            в ней можно вызвать Console.WriteLine
            
        */
        static void RecursiveFunction(int i)
        {
            
            // Бесконечная рекурсия нам не нужна
            // на некоторой итерации функция должна вернуть не себя,
            // тогда эта задача будет считаться выполненной и стек будет
            // освобождаться
            if (i == 0)
            {
                return 0;
            }
            Console.WriteLine(i);
            return RecursiveFunction(--i);
        }
    }
}
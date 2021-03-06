using System;


class Program
{
    static void Main()
    {
        
    }
}

/*
    Объектно ориентированное программирование
    это подход к программированию, основанный на разделении
    поведения и данных с целью достижения некоторых преимуществ
    одни из них:
    
    1. Увеличение понятности кода
    2. Разделение программы на модули с целью повторного использования
    3. Как следствие уменьшение объема кода
    
    так в чем же основа?
    
    Вспомним то что я рассказывал, 
    1. Кофемашина имеет скрытое от глаз внутреннее устройство
    2. Следовательно, нам не нужно разбираться во внутреннем
    устройстве кофемашины, чтобы ей пользоваться
    3. Кофемашина имеет понятный интерфейс: кнопки, купюроприемник
    
    Еще кое что,
    Чтобы понять пользу ООП ответь себе на вопросы:
    1. Зачем кофемашине корпус?
    2. Что упрощает взаимодействие с кофемашиной?

    Так объект в этой системе это кофеварка, а класс — ее чертеж
    Класс Console помечен модификатором static,
    так что создать объект этого класса невозможно
    
    Так как создать свой собственный класс?
    [Модификатор(ы)] class ИмяКласса
    {
        Описание класса
    }
*/

class MyClass
{
    // Элементарный класс 
}

// Если это класс не статический (то есть не помечен модификатором static)
// Мы можем создать как бы переменную типа MyClass, используя слово new (значит новый)
// (тип или var) имя_переменной = new Тип();

static void Main()
{
    
    MyClass variable = new MyClass();
}
// MyClass ничего в себе не содержит и ничего не объявляет, так что у него 0 функционала

/*
    Мы помним, что класс является сборником функционала
    как класс Console
    
    В объявлении класса можно создавать переменные
    
    Эти переменные и методы объявленные в классе могут быть использованы
    
    1. Через объект, если они не статические
    2. Через класс, если они статические
    
    1. 
    class Abc
    {
        public int hby;
        public string jki;
    }
    
    *В функции main:*
    Abc variable = new Abc();
    variable.hby = 5; Присвоение
    variable.jki = "Hello world!";
    
    Console.WriteLine(variable.hby); // 5
    Console.WriteLine(variable.jki); // Hello world!
    
    2. 
    class Abc
    {
        public static int hby;
        public static string jki;
    }
    
    *Main*
    Abc.hby = 5;
    Abc.jki = "Abc";
    
    Ну и дальше будто они обычные переменные, только через точку
*/

class MyClass1
{ // <-
    int a;
    string b;
    bool c;
} // <-

/*
    Здесь пора познакомиться с понятием модификатора доступа
    Он пишется первым в объявлении любого элемента класса
    Он предназначен для обеспечения доступности помеченного элемента извне класса 
    (извне фигурных скобок объявления, указанных стрелками)
    
    public - делает элемент доступным глобально отовсюду
    private - делает элемент недоступным извне объявления класса
    
    модификатор доступа можно опустить, тогда он будет автоматически установлен как private
    Быстрый пример:
*/
class MyClass2
{
    public static int a;
    private string b;
    bool c;
}

static void Main()
{
    MyClass2.a = 5;
    // мы смогли изменить значение переменной внутри класса
    Console.WriteLine(MyClass1.a); // 5
    // и вывести
    
    MyClass2.b = 10;
    // ошибка, нельзя получить доступ к приватному полю
    Console.WriteLine(MyClass1.b); 
    // ошибка нельзя получить доступ к приватному полю
    
    MyClass2.c = true; 
    // ошибка, нельзя получить доступ к приватному полю
    
}

// Пока что сконцентрируйся на том что есть и попробуй что нибудь сделать
/*
    Создай пару классов, попробуй создать в одном из них Main 
    и оттуда попробуй взаимодействовать со вторым классом
*/
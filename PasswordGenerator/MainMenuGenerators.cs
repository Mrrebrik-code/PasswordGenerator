using System;

namespace PasswordGenerator
{
    class MainMenuGenerators
    {
        static void Main()
        {
            while (true)
            {
                Menu();
            }
        }

        //Меню настройки генератора
        static public void Menu()
        {
            int passwordType;
            int lenght;

            Console.Title = "Генератор паролей";
            Console.WriteLine("Какой пароль хотите создать?");
            Console.WriteLine("1. Английские символы\t2. Цифры\n3.Сложные символы\t4.Русcкие буквы");
            Console.Write("Введите цифры из списка, чтобы эти свойства применились при генерации:");
            passwordType = Int32.Parse(Console.ReadLine());
            Console.Write("Количество символов(Длина пароля):");
            lenght = Int32.Parse(Console.ReadLine());

            //Создается объект, который ссылается на класс объекта
            //И передает в качестве аргумента длинну пароля в конструктор
            Generator ObjectGenerator = new Generator(lenght);

            //Запускается метод Show() для вывода сгенерированного пароля
            //Так же в качестве аргумента передается метод, который генерирует пароль и возвращает string
            ObjectGenerator.Show(ObjectGenerator.GeneratorPass());

            Console.ReadLine();
        }
    }
}

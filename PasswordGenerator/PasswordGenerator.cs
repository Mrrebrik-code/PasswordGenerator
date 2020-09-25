using System;

namespace PasswordGenerator
{
    class PasswordGenerator
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

    class Generator
    {
        int lenght;
        bool numbersInPassword = false;

        public Generator(int lenght)
        {
            this.lenght = lenght;
        }
        
        public string GeneratorPass()
        {
            string Password = "";
            Random rnd = new Random();
            if (!numbersInPassword)
            {
                for (int i = 0; i < lenght; i++)
                {
                    Password += (char)rnd.Next(65, 90);
                }
            }
            else
            {
                for (int i = 0; i <= lenght; i++)
                {
 
                    if ((rnd.Next(1, 10) % 3) == 0)
                    {
                        Password += rnd.Next(0, 50);
                    }
                    else
                    {
                        Password += rnd.Next(65, 90);
                    }
                }
            }
            return Password;
        }

        public void Show(string Password)
        {
            Console.WriteLine("Сгенерированный пароль: {0}", Password);
        }
    }
}

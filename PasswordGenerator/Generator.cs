using System;
namespace PasswordGenerator
{
    public class Generator
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

        public void TypeGenerator()
        {
            
        }

        public void Show(string Password)
        {
            Console.WriteLine("Сгенерированный пароль: {0}", Password);
        }  
    }
}
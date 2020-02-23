using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rigistration
{
    class Program
    {
        public static List<string> listFio = new List<string> { };
        public static List<string> listLogin = new List<string> { };
        public static List<string> listPassword = new List<string> { };
        public static List<string> listKey = new List<string> { };
        public static string FileName = "Registration.txt";
   
        static void Main(string[] args)
        {
            Console.WriteLine("1. Регестрация");
            Console.WriteLine("2. Войти");
            while (true)
            {
                string a = Console.ReadLine();
                switch (a)
                {
                 case "1":
                        SignUp();
                        break;
                 case "2":
                        Console.WriteLine("Введите логин:");
                        string login = Console.ReadLine();
                        Console.WriteLine("Введите пароль:");
                        string password = Console.ReadLine();
                        LogIn(login,password);
                        break;
                }
            }
        }

        private static void LogIn(string login,string password)
        {
            bool IsLogIn = false;
            int k = 0;
            for (int i = 0; i < listLogin.Count; i++)
            {
                if (listLogin[i] == login && listPassword[i] == password)
                {
                    Console.WriteLine("Добро пожаловать!!! =>");
                    k = i;
                    IsLogIn = true;
                }
            }
            if (IsLogIn == false)
            {
                Console.WriteLine("Логин или пароль введены неправильно");
                Console.WriteLine();
                ForgotPassword(login,password,k);
            }

            Console.WriteLine();
        }

        public static void ForgotPassword(string login, string password, int k)
        {
            Console.WriteLine("Нажмите 9 для востановление пароля или нажмите 1 чтобы пропустить этот шаг");
            string a = Console.ReadLine();
            if (a == "9")
            {
                Console.WriteLine("Введите ключевое слово");
                string key = Console.ReadLine();
                bool IsLogIn = false;

                    if ( listKey[k] == key)
                    {
                        Console.WriteLine("Добро пожаловать!!! =>");
                        IsLogIn = true;
                    }

                if (IsLogIn == false)
                {
                    Console.WriteLine("ключевое слово неверно!");
                }

                Console.WriteLine();
            }

        }

        public static void SignUp()
        {
            bool b = false;
            Console.Write("Ваше ФИО :");
            string fio = Console.ReadLine();
            Console.Write("Введите логин :");
            string login = Console.ReadLine();
            string password = "";
            while (b == false)
            {
                Console.Write("Введите пароль :");
                password = Console.ReadLine();
                if (!IsPasswordProtected(password))
                {
                    Console.WriteLine("Этот пароль слишком простой");
                    Console.WriteLine();
                }
                else
                {
                    b = true;
                }
            }
            Console.Write("Введите ключевое слово для восстановление пароля :");
            string key = Console.ReadLine();
            listFio.Add(fio);
            listLogin.Add(login);
            listPassword.Add(password);
            listKey.Add(key);

            using (StreamWriter sw = new StreamWriter(FileName, true, Encoding.Default))
            {
                sw.WriteLine("Данные пользователя:");
                sw.WriteLine("ФИО : " + fio);
                sw.WriteLine("логин : " + login);
                sw.WriteLine("пароль : " + password);
                sw.WriteLine("ключ для восстановления пароля : " + key);
                sw.WriteLine();
            }
            
            Console.WriteLine();
            Console.WriteLine("Регистрация прошла успешна! ");
            Console.WriteLine();
        }

        private static bool IsPasswordProtected(string password)
        {
            bool b = false;
            if (password.Length < 6 || password[0] == ' ')
                return false;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                    b = true;
            }
            string LatinLetter = password.ToLower(); 
            foreach(char ch in LatinLetter)
            {
                if ((int)ch < 97 && (int)ch > 122)
                {
                    b = false;
                }
            }
            return b;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task3
{
    public sealed class Authenticator
    {
        private Authenticator() { }

        private static Authenticator _instance;
        public static Authenticator GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Authenticator();
            }
            return _instance;
        }

        public void Authentithicate(int login, int pass)
        {
            if (login == 1111 && pass == 1111)
            {
                Console.WriteLine("Ви успішно увійшли");
            } else
            {
                Console.WriteLine("Ви не увійшли");
            }
        }
    }
}

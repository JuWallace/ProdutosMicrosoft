using BancoDados.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoDados.Dal
{
    class SingletonContext
    {
        private static Context ctx;

        private SingletonContext()
        {

        }

        public static Context GetInstance()
        {
            if (ctx == null)
            {
                ctx = new Context();
            }
            return ctx;
        }
    }
}

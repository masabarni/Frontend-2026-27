using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{

    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        public static Singleton GetSingleton()
        {
            return instance;
        }

        private Singleton()
        {
            
        }
    }
}

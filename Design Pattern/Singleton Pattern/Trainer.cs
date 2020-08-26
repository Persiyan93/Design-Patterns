using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Pattern
{
    public sealed class Trainer:Player
    {
        private static Trainer instance;
        private int numberOfInstance = 0;
       
        private Trainer()
        {

        }
        public static Trainer Instance
        {
            get
            {
                if (instance==null)
                {
                    instance = new Trainer();
                    
                }
                return instance;
            }
        }
    }
}

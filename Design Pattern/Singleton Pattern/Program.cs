using System;
using System.Collections.Generic;

namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Trainer trainer = Trainer.Instance;

            trainer.Name = "Pesho";
            trainer.Years = 30;
            Console.WriteLine(trainer.Name, trainer.Years);
            Team team = new Team(trainer);
            Trainer trainer2 = Trainer.Instance;
            trainer2.Name = "Ivan";
            Console.WriteLine(team.trainer.Name);
            
          

        }
    }
}

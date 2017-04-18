using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanusGoat.Scratch.ConsoleApp1 {

  class Program {

    static void Main(string[] args) {
      npc n1 = new npc();
      n1.Speak();
      n1.trade();

      Console.ReadKey();
    }

  }
}

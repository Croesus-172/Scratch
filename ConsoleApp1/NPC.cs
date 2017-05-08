using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanusGoat.Scratch.ConsoleApp1 {

  public class npc {
    public npc() {
      Console.WriteLine("NPC constructor");
    }

    public void Speak() {
      Console.WriteLine("NPC Speaking");    
    } 

    public void Trade() {
      Console.WriteLine("NPC Trading");    
    } 

    public void Attack() {
      Console.WriteLine("NPC Attacking");    
    } 

  }
}

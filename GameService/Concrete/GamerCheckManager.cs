using GameService.Abstract;
using GameService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameService.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public void Control(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " is controlled");
        }
    }
}

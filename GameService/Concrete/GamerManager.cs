using GameService.Abstract;
using GameService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameService.Concrete
{
    public class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Added : " + gamer.FirstName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Deleted : " + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Updated : " + gamer.FirstName);
        }
    }
}

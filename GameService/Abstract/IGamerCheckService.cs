using GameService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameService.Abstract
{
    public interface IGamerCheckService
    {
        public void Control(Gamer gamer);
    }
}

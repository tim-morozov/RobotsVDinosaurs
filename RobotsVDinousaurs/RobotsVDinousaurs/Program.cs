﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinousaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Battlefield myBattleField = new Battlefield();
            myBattleField.Run();
            Console.ReadLine();
        }
    }
}

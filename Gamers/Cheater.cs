﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamers
{
    public class Cheater : Gamer
    {
        public Cheater(string name, int age) : base(name, age) { }

        public override GamerTypesEnum Type => GamerTypesEnum.Cheater;

        public override int GetNumber()
        {
            int num;

            while (true)
            {
                num = random.Next(40, 141);
                if (used.IndexOf(num) == -1)
                    break;
            }

            localMem.Add(num);
            return num;
        }
    }
}

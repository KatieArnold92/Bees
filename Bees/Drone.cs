﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bees
{
    class Drone : Bee
    {
        //Override the Death check, so that we can use the correct values for each kind of bee.
        public override bool CheckIfDead()
        {
            if (Health < 50)
                IsDead = true;
            return IsDead;
        }
    }
}

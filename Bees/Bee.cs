using System;
using System.Collections.Generic;
using System.Text;

namespace Bees
{
    public class Bee
    {
        private float _health;
        private bool _isDead;

        //Cannot set health manually, so there is no set function within the property.
        public float Health { get { return _health; } }
        public bool IsDead { get { return _isDead; } set { _isDead = value; } }

        //Main constructor.
        public Bee()
        {
            _health = 100;
            _isDead = false;
        }

        //Our damage method.
        public bool Damage(int damage)
        {
            //Check if the bee is dead, if so, just return and continue
            if (_isDead)
                return false;

            //Check whether damage is within allowed ranges.
            if (damage > 100 || damage < 0)
            {
                //Write to console so we can see straight away that an error has occurred, but not halt the application. This is good for debugging an application
                //where you are handling data and have a visual outlet for any problems that might occurr whilst iterating through data. I always keep a thrown exception
                //to one side, commented out, for when I believe any bugs have been ironed out.
                Console.WriteLine("Error: Invalid damage value. Must be between 0 and 100 inclusive. Value: " + damage);
                //throw new Exception("Error: Damage value must be between 0 and 100 inclusive.")
                return false;
            }
            else
            {
                _health -= damage;
                if (_health < 0) //To Prevent Minuses
                    _health = 0;
                //Update death status once damage applied.
                CheckIfDead();
            }

            return true;
        }

        //virtual method to be overridden with different values for whether bees are dead or not.
        public virtual bool CheckIfDead()
        {
            return _isDead;
        }
    }
}

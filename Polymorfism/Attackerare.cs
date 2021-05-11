using System;

namespace Polymorfism
{
    public class Attackerare
    {
        protected int hp;

        public virtual void Attack()
        {

            hp = 10;
            System.Console.WriteLine(hp);
            Console.ReadLine();
        }
    }
}

using System;
using System.Linq;

namespace LibraryLaba14
{
    /// <summary>
    ///  battle with fighter
    /// </summary>
    public class Tournament
    {
        public bool fight = true;
        public bool kickFirst = true;
        /// <summary>
        /// default construct
        /// </summary>
        /// <param name="ht"></param>
        public Tournament(HeroTemplate[] ht)
        {
            this.ht = ht;
            if (ht.Count() % 2 != 0)
                throw new MyException();
        }
        /// <summary>
        /// main buttle
        /// </summary>
        public void Buttle()
        {
            ht[0].Dead += Tournament_Dead;
            ht[1].Dead += Tournament_Dead;
            ht[0].Stun += Tournament_Stun;
            ht[1].Dodge += Tournament_Dodge;

            while (fight)
            {
                if (kickFirst)
                {
                    kickFirst = false;
                    ht[0].IsStun();
                    ht[0].Attack(ht[1]);
                }
                if (kickFirst == false && fight == true)
                {
                    kickFirst = true;
                    ht[1].IsDodge();
                    ht[1].Attack(ht[0]);
                }
            }
        }
        /// <summary>
        /// event isDodge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tournament_Dodge(object sender, EventArgs e)
        {
            kickFirst = false;
            Console.WriteLine($"{(sender as HeroTemplate).Name} dodged");
        }
        /// <summary>
        /// event isStun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tournament_Stun(object sender, EventArgs e)
        {
            kickFirst = true;
            Console.WriteLine($"{(sender as HeroTemplate).Name} stun {ht[1].Name}");
        }
        /// <summary>
        /// event isDead
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tournament_Dead(object sender, EventArgs e)
        {
            fight = false;
            Console.WriteLine($"{(sender as HeroTemplate).Name} dead");
        }
        /// <summary>
        /// check equal objects
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>bool param</returns>
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        /// <summary>
        /// hash code for equals
        /// </summary>
        /// <returns>hash code</returns>
        public override int GetHashCode()
        {
            return ht.Count();
        }

        HeroTemplate[] ht;
    }
}

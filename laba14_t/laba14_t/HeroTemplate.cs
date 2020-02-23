using System;
namespace LibraryLaba14
{
    /// <summary>
    /// pattern class for heroes
    /// </summary>
    public abstract class HeroTemplate
    {
        public static Random rd = new Random();


        /// <summary>
        /// base costructor
        /// </summary>
        /// <param name="minDamage"></param>р
        /// <param name="maxDamage"></param>
        /// <param name="name"></param>
        /// <param name="hp"></param>
        public HeroTemplate(int minDamage, int maxDamage, string name, int hp)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            HP = hp;
            Name = name;
        }

        public virtual event EventHandler Dead;
        public virtual event EventHandler Stun;
        public virtual event EventHandler Dodge;
        /// <summary>
        /// set need parametrs
        /// </summary>
        public virtual string Name { get; set; }
        public virtual string Life { get; set; }
        public virtual string Damage { get; set; }
        public virtual int MinDamage { get; set; }
        public virtual int MaxDamage { get; set; }
        public virtual int HP { get; set; }
        /// <summary>
        /// attack hero
        /// </summary>
        /// <param name="other"></param>
        public virtual void Attack(HeroTemplate other)
        {
            other.GetDamage(rd.Next(MinDamage, MaxDamage) + 1);
        }
        /// <summary>
        /// Hero Get Damage
        /// </summary>
        /// <param name="damage"></param>
        public virtual void GetDamage(int damage)
        {
            this.hp -= damage;
            if (this.hp < 0)
                Dead?.Invoke(this, null);
        }
        /// <summary>
        /// Stun Hero
        /// </summary>
        public virtual void IsStun()
        {
            int k = rd.Next(5, 25);
            if (k < rd.Next(1, 100))
            {
                Stun?.Invoke(this, null);
            }
        }
        ///<summary>
        /// Is hero Dodge
        /// </summary>
        public virtual void IsDodge()
        {
            int k = rd.Next(10, 26);
            if (k < rd.Next(1, 100))
            {
                Dodge?.Invoke(this, null);
            }
        }
        private int hp;
    }
}

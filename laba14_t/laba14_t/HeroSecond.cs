﻿using System;

namespace LibraryLaba14
{
    /// <summary>
    /// Second fighter
    /// </summary>
    public class HeroSecond : HeroTemplate
    {
        /// <summary>
        /// events
        /// </summary>
        public override event EventHandler Dead;
        public override event EventHandler Dodge;

        /// <summary>
        /// contstr for first hero
        /// </summary>
        /// <param name="minDamage"></param>
        /// <param name="maxDamage"></param>
        /// <param name="name"></param>
        /// <param name="hp"></param>
        public HeroSecond(int minDamage, int maxDamage, string name, int hp) : base(minDamage, maxDamage, name, hp)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            HP = hp;
        }
        /// <summary>
        /// hp character
        /// </summary>
        public override int HP
        {
            get => hp;
            set
            {
                if ((value >= 135) && (value <= 170))
                {
                    hp = value;
                }
                else
                    throw new Exception();
            }
        }
        /// <summary>
        /// Check min damage
        /// </summary>

        public override int MinDamage
        {
            get => minDamage;
            set
            {
                if ((value >= 5) && (value <= 55))
                {
                    minDamage = value;
                }
                else
                    throw new Exception();
            }
        }
        /// <summary>
        /// check max damage
        /// </summary>
        public override int MaxDamage
        {
            get => maxDamage;
            set
            {
                if ((value >= 5) && (value <= 55))
                {
                    maxDamage = value;
                }
                else
                    throw new Exception();
            }
        }
        /// <summary>
        /// check IsDogle
        /// </summary>
        public override void IsDodge()
        {
            int k = rd.Next(10, 26);
            if (k > rd.Next(1, 100))
            {
                Dodge?.Invoke(this, null);
            }
        }
        /// <summary>
        /// attack other hero
        /// </summary>
        /// <param name="other"></param>

        public override void Attack(HeroTemplate other)
        {
            other.GetDamage(rd.Next(MinDamage, MaxDamage) + 1);
        }
        /// <summary>
        /// get damage for other hero
        /// </summary>
        /// <param name="damage"></param>
        public override void GetDamage(int damage)
        {
            this.hp -= damage;
            if (this.hp < 0)
                Dead?.Invoke(this, null);
        }
        /// <summary>
        /// equals objects
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>bool param</returns>
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        /// <summary>
        /// hash code fore equdals
        /// </summary>
        /// <returns>hash code</returns>
        public override int GetHashCode()
        {
            return HP + minDamage + maxDamage;
        }
        /// <summary>
        /// output character param
        /// </summary>
        /// <returns>ctring parametrs</returns>
        public override string ToString()
        {
            return ($"HP = {hp} minDamage = {minDamage} maxDamage = {maxDamage} name = {Name}").ToString();
        }

        int hp;
        int minDamage;
        int maxDamage;
    }
}

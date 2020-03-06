using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUP8
{
    /// <summary>
    /// structor for moment of time
    /// </summary>
    public struct MomentOfTime: IComparable<MomentOfTime>, ICloneable
    {
        int hours;
        int minutes;
        int seconds;
        
        /// <summary>
        /// constructor for copy
        /// </summary>
        /// <param name="momentOfTime"></param>
        public MomentOfTime(MomentOfTime momentOfTime) 
        {
            this.hours = momentOfTime.hours;
            this.minutes = momentOfTime.minutes;
            this.seconds = momentOfTime.seconds;
        }
        /// <summary>
        /// default constructor
        /// </summary>
        /// <param name="hours"></param>
        /// <param name="minutes"></param>
        /// <param name="seconds"></param>
        public MomentOfTime(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
        /// <summary>
        /// clone object
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new MomentOfTime(this);
        }
        /// <summary>
        /// compare two time of moment
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(MomentOfTime other)
        {
            if (this.hours == other.hours)
            {
                if (this.minutes == other.minutes)
                {
                    if (this.seconds > other.seconds)
                    {
                        return 1;
                    }
                    if (this.seconds < other.seconds)
                    {
                        return -1;
                    }
                }
                if (this.minutes > other.minutes)
                {
                    return 1;
                }
                if (this.minutes < other.minutes)
                {
                    return -1;
                }
            }
            if (this.hours > other.hours)
            {
                return 1;
            }
            if (this.hours < other.hours)
            {
                return -1;
            }
            return 0;
        }

        public override string ToString()
        {
            return ($"hours = {hours}, minutes = {minutes}, second = {seconds}").ToString();
        }
    }
}

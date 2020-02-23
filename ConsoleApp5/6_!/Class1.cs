using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6__
{
    class Counter
    {
        private int count; //поле сount
        private int limitMax = 32767; //поле определяющее максимальную границу счетчика
        private int limitMin = 0; //поле определяющее максимальную границу счетчика

        public int this[int index] //индексатор
        {
            get => this[index];
        }

        public Counter() //конструктор
        {
            count = 1; //задаем count для перегруженного конструктора
        }
        public Counter(int count, int limitMax) //перегруженный конструктор
        {
            if (count <= limitMax && count >= limitMin)
                this.count = count;
            else
            { Console.WriteLine("Вы вышли за возможные границы"); }

        }
        private int Count //свойство Count
        {
            get { return count; }
        }

        public void CountDown() //метод уменьшения Count
        {
            count--;
        }
        public void CountUp() //метод увеличения Count
        {
            count++;
        }
        public bool Range()
        {
         return true;
        }
        public static Counter operator -(Counter obj1, Counter obj2) //оператор -
        {
            obj1.count = obj1.count - obj2.count;
            if (obj1.count < 0)
            { obj1.count = 0; }
            return obj1;
        }
        public static Counter operator +(Counter obj1, Counter obj2) //оператор +
        {
            obj1.count = obj1.count + obj2.count;
            if (obj1.count > 32767)
            { obj1.count = 0; }
            return obj1;
        }
        public void ShowCount(int score) //метод вывода текущего значения
        {
            Console.WriteLine("Текущее значение счетчика: " + Convert.ToString(Count, score));
        }
    }
}

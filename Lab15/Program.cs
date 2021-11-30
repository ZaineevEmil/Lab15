using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Реализация класса арифметической прогресии
            ArithProgression AP = new ArithProgression();
            Console.WriteLine("Программа расчета арифметической прогресии.\n\nВведите параметры прогресии: начальное значение, шаг прогрессии, количество шагов прогрессии");
            Console.Write("начальное значение: ");
            AP.setStart(Convert.ToInt32(Console.ReadLine()));
            Console.Write("\nшаг прогрессии: ");
            AP.Step = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nколичество шагов прогрессии: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Следующий член прогресии: " + AP.getNext());
            }
            AP.reset();
            Console.Write("\n\nВведине другое начальное значение: ");
            AP.setStart(Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Следующий член прогресии: " + AP.getNext());
            }

            //Реализация класса геометрической прогресии
            GeomProgression GP = new GeomProgression();
            Console.WriteLine("\n\n\nПрограмма расчета геометрической прогресии.\n\nВведите параметры прогресии: начальное значение, шаг прогрессии, количество шагов прогрессии");
            Console.Write("начальное значение: ");
            GP.setStart(Convert.ToInt32(Console.ReadLine()));
            Console.Write("\nшаг прогрессии: ");
            GP.Step = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nколичество шагов прогрессии: ");
            int g = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < g; i++)
            {
                Console.WriteLine("Следующий член прогресии: " + GP.getNext());
            }
            GP.reset();
            Console.Write("\n\nВведине другое начальное значение: ");
            GP.setStart(Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < g; i++)
            {
                Console.WriteLine("Следующий член прогресии: " + GP.getNext());
            }
            Console.ReadKey();
        }
    }
    interface ISeries
    {
        //устанавливает начальное значение
        void setStart(int x);

        //возвращает следующее число ряда
        int getNext();

        //выполняет сброс к начальному значению
        void reset();
    }
    class ArithProgression : ISeries
    {
        int step;
        public int Step
        {
            get
            {
                return step;
            }
            set
            {
                step = value;
            }
        }
        int xFirst = 0;
        int xNext = 0;
        public int getNext()
        {
            xNext = xNext + step;
            return xNext;
        }

        public void reset()
        {
            xNext = xFirst;
        }

        public void setStart(int x)
        {
            xFirst = x;
            xNext = xFirst;
        }
    }

    class GeomProgression : ISeries
    {
        int step;
        public int Step
        {
            get
            {
                return step;
            }
            set
            {
                step = value;
            }
        }
        int xFirst = 0;
        int xNext = 0;
        public int getNext()
        {
            xNext = xNext*step;
            return xNext;
        }

        public void reset()
        {
            xNext = xFirst;
        }

        public void setStart(int x)
        {
            xFirst = x;
            xNext = xFirst;
        }
    }
}

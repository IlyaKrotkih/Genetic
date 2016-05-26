using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic
{
    //Класс популяция. предназначен для хранения 
    //информации и работы с текущей итерации.
    

    public class Population
    {
        public List<PopulationElement> CurrentPopulation; //Текущая популяция (скрещивание).
        public List<PopulationElement> ParrentPopulation; //Родительская популяция.
        public List<PopulationElement> MutationPopulation;//Мутация.
        public List<PopulationElement> AllCurrentPopulation;//Объединение родителей и мутаций.
        public List<PopulationElement> AnswerPopulation; //Ответ.

        public double Answer = -1; // Ответ - минимальное значение в популяции.

        public int PopulationCount; // Число популяции.
        public int PopulationNumber; // Номер итерации.

        // Конструктор для генерации новой (первоначальной) популяции.
        public Population(int count, int number)
        {
            this.PopulationCount = count;
            this.PopulationNumber = number;
            AnswerPopulation = new List<PopulationElement>();
            genPopulation(PopulationCount); // Генерируем популяцию.
            getAnswerElement(); // Получаем ответ.
        }

        // Создание новой популяции на основе родителей.
        public Population(List<PopulationElement> parrent, int count, int number)
        {
            this.ParrentPopulation = parrent;
            this.PopulationCount = count;
            this.PopulationNumber = number;
            Crossing(); // Производим скрещивание.
            PopMutation(); // Мутация.
            Selection();// Выборка наилучших.
            getAnswerElement(); // Получаем ответ.
        }

        //Скрещивание
        public void Crossing()
        {
            CurrentPopulation = new List<PopulationElement>();
            for (int i = 0; i < ParrentPopulation.Count-1; i += 2)
            {
                // Меняем X и Y
                byte[] Y1, Y2, X1, X2;
                Y1 = ParrentPopulation[i].Y;
                X1 = ParrentPopulation[i].X;
                Y2 = ParrentPopulation[i + 1].Y;
                X2 = ParrentPopulation[i + 1].X;
                CurrentPopulation.Add(new PopulationElement(X1, Y2));
                CurrentPopulation.Add(new PopulationElement(X2, Y1));
            }
        }

        //Мутация
        public void PopMutation()
        {
            MutationPopulation = new List<PopulationElement>();
            Random rnd = new Random();
            foreach (PopulationElement o in CurrentPopulation)
            {
                byte[] X, Y;
                X = o.X.Clone() as byte[];
                Y = o.Y.Clone() as byte[];
        
                PopulationElement p = new PopulationElement(X, Y);
                p.Mutation(rnd);// Вызываем мутацию
                MutationPopulation.Add(p);
            }
        }

        //Сортировка и отборка
        public void Selection()
        {
            AllCurrentPopulation = new List<PopulationElement>(ParrentPopulation);
            AllCurrentPopulation.AddRange(MutationPopulation);
            AnswerPopulation = AllCurrentPopulation
                .OrderBy(i1 => i1.F)// Сортируем по F
                .Take(PopulationCount).ToList(); //Выборка первых наилучших
        }

        //Генерация популяции
        public void genPopulation(int count)
        {
            AnswerPopulation = new List<PopulationElement>();
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                AnswerPopulation.Add(new PopulationElement(rnd));// Добавляем новые элементы в список.
            }
        } 

        // Получаем элемент - ответ.
        public void getAnswerElement()
        {
            Answer = AnswerPopulation.Min(i1 => i1.F);
        }

        public override string ToString()
        {
            if(Answer != -1)
                return "Популяция №" + PopulationNumber + ", Наименьшее значение: " + Answer.ToString("F");
            else return "Популяция №" + PopulationNumber + ", Наименьшее значение: нет";
        }
    }

    public class PopulationElement
    {
        public byte[] X = new byte[8]; // X
        public byte[] Y = new byte[8]; // Y
        public double valX, valY, D1, D2, F;
        private Random rnd;

        // Конструктор для генерации нового элемента.
        public PopulationElement(Random rand)
        {
            rnd = rand;
            genXY();// Генерируем X и Y.
            Calculate();// Высчитываем значения valX, valY, D1, D2, F.
        }
        
        // Конструктор, создает элемент на основе X и Y.
        public PopulationElement(byte[] x, byte[] y)
        {
            this.X = x;
            this.Y = y;
            Calculate();
        }
        
        // Высчитывает значения valX, valY, D1, D2, F.
        private void Calculate()
        {
            int znx, zny;
            znx = (X[0] == 0) ? 1 : -1;
            zny = (Y[0] == 0) ? 1 : -1;
            valX = znx * ((4 * X[1]) + (2 * X[2]) + X[3] + (0.5 * X[4]) + (0.25 * X[5]) + (0.125 * X[6]) + (0.0625 * X[7]));
            valY = zny * ((4 * Y[1]) + (2 * Y[2]) + Y[3] + (0.5 * Y[4]) + (0.25 * Y[5]) + (0.125 * Y[6]) + (0.0625 * Y[7]));
            D1 = -1.0 * Math.Exp(valX + 1) + Math.Pow(2.0, valX * valY + 3) + 0.75;
            D2 = 10 * valX + 2.0 * valY;
            F = Math.Abs(D1) + Math.Abs(D2);
        }

        // Мутация.
        public void Mutation(Random rnd)
        {
            int i = rnd.Next(0, X.Length);
            if (Convert.ToBoolean(rnd.Next(0, 2)))
                X[i] = Convert.ToByte(Math.Abs(X[i] - 1));
            else
                Y[i] = Convert.ToByte(Math.Abs(Y[i] - 1));
            Calculate();
        }

        //Генерация X и Y
        public void genXY()
        {
            for (int i = 0; i < X.Length; i++)
                X[i] = Convert.ToByte(rnd.Next(0, 2));
            for (int i = 0; i < Y.Length; i++)
                Y[i] = Convert.ToByte(rnd.Next(0, 2));
        }

        public override string ToString()
        {
            return "X: " + String.Concat(X) + " Y: " + String.Concat(Y);
        }
    }
}

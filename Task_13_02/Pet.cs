using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_02
{
    internal class Pet
    {
        #region поля
        private string name;
        private string kind;
        private string age;
        private string weight;
        private string health;
        #endregion

        #region св-ва
        public string Name
        {
            get { return name; }
            set
            {
                if (value != null)
                    name = value;
                else Console.WriteLine("ОШИБКА! ИМЯ ОТСУТСТВУЕТ");

            }
        }
        public string Kind
        {
            get { return kind; }
            set
            {
                if (value != null)
                    kind = value;
                else
                Console.WriteLine("ОШИБКА! ОТСУТСТВУЕТ ВИД ЖИВОТНОГО");
            }
        }
        public string Age
        {

            get { return age; }
            set
            {
                if (value != null)
                    age = value;
                else
                    Console.WriteLine("ОШИБКА! ОТСУТСТВУЕТ ВОЗРАСТ ЖИВОТНОГО");
            }
        }
        public string Weight
        {
            get { return weight; }
            set
            {
                if (value != null)
                    weight = value;
                else
                    Console.WriteLine("ОШИБКА! ОТСУТСТВУЕТ ВЕС ЖИВОТНОГО");
            }
        }
        public string Health
        {
            get { return health; }
            set
            {
                if (value != null)
                    health = value;
                else
                    Console.WriteLine("ОШИБКА! ОТСУТСТВУЕТ ОТМЕТКА О СОСТОЯНИИ ЖИВОТНОГО");
            }
        }
        #endregion
    
    #region методы
   /// <summary>
   /// возвращает текущую информацию об объекте
   /// </summary>
   /// <returns>строка с информацией</returns>
    public string GetInfoAnimal()
        {
            return $"Кличка животного - {name}\nВид - {kind}" +
                $"\nВозраст - {age}\nВес - {weight}\nОтметка о состоянии здоровья - {health}";
        }
        /// <summary>
        /// изменение веса объекта
        /// </summary>
        /// <param name="a">новый вес объекта</param>
        public void WeightChange(string a)
        {
            Weight = a;
        }
        /// <summary>
        /// изменение состояния здоровья объекта
        /// </summary>
        /// <param name="a">новое состояние здоровья объекта</param>
        public void HealthChange(string a)
        {
            Health = a;
        }

        #endregion
        #region конструкторы
        public Pet(string name, string kind, string age, string weight, string health)
        {
            this.name = name;
            this.kind = kind;
            this.age = age;
            this.weight = weight;
            this.health = health;
        }
        public Pet(string name, string kind, string age, string weight)
        {
            this.name=name;
            this.kind = kind;
            this.age = age;
            this.weight = weight;
        }
        public Pet(string name, string kind, string age)
        {
            this.name = name;
            this.kind = kind;
            this.age = age;
        }
        public Pet(string name,string kind)
        {
            this.name = name;
            this.kind = kind;
        }
        public Pet(string name)
        {
            this.name = name;
        }
        public Pet() { }
        #endregion
    }
}
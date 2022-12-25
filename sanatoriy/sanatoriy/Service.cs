using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sanatoriy
{
    // надо добавить в структуру Услуги список врач-время и записавшийся-время для работы программы
    internal class Service
    {
        string schedule; // убрать, заменив на словарь врач-время и записавшийся-время  
        string price;
        string description;
        public string Schedule { get { return schedule; } set { Schedule = value; } }
        public string Price { get { return price; } set { price = value; } }
        public string Desription { get { return description; } set { description = value; } }
        /// <summary>
        /// //Конструктор класса услуга, который создает элементы класса Услуга.
        /// </summary>
        public Service()
        {
            schedule = "";
            price = "";
            description = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateNetwork
{
    class JournalEntry //Класс сообщения об обновлении
    {
        public JournalEntry(string _source, string _changes, DateTime _time, string _info) //Конструктор
        {
            Source = _source;
            Changes = _changes;
            Time = _time;
            Information = _info;
        }

        private readonly string Source;

        private readonly string Changes;

        private readonly DateTime Time;

        private readonly string Information;

        public override string ToString() //Нормальный вывод
        {
            string output = "";
            output += "Сообщение о событии у " + Source + "\n";
            output += "        Тип события: " + Changes + "\n";
            output += "        Что произошло: " + Information + "\n";
            output += "        Время: " + Time.ToShortTimeString() + " " + Time.ToShortDateString() + "\n";
            return output;
        }
    }
}

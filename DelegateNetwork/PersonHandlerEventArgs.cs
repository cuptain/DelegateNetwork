using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateNetwork
{
    public class PersonHandlerEventArgs : EventArgs
    {
        public string Source { get; set; } //Источник
        public string Changes { get; set; } //Что произошло
        public DateTime Time { get; set; } //Время события
        public string Information { get; set; } //Доп. информация

        public PersonHandlerEventArgs(string _source, string _changes, DateTime _time, string _information) //Конструктор
        {
            Source = _source;
            Changes = _changes;
            Time = _time;
            Information = _information;
        }

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

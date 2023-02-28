/// @author Саранчин К.А.
/// Реализация методов класса на С#
/// Дата и операции с ней
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDate
{
    public class Date
    {
        /// День
        private int day;
        /// Месяц
        private int year;
        /// Год
        private int month;
        /// Массив дней в месяце
        // Добавил 13 элемент массива, если что удалить в месяце.
        private static readonly int[] mm = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31, 0 };

        /// Конструктор без параметров
        public Date()
        {
            day = 0;
            month = 0;
            year = 0;
        }

        /// Конструктор с параметрами
        public Date(int d, int m, int y)
        {
            SetYear(y);
            SetMonth(m);
            SetDay(d);
        }

        /// Деструктор
        ~Date() { }

        /// Задать день 
        public void SetDay(int d)
        {
            if ((d < 0) || (d > 31)) throw new ArgumentException("invalid parameter: day");
            day = d;
        }

        /// Задать месяц
        public void SetMonth(int m)
        {

            if ((m < 0) || (m > 12)) throw new ArgumentException("invalid parameter: month");

            if ((day <= 0) || (day <= mm[m]))
            {
                month = m;
            }
            else
            {
                month = m + 1;
                day -= mm[m];
                year++;
            }

        }

        /// Задать год
        public void SetYear(int y)
        {
            if (y < 0) throw new ArgumentException("invalid parameter: year");
            year = y;
        }

        /// Перевод времени в дни 
        public int ConvertDate()
        {
            int days = 0;
            for (int i = 0; i < month; i++)
            {
                days += mm[i];
            }
            days += day + year * 365;
            return days;
        }

        /// Преобразовать дни в дату 
        public void SetDateInDay(int dd)
        {
            int y = dd / 365;
            SetYear(y);
            int x = dd % 365;
            int mon = 0;
            for (int i = 0; i < 12; i++)
            {
                if (x < mm[i])
                {
                    SetMonth(mon);
                    SetDay(x);
                    break;
                }
                x -= mm[i];
                mon++;

            }
        }

        /// Задать дату
        public void SetDate(int d, int m, int y)
        {
            SetDay(d);
            SetMonth(m);
            SetYear(y);
        }

        ///Получить дни
        public int GetDay() { return day; }

        ///Получить месяца
        public int GetMonth() { return month; }

        ///Получить года
        public int GetYear() { return year; }

        /// Добавить дни
        public void AddDay(int d)
        {
            if (d < 0) throw new ArgumentException("Invalid parameter: seconds");
            int d1 = this.ConvertDate();
            d1 += d;

            this.SetDateInDay(d1);
        }

        public int CalcDay(Date d1, Date d2)
        {
            int D1 = d1.ConvertDate();
            int D2 = d2.ConvertDate();
            D2 += D1;
            this.SetDateInDay(D2);

            //int D2 = this.ConvertDate();
            //D2 += D1;

            //if (d < 0) throw new ArgumentException("Invalid parameter: seconds");
            //int d1 = this.ConvertDate();
            //d1 += d;

            //this.SetDateInDay(D2);
            return D2;
        }

        public int SubDate(Date d1, Date d2)
        {
            int D1 = d2.ConvertDate();
            int D2 = d1.ConvertDate();
            D2 -= D1;
            this.SetDateInDay(D2);
            return D2;
        }




        /// Удалить день
        public void SubDay(int d)
        {
            if (d < 0) throw new ArgumentException("Invalid parameter: seconds");
            int d1 = this.ConvertDate();
            d1 -= d;

            this.SetDateInDay(d1);
        }

        /// Добавить месяц
        public void AddMonth(int m)
        {
            if (m < 0) throw new ArgumentException("invalid parameter: month");

            if (m + month >= 12)
            {
                year += +m / 12;
                SetDate(day, month + m - 12, year + 1);

            }
            else
                SetDate(day, month + m, year);
        }

        /// Убрать месяц
        public void SubMonth(int m)
        {
            if (m < 0) throw new ArgumentException("invalid parameter: month");

            if (month - m <= 0)
            {
                year -= m / 12;
                SetDate(day, month - m + 12, year - 1);

            }
            else
                SetDate(day, month - m, year);
        }

        /// Добавить год
        public void AddYear(int y)
        {
            if (y < 0) throw new ArgumentException("invalid parameter: month");
            SetDate(day, month, year + y);
        }

        /// Убрать год
        public void SubYear(int y)
        {
            if (y < 0) throw new ArgumentException("invalid parameter: month");
            if (year - y < 0) throw new ArgumentException("invalid parameter: year < 0");
            SetDate(day, month, year - y);
        }


        /// Вывести дату в стандартном формате 
        override public string ToString()
        {
            return Convert.ToString(day) + " days " + Convert.ToString(month) + " month " + Convert.ToString(year) + " year";// +std::to_string(convert_date()) + " all day";
        }

    }

}

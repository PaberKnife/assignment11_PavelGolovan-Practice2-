using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment11_PavelGolovan_Practice2_
{
    class Car
    {
        private int _year;
        private string _make;
        private int _speed;

        public Car()
        {
            _year = -1;
            _make = "";
            _speed = 0;
        }

        public int Accelerate()
        {
            _speed += 5;
            return Speed;
        }

        public int Brake()
        {
            if (_speed >= 5)
            {
                _speed -= 5;
                return Speed;
            }
            return Speed;
        }

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }
        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }
        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class_Cat
{
    public class CatClass
    {
        private string _name;
        private  int? _age;
        public string Color { get; set; } 
        private int _health = 5;
        public int? CatAge
        {
            get { return _age; }
            set
            {
                if (_age == null)
                {
                    _age = value;
                }
            }
        }

       public CatColors colors = new CatColors();

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = value;
                }
            }
        }

        public string CurrentColor
        {
            get
            {
                if (_health >= 5)
                    return colors.HealthyColor;
                else
                {
                    return colors.SickColor;
                }
            }
        }

        public void ChangeCatColor()
        {
            if (_health < 5)
            {
                Color = colors.SickColor;
            }
            if (_health >= 5)
            {
                Color = colors.HealthyColor;
            }
            
        }

        public void Feed(int n)
        {
            _health = _health + n;
            ChangeCatColor();
        }

        public void Punish(int h)
        {
            _health = _health - h;
            ChangeCatColor();
        }
    }

    public class CatColors
    {
        public string HealthyColor { get; set; } = "Белый";

        public string SickColor { get; set; } = "Зеленый";
    }

}


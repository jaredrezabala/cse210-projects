using System;

    class  Shape
    {
        public string color;

        public Shape(string color)
        {
            this.color = color;
        }

        public string getColor()
        {
            return color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public virtual double GetArea()
        {
            double a = 0;
            double b = 0;
            return a + b;
        }
    }
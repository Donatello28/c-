using System;
using System.Collections.Generic;
using System.Text;

namespace testMyself
{
    class fraction :IComparable
    {
        public float X { get; set; }
        private float y;

        public float Y
        {
            get { return y; }
            set { if (value != 0)
                    y = value;
                else {
                    y = 1;
                }
            }
        }

        public fraction (float x,float y)
        {
            this.X = x;
            this.Y = y;
        }

        public int CompareTo(object obj)
        {
            fraction fra = obj as fraction;
            if(fra != null)
            {
                return (this.X / this.Y).CompareTo(fra.X / fra.Y);
            }
            else
            {
                return 1;
            }
        }
    }
}

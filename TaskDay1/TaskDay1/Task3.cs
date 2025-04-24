using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay1
{
    //class Rectangle
    // def initialize(width, height)
    // @width, @height = width, height
    // end
    // def set_width(width)
    // @width = width
    // end
    // def set_height(height)
    // @height = height
    // end
    //end
    //class Square<Rectangle "inherits"
    // def set_width(width)
    // super(width)
    // @height = height
    // end
    // def set_height(height)
    // super(height)
    // @width = width
    // end
    //end

    //public class rectangle
    //{
    //    protected int width;
    //    protected int height;
    //    public void setWidth (int w){ 
    //        this.width = w;
    //    }
    //    public void setheight(int h)
    //    {
    //        this.height = h;
    //    }
    //}
    //public class square:rectangle
    //{
    //    public void setWidth(int w)
    //    {
    //        this.setWidth(w);
    //        height = w;

    //    }
    //    public void setheight(int h)
    //    {
    //        this.setheight(h);
    //        this.width = h;
    //    }


    //}


    public interface IShape
    {
        int GetArea();
    }
    public class rectangle:IShape
    {
        protected int width;
        protected int height;
        public void setWidth(int w)
        {
            this.width = w;
        }
        public void setheight(int h)
        {
            this.height = h;
        }

        public int GetArea()
        {
            return width*height;
        }
    }


    public class square : IShape
    {
        int lengthL;
        public void setlengthL(int lengthL)
        {
            this.lengthL = lengthL;

        }
        public int GetArea()
        {
            return lengthL * lengthL;
        }

    }
}

using System;

namespace Shape
{

    public class Rectangle
    {
        private Nullable<double> width;
        private Nullable<double> length;
        
        private string widthString;
        private string lengthString;
            
        public Rectangle(Nullable<double>  width, Nullable<double>  length) 
        {
                this.width = width;
                this.length = length;
        }

        public Rectangle(string widthString, string lengthString){
            this.widthString = widthString;
            this.lengthString = lengthString;
        }



        public override bool Equals(Object obj)
        {
            Rectangle b = obj as Rectangle;

            if (b != null && this.length == b.length && this.width == b.width )
            {
                return true;
            }
        
            else{
                 return false;
            }
        }

        // public override int GetHashCode()
        // {
        //     return base.GetHashCode();
        // }

        public Nullable<double> CalculateArea()
        {
            // try{
            //
            //     double area = width*length;
            //     return area;
            //
            // }catch (ArgumentOutOfRangeException)
            // {
            //     throw new ArgumentOutOfRangeException($"{nameof(width)} or {nameof(length)} cannot be 0 or negative");
            // }
            
            if(width >0 && length >0){
                Nullable<double> area = width*length;
                return area;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"{nameof(width)} or {nameof(length)} cannot be 0 or negative");
            }

        }
        public Nullable<double> CalculatePermiterOfRectangle()
        {
            
                if (width > 0 && length >0)
                {
                    Nullable<double> permiteter = (2*width)+(2*length);
                    return permiteter;
                }else if (width < 0 || length <0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else if (width is null || length is null)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    throw new Exception();
                }
        }
        
    }   

}

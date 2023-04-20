using System;
using Xunit;
using Shape;

namespace Shape.Tests
{
    public class  RectangleTest
    {
        [Fact]
        public void Ensure_RectangleA_Is_Equal_To_RectangleB_Successfully()
        {
           //Arrange
            Rectangle rectangleA = new Rectangle(10, 11);
            Rectangle rectangleB = new Rectangle(10, 11);
           
           //Act

           //Assert
           Assert.True(rectangleA.Equals(rectangleB));
        }
        /// <summary>
        ///     Notice a variation in the patterning of the result.
        /// </summary>
        [Fact]
        public void Ensure_RectangleA_Is_Not_Equal_To_ReactangelB_Successfully()
        {
           //Arrange
            Rectangle rectangleA = new Rectangle(10, 12);
            Rectangle rectangleB = new Rectangle(10, 11);
           
           //Act
           bool testResult = rectangleA.Equals(rectangleB);
           //Assert
           Assert.False(testResult);
        }
        
        [Fact] 
        public void Calculate_Permitere_Of_A_Rectangle_Successfully() 
        {
            //Arrange
            Rectangle rectangleA = new Rectangle(10, 11);
            const double TrueValueOFPermitere = 42;

            //Act
            Nullable<double> PermitereOfRectangle = rectangleA.CalculatePermiterOfRectangle();
            
            //Assert
            Assert.True(TrueValueOFPermitere == PermitereOfRectangle);
        }

        [Fact]
        public void Calculate_Area_Of_A_Rectangle_Successfully()
        {
            //Arrange
            Rectangle rectangleA = new Rectangle(10, 11);
            const double TrueValueOFArea = 110;

            //Act
            Nullable<double> areaOfRectangle = rectangleA.CalculateArea();
            
            //Assert
            Assert.True(TrueValueOFArea == areaOfRectangle);
        }

        [Fact] 
        public void Calculate_Area_Of_A_Rectangle_Unuccessfully() 
        {
            //Arrange
            Rectangle rectangleA = new Rectangle(10, 11);
            const double TrueValueOFArea = 100;

            //Act
            Nullable<double> areaOfRectangle = rectangleA.CalculateArea();
            
            //Assert
            Assert.True(TrueValueOFArea != areaOfRectangle);
        } 
        
        [Fact] 
        public void Calculate_Area_Of_A_Rectangle_Unuccessfully_With_Exception() 
        {
            //Arrange
            Rectangle rectangleA = new Rectangle(-10, 11);
            

            //Assert +Act
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var incorrectArea = rectangleA.CalculateArea();
            });
            
        }

        [Fact] 
        public void Calculate_Permitere_Of_A_Rectangle_Unuccessfully_With_ArgoutofrangeException() 
        {
            //Arrange
            Rectangle rectangleA = new Rectangle( -10, 11);

            //Act + Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var exceptionPerimeter = rectangleA.CalculatePermiterOfRectangle();
            });

        }
        
        [Fact] 
        public void Calculate_Permitere_Of_A_Rectangle_Unuccessfully_With_NullException() 
        {
            //Arrange
            Rectangle rectangleB = new Rectangle( null, 1);

            //Act + Assert
            Assert.Throws<ArgumentNullException>(() =>
            {
                var exceptionPerimeter = rectangleB.CalculatePermiterOfRectangle();
               
            });

        }

    }
}

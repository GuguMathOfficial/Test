using System;

namespace Triangle
{


    /// <summary>
    /// The interface IAreaFunctions contains the prototypes for all formulas used to calculate a triangle's face. (This includes all types of triangles)
    /// </summary>


    interface IAreaFunctions
    {   

        /// <summary>
        /// The method AreaByHeron uses the values of the three side of an triangle to calculate that triangle's face using the Heron's formula.
        /// </summary>
        /// <param name="SideA"></param>
        /// <param name="SideB"></param>
        /// <param name="SideC"></param>
        /// <returns>Double</returns>
        
        double AreaByHeron(double SideA, double SideB, double SideC);

        /// <summary>
        /// The method Area uses a side and the height to that side to calculate that triangle's face using the basic triangle face formula of S=(a*ha)/2
        /// </summary>
        /// <param name="Side"></param>
        /// <param name="HeightToSide"></param>
        /// <returns>Double</returns>
        
        double Area(double Side, double HeightToSide);

        /// <summary>
        /// The method SinusFormolaForArea uses two sides and a angle between those two sides to calculate the face of the triangle.
        /// </summary>
        /// <param name="Side"></param>
        /// <param name="SecondSide"></param>
        /// <param name="SinOfAngleBetweenTheTwoSides"></param>
        /// <param name="mode"></param>
        /// <returns>Double</returns>
        
        double SinusFromulaForArea(double Side, double SecondSide, int SinOfAngleBetweenTheTwoSides, int mode);

        /// <summary>
        /// The method RadialFormulaForArea uses the three sides of an triangle and the radius of the circle that the triangle is builded in. S=(a*b*c)/4*R
        /// </summary>
        /// <param name="SideA"></param>
        /// <param name="SideB"></param>
        /// <param name="SideC"></param>
        /// <param name="R"></param>
        /// <returns>Double</returns>

        double RadialFormulaForArea(double SideA, double SideB, double SideC, double R);
    }



    /// <summary>
    /// The class TriangleArea contains the definitions of all the functions from the interface IAreaFunctions
    /// </summary>

    public class Triangle : IAreaFunctions
    {
        //All the varialbles for the triangle
        double SideA = 0, SideB = 0, SideC = 0, HeightToA = 0, HeightToB = 0, HeightToC = 0, BisectorToA = 0, BisectorToB = 0, BisectorToC = 0, MedianToA = 0, MedianToB = 0, MedianToC = 0, RadiusOfInsideCricle = 0, RadiusOfOutsideCircle = 0, AngleAlpha = 0, AngleBeta = 0, AngleGama = 0;


        public Triangle(double SideA=0, double SideB=0, double SideC=0, double HeightToA=0, double HeightToB=0, double HeightToC=0, double BisectorToA=0, double BisectorToB=0, double BisectorToC=0, double MedianToA=0, double MedianToB=0, double MedianToC=0, double RadiusOfInsideCricle = 0, double RadiusOfOutsideCircle = 0, double AngleAlpha=0, double AngleBeta=0, double AngleGama=0)
        //The parametric constructor that autumaticly calculates everything for a triangle
        {

        }



        public double Area(double Side, double HeightToSide)
        {
            return (Side * HeightToSide) / 2;
        }

        public double AreaByHeron(double SideA, double SideB, double SideC)
        {
            double p = SideA + SideB + SideC;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public double RadialFormulaForArea(double SideA, double SideB, double SideC, double R)
        {
            return (SideA * SideB * SideC) / 4 * R;
        }

        public double SinusFromulaForArea(double Side, double SecondSide, int SinOfAngleBetweenTheTwoSides, int mode)
        {
            return (Side * SecondSide * (Math.PI * SinOfAngleBetweenTheTwoSides / 180)) / 2;
        }
    }
}
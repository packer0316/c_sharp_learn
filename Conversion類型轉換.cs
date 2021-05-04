using System ;
namespace RectangleApplication
{
      class ExecuteRectangle
    {
        static void Main ( string [ ] args )
        {
            string s = "1234" ; 
            int it = 0 ; 
            it = int.Parse(s) ; 
            Console.WriteLine(it) ; 

            int i = 75 ;
            float f = 53.005f ;
            double d = 2345.7652 ;
            bool b = true ;

            Console.WriteLine ( i.ToString ( ) ) ;
            Console.WriteLine ( f.ToString ( ) ) ;
            Console.WriteLine ( d.ToString ( ) ) ;
            Console.WriteLine ( b.ToString ( ) ) ;
            Console.ReadKey ( ) ;

        }
    }
}
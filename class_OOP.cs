using System ;
namespace RectangleApplication
{
    class ExecuteRectangle
    {
        public int FindMax ( int num1, int num2 )
        {
            /*局部變量聲明*/
            int result ;

            if ( num1 > num2 )
                result = num1 ;
            else
                result = num2 ;
            return result ;
        }
    }

    class Test 
    {
        static void Main ( string [ ] args )
        {
            ExecuteRectangle n = new ExecuteRectangle() ; 
            int i = n.FindMax(1,2) ; 
            Console.WriteLine(i) ; 
        }

    }
}
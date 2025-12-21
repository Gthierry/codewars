using System.Security.Authentication.ExtendedProtection;
using System.Xml;

namespace CSharp;



public static class StringEndsWith
{
    public static bool String_Ends_With(string text,string ending)
    {

        bool result =false;
        if(text.Length < ending.Length)
        {
            return false;
        }
        if(text.Length > 0 && ending.Length >0)
        {
            int textLastIndex = text.Length;
            int endingLastIndex = ending.Length;
            for(int i=0; i< ending.Length;i++)
            {
               
                if (text[textLastIndex] == ending[endingLastIndex])
                {
                    result = true;
                    endingLastIndex--;
                }
                else
                {
                    result =false;
                }
            }
            
        }
        return result;
    }
}
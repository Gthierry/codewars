using System.Security.Authentication.ExtendedProtection;
using System.Xml;

namespace CSharp;



public static class StringEndsWith
{
    public static bool String_Ends_With(string str,string ending)
    {

        bool result =false;
        if(str.Length < ending.Length)
        {
            return false;
        }
        if(str.Length > 0 && ending.Length > 0)
        {   
            int textLastIndex = str.Length;
            int endingLastIndex = ending.Length;
            for(int i=0; i< endingLastIndex;i++)
            {
               
                if (str[textLastIndex-1] == ending[endingLastIndex-1])
                {
                    result = true;
                    endingLastIndex--;
                    textLastIndex--;
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
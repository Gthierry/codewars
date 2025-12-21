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
        
        if(str.Length >= 0 && ending.Length >= 0)
        {   
            int textLastIndex =0;
            if(str.Length > 0)
                textLastIndex = str.Length-1;

            int endingLastIndex = 0;
            if(ending.Length >0)
                endingLastIndex = ending.Length-1;
                //TODO 
            for(int i=0; i <= ending.Length-1;i++)
            {
               
                if (str[textLastIndex] == ending[endingLastIndex])
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
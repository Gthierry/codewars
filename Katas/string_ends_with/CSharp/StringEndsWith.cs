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
            int negativeIndex = -1;
            for(int i=0; i< ending.Length;i++)
            {
                //TODO get the last index of each string with Length
                if (true)
                {
                    result = true;
                    negativeIndex--;
                }
                // else
                // {
                //     result =false;
                // }
            }
            
        }
        return result;
    }
}
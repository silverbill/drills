using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;

public class Program {

    public static string rovarspraket(string s){
        VowelChecker checker = new VowelChecker();
        string rovarspraket = " " ;
        char[] list = s // string
                    .ToLower() // string
                    .ToCharArray();
            foreach(char c in list){
                if (checker.ContainsVowel(c)){
                    rovarspraket += c.ToString();
                }
                else{
                    rovarspraket += c + "o" + c;
                }
            }
    return rovarspraket;            
    }                        
      
    public class VowelChecker
        //another option for the vowel checker ~ Chris
        //string[] vowels = { "a", "e", "i", "o", "u" };
        //return vowels.Where(x => x == c.ToLower()).Count() != 0;
{
    public char[] vowels = new [] { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };

    public bool ContainsVowel(char c)
    {
        foreach (char vowel in vowels)
        {
            if (c == vowel)
            {
                return true;
            }
        }
        return false;
    }
}
    public static void Main(){
            string x = rovarspraket("airplane");
            Console.WriteLine(x);
            Console.WriteLine((rovarspraket("Chris")));
            Console.WriteLine((rovarspraket("Bryan")));
            
    }
}    

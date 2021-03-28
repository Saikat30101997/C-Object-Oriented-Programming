using System;
using System.Collections.Generic;
using System.Text;
using Leetcode;   //Leetcode er namespace diye disi program er object bind korar jonno

namespace Extentionmethod
{

    public static class Class1
    {
       public static string ToEnglish(this int i) //this int i eta holo binding parameter etar maddhome amra program class e binding korbo ei method ta k
        {
            string x = null;
            if (i == 1) x = "One";
            return x;
        }
       
        public static void Fun1(this Program p)
        {
            Console.WriteLine("Hello");
        }

        public static void Fun2(this Program p,int x) // ekhane ekta integer pass korbo bt eta binding na eta normal paramter jeta main func call dwr shmy nbo prothom parameter obossoi bining parameter hobe
        {
            Console.WriteLine(x);
        }
    
       
    }
}

/*Extension methods, as the name suggests, are additional methods. Extension methods allow you to inject additional methods without modifying, deriving or recompiling the original class, struct or interface
 *static class er shb member static hobe
 * extension method binding parameter pass korate hobe naile extension method hobe na
 * extension method create korbo static class e 
 * this ei word khub joruri binding paramter er jonno
 * extension method static method e toiri korte hobe .. but jokhn amra extension method k class ba structure er sate bind kori tokhn seta hobe non static or instance method
 * binidng parameter e variable ba class jekunu hote pare jodi amra variable er sate bind kori taile bining parameter hobe variable type
 * r class er sate bind korte hole j class er sate bind korbo tar object Like(this program p) abar (this int i)variable bining er jonno
 * extension method er nam r j method er sate bind korbo tar knu ekta method nam jodi ek hy tobe ex.method k call korbe na
 * multiple binidng parameter kokhno hobe naa.. Sealed class ba interface e amra extension method use korte parbo
 * struct er sate extension method use korte parbo jmn (int, ba onnano variable type
 */

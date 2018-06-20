using System;
using System.Collections.Generic;

namespace Exercise1
{
    static class Quotes{

        static readonly int i_numQuotes = 20;
        static readonly string[] s_quotes = new string[i_numQuotes];
        static int i_ptr = -1;

        static Quotes ()
        {
            s_quotes[0] = "Look deep into nature, and then you will understand everything better.";
            s_quotes[1] = "You can't blame gravity for falling in love.";
            s_quotes[2] = "Lottie thinks this is cool!";
        }

        public static string GetQuote(string action){

            switch (action){
                case "Next":
                    IncrementPointer();
                    break;
                case "Previous":
                    DecrementPointer();
                    break;
                case "First":
                    i_ptr = 0;
                    break;
                case "Last":
                    i_ptr = 19;
                    break;
                default:
                    break;
            }

            return FormatQuote(i_ptr);
        }

        public static string GetNextQuote(){

            IncrementPointer();
            return FormatQuote(i_ptr);

        }

        public static string GetPreviousQuote(){
            
            DecrementPointer();
            return FormatQuote(i_ptr);
        }

        private static void DecrementPointer(){

            i_ptr -= 1;
            if (i_ptr == -1) {
                i_ptr = i_numQuotes - 1; 
            }
        }
        private static void IncrementPointer(){
            
            i_ptr += 1;
            if (i_ptr == i_numQuotes){
                i_ptr = 0;
            }
        }
        
        private static string FormatQuote(int quoteNum){
            
            return (quoteNum + 1).ToString() + ". " + s_quotes[quoteNum];
        }
    }
}
 
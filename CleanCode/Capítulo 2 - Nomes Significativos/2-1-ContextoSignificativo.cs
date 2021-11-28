using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Capítulo_2___Nomes_Significativos
{
    class _2_1_ContextoSignificativo
    {
        //Variáveis com contexto obscuro
        private void PrintGuessStatistics(char candidate, int count)
        {
            String number;
            String verb;
            String pluralModifier;

            if (count == 0)
            {
                number = "no";
                verb = "are";
                pluralModifier = "s";
            }
            else if (count == 1)
            {
                number = "1";
                verb = "is";
                pluralModifier = "";
            }
            else
            {
                number = Convert.ToString(count);
                verb = "are";
                pluralModifier = "s";
            }

            String guessMessage = string.Format("There {0} {1} {2}{3}", verb, number, candidate, pluralModifier);
            Console.WriteLine(guessMessage);
        }      

    }

    //Variavéis possuem contexto
    public class GuestStatisticsMessage
    {
        private String number;
        private String verb;
        private String pluralModifier;

        public String Make(char candidate, int count)
        {
            CreatePluralDependentMessageParts(count);
            return String.Format("There {0} {1} {2}{3}", verb, number, candidate, pluralModifier);
        }

        private void CreatePluralDependentMessageParts(int count)
        {
            if (count == 0)
            {
                ThereAreNoLetters();
            }
            else if (count == 1)
            {
                ThereIsOneLetter();
            }
            else
            {
                ThereAreManyLetters(count);
            }
        }

        private void ThereAreManyLetters(int count)
        {
            number = Convert.ToString(count);
            verb = "are";
            pluralModifier = "s";
        }

        private void ThereIsOneLetter()
        {
            number = "1";
            verb = "is";
            pluralModifier = "";
        }

        private void ThereAreNoLetters()
        {
            number = "no";
            verb = "are";
            pluralModifier = "s";
        }
    }
}

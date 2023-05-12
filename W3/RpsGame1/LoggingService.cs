using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpsGame1
{
    /// <summary>
    /// The loggingService Class will write messges to a file for you so that your main method doesn't have to.
    /// </summary>
    public class LoggingService
    {
        /// <summary>
        /// call this method to document what choices are made by the players
        /// </summary>
        internal static void LogChoices(Person p, Choices? c)
        {
            // in this method we'll write the "timestamp - playersId - choiceNumber" 
            File.AppendAllText("Player_Choice_documentation", $"{DateTime.Now} - {p.PersonId} - {c}\n");
        }



    }
}
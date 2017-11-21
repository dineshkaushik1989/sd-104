using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Console
{
    class fileAccessor
    {
        /// <summary>
        /// Gets or sets the path to the file that is being accessed.
        /// </summary>

        public string Filepath { get; set; }


        /// <summary>
        /// Creat an instance of a FileAccessor, setting
        /// the Filepath property to the passed valus.
        /// </summary>
        /// <param name="filepath"></param>
        public fileAccessor(string filepath)
        {
            Filepath = filepath;
        }





        /// <summary>
        /// Returns a random line from a file.
        /// </summary>
        /// <returns>Random line from file as a string.</returns>
        public string GetRandomLine()
        {
            StreamReader textIn = new StreamReader(Filepath);

            //get random word
            Random random = new Random();
            int randNum = random.Next(1, 479781);

            //read through file to get that word
            for (int n = 0; n < randNum; n++)
            {
                textIn.ReadLine();

            }

            return textIn.ReadLine();

        }
    }
}

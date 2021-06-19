using System;
using System.Linq;
using CommandLineArgsHelpers;

namespace Wordladder
{
    /// <summary>
    /// Strong type class that represents all the application's available arguments
    /// </summary>
    public class Arguments
    {
        private CommandLineArgsHelper args = null;

        public Arguments(string[] args)
        {
            if(args == null || !args.Any()) throw new ArgumentNullException(nameof(args), "no parameters were supplied. Please specify required parameters!");

            this.args = new CommandLineArgsHelper(args);
        }
        /// <summary>
        /// Gets the start word
        /// </summary>
        public string Start => args["s"] ?? throw new ArgumentNullException("s", "The start word argument is Required!");
        /// <summary>
        /// Gets the end word
        /// </summary>
        public string End => args["e"] ?? throw new ArgumentNullException("e", "The end word argument is Required!");
        /// <summary>
        /// Gets the dictionary file path
        /// </summary>
        public string DictionaryFilePath => args["d"] ?? throw  new ArgumentException("d", "The dictionary file argument is required!");
        /// <summary>
        /// Gets the output file path
        /// </summary>
        public string OutputFilePath => args["o"] ?? throw  new ArgumentException("o", "The output file argument is required!");
    }
}
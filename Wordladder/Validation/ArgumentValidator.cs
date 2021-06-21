using System;
using System.Linq;
using Wordladder.Input;

namespace Wordladder.Validation
{
    /// <summary>
    /// Handles application validation 
    /// </summary>
    public class ArgumentValidator
    {
        /// <summary>
        /// Validates the arguments according to the input test rules
        /// </summary>
        /// <param name="args"></param>
        /// <param name="dictionary"></param>
        public void Validate(Arguments args, string[] dictionary)
        {
            if (args.End.Length != Settings.MaxLength ||
                args.Start.Length != Settings.MaxLength)
                throw new ApplicationException($"Both start and end words must be {Settings.MaxLength} long!");

            if (dictionary.All(w => w != args.End))
                throw new ApplicationException("The end word must exist in the supplied dictionary!");
        }
    }
}
using System;
using System.Collections.Generic;
using Xunit;

namespace Wordladder.UnitTests
{
    public class WordTests
    {
        [Fact]
        public void Should_Invalidate_Start_Word()
        {
            var arguments = new Arguments(new[] {"-s:elsewhere", "-e:safe", "-d:\"words-english.txt\"", "-o:\"outputfile.txt\""});
            var validator = new ArgumentValidator();

            Assert.Throws<ApplicationException>(() =>
            {
                validator.Validate(arguments, new string[] { });
            });
        }

        [Fact]
        public void Should_Invalidate_End_Word()
        {
            Assert.False(true);
        }

        [Fact]
        public void Should_Invalidate_Non_Existing_End_Word()
        {
            Assert.False(true);
        }

        [Fact]
        public void Should_Validate_Arguments()
        {
            Assert.False(true);
        }
    }
}

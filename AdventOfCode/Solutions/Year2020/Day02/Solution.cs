using System.IO;
using System;
using System.Linq;

namespace AdventOfCode.Solutions.Year2020
{

    class Day02 : ASolution
    {
    

        public Day02() : base(02, 2020, "")
        {
        
        }

        protected override string SolvePartOne()
        {
            var validator = new passwordValidator();
            var count = 0;
            foreach(var line in this.Input.SplitByNewline()) {
                if(validator.isValid(line)){
                    count += 1;
                }
            }
            return count.ToString();
        }

        protected override string SolvePartTwo()
        {
            var validator = new passwordValidator();
            var count = 0;
            foreach(var line in this.Input.SplitByNewline()) {
                if(validator.isValidPart2(line)){
                    count += 1;
                }
            }
            return count.ToString();
        }
    }
}

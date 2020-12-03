using System.Net.Sockets;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Solutions.Year2020
{

    class Day03 : ASolution
    {

        public Day03() : base(03, 2020, "")
        {

        }

        protected override string SolvePartOne()
        {   
            var step = 0;
            var counterTrees = 0;
            foreach(var line in this.Input.SplitByNewline()) {
               counterTrees += calculateTreesForStep(step, 3, line, 1);
               step +=1;
            }

            return counterTrees.ToString();
        }

        protected override string SolvePartTwo()
        {
            var step = 0;
            double total = 1;
            int[] treeCounters = {0,0,0,0,0};
            foreach(var line in this.Input.SplitByNewline()) {
                treeCounters[0] += calculateTreesForStep(step, 1, line, 1);
                treeCounters[1] += calculateTreesForStep(step, 3, line, 1);
                treeCounters[2] += calculateTreesForStep(step, 5, line, 1);
                treeCounters[3] += calculateTreesForStep(step, 7, line, 1);
                treeCounters[4] += calculateTreesForStep(step, 1, line, 2);
                step +=1;
            }

            foreach(var treeCounter in treeCounters ){
                total *= treeCounter;
            }
            
            return total.ToString();
        }

        private int calculateTreesForStep(int step, int multiplier, string line, int down){
            var right = step * multiplier/down;
            if(step % down == 0 && line[right % line.Length] == '#'){
                return 1;
            }
            return 0;
        }
    }
}

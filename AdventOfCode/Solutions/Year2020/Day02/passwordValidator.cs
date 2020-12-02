using System;
using System.ComponentModel;
using System.Linq;


namespace AdventOfCode.Solutions.Year2020
{
    public class passwordValidator {
        public bool isValid(string input) {
                // 1-2 r: asdasdhvasj
                var pair = input.Split(":").Select(s=> s.Trim()).ToArray();
                var policy = pair[0];
                var password = pair[1];

                var splitPolicy = policy.Split(" ");
                var digitBoundaries = splitPolicy[0].Split("-").Select(Int32.Parse).ToArray();
                var letterToCheck = splitPolicy[1][0];

                var count =  password.Count(toCheck => toCheck == letterToCheck);
                return count >= digitBoundaries[0] && count <= digitBoundaries[1];

        public bool isValidPart2(String input) {
            var pair = input.Split(":").Select(s=> s.Trim()).ToArray();
            var policy = pair[0];
            var password = pair[1];

            var splitPolicy = policy.Split(" ");
            var digitBoundaries = splitPolicy[0].Split("-").Select(Int32.Parse).ToArray();
            var letterToCheck = splitPolicy[1][0];

            return password[digitBoundaries[0]-1] == letterToCheck ^ password[digitBoundaries[1]-1] == letterToCheck;
        }
    }
}
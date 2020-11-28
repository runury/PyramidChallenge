﻿using PyramidChallengeDomain;
using System;

namespace PyramidChallengeConsole
{
    class Program
    {
        static void Main()
        {
            var pyramid = new Pyramid(input);
            var longestPath = pyramid.GetLongestPath();
            Console.WriteLine($"Max sum: {longestPath.GetTotalWeight()}");
            Console.WriteLine($"Path: {longestPath}");
        }

        private static readonly int[] input = new[]
        {
            215,
            192, 124,
            117, 269, 442,
            218, 836, 347, 235,
            320, 805, 522, 417, 345,
            229, 601, 728, 835, 133, 124,
            248, 202, 277, 433, 207, 263, 257,
            359, 464, 504, 528, 516, 716, 871, 182,
            461, 441, 426, 656, 863, 560, 380, 171, 923,
            381, 348, 573, 533, 448, 632, 387, 176, 975, 449,
            223, 711, 445, 645, 245, 543, 931, 532, 937, 541, 444,
            330, 131, 333, 928, 376, 733, 017, 778, 839, 168, 197, 197,
            131, 171, 522, 137, 217, 224, 291, 413, 528, 520, 227, 229, 928,
            223, 626, 034, 683, 839, 052, 627, 310, 713, 999, 629, 817, 410, 121,
            924, 622, 911, 233, 325, 139, 721, 218, 253, 223, 107, 233, 230, 124, 233,
        };
    }
}

<Query Kind="Statements" />

/*
https://app.codility.com/programmers/lessons/1-iterations/binary_gap/

A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is surrounded by ones at both ends in the binary representation of N.

For example, number 9 has binary representation 1001 and contains a binary gap of length 2. The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3. The number 20 has binary representation 10100 and contains one binary gap of length 1. The number 15 has binary representation 1111 and has no binary gaps. The number 32 has binary representation 100000 and has no binary gaps.

Write a function:

class Solution { public int solution(int N); }

that, given a positive integer N, returns the length of its longest binary gap. The function should return 0 if N doesn't contain a binary gap.

For example, given N = 1041 the function should return 5, because N has binary representation 10000010001 and so its longest binary gap is of length 5. Given N = 32 the function should return 0, because N has binary representation '100000' and thus no binary gaps.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [1..2,147,483,647].

Copyright 2009–2024 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited.
*/

var array = new int[] { 
    1041,             // Example 1
    15,               // Example 2
    32,               // Example 3
    1, 5, 2147483647, // Extremes
    6, 328,           // Trailing Zero's
    5, 16, 1024,      // Power of 2
    9, 11,            // Simple 1,
    19, 42,           // Simple 2
    1162, 5,          // Simple 3
    51712, 20,        // Medium 1
    561892, 9,        // Medium 2
    66561,            // Medium 3
    6291457,          // Large 1
    74901729,         // Large 2,
    805306373,        // Large 3,
    1376796946,       // Large 4,
    1073741825,       // Large 5,
    1610612737,       // Large 6
};

foreach (var item in array)
{
    Solution(item).Dump(item.ToString());
}

int Solution(int value)
{
    // Convert the integer to its binary representation
    var binary = Convert.ToString(value, 2);

    var result = 0;
    var currentGap = 0;
    var countingGap = false; // Make sure we are only counting zero's

    foreach (var item in binary)
    {
        if (item == '1')
        {
            if (countingGap)
            {
                result = Math.Max(result, currentGap);
                currentGap = 0;
            }
            countingGap = true;
        }
        else if (countingGap)
        {
            currentGap++;
        }
    }

    return result;
}
<Query Kind="Statements" />

/*
https://app.codility.com/programmers/lessons/3-time_complexity/tape_equilibrium/

A non-empty array A consisting of N integers is given. Array A represents numbers on a tape.

Any integer P, such that 0 < P < N, splits this tape into two non-empty parts: A[0], A[1], ..., A[P − 1] and A[P], A[P + 1], ..., A[N − 1].

The difference between the two parts is the value of: |(A[0] + A[1] + ... + A[P − 1]) − (A[P] + A[P + 1] + ... + A[N − 1])|

In other words, it is the absolute difference between the sum of the first part and the sum of the second part.

For example, consider array A such that:

  A[0] = 3
  A[1] = 1
  A[2] = 2
  A[3] = 4
  A[4] = 3
We can split this tape in four places:

P = 1, difference = |3 − 10| = 7
P = 2, difference = |4 − 9| = 5
P = 3, difference = |6 − 7| = 1
P = 4, difference = |10 − 3| = 7
Write a function:

class Solution { public int solution(int[] A); }

that, given a non-empty array A of N integers, returns the minimal difference that can be achieved.

For example, given:

  A[0] = 3
  A[1] = 1
  A[2] = 2
  A[3] = 4
  A[4] = 3
the function should return 1, as explained above.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [2..100,000];
each element of array A is an integer within the range [−1,000..1,000].

Copyright 2009–2024 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited.
*/

solution(new[]{ 3, 1, 2, 4, 3, }).Dump();
solution(Enumerable.Range(2, 100000).ToArray()).Dump();
solution(Enumerable.Range(-1000, 2000).ToArray()).Dump();

int solution(int[] tape)
{
    // Initialize left with the first element of the tape array, and right with the sum of all remaining elements.
    var left = tape[0];
    var right = tape.Skip(1).Aggregate((c, x) => c += x);
    // Calculate the initial difference between left and right and store it in result.
    var result = Math.Abs(left - right);

    // Iterate through the remaining elements in the tape array (from index 1 to the second-to-last element).
    for (var i = 1; i < tape.Length - 1; i++)
    {
        // For each iteration, update left by adding the current element and update right by subtracting the current element.
        left += tape[i];
        right -= tape[i];
        // Calculate the absolute difference between left and right and update result if the new difference is smaller.
        result = Math.Min(result, Math.Abs(left - right));
    }

    // Return the final result, which is the minimal difference that can be achieved.
    return result;
}
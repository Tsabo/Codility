<Query Kind="Statements" />

/*
1. There's no option to pause. Make sure you will not be interrupted for 75 minutes.
2. Your solution(s) should consider all possible corner cases and handle large input efficiently.
   Passing the example test does not indicate that your solution is correct.
   The example test is not part of your final score.
3. If you accidentally close your browser, use the invitation link to get back to your test.
*/

/*
There are N nails hammered into the same block of wood. Each nail sticks out of the wood at some length.
You can choose at most K nails and hammer them down to any length between their original lengths and 0.
Nails cannot be pulled up. The goal is to have a s many nails of the same length as possible.

You are given an implementation of a function:

    class Solution { public int solution(int[] A, int K); }

which, given an array of A of N integers representing lengths of the nails sorted in a non-decreasing order and an interger K,
returns the maxmial number of nails that can be positioned at the same length after hammering down at most K nails.

For example, given K = 2 and array A = [1, 1, 3, 3, 3, 4, 5, 5, 5, 5] the function should return 5.
One of the possibilities is to hammer the nails represented by A[8] and A[9] down to length 3.

The following code is still incorrect for some inputs. Despite the error(s), the code may produce a correct answer for the
example test cases. The goal of the exercise is to find and fix the bug(s) in the implementation. You can modify at most four lines.

Assume that:

N is an integer within the range [1..10,000];
K is an integer within the range [0..N];
Each element of array A is an integer within the range [1..1,000,000,000]
Array A is sorted in non-decreasing order.

The solution should be focused on correctness. The performance of your solution is not the focus of the assessment.

public int solution(int[] A, int K) {
    int n = A.Length;
    int best = 0;
    int count = 1;
    for (int i = 0; i < n - K - 1; i++) {
        if (A[i] == A[i + 1])
            count = count + 1;
        else
            count = 0;
        if (count > best)
            best = count;
    }
    int result = best + 1 + K;
    return result;
}
*/

// You can modifty at most four lines!

solution(new []{1, 1, 3, 3, 3, 4, 5, 5, 5, 5}, 2).Dump(); // Should return 5
solution(new []{1,1,3,3,4,4,4,5,5,6,6,6,6,6,6}, 2).Dump(); // Should return 6

// hammered = How many times you can hammer a nail
int solution(int[] nails, int hammered)
{
    var length = nails.Length; 
    var best = 0;
    var count = 1;
    for (var i = 0; i < length - hammered - 1; i++)
    {
        if (nails[i] == nails[i + 1])
            count = count + 1;
        else
            count = 1;

        if (count > best)
            best = count;
    }

    var result = hammered + 1 > length
        ? length
        : Math.Max(best + hammered, hammered + 1);

    return result;
}
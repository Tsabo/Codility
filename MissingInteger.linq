<Query Kind="Statements" />

/*
Write a function:

class Solution { public int solution(int[] A); }

that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

Given A = [1, 2, 3], the function should return 4.

Given A = [−1, −3], the function should return 1.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [1..100,000];
each element of array A is an integer within the range [−1,000,000..1,000,000].
*/

solution(new [] {1, 3, 6, 4, 1, 2}).Dump();
solution(new [] {1, 2, 3}).Dump();
solution(new [] {-1, -3}).Dump();

int solution(int[] values)
{
    var result = 1;

    foreach (var item in values.OrderBy(p => p).Where(p => p > 0))
    {
        if (item <= 0)
            continue;
        else if (item == result)
            result++;
    }

    return result;
}

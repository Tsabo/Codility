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

// Only got an 88% due to correctness ?

solution(new [] {1, 3, 6, 4, 1, 2}).Dump();
solution(new [] {1, 2, 3}).Dump();
solution(new [] {-1, -3}).Dump();

int solution(int[] values)
{
    var hashset = new HashSet<int>();
    
    foreach (var item in values)
    {
        if (item > 0)
            hashset.Add(item);
    }
    
    for (int i = 1; i < values.Length; i++)
    {
        if (!hashset.Contains(i))
            return i;
    }
    
    return values.Length + 1;
}

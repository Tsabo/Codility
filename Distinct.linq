<Query Kind="Statements" />

/*
https://app.codility.com/programmers/lessons/6-sorting/distinct/

Write a function

class Solution { public int solution(int[] A); }

that, given an array A consisting of N integers, returns the number of distinct values in array A.

For example, given array A consisting of six elements such that:

 A[0] = 2    A[1] = 1    A[2] = 1
 A[3] = 2    A[4] = 3    A[5] = 1
the function should return 3, because there are 3 distinct values appearing in array A, namely 1, 2 and 3.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [0..100,000];
each element of array A is an integer within the range [−1,000,000..1,000,000].
Copyright 2009–2024 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited.
*/

solution(Array.Empty<int>()).Dump();
solution(new [] { 2, 1, 1, 2, 3, 1 }).Dump();
solution(Enumerable.Range(0, 100000).ToArray()).Dump();
solution(Enumerable.Range(-1000000, 100000).ToArray()).Dump();

int solution(int[] values)
{    
    return values.Distinct().Count();
}
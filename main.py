"""Sum of Consecutive Numbers
No one likes homework, but your math teacher has given you an assignment to find the sum of the first N numbers.

Let’s save some time by creating a program to do the calculation for you!

Take a number N as input and output the sum of all numbers from 1 to N (including N)."""


N = int(input())
#your code goes here
i =0
sum =0
while i < N:
 i = i +1
 sum = sum + i
print(sum)
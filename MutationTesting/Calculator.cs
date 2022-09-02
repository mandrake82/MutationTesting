﻿namespace MutationTesting
{
    public class Calculator
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Subtract(int first, int second)
        {
            return first - second;
        }

        public int Multiply(int first, int second)
        {
            return first * second;
        }

        public int Divide(int first, int second)
        {
            if (second == 0)
            {
                throw new DivideByZeroException();
            }

            return first / second;
        }

        public int Squared(int first)
        {
            return first * first;
        }

    }
} 
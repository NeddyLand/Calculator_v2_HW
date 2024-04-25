using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_v2_HW
{
    class Calculator
    {
        private double result = 0;
        Stack<double> results = new Stack<double>();

        public double Add(double value)
        {
            results.Push(result);
            return result += value;
        }
        public double Sub(double value)
        {
            results.Push(result);
            return result -= value;
        }
        public double Mul(double value)
        {
            results.Push(result);
            return result *= value;
        }
        public double Div(double value)
        {
            results.Push(result);
            return result /= value;
        }
        public double Div(double value, Calculator calc)
        {
            results.Push(result);
            return result = value / calc.result;
        }
        public double Cancel()
        {
            if (results.Count > 0)
            {
                return result = results.Pop();
            }
            return result;
        }
        public static double operator +(Calculator a, int b) => a.Add(b);
        public static double operator +(int b, Calculator a) => a.Add(b);
        public static double operator +(Calculator a, double b) => a.Add(b);
        public static double operator +(double b, Calculator a) => a.Add(b);
        public static double operator -(Calculator a, int b) => a.Sub(b);
        public static double operator -(int b, Calculator a) => a.Sub(-b);
        public static double operator -(Calculator a, double b) => a.Sub(b);
        public static double operator -(double b, Calculator a) => a.Sub(-b);
        public static double operator *(Calculator a, int b) => a.Mul(b);
        public static double operator *(int b, Calculator a) => a.Mul(b);
        public static double operator *(Calculator a, double b) => a.Mul(b);
        public static double operator *(double b, Calculator a) => a.Mul(b);
        public static double operator /(Calculator a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            else
                return a.Div(b);
        }
        public static double operator /(int b, Calculator a)
        {
            if (a.result == 0)
            {
                throw new DivideByZeroException();
            }
            else
                return a.Div(b, a);
        }
        public static double operator /(Calculator a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            else
                return a.Div(b);
        }
        public static double operator /(double b, Calculator a)
        {
            if (a.result == 0)
            {
                throw new DivideByZeroException();
            }
            else
                return a.Div(b, a);
        }
        public override string ToString()
        {
            return result.ToString();
        }
    }
}
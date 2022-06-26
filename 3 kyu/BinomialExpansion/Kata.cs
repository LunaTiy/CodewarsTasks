using System;
using System.Linq;

namespace BinomialExpansion
{
	public struct ExpressionValues
	{
		public char symbol;
		public int variable1;
		public int variable2;
		public int degree;
	}

	public class Kata
	{
		public static string Expand(string expr)
		{
			string[] elements = expr.Split('^');

			ExpressionValues expressionValues = GetVariablesFromStringExpression(elements[0]);
			expressionValues.degree = int.Parse(elements[1]);

			return GetResultCalculate(expressionValues);
		}

		private static ExpressionValues GetVariablesFromStringExpression(string expr)
		{
			ExpressionValues expressionValues = new ExpressionValues();

			expr = expr.Substring(1, expr.Length - 2);
			string[] variables = expr.Split(new char[] { '+', '-' });

			variables = variables.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

			foreach(char sym in variables[0])
			{
				if (char.IsLetter(sym))
				{
					expressionValues.symbol = sym;
					variables[0] = variables[0].Replace(sym.ToString(), "");
					break;
				}
			}

			expressionValues.variable1 = variables[0] == "" ? 1 : int.Parse(variables[0]);
			expressionValues.variable2 = int.Parse(variables[1]);

			int countOfMinus = 0;

			foreach(char sym in expr)
				if (sym == '-') countOfMinus++;

			if(countOfMinus == 2)
			{
				expressionValues.variable1 *= -1;
				expressionValues.variable2 *= -1;
			}
			else if(countOfMinus == 1)
			{
				if (expr[0] == '-') expressionValues.variable1 *= -1;
				else expressionValues.variable2 *= -1;
			}

			return expressionValues;
		}

		private static string GetResultCalculate(ExpressionValues expressionValues)
		{
			if (expressionValues.degree == 0)
				return "1";

			if(expressionValues.variable2 == 0)
			{
				int degree = expressionValues.degree;
				int variable = (int)Math.Pow(expressionValues.variable1, degree);

				return variable == 1 ? $"{expressionValues.symbol}^{degree}" : variable == -1 ? $"-{expressionValues.symbol}^{degree}" :
					$"{variable}{expressionValues.symbol}^{degree}";
			}

			string resultCalculate = "";

			for(int i = expressionValues.degree, j = 0; i >= 0; i--, j++)
			{
				int binomialCoef = CalculateBinomialCoef(expressionValues.degree, j);
				long value = binomialCoef * (long)Math.Pow(expressionValues.variable1, i) * (long)Math.Pow(expressionValues.variable2, j);

				if ((value != 1 && value != -1) || i == 0)
				{
					resultCalculate += i == expressionValues.degree || value < 0 ? $"{value}" : $"+{value}";
				}
				else if(value == -1)
				{
					resultCalculate += "-";
				}

				resultCalculate += i > 1 ? $"{expressionValues.symbol}^{i}" : i == 1 ? $"{expressionValues.symbol}" : "";
			}

			return resultCalculate;
		}

		private static int CalculateBinomialCoef(int degree, int currentIndex)
		{
			long temp = 1;

			for (int i = degree - currentIndex + 1; i <= degree; i++)
				temp = temp * i;

			for (int i = 2; i <= currentIndex; i++)
				temp = temp / i;

			return (int)temp;
		}
	}
}

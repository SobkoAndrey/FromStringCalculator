using System;

namespace FromStringCalculator
{
	class FromStringCalculator
	{
		string numbers = "0123456789";
		public string Numbers
		{
			get
			{
				return numbers;
			}
		}

		private void TrimAll(ref string firstOperand, ref string secondOperand)
		{
			firstOperand = firstOperand.Trim();
			secondOperand = secondOperand.Trim();
		}

		private string CheckOperator(string calculation)
		{
			if ((calculation.Contains("+") & !calculation.Contains("-") &
				 !calculation.Contains("*") & !calculation.Contains("/")))
			{
				return "+";
			}
			else if ((!calculation.Contains("+") & calculation.Contains("-") &
					  !calculation.Contains("*") & !calculation.Contains("/")))
			{
				return "-";
			}
			else if ((!calculation.Contains("+") & !calculation.Contains("-") &
					  calculation.Contains("*") & !calculation.Contains("/")))
			{
				return "*";
			}
			else if ((!calculation.Contains("+") & !calculation.Contains("-") &
					  !calculation.Contains("*") & calculation.Contains("/")))
			{
				return "/";
			}
			else 
				return WrongStringError();

		}

		private string WrongStringError()
		{
			return "Error! Wrong string!";
		}

		private bool IsNumber(string operand)
		{
			foreach (char item in operand)
			{
				if (!Numbers.Contains(item.ToString()))
					return false;
			}

			return true;
		}

		public string Calculator(string calculation)
		{

			switch (CheckOperator(calculation))
			{
				case "+":
					
				string[] operands1 = calculation.Split('+');

					if (operands1.Length > 2) return WrongStringError();

					TrimAll(ref operands1[0], ref operands1[1]);

					if (IsNumber(operands1[0]) && IsNumber(operands1[1]))
					{
						int firstOperand = Convert.ToInt32(operands1[0]);
						int secondOperand = Convert.ToInt32(operands1[1]);

						return $"{firstOperand} + {secondOperand} = {firstOperand + secondOperand}";
					}
					else
					{
						return $"{operands1[0]} + {operands1[1]} = {operands1[0] + operands1[1]}";
					}

				case "-":

					string[] operands2 = calculation.Split('-');
					if (operands2.Length > 2) return WrongStringError();

					TrimAll(ref operands2[0], ref operands2[1]);

					if (IsNumber(operands2[0]) && IsNumber(operands2[1]))
					{
						int firstOperand = Convert.ToInt32(operands2[0]);
						int secondOperand = Convert.ToInt32(operands2[1]);

						return $"{firstOperand} - {secondOperand} = {firstOperand - secondOperand}";
					}
					else
					{
						return WrongStringError();
					}

				case "*":
					
					string[] operands3 = calculation.Split('*');
					if (operands3.Length > 2) return WrongStringError();

					TrimAll(ref operands3[0], ref operands3[1]);

					if (IsNumber(operands3[0]) && IsNumber(operands3[1]))
					{
						int firstOperand = Convert.ToInt32(operands3[0]);
						int secondOperand = Convert.ToInt32(operands3[1]);

						return $"{firstOperand} * {secondOperand} = {firstOperand * secondOperand}";
					}
					else
					{
						return WrongStringError();
					}

				case "/":

					string[] operands4 = calculation.Split('/');
					if (operands4.Length > 2) return WrongStringError();

					TrimAll(ref operands4[0], ref operands4[1]);

					if (IsNumber(operands4[0]) && IsNumber(operands4[1]))
					{
						int firstOperand = Convert.ToInt32(operands4[0]);
						int secondOperand = Convert.ToInt32(operands4[1]);

						return $"{firstOperand} / {secondOperand} = {firstOperand / secondOperand}";
					}
					else
					{
						return WrongStringError();
					}

				default:

					return WrongStringError();
			}

			/*

			if (CheckOperator(calculation) == "+")
			{
				string[] operands = calculation.Split('+');

				if (operands.Length > 2) return WrongStringError();

				TrimAll(ref operands[0], ref operands[1]);

				if (IsNumber(operands[0]) && IsNumber(operands[1]))
				{
					int firstOperand = Convert.ToInt32(operands[0]);
					int secondOperand = Convert.ToInt32(operands[1]);

					return $"{firstOperand} + {secondOperand} = {firstOperand + secondOperand}";
				}
				else
				{
					return $"{operands[0]} + {operands[1]} = {operands[0] + operands[1]}";
				}

			}
			else if (CheckOperator(calculation) == "-")
			{
				string[] operands = calculation.Split('-');
				if (operands.Length > 2) return WrongStringError();

				TrimAll(ref operands[0], ref operands[1]);

				if (IsNumber(operands[0]) && IsNumber(operands[1]))
				{
					int firstOperand = Convert.ToInt32(operands[0]);
					int secondOperand = Convert.ToInt32(operands[1]);

					return $"{firstOperand} - {secondOperand} = {firstOperand - secondOperand}";
				}
				else
				{
					return WrongStringError();
				}
			}
			else if (CheckOperator(calculation) == "*")
			{
				string[] operands = calculation.Split('*');
				if (operands.Length > 2) return WrongStringError();

				TrimAll(ref operands[0], ref operands[1]);

				if (IsNumber(operands[0]) && IsNumber(operands[1]))
				{
					int firstOperand = Convert.ToInt32(operands[0]);
					int secondOperand = Convert.ToInt32(operands[1]);

					return $"{firstOperand} * {secondOperand} = {firstOperand * secondOperand}";
				}
				else
				{
					return WrongStringError();
				}
			} 
			else if (CheckOperator(calculation) == "/")
			{
				string[] operands = calculation.Split('/');
				if (operands.Length > 2) return WrongStringError();

				TrimAll(ref operands[0], ref operands[1]);

				if (IsNumber(operands[0]) && IsNumber(operands[1]))
				{
					int firstOperand = Convert.ToInt32(operands[0]);
					int secondOperand = Convert.ToInt32(operands[1]);

					return $"{firstOperand} / {secondOperand} = {firstOperand / secondOperand}";
				}
				else
				{
					return WrongStringError();
				}
			}
			return WrongStringError(); 

*/
		}

		public static void Main(string[] args)
		{
			FromStringCalculator a = new FromStringCalculator();
			Console.WriteLine(a.Calculator(" 266  - 35 "));
			Console.WriteLine(a.Calculator("  fjdgf + kjdfkjkjk  "));
			Console.WriteLine(a.Calculator(" 2  * 35 "));
			Console.WriteLine(a.Calculator(" 266  / 35 "));
			Console.WriteLine(a.Calculator(" 266  + 35"));
			Console.WriteLine(a.Calculator(" 266  / 35 + 2"));

		}
	}
}

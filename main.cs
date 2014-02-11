// Courey Elliott
// try/catch example

using System;

public class MainMethod
{

	public static void Main (string[] args)
	{
		try 
		{
			try
			{
			Console.Write ("Enter an equation:");
			string input = Console.ReadLine ().Trim ();
			string[] terms = input.Split (new Char[] { ' ', '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);

			int firstNumber = Convert.ToInt32 (terms [0]);
			if (input [0] == '-') 
				{
				firstNumber = -firstNumber;
				input = input.Remove (0, 1);
				}
			input = input.Remove (0, terms [0].Length).Trim ();

			char op = input [0];
			input = input.Remove (0, 1).Trim ();
	
			int secondNumber = Convert.ToInt32 (terms [1]);
			if (input [0] == '-')
				secondNumber = -secondNumber;
	
			int result = 0;
			if (op == '+')
				result = (firstNumber + secondNumber);
			else if (op == '-')
				result = (firstNumber - secondNumber);
			else if (op == '*')
				result = (firstNumber * secondNumber);
			else if (op == '/')
				result = (firstNumber / secondNumber);
	
			Console.WriteLine (result);

			}// end inner try

			catch (FormatException e) 
			{
				Console.WriteLine ("Invalid input. Please input an integer.");
			}

			catch (ArgumentNullException e) 
			{
				Console.WriteLine ("You gotta put numbers in if you want an answer.");
			}

			catch (ArgumentException e)
			{
				Console.WriteLine("Invalid argument. Formula accepts only 2 integers.");
			}

			catch (OverflowException)
			{
				Console.WriteLine("Number must be between -2147483647 and 2147483646.");
			}

			catch (Exception e) //catches anything that isn't caught before and throws it to the outside try/catch
			{
				throw;
			}
		}// end outer try

		
		catch (Exception e) //catches exception e thrown from inner catch
		{
			Console.WriteLine("General exception thrown from inner catch's catch all exception handling. Could do something like save here etc...");
		}
	}
}	

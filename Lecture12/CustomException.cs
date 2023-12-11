using System;

class CustomException : Exception
{
	public CustomException(string message) : base(message)
	{
	}
}

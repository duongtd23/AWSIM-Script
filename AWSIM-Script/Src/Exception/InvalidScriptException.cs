using System;
namespace AWSIM_Script.Except
{
	public class InvalidScriptException : Exception
	{
		public InvalidScriptException()
		{
		}
        public InvalidScriptException(string message)
            : base(message)
        {
        }
    }
}


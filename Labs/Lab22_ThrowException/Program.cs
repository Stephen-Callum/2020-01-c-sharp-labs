using System;
using System.IO;

namespace Lab22_ThrowException
{
    class Program
    {
        static void Main(string[] args)
        {
			// OVERALL SYSTEM
			try
			{
				// DEPARTMENT
				try
				{
					// YOU!
					try
					{
						// custom exception
						// read database and FAILS
						throw new Exception("Database read has failed for user Joe");
					}
					catch(Exception e)
					{
						// don't handle
						//pass up
						throw;
					}
				}
				catch (Exception e)
				{
					throw;
				}
			}
			catch (Exception e)
			{
				File.AppendAllText("ErrorLog.txt", Environment.NewLine + e.Message);		// LOGGING SYSTEM
				//throw;
			}
        }
    }
}

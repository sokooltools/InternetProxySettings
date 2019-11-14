using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Parker.Tucson.InternetSettings
{
	//----------------------------------------------------------------------------------------------------------------
	/// <summary>
	/// Provides static methods used for validation as well as other general utility functions.
	/// </summary>
	//----------------------------------------------------------------------------------------------------------------
	public class Utils
	{

		//--------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Indicates whether the specified IP Address is valid or not. (i.e., the IP Address is null or empty or falls 
		/// within the range of '1.0.0.0' to '255.255.255.255').
		/// </summary>
		/// <param name="ipAddress">The IP Address to validate.</param>
		/// <returns><c>true</c> if the specified IP Address is valid; otherwise, <c>false</c>.</returns>
		//--------------------------------------------------------------------------------------------------------------
		public static bool IsValidIpAddress(string ipAddress)
		{
			const string PATTERN = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])"
										+ @"(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";
			return String.IsNullOrEmpty(ipAddress) || Regex.IsMatch(ipAddress, PATTERN);
		}

		//--------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Gets the calling method in which the specified frame is executing prepended by the class that calls the 
		/// method (accomplished by using System.Reflection).
		/// </summary>
		/// <param name="frameNumber">The frame number.</param>
		/// <returns></returns>
		//--------------------------------------------------------------------------------------------------------------
		public static string GetCallingMethod(int frameNumber = 1)
		{
			// Get the call stack.
			var stackTrace = new StackTrace();

			// Get the calling method name.
			var declaringType = stackTrace.GetFrame(frameNumber).GetMethod().DeclaringType;
			return (declaringType != null)
				? declaringType.FullName + "." + stackTrace.GetFrame(frameNumber).GetMethod().Name
				: stackTrace.GetFrame(frameNumber).GetMethod().Name;
		}
	}
}

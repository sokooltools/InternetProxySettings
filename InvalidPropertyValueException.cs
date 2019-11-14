using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace InternetProxySettings
{
	//---------------------------------------------------------------------------------------------------------------------------
	/// <summary>
	/// 
	/// </summary>
	//---------------------------------------------------------------------------------------------------------------------------
	[Serializable]
	public class InvalidPropertyValueException : Exception, ISerializable
	{
		private readonly string _message;
		private readonly string _source;

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Initializes a new instance of the <see cref="InvalidPropertyValueException"/> class.
		/// </summary>
		//------------------------------------------------------------------------------------------------------------------------
		public InvalidPropertyValueException()
		{
			_message = "The specified property value is invalid.";
			_source = base.Source;
		}

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Initializes a new instance of the <see cref="InvalidPropertyValueException"/> class.
		/// </summary>
		/// <param name="value">The property value.</param>
		//------------------------------------------------------------------------------------------------------------------------
		public InvalidPropertyValueException(object value)
		{
			_message = "'" + value + "' is an invalid property value.";
			_source = base.Source;
		}

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Initializes a new instance of the <see cref="InvalidPropertyValueException"/> class.
		/// </summary>
		/// <param name="value">The property value.</param>
		/// <param name="source">The source of the exception.</param>
		//------------------------------------------------------------------------------------------------------------------------
		public InvalidPropertyValueException(object value, string source)
		{
			_message = "'" + value + "' is an invalid property value.";
			_source = source;
		}

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Gets a message that describes the current exception.
		/// </summary>
		/// <returns>The error message that explains the reason for the exception, or an empty string("").</returns>
		//------------------------------------------------------------------------------------------------------------------------
		public override string Message => _message;

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Gets or sets the name of the application or the object that causes the error.
		/// </summary>
		/// <returns>The name of the application or the object that causes the error.</returns>
		//------------------------------------------------------------------------------------------------------------------------
		public override string Source => _source;

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// When overridden in a derived class, sets the <see cref="T:System.Runtime.Serialization.SerializationInfo"/> with 
		/// information about the exception.
		/// </summary>
		/// <param name="info">
		/// The <see cref="T:System.Runtime.Serialization.SerializationInfo"/> that holds the serialized object data about the 
		/// exception being thrown.
		/// </param>
		/// <param name="context">
		/// The <see cref="T:System.Runtime.Serialization.StreamingContext"/> that contains contextual information about the 
		/// source or destination.
		/// </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// The <paramref name="info"/> parameter is a null reference (Nothing in Visual Basic).
		/// </exception>
		//------------------------------------------------------------------------------------------------------------------------
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
				throw new ArgumentNullException("info");
			GetObjectData(info, context);
		}

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// When overridden in a derived class, sets the <see cref="T:System.Runtime.Serialization.SerializationInfo"/> with 
		/// information about the exception.
		/// </summary>
		/// <param name="info">
		/// The <see cref="T:System.Runtime.Serialization.SerializationInfo"/> that holds the serialized object data about the 
		/// exception being thrown.
		/// </param>
		/// <param name="context">
		/// The <see cref="T:System.Runtime.Serialization.StreamingContext"/> that contains contextual information about the 
		/// source or destination.
		/// </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// The <paramref name="info"/> parameter is a null reference (Nothing in Visual Basic).
		/// </exception>
		//------------------------------------------------------------------------------------------------------------------------
		[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("Message", _message);
		}
	}
}
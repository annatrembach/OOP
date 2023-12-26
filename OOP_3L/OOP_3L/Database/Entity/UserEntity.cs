using System;
using System.Security.Cryptography.X509Certificates;

namespace OOP_3L
{
	public enum UserType
	{
		GameAccount,
		DoubleDeductionPointsGameAccount,
		DoublePointsGameAccount
	};
	public class UserEntity
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public int CurrentRating { get; set; }
		public UserType Type { get; set; }
    }   
}


using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class DatabaseUser
{
	public DatabaseUser : User()
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public override int Id { get; set; }

	}
}

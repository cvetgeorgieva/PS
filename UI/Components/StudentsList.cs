using System;

public class StudentsList
{
    private object students;

    public StudentsList()
	{
		using (var context = new DatabaseContext()) 
		{
			var record = context.Users.ToList();
            students.DataContext = record;
        }
	}
}

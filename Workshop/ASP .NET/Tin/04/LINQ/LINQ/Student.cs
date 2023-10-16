using System;

namespace LINQ
{
	public class Student
	{
		public string Name { get; set; }

		public int Age { get; set; }

		public int ExamMark1;

		public int ExamMark2;

		public Student(string name, int age)
		{
			this.Name = name;
			this.Age = age;
		}

		public Student(string name, int m1, int m2)
		{
			this.Name = name;
			this.ExamMark1 = m1;
			this.ExamMark2 = m2;
		}
	}
}


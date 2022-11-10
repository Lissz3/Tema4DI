#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
	internal class Classroom
	{
		public int[,] marks;
		public string[] students;

		public int this[int student, int asig]
		{
			set
			{
				marks[student, asig] = value;
			}
			get
			{
				return marks[student, asig];
			}
		}

		public Classroom(string[] studentNames)
		{
			ConstructorBuilder(studentNames);
		}

		public Classroom(string studentNames) : this(studentNames.Split(","))
		{
			//ConstructorBuilder(studentNames.Split(","));
		}

		public void ConstructorBuilder(string[] studentNames)
		{
			marks = new int[studentNames.Length, Enum.GetNames(typeof(Asignaturas)).Length];
			students = studentNames;

			for (int i = 0; i < students.Length; i++)
			{
				students[i] = students[i].Trim().ToUpper();
			}

			for (int i = 0; i < marks.GetLength(0); i++)
			{
				for (int j = 0; j < marks.GetLength(1); j++)
				{
					marks[i, j] = new Random().Next(0, 11);
				}
			}
		}


		public double Average()
		{
			int total = 0;
			for (int i = 0; i < marks.GetLength(0); i++)
			{
				for (int j = 0; j < marks.GetLength(1); j++)
				{
					total += marks[i, j];
				}
			}
			return total / (double)marks.Length;
		}

		public double Average(int student)
		{
			int total = 0;
			for (int i = 0; i < marks.GetLength(1); i++)
			{
				total += marks[student, i];
			}
			return total / (double)marks.GetLength(1);
		}

		public double Average(Asignaturas asig)
		{
			int total = 0;
			for (int i = 0; i < marks.GetLength(0); i++)
			{
				total += marks[i, (int)asig];
			}
			return total / (double)marks.GetLength(0);
		}

		public int[] ShowGrades(int student)
		{
			int[] grades = new int[Enum.GetNames(typeof(Asignaturas)).Length];
			for (int i = 0; i < marks.GetLength(1); i++)
			{
				grades[i] = marks[student, i];
			}

			return grades;
		}

		public int[] ShowGrades(Asignaturas asig)
		{
			int[] grades = new int[students.Length];
			for (int i = 0; i < marks.GetLength(0); i++)
			{
				grades[i] = marks[i, (int)asig];
			}

			return grades;
		}

		public void MinMax(int student, out int max, out int min)
		{
			max = 0;
			min = 10;
			for (int i = 0; i < marks.GetLength(0); i++)
			{
				for (int j = 0; j < marks.GetLength(1); j++)
				{
					if (marks[student, j] > max)
					{
						max = marks[student, j];
					}
					if (marks[student, j] < min)
					{
						min = marks[student, j];
					}
				}
			}

		}
	}
}


using System;
namespace Exercise_G
{
	public class G3
	{
		public static int[,] marks = new int[,]
		{
            {56,84,68,29},
			{94,73,31,96},
			{41,63,36,90},
			{99,9,18,17},
			{62,3,65,75},
			{40,96,53,23},
			{81,15,27,30},
			{21,70,100,22},
			{88,50,13,12},
			{48,54,52,78},
			{64,71,67,25},
			{16,93,46,72}
        };

		public static void G3_work()
		{
			int subjectNum = marks.GetLength(1);
			int studentNum = marks.GetLength(0);

			int[] stuTotal = new int[studentNum];
			double[] stuAvg = new double[studentNum];
			double[] subjectAvg = new double[subjectNum];

			for(int i = 0; i < studentNum; i++)
			{
				int t = 0;
				for (int j = 0; j < subjectNum; j++)
				{
					t = t + marks[i,j];
					subjectAvg[j] += marks[i, j];
				}
				stuTotal[i] = t;
				stuAvg[i] = Math.Round((double)t/studentNum, 2);
			}

			for (int i = 0; i < subjectNum; i++) subjectAvg[i] = Math.Round(subjectAvg[i]/studentNum, 5);

			string s1 = "Subject 1\tSubject 2\tSubject 3\tSubject 4\tTotal\tAvg";
			Console.WriteLine(s1);
			for(int i = 0; i < studentNum; i++)
			{
				s1 = "";
				for(int j = 0; j < subjectNum; j++)
				{
					s1 += marks[i, j] +"\t";
				}
				s1 = s1 + stuTotal[i] + "\t";
				s1 = s1 + stuAvg[i];
				Console.WriteLine(s1);
			}

			s1 = "";
			Console.WriteLine("\nAverage per subject:");
			for(int i = 0; i < subjectNum; i++)
			{
				s1 = s1 + subjectAvg[i];
				if (i != subjectNum - 1) s1 += "\t";
			}
			Console.WriteLine(s1);
		}
	}
}


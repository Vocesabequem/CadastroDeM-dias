/*
 * Created by SharpDevelop.
 * User: THGEVER
 * Date: 10/06/2019
 * Time: 22:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CadastrodeMédias
{
	class Program
	{
		public static void Main(string[] args)
		{
			int materias;
			float notas;
			Console.WriteLine("Por favor, informe quantas matérias você possui.");
			materias = int.Parse(Console.ReadLine());
			int [,] matriz = new int[materias, 4];
			
			for (int m = 0 ; m < materias; m++)
			{
				for (int u = 0; u < 4; u++)
				{
					Console.Write("Por favor, informe sua nota na matéria"  +(m+1)+  "unidade" +(u+1)+ ": ");
					notas = float.Parse(Console.ReadLine());
				}
			}
			Console.WriteLine("");
			Console.ReadLine();
		}
	}
}
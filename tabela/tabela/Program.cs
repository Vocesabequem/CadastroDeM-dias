/*
 * Created by SharpDevelop.
 * User: THGEVER
 * Date: 14/06/2019
 * Time: 15:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace tabela
{
	class Program
	{
		public static void Main(string[] args)
		{
			string perg1, perg2;
			bool resp1, resp2;
			
			Console.WriteLine ("Por favor, digite uma afirmação");
			perg1 = Console.ReadLine ();
			Console.WriteLine ("Digite outra afirmação, por favor");
			perg2 = Console.ReadLine ();
			
			Console.WriteLine ("A primeira afirmativa é verdadeira ou falsa? Responda com true ou false");
			resp1 == Console.ReadLine () ;
		    Console.WriteLine ("A segunda afirmativa é verdadeira ou falsa? Por favor, responda com true ou false");
			resp2 == Console.ReadLine () ;
	
			if (resp1 == true && resp2 == true) {
				Console.WriteLine("O resultado lógico das afirmativas é: " + resp1 + "e" + resp2 +"é: true");
			} else {
				Console.WriteLine("O resultado lógico das afirmativas é: " + resp1 + "ou" + resp2 +"é: true");
				
			}
			if (resp1 == false && resp2 == true) {
				Console.WriteLine ("O resultado lógico das afirmativas é: " +resp1+ "e" +resp2+ "é: false");
			} else {
				Console.WriteLine ("O resultado lógico das afirmativas é: " +resp1+ "ou" +resp2+ "é: true");
			}
			if (resp1 == true && resp2 == false) {
				Console.WriteLine ("O resultado lógico das afirmativas é: " +resp1+ "e" +resp2+ "é: false");
			} else {
				Console.WriteLine ("O resultado lógico das afirmativas é: " +resp1+ "ou" +resp2+ "é: true");
			}
			if (resp1 == false && resp2 == false) {
				Console.WriteLine ("O resultado lógico das afirmativas é: " +resp1+ "e" +resp2+ "é: false");
			} else {
				Console.WriteLine ("O resultado lógico das afirmativas é: " +resp1+ "ou" +resp2+ "é: false");
				                 
			}
			
		}
	}
}
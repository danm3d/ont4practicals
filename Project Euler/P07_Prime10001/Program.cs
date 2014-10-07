using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace P07_Prime10001 {

	internal class Program {
		private static void Main(string[] args) {
			char escape = 'y';
			do {
				Console.Clear();
				Console.WriteLine("\n==Regular==");
				Prime10001();
				Console.WriteLine("\n[Hit 'y' to run again or anything else to end]");
				escape = Console.ReadKey().KeyChar;
			} while (escape == 'y');

			Console.ReadLine();
		}
		public static void Prime10001() {
			long num = 1L,
	primeCount = 1L;
			TimeSpan ts;
			long tickCounter;
			Stopwatch stw = new Stopwatch();
			stw.Start();
			while (primeCount < 10001) {
				num = num + 2;
				if (IsPrime(num)) {
					primeCount++;
				}
			}
			stw.Stop();
			ts = stw.Elapsed;
			tickCounter = stw.ElapsedTicks;
			string elapsed = String.Format("{0}ms", ts.TotalMilliseconds);
			Console.WriteLine("The 10001st prime: {0} \nTime:\t{1} \nTicks:\t{2}", num, elapsed, tickCounter);

		}

		static bool IsPrime(long num) {
			if (num % 2 == 0) {//even numbers greater than 2 aren't prime (that we know)
				if (num == 2) {
					return true;
				}
				return false;
			}
			long root = (int)Math.Sqrt(num);//loop until the sqrt
			for (long i = 3; i <= root; i += 2) {
				if (num % i == 0) {
					return false;
				}
			}
			return true;
		}


	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25f_rekurziv_prog_thm
{
	internal class Program
	{

		/// <summary>
		/// Kiszámolja az innentől hátralévő elemek összegét!
		/// </summary>
		/// <param name="l"></param>
		/// <param name="innentől"></param>
		/// <returns></returns>
		static int Összeg(List<int> l, int innentől = 0)
		{
			// 1. kilépési feltétel: NAGYON egyszerű szituáció, amikor NINCS szükség rekurzió
			if (innentől == l.Count)
			{
				return 0;
			}
			else
			{
				return l[innentől] + Összeg(l, innentől + 1);
			}
		}

		static int Összeg2(List<int> l, int innentől = 0)
			=> innentől == l.Count ? 0 : l[innentől] + Összeg2(l, innentől + 1);


		static int Párosak_száma(List<int> l, int i = 0)
		{
			if (i == l.Count)
			{
				return 0;
			}
			else
			{
				return 1 - l[i] % 2 + Párosak_száma(l, i + 1);
			}
		}

		static int Párosak_száma2(List<int> l, int i = 0) => (i == l.Count) ? 0 : 1 - l[i] % 2 + Párosak_száma2(l, i + 1);

		static bool Benne_van_e(List<int> l, int elem, int i = 0)
		{
			if (i == l.Count)
			{
				return false;
			}
			else
			{
				if (l[i] == elem)
				{
					return true;
				}
				else
				{
					return Benne_van_e(l, elem, i + 1);
				}
			}
		}

		static bool Benne_van_e2(List<int> l, int elem, int i = 0)
			=> (i == l.Count) ? false : ((l[i] == elem) ? true : Benne_van_e2(l, elem, i + 1));


		static int Első_páros(List<int> l, int i = 0)
		{

		}
		static int Utolsó_páros(List<int> l, int i = 0)
		{

		}
		static int Első_páros_indexe(List<int> l, int i = 0)
		{

		}
		static int Utolsó_páros_indexe(List<int> l, int i = 0)
		{

		}
		static int Maximum(List<int> l, int i = 0)
		{
			if (i == l.Count) throw new Exception("a lista üres!");
			return (i == l.Count - 1)? l[l.Count - 1] : Math.Max(l[i], Maximum(l, i + 1)); 
		}

		static int Maximum_helye(List<int> l, int i = 0)
		{

		}
		static List<int> Párosai(List<int> l, int i = 0)
		{

		}
		static List<int> Duplázottja(List<int> l, int i = 0)
		{

		}
		static List<int> Megfordítása(List<int> l, int i = 0)
		{

		}


		static void Main(string[] args)
		{
			// Tilos ciklust haszálni. nincs foreach, nincs for, nincs while, nincs LinQ.

			List<int> l = new List<int> { 2, 5, 6, 8, 7, 5, 4, 23, 2, 4, 56, 64, 2, 4515, 1, 51, 56, 2456, 2345, 62, 456 };

			int s = Összeg2(l);

			Console.WriteLine(s);



		}
	}
}

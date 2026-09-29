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
		static int Párosak_száma2(List<int> l, int i = 0) 
			=> (i == l.Count) ? 0 : 1 - l[i] % 2 + Párosak_száma2(l, i + 1);
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
			if (i == l.Count)
				throw new Exception("ebben a listában nincs páros elem!");
			return (l[i] % 2 == 0) ? l[i] : Első_páros(l, i + 1);
		}
		static int Utolsó_páros(List<int> l, int i = 0)
		{
			throw new NotImplementedException();
		}
		static int Első_páros_indexe(List<int> l, int i = 0)
		{
			throw new NotImplementedException();
		}
		static int Utolsó_páros_indexe(List<int> l) => Utolsó_páros_indexe(l, l.Count - 1);
		static int Utolsó_páros_indexe(List<int> l, int i)
		{
			if (i == -1)
				return -1;

			if (l[i] % 2 == 0)
				return i;
			
			return Utolsó_páros_indexe(l, i - 1);
		}
		static int Utolsó_páros_indexe2(List<int> l, int i)
			=> (i == -1) ? -1 : l[i] % 2 == 0 ? i : Utolsó_páros_indexe2(l, i - 1);
		static int Maximum(List<int> l, int i = 0)
		{
			if (i == l.Count) throw new Exception("a lista üres!");
			return (i == l.Count - 1)? l[l.Count - 1] : Math.Max(l[i], Maximum(l, i + 1)); 
		}
		static int Maximum_helye(List<int> l, int i = 0)
		{
			throw new NotImplementedException();
		}
		static List<int> Párosai(List<int> l, int i = 0)
		{
			if (i==l.Count)
				return new List<int>();

			List<int> eddigiek = Párosai(l, i + 1);
			
			if (l[i]%2==0)
			{
				eddigiek.Add(l[i]);
			}
			
			return eddigiek;
		}
		static List<int> Duplázottja(List<int> l) => Duplázottja(l, l.Count - 1);

		static List<int> Duplázottja(List<int> l, int i)
		{
			if (i==-1)
				return new List<int>();

			List<int> eddigiek = Duplázottja(l, i - 1);

			eddigiek.Add(2 * l[i]);

			return eddigiek;

		}
		static List<int> Megfordítása(List<int> l, int i = 0)
		{
			if (i == l.Count)
				return new List<int>();

			List<int> eddigiek = Megfordítása(l, i + 1);

			eddigiek.Add(l[i]);

			return eddigiek;
		}


		static void Main(string[] args)
		{
			// Tilos ciklust haszálni. nincs foreach, nincs for, nincs while, nincs LinQ.

			List<int> l = new List<int> { 3, 5, 6, 8, 7, 5, 4, 23, 2, 4, 56, 64, 2, 4515, 1, 51, 56, 2456, 2345, 62, 456 };

			Console.WriteLine(string.Join(", ", l));

			Console.WriteLine(Összeg2(l));

			Console.WriteLine(Párosak_száma2(l));

			Console.WriteLine(Benne_van_e2(l, 23));
			Console.WriteLine(Benne_van_e2(l, 24));
			Console.WriteLine(Első_páros(l));
			Console.WriteLine(Utolsó_páros_indexe(l));
			Console.WriteLine(Maximum(l));
			Console.WriteLine(string.Join(", ", Párosai(l)));
			Console.WriteLine(string.Join(", ", Duplázottja(l)));
			Console.WriteLine(string.Join(", ", Megfordítása(l)));



		}
	}
}

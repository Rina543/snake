﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake2
{
	class point
	{
		public int x;
		public int y;
		public char sym;

		public void drow()
		{
			Console.SetCursorPosition(x, y);
			Console.Write(sym);
		}
	}
}

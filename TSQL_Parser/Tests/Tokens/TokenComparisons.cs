﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

using TSQL;
using TSQL.Tokens;

namespace Tests.Tokens
{
	public static class TokenComparisons
	{
		public static void CompareStreamStartToList(List<TSQLToken> expected, TSQLTokenizer lexer)
		{
			CompareTokenListStart(expected, lexer.ToList());
		}

		public static void CompareTokenListStart(List<TSQLToken> expected, List<TSQLToken> actual)
		{
			Assert.AreEqual(expected == null, actual == null);
			if (expected != null && actual != null)
			{
				Assert.IsTrue(actual.Count >= expected.Count);
				for (int index = 0; index < expected.Count; index++)
				{
					Assert.AreEqual(expected[index], actual[index]);
				}
			}
		}

		public static void CompareStreamToList(List<TSQLToken> expected, TSQLTokenizer lexer)
		{
			CompareTokenLists(expected, lexer.ToList());
		}

		public static void CompareTokenLists(List<TSQLToken> expected, List<TSQLToken> actual)
		{
			Assert.AreEqual(expected == null, actual == null);
			if (expected != null && actual != null)
			{
				Assert.AreEqual(expected.Count, actual.Count, "Token list count does not match.");
				for (int index = 0; index < expected.Count; index++)
				{
					Assert.AreEqual(expected[index], actual[index], "Token value does not match.");
				}
			}
		}
	}
}

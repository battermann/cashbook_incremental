using System;
using eventstore.contract;
using eventstore.internals;
using System.Collections.Generic;

namespace cashbook.body.data.contract
{
	public class Balance {
		public DateTime Month;
		public double Value;
	}
}
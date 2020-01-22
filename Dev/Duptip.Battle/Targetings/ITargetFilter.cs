
using System.Collections.Generic;
using Duptip.Battle.Entities;

namespace Duptip.Battle.Targetings
{
	public interface ITargetFilter
	{
		IEnumerable<ITargetable> Filter(IEnumerable<ITargetable> source);
	}
}
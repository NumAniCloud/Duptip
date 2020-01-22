
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Duptip.Battle.Targetings
{
	public interface ITargetingStrategy
	{
		Task<ActiveTarget?> SelectAsync(IEnumerable<ITargetable> targetables);
	}
}
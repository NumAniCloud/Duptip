
using System.Threading.Tasks;
using Duptip.Battle.Common;

namespace Duptip.Battle.Targetings
{
	public class TargetRange
	{
#nullable disable
		public virtual ITargetFilter Filter { get; set; }
#nullable restore

		public virtual async Task<ActiveTarget?> SelectAsync(ITargetingStrategy strategy, BattleContext<TBattler> context)
		{
			var targetables = context.GetTargetables();
			var filtered = Filter.Filter(targetables);
			return await strategy.SelectAsync(filtered);
		}
	}
}
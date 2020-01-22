
using System.Threading.Tasks;
using Duptip.Battle.Common;
using Duptip.Battle.Entities;
using Duptip.Battle.Targetings;

namespace Duptip.Battle.ActiveAttributes
{
	public class ActiveAttribute<TBattler> where TBattler : Battler
	{
#nullable disable
		public TargetRange Range { get; set; }
		public IActiveEffect Effect { get; set; }
#nullable restore

		public Task<ActiveTarget?> SelectTargetAsync(BattleContext<TBattler> context, ITargetingStrategy strategy)
		{
			return Range.SelectAsync(strategy, context);
		}

		public Task RunAsync(InvocationContext invocation)
		{
			return Effect.RunAsync(invocation);
		}
	}
}

using System.Threading.Tasks;
using Duptip.Battle.ActiveAttributes;
using Duptip.Battle.Common;
using Duptip.Battle.Entities;

namespace Duptip.Battle.Targetings
{
	public class TargetSelectionContext<TBattler> where TBattler : Battler
	{
		public ActiveAttribute ActiveAttribute { get; }
		public TBattler Doer { get; }
		public BattleContext<TBattler> Context { get; }

		public TargetSelectionContext(BattleContext<TBattler> context, TBattler battler, ActiveAttribute activeAttribute)
		{
			Context = context;
			Doer = battler;
			ActiveAttribute = activeAttribute;
		}

		public async Task<InvocationContext?> DetermineInvocationAsync()
		{
			var target = await ActiveAttribute.SelectTargetAsync(Context, Doer.TargetingStrategy);
			if (target == null)
			{
				return null;
			}

			return new InvocationContext(this, target);
		}
	}
}
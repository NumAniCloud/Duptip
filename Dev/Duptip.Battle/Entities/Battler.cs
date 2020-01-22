
using System.Collections.Generic;
using Duptip.Battle.Common;
using Duptip.Battle.Targetings;

namespace Duptip.Battle.Entities
{
	public abstract class Battler : ITargetable
	{
		public abstract ITargetingStrategy TargetingStrategy { get; }

		public abstract IEnumerable<Battler> GetAllies(BattleContext<Battler> context);
		public abstract IEnumerable<Battler> GetRivals(BattleContext<Battler> context);
	}
}
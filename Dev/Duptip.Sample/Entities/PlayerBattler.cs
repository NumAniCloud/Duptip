
using System;
using System.Collections.Generic;
using Duptip.Battle.Common;
using Duptip.Battle.Entities;
using Duptip.Battle.Targetings;

namespace Duptip.Sample.Entities
{
	public class PlayerBattler : Battler
	{
		private readonly Func<BattleContext, IEnumerable<Battler>> getAllies;
		private readonly Func<BattleContext, IEnumerable<Battler>> getRivals;

		public override ITargetingStrategy TargetingStrategy => throw new System.NotImplementedException();

		public PlayerBattler(Func<BattleContext, IEnumerable<Battler>> getAllies,
			Func<BattleContext, IEnumerable<Battler>> getRivals)
		{
			this.getAllies = getAllies;
			this.getRivals = getRivals;
		}

		public override IEnumerable<Battler> GetAllies(BattleContext context) => getAllies(context);

		public override IEnumerable<Battler> GetRivals(BattleContext context) => getRivals(context);
	}
}
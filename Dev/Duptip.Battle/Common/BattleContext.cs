
using System.Collections.Generic;
using System.Linq;
using Duptip.Battle.BattleEvents;
using Duptip.Battle.Entities;
using Duptip.Battle.Targetings;

namespace Duptip.Battle.Common
{
	public class BattleContext<TBattler> where TBattler : Battler
	{
		public IBattlerOrderDeterminator OrderDeterminator { get; }
		public ITurnProcessor<TBattler> TurnProcessor { get; }
		public IBattleEventHandler Handler { get; }
		public TBattler[] Players { get; set; } = new TBattler[0];
		public TBattler[] Opponents { get; set; } = new TBattler[0];

		public BattleContext(IBattlerOrderDeterminator orderDeterminator,
			ITurnProcessor<TBattler> turnProcessor,
			IBattleEventHandler handler)
		{
			OrderDeterminator = orderDeterminator;
			TurnProcessor = turnProcessor;
			Handler = handler;
		}

		public virtual IEnumerable<ITargetable> GetTargetables()
		{
			return Players.Concat(Opponents);
		}
	}
}
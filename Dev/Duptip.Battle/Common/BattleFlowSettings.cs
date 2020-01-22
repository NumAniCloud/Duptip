
using Duptip.Battle.BattleEvents;
using Duptip.Battle.Entities;

namespace Duptip.Battle.Common
{
	public class BattleFlowSettings<TBattler> where TBattler : Battler
	{
		public IBattlerOrderDeterminator OrderDeterminator { get; }
		public ITurnProcessor<TBattler> TurnProcessor { get; }
		public IBattleEventHandler Handler { get; }
		public TBattler[] Players { get; }
		public TBattler[] Opponents { get; }

		public BattleFlowSettings(IBattlerOrderDeterminator orderDeterminator,
			ITurnProcessor<TBattler> turnProcessor,
			IBattleEventHandler handler,
			TBattler[] players,
			TBattler[] opponents)
		{
			OrderDeterminator = orderDeterminator;
			TurnProcessor = turnProcessor;
			Handler = handler;
			Players = players;
			Opponents = opponents;
		}
	}
}
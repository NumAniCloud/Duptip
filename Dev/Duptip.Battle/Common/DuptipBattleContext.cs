
using Duptip.Battle.BattleEvents;
using Duptip.Battle.Entities;

namespace Duptip.Battle.Common
{
	public class DuptipBattleContext<TUserBattleContext> where TUserBattleContext : IUserBattleContext
	{
		public TUserBattleContext UserBattleContext { get; }
		public IBattlerOrderDeterminator OrderDeterminator { get; }
		public ITurnProcessor<TUserBattleContext> TurnProcessor { get; }
		public IBattleEventHandler Handler { get; }
		public Battler[] Players => UserBattleContext.Players;
		public Battler[] Opponents => UserBattleContext.Opponents;
	}
}
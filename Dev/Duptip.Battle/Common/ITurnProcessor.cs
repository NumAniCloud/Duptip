
using System.Collections.Generic;
using System.Threading.Tasks;
using Duptip.Battle.Entities;

namespace Duptip.Battle.Common
{
	public interface ITurnProcessor<TUserBattleContext, TBattler>
		where TUserBattleContext : IUserBattleContext
		where TBattler : Battler
	{
		Task ProcessTurn(IEnumerable<TBattler> ordered, DuptipBattleContext<TUserBattleContext> context);
	}
}
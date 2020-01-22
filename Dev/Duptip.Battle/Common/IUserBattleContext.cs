
using Duptip.Battle.Entities;

namespace Duptip.Battle.Common
{
	public interface IUserBattleContext
	{
		Battler[] Players { get; }
		Battler[] Opponents { get; }
	}
}
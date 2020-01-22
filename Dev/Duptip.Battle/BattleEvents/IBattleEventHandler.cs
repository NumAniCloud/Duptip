
using System.Threading.Tasks;

namespace Duptip.Battle.BattleEvents
{
	public interface IBattleEventHandler
	{
		Task HandleAsync(IBattleEvent @event);
	}
}
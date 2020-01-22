
using System.Threading.Tasks;
using Duptip.Battle.Common;

namespace Duptip.Battle.BattleEvents
{
	public interface IBattleEvent
	{
		Task RunAsync(BattleContext context);
	}
}
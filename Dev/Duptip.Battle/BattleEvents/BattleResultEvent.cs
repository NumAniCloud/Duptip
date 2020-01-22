
using System.Threading.Tasks;
using Duptip.Battle.Common;

namespace Duptip.Battle.BattleEvents
{
	public class BattleResultEvent<TBattleResult> : IBattleEvent
	{
		public IBattleResult<TBattleResult> Result { get; set; }

		public BattleResultEvent(IBattleResult<TBattleResult> result)
		{
			Result = result;
		}

		public Task RunAsync(BattleContext context)
		{
			return Task.CompletedTask;
		}
	}
}
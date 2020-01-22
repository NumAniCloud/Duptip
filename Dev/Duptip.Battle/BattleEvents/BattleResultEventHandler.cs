using System;
using System.Threading.Tasks;
using Duptip.Battle.Common;

namespace Duptip.Battle.BattleEvents
{
	public class BattleResultEventHandler<TBattleResult> : IBattleEventHandler
	{
		private readonly Action<IBattleResult<TBattleResult>> setter;

		public BattleResultEventHandler(Action<IBattleResult<TBattleResult>> setter)
		{
			this.setter = setter;
		}

		public Task HandleAsync(IBattleEvent @event)
		{
			if (@event is BattleResultEvent<TBattleResult> result)
			{
				setter(result.Result);
			}
			return Task.CompletedTask;
		}
	}
}
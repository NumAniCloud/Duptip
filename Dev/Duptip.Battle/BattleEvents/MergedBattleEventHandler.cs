
using System;
using System.Threading.Tasks;

namespace Duptip.Battle.BattleEvents
{
	public class MergedBattleEventHandler : IBattleEventHandler
	{
		private readonly IBattleEventHandler[] handlers;
		private readonly Func<bool> isResultSet;

		public MergedBattleEventHandler(IBattleEventHandler[] handlers, Func<bool> isResultSet)
		{
			this.handlers = handlers;
			this.isResultSet = isResultSet;
		}

		public async Task HandleAsync(IBattleEvent @event)
		{
			foreach (var item in handlers)
			{
				await item.HandleAsync(@event);
				if (isResultSet())
				{
					return;
				}
			}
		}
	}
}
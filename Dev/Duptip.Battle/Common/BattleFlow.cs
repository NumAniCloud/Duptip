
using System.Linq;
using System.Threading.Tasks;
using Duptip.Battle.BattleEvents;
using Duptip.Battle.Entities;

namespace Duptip.Battle.Common
{
	public class BattleFlow<TBattleResult, TBattler> where TBattler : Battler
	{
		private IBattleResult<TBattleResult>? battleResult;
		private readonly BattleContext<TBattler> context;

		public BattleFlow(BattleFlowSettings<TBattler> settings)
		{
			var battleResultHandler = new BattleResultEventHandler<TBattleResult>(result => battleResult = result);
			var merged = new MergedBattleEventHandler(
				new [] { settings.Handler, battleResultHandler },
				() => battleResult != null
			);

			this.context = new BattleContext<TBattler>(settings.OrderDeterminator,
				settings.TurnProcessor,
				merged)
				{
					Players = settings.Players,
					Opponents = settings.Opponents
				};
		}

		public async Task<TBattleResult> RunAsync()
		{
			while (battleResult == null)
			{
				var battlers = context.Players.Concat(context.Opponents);
				var ordered = context.OrderDeterminator.Determinate(battlers); 
				await context.TurnProcessor.ProcessTurn(ordered, context);
			}

			return await battleResult.RunAsync();
		}
	}
}
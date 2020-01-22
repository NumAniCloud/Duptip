
using System.Collections.Generic;
using System.Threading.Tasks;
using Duptip.Battle.Common;
using Duptip.Battle.Entities;

namespace Duptip.Sample.Services
{
	public class TurnProcessor : Battle.Common.ITurnProcessor
	{
		public async Task ProcessTurn(IEnumerable<Battler> ordered, BattleContext context)
		{
			foreach (var item in ordered)
			{
				// 何かする
				System.Console.WriteLine(ordered);
				Task.Delay(2000);
			}
		}
	}
}
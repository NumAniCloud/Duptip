
using System.Collections.Generic;
using Duptip.Battle.Entities;

namespace Duptip.Sample.Services
{
	public class BattlerOrderDeterminator : Battle.Common.IBattlerOrderDeterminator
	{
		public IEnumerable<Battler> Determinate(IEnumerable<Battler> battlers)
		{
			return battlers;
		}
	}
}
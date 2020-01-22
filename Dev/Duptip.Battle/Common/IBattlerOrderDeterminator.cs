
using System.Collections.Generic;
using Duptip.Battle.Entities;

namespace Duptip.Battle.Common
{
	public interface IBattlerOrderDeterminator
	{
		IEnumerable<Battler> Determinate(IEnumerable<Battler> battlers);
	}
}
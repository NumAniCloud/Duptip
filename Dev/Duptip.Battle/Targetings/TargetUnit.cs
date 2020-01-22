using Duptip.Battle.Entities;

namespace Duptip.Battle.Targetings
{
	public class TargetUnit
	{
		public Battler[] Targets { get; }

		public TargetUnit(Battler[] targets)
		{
			Targets = targets;
		}
	}
}
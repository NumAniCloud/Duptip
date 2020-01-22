
using Duptip.Battle.Entities;

namespace Duptip.Battle.Targetings
{
	public class ActiveTarget
	{
		public TargetUnit[] TargetUnits { get; }

		public ActiveTarget(TargetUnit[] targets)
		{
			TargetUnits = targets;
		}

		public ActiveTarget(Battler[] targets)
		{
			TargetUnits = new TargetUnit[]
			{
				new TargetUnit(targets)
			};
		}
	}
}
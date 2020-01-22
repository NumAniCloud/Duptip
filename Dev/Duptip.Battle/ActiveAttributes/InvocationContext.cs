
using System.Threading.Tasks;
using Duptip.Battle.Common;
using Duptip.Battle.Entities;
using Duptip.Battle.Targetings;

namespace Duptip.Battle.ActiveAttributes
{
	public class InvocationContext
	{
		BattleContext Context { get; }
		Battler Doer { get; }
		ActiveAttribute ActiveAttribute { get; }
		ActiveTarget Target { get; }

		public InvocationContext(TargetSelectionContext targetSelection, ActiveTarget target)
		{
			Context = targetSelection.Context;
			ActiveAttribute = targetSelection.ActiveAttribute;
			Target = target;
			Doer = targetSelection.Doer;
		}

		public Task RunAsync()
		{
			return ActiveAttribute.RunAsync(this);
		}
	}
}
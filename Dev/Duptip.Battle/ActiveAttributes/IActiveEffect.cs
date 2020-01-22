
using System.Threading.Tasks;

namespace Duptip.Battle.ActiveAttributes
{
	public interface IActiveEffect
	{
		Task RunAsync(InvocationContext invocation);
	}
}
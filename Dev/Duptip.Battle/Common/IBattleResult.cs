
using System.Threading.Tasks;

namespace Duptip.Battle.Common
{
	public interface IBattleResult<TReturn>
	{
		Task<TReturn> RunAsync();
	}
}
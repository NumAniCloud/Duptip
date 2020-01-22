using System;
using Duptip.Battle.Common;
using Duptip.Sample.Entities;
using Duptip.Sample.Services;

namespace Duptip.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderDeterminator = new BattlerOrderDeterminator();
			var settings = new BattleFlowSettings();
			var flow = new BattleFlow<BattleResult>(settings);
        }
    }
}

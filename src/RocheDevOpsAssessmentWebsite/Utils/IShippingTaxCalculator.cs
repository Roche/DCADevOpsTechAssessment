using System.Collections.Generic;
using RocheDevOpsAssessment.Models;

namespace RocheDevOpsAssessment.Utils
{
	public interface IShippingTaxCalculator
	{
		OrderCostSummary CalculateCost(IEnumerable<ILineItem> items, string orderZip);
	}
}
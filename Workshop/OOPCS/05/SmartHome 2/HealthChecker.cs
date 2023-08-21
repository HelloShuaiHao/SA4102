using System.Collections.Generic;

namespace SmartHome;

class HealthChecker 
{
  private Dictionary<string, uint> svcThreshold;

  public HealthChecker(Dictionary<string, uint> svcThreshold)
  {
    this.svcThreshold = svcThreshold;
  }

  public void CheckHealth(IHealth appliance) 
  {
    string type = appliance.GetApplType();

    if (svcThreshold.ContainsKey(type)) {
        // get the service-threshold for this appliance-type
        uint limit = svcThreshold[type];

        // get usage count for this appliance
        uint nUsed = appliance.GetUsageCount();

        // determine health-status based on threshold
        if (nUsed >= limit) {
            Console.WriteLine("{0} needs servicing after {1} uses.",
                appliance.GetName(), nUsed);
        } else {
            Console.WriteLine("{0} is healthy after {1} uses.",
                appliance.GetName(), nUsed);
        }
    }
  }
}
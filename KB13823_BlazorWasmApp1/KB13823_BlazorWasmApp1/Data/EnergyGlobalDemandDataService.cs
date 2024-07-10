namespace KB13823_BlazorWasmApp1.Data;

public class EnergyGlobalDemandDataService
{
    private List<EnergyGlobalDemandItem>? _energyGlobalDemandItems = null;
    public Task<List<EnergyGlobalDemandItem>> GetEnergyGlobalDemandItemsAsync()
    {
        if(this._energyGlobalDemandItems == null)
        {
            this._energyGlobalDemandItems = new List<EnergyGlobalDemandItem>()
            {
                new () { Value = 37, Category = @"Cooling", Summary = @"Cooling 37%" },
                new () { Value = 25, Category = @"Residential", Summary = @"Residential 25%" },
                new () { Value = 12, Category = @"Heating", Summary = @"Heating 12%" },
                new () { Value = 11, Category = @"Lighting", Summary = @"Lighting 11%" },
                new () { Value = 15, Category = @"Other", Summary = @"Other 15%" },
            };
        }
        return Task.FromResult(this._energyGlobalDemandItems);
    }
}

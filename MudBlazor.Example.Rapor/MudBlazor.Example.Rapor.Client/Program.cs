using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Example.Rapor.Client.Model;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();

#region SET SELL LÝST
List<Sell> Sells = new();
for (int i = 1; i < 5; i++)
{
    Sells.Add(new Sell
    {
        Id = i,
        CreatedDate = new DateTime(2024, 10, 8),
        CustomerId = 18091,
        ProductName = "Akaryakýt",
        Status = "Tamamlandý",
        OrderType = "Pompa",
        Plate = "07 TST 320",
        Location = "#1234567",
        DiscountAmount = 0,
        TotalPiece = Convert.ToDecimal("12,7"),
        TotalAmount = Convert.ToDecimal("530,1")
    });
}
Sells.Add(new Sell
{
    Id = 10,
    CreatedDate = new DateTime(2024, 11, 03),
    CustomerId = 18091,
    ProductName = "Akaryakýt",
    Status = "Tamamlandý",
    OrderType = "Pompa",
    Plate = "07 TST 321",
    Location = "#1234567",
    DiscountAmount = 0,
    TotalPiece = Convert.ToDecimal("112,7"),
    TotalAmount = Convert.ToDecimal("1530,1")
});
SellList.Sells.AddRange(Sells);
#endregion

await builder.Build().RunAsync();
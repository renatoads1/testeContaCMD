using Microsoft.Extensions.DependencyInjection;
using teste1;

var serviceProvider = new ServiceCollection()
    .AddTransient<IConta, Conta>()
    .AddTransient<IPessoa, Pessoas>()
    .AddTransient<IContaService, ContaService>()
    .BuildServiceProvider();

var contaService = serviceProvider.GetRequiredService<IContaService>();
var pessoa = serviceProvider.GetRequiredService<IPessoa>();
var conta = serviceProvider.GetRequiredService<IConta>();

contaService.CriarConta(pessoa, conta);
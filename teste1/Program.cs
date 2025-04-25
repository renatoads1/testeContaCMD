using teste1;

Pessoas pessoa = new Pessoas();
Conta conta = new Conta();

Console.WriteLine("Entre com o Número da conta");
conta.NumeroConta = Console.ReadLine();
Console.WriteLine("Entre com o Nome do Titular da conta");
pessoa.Nome = Console.ReadLine();
Console.WriteLine("Entre com o Deposito da conta");
conta.Saldo = Console.ReadLine();
Console.WriteLine($"conta de {pessoa.Nome} \n De numero {conta.NumeroConta} \n com saldo de {conta.Saldo}");

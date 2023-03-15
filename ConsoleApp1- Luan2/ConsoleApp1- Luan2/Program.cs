// See https://aka.ms/new-console-template for more information
using ConsoleApp1__Luan2;

Console.WriteLine("Hello, World!");

Produto p1 = new Produto(1, "Mouse sem fio", 59.90M);
//Console.WriteLine(p1.getDescricao()+ " " +p1.getValor() );

p1.setValor(89.9M);
Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

Endereco e1 = new Endereco("Rua Mario  Miziara", "Nº: 91", "cep:15997420", "Bairro: Sobral", "Taquaritinga", "SP");

Cliente c1 = new Cliente(2, "George", "9987654321",e1);
Cliente c2 = new Cliente(1, "Ferneko", "9912345567", e1);
Cliente c3 = new Cliente(3, "Rafaela", "9912345678", e1);
Cliente c4 = new Cliente(4, "Jessica", "923456789", e1);

Console.WriteLine(c1.getEndereco().getEnderecoCompleto());
c1.getEndereco().setRua("Prudente de Moraes");

Carro car = new Carro();
car.Marca = "VW";
car.numeroPortas = 4;
car.numeroRodas = 4;
car.Cor = "Vermelho";
car.quantidadeAcento = 5;

Aviao aviao = new Aviao();
aviao.portasInternas = 50;
aviao.numeroRodas = 3;
aviao.numeroPortas = 12;
aviao.Cor = "azul";
aviao.PagaImposto = false;

bike bicicleta = new bike();
bicicleta.PagaImposto = false;

Console.WriteLine(aviao.ExibirDados());

List<Cliente> listaCliente = new List<Cliente>();
listaCliente.Add(c1);
listaCliente.Add(c2);
listaCliente.Add(c3);
listaCliente.Add(c4);

foreach (var item in listaCliente)
{
    Console.WriteLine(item.getNome());
}



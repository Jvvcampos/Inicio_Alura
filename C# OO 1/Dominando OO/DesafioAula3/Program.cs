using DesafioAula3.ModelosEletronicos;

Laptop laptop = new Laptop();
laptop.Modelo = "G15";
laptop.Preco = 3000;
laptop.Processador = "Ryzen 5";

Console.WriteLine(laptop.ExibirInformacoes());
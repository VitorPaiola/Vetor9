using System.Globalization;

int N = int.Parse(Console.ReadLine());

string[] nomes = new string[N];
double[] compra = new double[N];
double[] venda = new double[N];

for (int i = 0; i < N; i++) {
    string[] vet = Console.ReadLine().Split(' ');
    nomes[i] = vet[0];
    compra[i] = double.Parse(vet[1], CultureInfo.InvariantCulture);
    venda[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
}

int contAbaixoDe10 = 0;
int contEntre10E20 = 0;
int contAcimaDe20 = 0;

for (int i = 0; i < N; i++) {
    double lucro = venda[i] - compra[i];
    double porcentagemLucro = lucro / compra[i] * 100.0;

    if (porcentagemLucro < 10.0) {
        contAbaixoDe10++;
    } else if (porcentagemLucro <= 20.0) {
        contEntre10E20++;
    } else {
        contAcimaDe20++;
    }
}

Console.WriteLine("Lucro abaixo de 10%: " + contAbaixoDe10);
Console.WriteLine("Lucro entre 10% e 20%: " + contEntre10E20);
Console.WriteLine("Lucro acima de 20%: " + contAcimaDe20);

double totalCompra = 0.0;
double totalVenda = 0.0;

for (int i = 0; i < N; i++) {
    totalCompra += compra[i];
    totalVenda += venda[i];
}

double totalLucro = totalVenda - totalCompra;

Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Lucro total: " + totalLucro.ToString("F2", CultureInfo.InvariantCulture));
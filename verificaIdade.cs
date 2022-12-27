// Faça um algoritmo que exiba quantas pessoas possuem +  e - de 18 anos.
// O algoritmo deverá ler a idade de 10 pessoas.

Console.WriteLine("Exercicio Calcula idade das Pessoas");
int maiorIdade = 0;
int menorIdade = 0;
int idade = 0;

int i = 0;
while (i < 10) // faz a leitura 10 x 
{
    i = i + 1;   
    Console.WriteLine("informe a Idade da pessoa");
    idade = Convert.ToInt32(Console.ReadLine());

    if (idade >= 18)
    {
        maiorIdade = maiorIdade + 1;
    }
    else if(idade < 18)
    {
        menorIdade = menorIdade + 1;
    }

}
Console.WriteLine("Existem" +maiorIdade + "de pessoas maiores de 18 anos"  );
Console.WriteLine("Existem" + menorIdade + "de pessoas menores de 18 anos");

Console.ReadKey();


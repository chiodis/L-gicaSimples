using estudar.models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal ValorMonetario = 1500.50m;

Console.WriteLine(ValorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));    





























/*Pessoa p1 = new Pessoa(nome: "lucas", sobrenome: "chiodi", 19);
Pessoa p2 = new Pessoa(nome: "joyce", sobrenome: "reguete", 21);

p1.Apresentar();
p2.Apresentar();


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarALunos();
cursoDeIngles.RemoverAluno(p2);
cursoDeIngles.ListarALunos();
*/





















//Pessoa p1 = new Pessoa();
//p1.Nome = "chiodi";
//p1.Sobrenome = "reis";
//p1.Idade = 19;
//p1.Apresentar();








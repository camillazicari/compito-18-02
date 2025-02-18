
using compito_18_02.Models;

var cv = new CV();

Console.WriteLine("Curriculum Vitae di:");
Console.WriteLine("Inserisci il tuo nome: ");
string nome = Console.ReadLine().ToUpper();
cv.InformazioniPersonali.Nome = nome;
Console.WriteLine("Inserisci il tuo cognome:");
string cognome = Console.ReadLine().ToUpper();
cv.InformazioniPersonali.Cognome = cognome;
Console.Clear();
Console.WriteLine("------Curriculum Vitae di: " + nome+ " " + cognome + "------");

Console.WriteLine("*INFORMAZIONI PERSONALI*");
Console.WriteLine("Inserisci la tua email:");
string email = Console.ReadLine();
cv.InformazioniPersonali.Mail = email;
Console.WriteLine("Inserisci il tuo numero di telefono:");
string telefono = Console.ReadLine();
cv.InformazioniPersonali.Telefono = telefono;
Console.Clear();


Console.WriteLine("Informazioni personali aggiunte con successo!");
Console.WriteLine("*STUDI E FORMAZIONE*");
back:
Console.WriteLine("Inserisci il nome dell'istituto di formazione che hai frequentato:");
string istituto = Console.ReadLine().ToUpper();
Console.WriteLine("Inserisci la tipologia di studi:");
string tipo = Console.ReadLine();
Console.WriteLine("Inserisci la qualifica raggiunta:");
string qualifica = Console.ReadLine();
Console.WriteLine("Inserisci la data di inizio studi:");
DateTime.TryParse(Console.ReadLine(), out DateTime inizio);
Console.WriteLine("Inserisci la data di fine studi:");
DateTime.TryParse(Console.ReadLine(), out DateTime fine);
var studi = new Studi()
{
    Istituto = istituto,
    Tipo = tipo,
    Qualifica = qualifica,
    Dal = inizio,
    Al = fine
};
cv.StudiEffettuati.Add(studi);
Console.WriteLine("Hai frequentato altri istituti di formazione?");
Console.WriteLine("1.Si");
Console.WriteLine("2.No");
int.TryParse(Console.ReadLine(), out int scelta);
if (scelta == 1)
{
    goto back;
} else
{
    Console.Clear();
}

Console.WriteLine("Studi e formazione aggiunti con successo!");
Console.WriteLine("*ESPERIENZE PROFESSIONALI*");
back2:
Console.WriteLine("Inserisci il nome dell'azienda per la quale hai lavorato:");
string presso = Console.ReadLine().ToUpper();
Console.WriteLine("Inserisci il tipo di impiego:");
string impiego = Console.ReadLine();
Console.WriteLine("Inserisci il compito che hai dovuto svolgere come " + impiego);
string compito = Console.ReadLine();
Console.WriteLine("Inserisci la data di inizio impiego:");
DateTime.TryParse(Console.ReadLine(), out DateTime inizioImpiego);
Console.WriteLine("Inserisci la data di fine impiego:");
DateTime.TryParse(Console.ReadLine(), out DateTime fineImpiego);
var esperienza = new Esperienza()
{
    Azienda = presso,
    JobTitle = impiego,
    Compiti = compito,
    Dal = inizioImpiego,
    Al = fineImpiego
};
cv.Impieghi.Add(esperienza);
Console.WriteLine("Hai lavorato per altre aziende?");
Console.WriteLine("1.Si");
Console.WriteLine("2.No");
int.TryParse(Console.ReadLine(), out int scelta2);
if (scelta2 == 1)
{
    goto back2;
}
else
{
    Console.WriteLine("Esperienze professionali aggiunte con successo!");
}

Console.Clear();
Console.WriteLine("------Curriculum Vitae di: " + cv.InformazioniPersonali.Nome + " " + cv.InformazioniPersonali.Cognome + "------");
Console.WriteLine("*INFORMAZIONI PERSONALI*");
Console.WriteLine("Nome: " + cv.InformazioniPersonali.Nome);
Console.WriteLine("Cognome: " + cv.InformazioniPersonali.Cognome);
Console.WriteLine("Email: " + cv.InformazioniPersonali.Mail);
Console.WriteLine("Telefono: " + cv.InformazioniPersonali.Telefono);
Console.WriteLine("*FINE INFORMAZIONI PERSONALI*");

Console.WriteLine("-----------------------------");
Console.WriteLine("*STUDI E FORMAZIONE*");
foreach(var studio in cv.StudiEffettuati)
{
    Console.WriteLine("Istituto: " + studio.Istituto);
    Console.WriteLine("Qualifica: " + studio.Qualifica);
    Console.WriteLine("Tipo: " + studio.Tipo);
    Console.WriteLine("Dal " + studio.Dal + " al " + studio.Al);
}

Console.WriteLine("*FINE STUDI E FORMAZIONE*");
Console.WriteLine("-----------------------------");

Console.WriteLine("*ESPERIENZE PROFESSIONALI*");
foreach (var esp in cv.Impieghi)
{
    Console.WriteLine("Istituto: " + esp.Azienda);
    Console.WriteLine("Qualifica: " + esp.JobTitle);
    Console.WriteLine("Tipo: " + esp.Compiti);
    Console.WriteLine("Dal " + esp.Dal + " al " + esp.Al);
}
Console.WriteLine("*FINE ESPERIENZE PROFESSIONALI*");
Console.WriteLine("-----------------------------");
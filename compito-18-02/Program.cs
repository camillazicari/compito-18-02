
using System.ComponentModel;
using System.Text.RegularExpressions;
using compito_18_02.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

var cv = new CV();

Console.WriteLine("Curriculum Vitae di:");
nome:
Console.WriteLine("Inserisci il tuo nome: ");
string nome = Console.ReadLine().ToUpper();
if (!string.IsNullOrWhiteSpace(nome))
{
    cv.InformazioniPersonali.Nome = nome;

} else
{
    Console.WriteLine("Inserisci un nome valido.");
    goto nome;
}
cognome:
Console.WriteLine("Inserisci il tuo cognome:");
string cognome = Console.ReadLine().ToUpper();
if (!string.IsNullOrWhiteSpace(cognome))
{
    cv.InformazioniPersonali.Cognome = cognome;

}
else
{
    Console.WriteLine("Inserisci un cognome valido.");
    goto cognome;
}
Console.Clear();
Console.WriteLine("------Curriculum Vitae di: " + nome+ " " + cognome + "------");

Console.WriteLine("*INFORMAZIONI PERSONALI*");
email:
Console.WriteLine("Inserisci la tua email:");

string email = Console.ReadLine();
if (!string.IsNullOrWhiteSpace(email) && email.Contains("@") && email.Contains("."))
{
    cv.InformazioniPersonali.Mail = email;

}
else
{
    Console.WriteLine("Inserisci una email valido.");
    goto email;
}
telefono:
Console.WriteLine("Inserisci il tuo numero di telefono:");
double.TryParse(Console.ReadLine(), out double telefono);
if (telefono > 3000000000)
{
    cv.InformazioniPersonali.Telefono = telefono;
}
else
{
    Console.WriteLine("Inserisci un numero di telefono valido.");
    goto telefono;
}
Console.Clear();


Console.WriteLine("Informazioni personali aggiunte con successo!");
Console.WriteLine("*STUDI E FORMAZIONE*");
back:
Console.WriteLine("Inserisci il nome dell'istituto di formazione che hai frequentato:");
string istituto = Console.ReadLine().ToUpper();
if (string.IsNullOrWhiteSpace(istituto))
{
    Console.WriteLine("Inserisci un istituto di formazione valido.");
    goto back;
}
studi:
Console.WriteLine("Inserisci la tipologia di studi:");
string tipo = Console.ReadLine();
if (string.IsNullOrWhiteSpace(tipo))
{
    Console.WriteLine("Inserisci una tipologia di studi valida.");
    goto studi;
}
qualifica:
Console.WriteLine("Inserisci la qualifica raggiunta:");
string qualifica = Console.ReadLine();
if (string.IsNullOrWhiteSpace(qualifica))
{
    Console.WriteLine("Inserisci un qualifica valida.");
    goto qualifica;
}
inizio:
Console.WriteLine("Inserisci la data di inizio studi nel formato aaaa-mm-gg (es. 2020-10-19):");
string dataInizio = Console.ReadLine();
Regex regex = new Regex(@"^\d{4}-\d{2}-\d{2}$");
DateOnly inizio;
if (regex.IsMatch(dataInizio) && !string.IsNullOrWhiteSpace(dataInizio))
{
    if (!DateOnly.TryParse(dataInizio, out inizio))
    {
        Console.WriteLine("Data non valida. Verifica che il mese e il giorno siano corretti.");
        goto inizio;
    }
}
else
{
    Console.WriteLine("Inserire la data di inizio studi nel formato corretto. Attenzione ad inserire anche - tra l'anno, il giorno ed il mese");
    goto inizio;
}

fine:
Console.WriteLine("Inserisci la data di fine studi nel formato aaaa-mm-gg (es. 2020-10-19):");
string dataFine = Console.ReadLine();
DateOnly fine;
if (regex.IsMatch(dataFine) && !string.IsNullOrWhiteSpace(dataFine))
{
    if (!DateOnly.TryParse(dataFine, out fine))
    {
        Console.WriteLine("Data non valida. Verifica che il mese e il giorno siano corretti.");
        goto fine;
    }
}
else
{
    Console.WriteLine("Inserire la data di fine studi nel formato corretto. Attenzione ad inserire anche - tra l'anno, il giorno ed il mese");
    goto fine;
}

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
if (string.IsNullOrWhiteSpace(presso))
{
    Console.WriteLine("Inserisci un'azienda valida.");
    goto back2;
}
impiego:
Console.WriteLine("Inserisci il tipo di impiego:");
string impiego = Console.ReadLine();
if (string.IsNullOrWhiteSpace(impiego))
{
    Console.WriteLine("Inserisci un impiego valido.");
    goto impiego;
}
compito:
Console.WriteLine("Inserisci il compito che hai dovuto svolgere come " + impiego);
string compito = Console.ReadLine();
if (string.IsNullOrWhiteSpace(compito))
{
    Console.WriteLine("Inserisci un compito valido.");
    goto compito;
}
inizioImp:
Console.WriteLine("Inserisci la data di inizio impiego nel formato aaaa-mm-gg (es. 2020-10-19):");
string inizioImp = Console.ReadLine();
DateOnly inizioImpiego;
if (regex.IsMatch(inizioImp) && !string.IsNullOrWhiteSpace(inizioImp))
{
    if (!DateOnly.TryParse(inizioImp, out inizioImpiego))
    {
        Console.WriteLine("Data non valida. Verifica che il mese e il giorno siano corretti.");
        goto inizioImp;
    }
}
else
{
    Console.WriteLine("Inserire la data di inizio impiego nel formato corretto. Attenzione ad inserire anche - tra l'anno, il giorno ed il mese");
    goto inizioImp;
}

scelta2:
Console.WriteLine("Attualmente lavori qui?");
Console.WriteLine("1. Sì");
Console.WriteLine("2. No");
int.TryParse(Console.ReadLine(), out int scelta2);
DateOnly fineImpiego = DateOnly.FromDateTime(DateTime.Today);
if (scelta2 > 0 && scelta2 < 3)
{
    if(scelta2 == 1)
    {
        goto lista;
    }

} else
{
    Console.WriteLine("Effettua una scelta valida.");
    goto scelta2;
}
fineImp:
Console.WriteLine("Inserisci la data di fine impiego nel formato aaaa-mm-gg (es. 2020-10-19):");
string fineImp = Console.ReadLine();
if (regex.IsMatch(fineImp) && !string.IsNullOrWhiteSpace(fineImp))
{
    if (!DateOnly.TryParse(fineImp, out fineImpiego))
    {
        Console.WriteLine("Data non valida. Verifica che il mese e il giorno siano corretti.");
        goto fineImp;
    }
}
else
{
    Console.WriteLine("Inserire la data di fine impiego nel formato corretto. Attenzione ad inserire anche - tra l'anno, il giorno ed il mese");
    goto fineImp;
}

lista:
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
int.TryParse(Console.ReadLine(), out int scelta3);
if (scelta3 == 1)
{
    goto back2;
}
else
{
    Console.WriteLine("Esperienze professionali aggiunte con successo!");
    Console.Clear();
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
using System;
using System.Collections.Generic;
using Test_2;

namespace SchoolManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Schüler und Klassenräume
            var schule = new Schule();

            var schueler1 = new Schueler("Merlin", "Female", new DateTime(2010, 5, 15), "3bWi");
            var schueler2 = new Schueler("Macknuss", "Male", new DateTime(2006, 3, 22), "3bWi");
            var schueler3 = new Schueler("Oman", "Male", new DateTime(2007, 10, 15), "3bWi");

            schule.Schueler.AddRange(new[] { schueler1, schueler2, schueler3 });

            var klassenraum1 = new Klassenraum("Room 247", 50.0, 30, true);
            var klassenraum2 = new Klassenraum("Room 102", 40.0, 20, false);

            schule.Klassenraeume.AddRange(new[] { klassenraum1, klassenraum2 });

            Console.WriteLine($"Schueler: {schule.GetTotalSchueler()}");
            var (maleCount, femaleCount) = schule.GetMaleAndFemaleCount();
            Console.WriteLine($"Männliche Schüler: {maleCount}, Weibliche Schüler: {femaleCount}");
            Console.WriteLine($"Klassenraeume: {schule.GetTotalKlassenraeume()}");
            Console.WriteLine($"Durchschnittsalter der Schüler: {schule.GetAverageAge()} Jahre");

            var cynapRooms = schule.GetKlassenraeumeWithCynap();
            Console.WriteLine($"Räume mit Cynap: {cynapRooms.Count}");

            Console.WriteLine($"Anzahl der Klassen: {schule.GetTotalKlassen()}");

            var classStudentCount = schule.GetClassStudentCount();
            foreach (var className in classStudentCount.Keys)
            {
                Console.WriteLine($"{className}: {classStudentCount[className]} Schüler");
            }

            Console.WriteLine($"Frauenanteil in Klasse 3bWi: {schule.GetFemalePercentageInClass("3bWi")}%");

            Console.WriteLine($"Kann Klasse 3bWi in Room 247 unterrichtet werden? {schule.CanClassBeTaughtInRoom("3bWi", klassenraum1)}");
        }
    }
}

/* Theoriefragen: 
_ Was ist ein Klasse?       (*eine)
Vorlage für Eigenschaften und Methoden eines Objekts der jeweiligen Klasse 
_ Was ist ein Objekt?
eine Instanz einer Klasse mit eigenen Werten für die Eigenschaften

_ Was ist ein Access Modifier? 
steuert den zugriff auf mitglieder

_ Geben Sie 3 Access Modifier von C# an
public
private
protected

_ Was ist LINQ?
Language Intergrated Query
Daten dirket mit C# Abfragen bearbeiten */
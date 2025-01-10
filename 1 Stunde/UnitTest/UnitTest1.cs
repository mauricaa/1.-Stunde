using NUnit.Framework;
using SchoolManagement;
using System;
using Test_2;

namespace Test_2
{
    public class SchuleTests
    {
        // Test 1: Überprüft, ob die Gesamtzahl der Schüler korrekt ist
        [Test]
        public void GetTotalSchueler_ShouldReturnCorrectCount()
        {
            var schule = new Schule();
            var schueler1 = new Schueler("Merlin", "Female", new DateTime(2010, 5, 15), "3bWi");
            var schueler2 = new Schueler("Macknus", "Male", new DateTime(2006, 3, 22), "3bWi");
            schule.Schueler.Add(schueler1);
            schule.Schueler.Add(schueler2);

            int result = schule.GetTotalSchueler();

            Assert.AreEqual(2, result);  // Erwartet, dass es 2 Schüler gibt
        }

        // Test 2: Überprüft, ob der Frauenanteil in einer Klasse korrekt berechnet wird
        public void GetFemalePercentageInClass_ShouldReturnCorrectPercentage()
        {
            var schule = new Schule();
            var schueler1 = new Schueler("Merlin", "Female", new DateTime(2010, 5, 15), "3bWi");
            var schueler2 = new Schueler("Macknus", "Male", new DateTime(2006, 3, 22), "3bWi");
            schule.Schueler.Add(schueler1);
            schule.Schueler.Add(schueler2);

            double result = schule.GetFemalePercentageInClass("3bWi");

            Assert.AreEqual(50, result);  // Erwartet, dass der Frauenanteil 50% beträgt
        }

        // Test 3: Überprüft, ob die Gesamtzahl der Klassenräume korrekt ist
        public void GetTotalKlassenraeume_ShouldReturnCorrectCount()
        {
            var schule = new Schule();
            var klassenraum1 = new Klassenraum("Room 247", 50.0, 30, true);
            var klassenraum2 = new Klassenraum("Room 102", 40.0, 20, false);
            schule.Klassenraeume.Add(klassenraum1);
            schule.Klassenraeume.Add(klassenraum2);

            int result = schule.Klassenraeume.Count;

            Assert.AreEqual(2, result);  // Erwartet, dass es 2 Klassenräume gibt
        }

    }
}

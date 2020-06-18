using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation
{
    class School
    {        
        public void Ekle(ArrayList liste, string input)
        {
            liste.Add(input);
        }

        public void Sil(ArrayList liste, string input)
        {
            liste.Remove(input);
        }

        public bool Ara(ArrayList liste, string input)
        {
            return liste.Contains(input);
        }

        public void Guncelle(ArrayList liste, string eskiIsım, string yeniIsım)
        {
            int index = liste.IndexOf(eskiIsım);
            liste[index] = yeniIsım;
        }

        public void EkranaYazdir(ArrayList liste)
        {
            Console.WriteLine("Öğrenci Listesi:");
            foreach (object item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}

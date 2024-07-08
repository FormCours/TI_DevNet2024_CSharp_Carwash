using Exo_Carwash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Carwash.Models
{
    public delegate void CarwashDelegate(Voiture v);

    public class Carwash
    {
        private void Preparer(Voiture v)
        {
            Console.WriteLine($"« je prépare la voiture : {v.Plaque} »");
        }

        private void Laver(Voiture v)
        {
            Console.WriteLine($"« je lave la voiture : {v.Plaque} »");
        }

        private void Secher(Voiture v)
        {
            Console.WriteLine($"« je sèche la voiture : {v.Plaque} »");
        }

        private void Finaliser(Voiture v)
        {
            Console.WriteLine($"« je finalise la voiture : {v.Plaque} »");
        }

        public void Traiter(Voiture v)
        {
            CarwashDelegate del =  Preparer;
            del += Laver;
            del += Secher;
            del += Finaliser;

            del(v);
        }
    }

    public class Carwash2
    {
        private CarwashDelegate _MyDelegate { get; set; }

        public Carwash2()
        {
            _MyDelegate += Preparer;
            _MyDelegate += Laver;
            _MyDelegate += Secher;
            _MyDelegate += Finaliser;
        }

        private void Preparer(Voiture v)
        {
            Console.WriteLine($"« je prépare la voiture : {v.Plaque} »");
        }

        private void Laver(Voiture v)
        {
            Console.WriteLine($"« je lave la voiture : {v.Plaque} »");
        }

        private void Secher(Voiture v)
        {
            Console.WriteLine($"« je sèche la voiture : {v.Plaque} »");
        }

        private void Finaliser(Voiture v)
        {
            Console.WriteLine($"« je finalise la voiture : {v.Plaque} »");
        }

        public void Traiter(Voiture v)
        {
            _MyDelegate(v);
        }
    }

    public class Carwash3
    {
        public void Traiter(Voiture voitureCible)
        {
            CarwashDelegate? del = null;

            del += delegate (Voiture v)
            {
                Console.WriteLine($"« je prépare la voiture : {v.Plaque} »");
            };

            del += delegate (Voiture voiture)
            {
                Console.WriteLine($"« je lave la voiture : {voiture.Plaque} »");
            };

            del += (car) =>
            {
                Console.WriteLine($"« je sèche la voiture : {car.Plaque} »");
            };

            del += v =>
            {
                Console.WriteLine($"« je finalise la voiture : {v.Plaque} »");
            };

            del(voitureCible);
        }
    }
}

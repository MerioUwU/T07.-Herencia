using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente pac = new Paciente();
            pac.ID = 1;
            pac.Nombre = "Paola Aranza";
            pac.Nacimiento = new DateTime(1998,04,12);
            pac.Teléfono = "6641564578";
            pac.Correo = "Pao19@gmail.com";
            pac.Tipo = "Operación de Apéndice";
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\n\n",pac.ID,pac.Nombre,pac.Nacimiento,pac.Teléfono,pac.Correo,pac.Tipo);
            Enfermera enf = new Enfermera();
            enf.ID = 2;
            enf.Nombre = "Jessica Alejanda Hernández Agripino";
            enf.Nacimiento = new DateTime(1999, 09, 16);
            enf.Teléfono = "6642772281";
            enf.Correo = "J.jessikhernandez11@gmail.com";
            enf.Area = "Enfermera Líder";
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\n\n ",enf.ID,enf.Nombre,enf.Nacimiento,enf.Teléfono,enf.Correo,enf.Area);
            Medico med = new Medico();
            med.ID = 3;
            med.Nombre = "Mario Enrique Silva Jiménez";
            med.Nacimiento = new DateTime(1998, 10, 08);
            med.Teléfono = "6648204619";
            med.Correo = "merio.uwu@gmail.com";
            med.Especialidad = "Memes";
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\n\n ", med.ID, med.Nombre, med.Nacimiento, med.Teléfono, med.Correo, med.Especialidad);
            Familiar fam = new Familiar();
            fam.ID = 4;
            fam.Nombre= "Jaja Memes";
            fam.Nacimiento = new DateTime(1990, 10, 10);
            fam.Teléfono = "6646666666";
            fam.Correo = "sherwood@gmail.com";
            fam.Especialidad = "Circunstancias especiales";
            fam.ConsultaDomiciliaria = false;
            if (fam.ConsultaDomiciliaria == true)
            { Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\tAgendar Cita a Domicilio\n\n ", fam.ID, fam.Nombre,fam.Nacimiento,fam.Teléfono,fam.Correo,fam.Especialidad); }
            else
            { Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\tNo dispoible para Citas a Domicilio\n\n ", fam.ID, fam.Nombre, fam.Nacimiento, fam.Teléfono, fam.Correo, fam.Especialidad); }
            Cirujano cir = new Cirujano();
            cir.ID = 5;
            cir.Nombre = "Queso";
            cir.Nacimiento = new DateTime(1988, 02, 31);
            cir.Teléfono = "1029364859";
            cir.Correo = "Tenientecirujano@gmail.com";
            cir.Especialidad = "Extirpacion de tumores";
            cir.Estetico = false;
            Console.ReadKey();
        }
    }
}

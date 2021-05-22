using System;

namespace EntityFrameworkMapping
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonelManager personelManager = new PersonelManager(new EfPersonelDal());
            foreach (var personel in personelManager.GetAll())
            {
                Console.WriteLine(personel.Name+" "+personel.SurName);
            }
        }
    }
}

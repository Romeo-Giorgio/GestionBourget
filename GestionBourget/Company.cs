using System;
namespace GestionBourget
{
	public class Company
	{
		private string siret;
		private string name;
		private List<Contact> contacts;


		public Company()
		{
		}

        public Company(string siret, string name)
        {
            this.siret = siret;
            this.name = name;
			contacts = new List<Contact>();
        }
    }
}


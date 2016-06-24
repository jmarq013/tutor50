using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;
using Xamarin.Forms;
namespace Tutor50
{
	public class TutorDatabase
	{
		private SQLiteConnection database;
		static object locker = new object();

		public TutorDatabase()
		{
			database = DependencyService.Get<ISQLite>().GetConnection();
			database.CreateTable<Tutor>();
		}

		public int SaveTutor(Tutor tutor)
		{
			lock (locker)
			{
				if (tutor.ID != 0)
				{
					database.Update(tutor);
					return tutor.ID;
				} else {
					return database.Insert(tutor);
				}
			}
		}

		public IEnumerable<Tutor> GetTutors()
		{
			lock (locker)
			{
				return (from c in database.Table<Tutor>() select c).ToList();
			}
		}

		public Tutor GetTutor(int id)
		{
			lock (locker)
			{
				return database.Table<Tutor>().Where(c => c.ID == id).FirstOrDefault();
			}
		}

		public int DeleteContact(int id)
		{
			lock (locker)
			{
				return database.Delete<Tutor>(id);
			}
		}
	}
}


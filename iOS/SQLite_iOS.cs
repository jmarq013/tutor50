using System;
using WebKit;
using System.IO;
using Tutor50.iOS;

[assembly:Xamarin.Forms.Dependency(typeof(SQLite_iOS))]
namespace Tutor50.iOS
{
	public class SQLite_iOS : ISQLite
	{
		public SQLite_iOS()
		{
		}

		public SQLite.SQLiteConnection GetConnection()
		{
			//var sqliteFilename = "Tutor.db";
			//string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			//string libraryPath = Path.Combine(documentsPath, "..", "Library");
			//var path = Path.Combine(libraryPath, sqliteFilename);

			var path = "/users/julio/Data/Tutor.db";
			var conn = new SQLite.SQLiteConnection(path);
			return conn;
		}
	}
}


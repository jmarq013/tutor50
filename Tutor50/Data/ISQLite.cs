using System;
using SQLite;
namespace Tutor50
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}


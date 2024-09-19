using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using PersonDbLib;
using System.Data.Common;
using NUnit.Framework.Internal;
namespace PersonDbTesting;
internal class IMPersonDbContext : IDisposable
{
    private readonly DbConnection _connection;
    private readonly DbContextOptions<PersonDbContext> _contextOptions;
    public IMPersonDbContext()
    {
        // Create and open a connection. This creates the SQLite in-memory database,
        // which will persist until the connection is closed at the end of the test
        // (see Dispose below).

        _connection = new SqliteConnection("Filename=:memory:");
        _connection.Open();

        // These options will be used by the context instances in this test suite,
        // including the connection opened above.
        _contextOptions = new DbContextOptionsBuilder<PersonDbContext>()
        .UseSqlite(_connection)
        .Options;
        var context = CreateContext();
        context.Database.EnsureCreated();
    }
    public PersonDbContext CreateContext() => new(_contextOptions);
        public void Dispose()
        {
            _connection.Dispose();
        }
}

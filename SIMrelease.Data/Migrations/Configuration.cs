namespace Simrelease.Data.Migrations
{
    using Npgsql;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Model;
    using System.Linq;

    internal sealed class Configuration : DbConfiguration
    {
        public Configuration()
        {
            
            SetMigrationSqlGenerator("Npgsql", () => new SqlGenerator());
        }

        //protected override void Seed(Simrelease.Data.SimDbcontext context)
        //{
        //    //  This method will be called after migrating to the latest version.

        //    //  You can use the DbSet<T>.AddOrUpdate() helper extension method
        //    //  to avoid creating duplicate seed data.
        //}
    }

    public class SqlGenerator : NpgsqlMigrationSqlGenerator
    {
        private readonly string[] systemColumnNames = { "oid", "tableoid", "xmin", "cmin", "xmax", "cmax", "ctid" };

        protected override void Convert(CreateTableOperation createTableOperation)
        {
            var systemColumns = createTableOperation.Columns.Where(x => systemColumnNames.Contains(x.Name)).ToArray();
            foreach (var systemColumn in systemColumns)
                createTableOperation.Columns.Remove(systemColumn);
            base.Convert(createTableOperation);
        }
    }
}

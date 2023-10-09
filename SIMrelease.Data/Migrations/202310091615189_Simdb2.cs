namespace Simrelease.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Simdb2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("Public.Dmkh", "Ten_kh2", c => c.String());
            AddColumn("Public.Dmkh", "Addres", c => c.String());
            AddColumn("Public.Dmkh", "Addres2", c => c.String());
            AddColumn("Public.Dmkh", "Phone", c => c.String());
            AddColumn("Public.Dmkh", "Email", c => c.String());
            AddColumn("Public.Dmkh", "Fax", c => c.String());
            AddColumn("Public.Dmkh", "nh_kh1", c => c.String());
            AddColumn("Public.Dmkh", "nh_kh2", c => c.String());
            AddColumn("Public.Dmkh", "nh_kh3", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("Public.Dmkh", "nh_kh3");
            DropColumn("Public.Dmkh", "nh_kh2");
            DropColumn("Public.Dmkh", "nh_kh1");
            DropColumn("Public.Dmkh", "Fax");
            DropColumn("Public.Dmkh", "Email");
            DropColumn("Public.Dmkh", "Phone");
            DropColumn("Public.Dmkh", "Addres2");
            DropColumn("Public.Dmkh", "Addres");
            DropColumn("Public.Dmkh", "Ten_kh2");
        }
    }
}

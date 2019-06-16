using DDDCarteira.Domain.Account;
using DDDCarteira;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira.Infra.Migrations
{
   public class _20190614{

        public override void Up()
        {
            CreateTable(
                "dbo.Brokers",
                c => new
                {
                    Id = c.Guid(nullable: false),
                    Name = c.String(nullable: false, maxLength: 11, fixedLength: true),
                    CNPJ = c.String(nullable: false, maxLength: 11, fixedLength: true),
                    Email = c.String(nullable: false, maxLength: 11, fixedLength: true),
                    Phone = c.String(nullable: false, maxLength: 11, fixedLength: true),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                  "dbo.Customer",
                  c => new
                  {
                      Id = c.Guid(nullable: false),
                      Name = c.String(nullable: false, maxLength: 11, fixedLength: true),
                      Document = c.String(nullable: false, maxLength: 11, fixedLength: true),
                      Email = c.String(nullable: false, maxLength: 11, fixedLength: true),
                      Phone = c.String(nullable: false, maxLength: 11, fixedLength: true),
                  })
                  .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Wallet",
                c => new
                {

                    Id = c.Guid(nullable: false),
                    BuyDate = c.DateTime(nullable: false),
                    Broker_Id = c.Guid(nullable: false),
                    Customer_Id = c.Guid(),
                })

            .PrimaryKey(t => t.Id)
            .ForeignKey("dbo.Broker", t => t.Carrier_Id, cascadeDelete: true)
            .ForeignKey("dbo.Customers", t => t.Customer_Id)
            .ForeignKey("dbo.BuyDate", t => t.Code, cascadeDelete: true)
            .Index(t => t.BuyDate)
            .Index(t => t.Broker_Id)
            .Index(t => t.Customer_Id);
        }

        private object CreateTable(string v, Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        public override void Down()
        {
            DropForeignKey("dbo.Wallet", "BuyDate", "dbo.Shopping");
            DropForeignKey("dbo.Shopping", "Broker_Id", "dbo.Brokers");
            DropForeignKey("dbo.Wallet", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Shopping", new[] { "Brokers_Id" });
            DropIndex("dbo.Wallet", new[] { "Customer_Id" });
            DropIndex("dbo.Wallet", new[] { "Shopping" });
            DropTable("dbo.Shopping");
            DropTable("dbo.Wallet");
            DropTable("dbo.Customers");
            DropTable("dbo.Broker");
            }

        private void DropTable(string v)
        {
            throw new NotImplementedException();
        }

        private void DropIndex(string v1, string[] v2)
        {
            throw new NotImplementedException();
        }

        private void DropForeignKey(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }
    }

    }
}

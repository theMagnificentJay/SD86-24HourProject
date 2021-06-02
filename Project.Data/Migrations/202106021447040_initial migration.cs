namespace Project.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comment", "Id", "dbo.Post");
            DropIndex("dbo.Comment", new[] { "Id" });
            DropPrimaryKey("dbo.Comment");
            CreateTable(
                "dbo.Reply",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CommentId = c.Int(nullable: false),
                        Text = c.String(nullable: false),
                        AuthorId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReplyComment",
                c => new
                    {
                        Reply_Id = c.Int(nullable: false),
                        Comment_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Reply_Id, t.Comment_Id })
                .ForeignKey("dbo.Reply", t => t.Reply_Id, cascadeDelete: true)
                .ForeignKey("dbo.Comment", t => t.Comment_Id, cascadeDelete: true)
                .Index(t => t.Reply_Id)
                .Index(t => t.Comment_Id);
            
            AddColumn("dbo.Comment", "PostId", c => c.Int(nullable: false));
            AlterColumn("dbo.Comment", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Comment", "Id");
            CreateIndex("dbo.Comment", "PostId");
            AddForeignKey("dbo.Comment", "PostId", "dbo.Post", "PostId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comment", "PostId", "dbo.Post");
            DropForeignKey("dbo.ReplyComment", "Comment_Id", "dbo.Comment");
            DropForeignKey("dbo.ReplyComment", "Reply_Id", "dbo.Reply");
            DropIndex("dbo.ReplyComment", new[] { "Comment_Id" });
            DropIndex("dbo.ReplyComment", new[] { "Reply_Id" });
            DropIndex("dbo.Comment", new[] { "PostId" });
            DropPrimaryKey("dbo.Comment");
            AlterColumn("dbo.Comment", "Id", c => c.Int(nullable: false));
            DropColumn("dbo.Comment", "PostId");
            DropTable("dbo.ReplyComment");
            DropTable("dbo.Reply");
            AddPrimaryKey("dbo.Comment", "Id");
            CreateIndex("dbo.Comment", "Id");
            AddForeignKey("dbo.Comment", "Id", "dbo.Post", "PostId");
        }
    }
}

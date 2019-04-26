namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1ac8c053-63ae-4b87-bbbd-c103fafcf374', N'guest@vidly.com', 0, N'AP9Ix+NBWgcTIqGsB21sMdoGUPkshuYJ18fwlITsaT8/4W8UttGxy7lDvIRcOquO6A==', N'866423f0-3618-4ed3-9adb-78c6ec4af44a', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'33cff9f1-d05d-4361-b00e-4507ac5607f1', N'admin@vidly.com', 0, N'AM+IhwnT5IBybzl0kgvq3xpI2ORJrEy8GzlZcih0cFJltyX6RuG4CdSSoAxabzjqBQ==', N'02e86d25-087e-4649-9826-63b43142b240', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ae9c073a-b5b5-4a35-a357-25f2205cfbc4', N'CanManageMovies')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'33cff9f1-d05d-4361-b00e-4507ac5607f1', N'ae9c073a-b5b5-4a35-a357-25f2205cfbc4')

            ");
        }
        
        public override void Down()
        {
        }
    }
}

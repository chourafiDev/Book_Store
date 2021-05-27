using Microsoft.EntityFrameworkCore.Migrations;

namespace Book_Store.Data.Migrations
{
    public partial class AddAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[Users] ([Id], [FirstName], [LastName], [Country], [FullAdress], [ZipCode], [DateCreate], [UserPhoto], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'137fc66e-6e0a-431c-a1ca-d1d4ae8be1d4', N'admin', N'admin', N'AM', N'Admin Adress', N'42050', N'2021-05-21 16:52:08', NULL, N'admin', N'ADMIN', N'admin@gmail.com', N'ADMIN@GMAIL.COM', N'AQAAAAEAACcQAAAAEKkAp5gdW7D3RE2QfQnWSMYUB5Nm/IJbYYhmXG219qDPlDWGh5D5nwuJnzU/b0gOsg==', N'BSRRNRXMZPKHL54CJWFVG7KFFJI762QN', N'5975150e-0302-408b-b9ca-0b3d49f96577', N'0603940215', 0, NULL, 1, 0)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[Users] where [Id]= '137fc66e-6e0a-431c-a1ca-d1d4ae8be1d4'");
        }
    }
}

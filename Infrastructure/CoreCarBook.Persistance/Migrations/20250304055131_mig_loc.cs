﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreCarBook.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig_loc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PickUpLocationID",
                table: "RentACars");
        } 

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PickUpLocationID",
                table: "RentACars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

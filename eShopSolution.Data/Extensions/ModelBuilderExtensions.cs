using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSolution" },
               new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eShopSolution" },
               new AppConfig() { Key = "HomeDescription", Value = "This is description of eShopSolution" }
               );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en", Name = "English", IsDefault = false });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                 new Category()
                 {
                     Id = 2,
                     IsShowOnHome = true,
                     ParentId = null,
                     SortOrder = 2,
                     Status = Status.Active
                 },
                 new Category()
                 {
                     Id = 3,
                     IsShowOnHome = true,
                     ParentId = null,
                     SortOrder = 1,
                     Status = Status.Active,
                 },
                 new Category()
                 {
                     Id = 4,
                     IsShowOnHome = true,
                     ParentId = null,
                     SortOrder = 2,
                     Status = Status.Active
                 }
                 );

            modelBuilder.Entity<CategoryTranslation>().HasData(
                  new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "máy ảnh", LanguageId = "vi", SeoAlias = "may-anh", SeoDescription = "máy ảnh", SeoTitle = "máy ảnh" },
                  new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "camera", LanguageId = "en", SeoAlias = "camera", SeoDescription = "camera", SeoTitle = "camera" },
                  new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "thẻ nhớ", LanguageId = "vi", SeoAlias = "the-nho", SeoDescription = "thẻ nhớ", SeoTitle = "thẻ nhớ" },
                  new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "memory-card", LanguageId = "en", SeoAlias = "memory-card", SeoDescription = "memory-card", SeoTitle = "memory-card" },
                  new CategoryTranslation() { Id = 5, CategoryId = 3, Name = "giầy nữ", LanguageId = "vi", SeoAlias = "giay-nu", SeoDescription = "giầy nữ", SeoTitle = "giầy nữ" },
                  new CategoryTranslation() { Id = 6, CategoryId = 3, Name = "boots", LanguageId = "en", SeoAlias = "boots", SeoDescription = "boots", SeoTitle = "boots" },
                  new CategoryTranslation() { Id = 7, CategoryId = 4, Name = "máy đọc sách", LanguageId = "vi", SeoAlias = "may-doc-sach", SeoDescription = "máy đọc sách", SeoTitle = "máy đọc sách" },
                  new CategoryTranslation() { Id = 8, CategoryId = 4, Name = "e-book reader", LanguageId = "en", SeoAlias = "e-book-reader", SeoDescription = "e-book reader", SeoTitle = "e-book reader" }
                  );

            modelBuilder.Entity<Product>().HasData(
               new Product()
               {
                   Id = 1,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 100000,
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
               },
               new Product()
               {
                   Id = 2,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 100000,
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
               },
               new Product()
               {
                   Id = 3,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 100000,
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
               },
               new Product()
               {
                   Id = 4,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 100000,
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
               },
               new Product()
               {
                   Id = 5,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 100000,
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
               },
               new Product()
               {
                   Id = 6,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 100000,
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
               },
               new Product()
               {
                   Id = 7,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 100000,
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
               },
               new Product()
               {
                   Id = 8,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 100000,
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
               },
               new Product()
               {
                   Id = 9,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 100000,
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
               },
               new Product()
               {
                   Id = 10,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 100000,
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
               },
               new Product()
               {
                   Id = 11,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 100000,
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
               },
               new Product()
               {
                   Id = 12,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 100000,
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
               },
               new Product()
               {
                   Id = 13,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 100000,
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
               },
               new Product()
               {
                   Id = 14,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 100000,
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
               },
               new Product()
               {
                   Id = 15,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 100000,
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
               },
               new Product()
               {
                   Id = 16,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 100000,
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
               },
               new Product()
               {
                   Id = 17,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 100000,
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
               },
               new Product()
               {
                   Id = 18,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 100000,
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
               },
               new Product()
               {
                   Id = 19,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 100000,
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
               }
               );
            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     Id = 1,
                     ProductId = 1,
                     Name = "máy ảnh 1",
                     LanguageId = "vi",
                     SeoAlias = "may anh",
                     SeoDescription = "máy ảnh 1",
                     SeoTitle = "máy ảnh 1",
                     Details = "máy ảnh 1",
                     Description = "máy ảnh 1"
                 },
                 new ProductTranslation()
                 {
                     Id = 2,
                     ProductId = 1,
                     Name = "camera 1",
                     LanguageId = "en",
                     SeoAlias = "camera 1",
                     SeoDescription = "camera 1",
                     SeoTitle = "camera 1",
                     Details = "camera 1",
                     Description = "camera 1"
                 },
                 new ProductTranslation()
                 {
                     Id = 3,
                     ProductId = 2,
                     Name = "máy ảnh 2",
                     LanguageId = "vi",
                     SeoAlias = "may anh",
                     SeoDescription = "máy ảnh 2",
                     SeoTitle = "máy ảnh 2",
                     Details = "máy ảnh 2",
                     Description = "máy ảnh 2"
                 },
                 new ProductTranslation()
                 {
                     Id = 4,
                     ProductId = 2,
                     Name = "camera 2",
                     LanguageId = "en",
                     SeoAlias = "camera 2",
                     SeoDescription = "camera 2",
                     SeoTitle = "camera 2",
                     Details = "camera 2",
                     Description = "camera 2"
                 },
                 new ProductTranslation()
                 {
                     Id = 5,
                     ProductId = 3,
                     Name = "máy ảnh 3",
                     LanguageId = "vi",
                     SeoAlias = "may anh",
                     SeoDescription = "máy ảnh 3",
                     SeoTitle = "máy ảnh 3",
                     Details = "máy ảnh 3",
                     Description = "máy ảnh 3"
                 },
                 new ProductTranslation()
                 {
                     Id = 6,
                     ProductId = 3,
                     Name = "camera 3",
                     LanguageId = "en",
                     SeoAlias = "camera 3",
                     SeoDescription = "camera 3",
                     SeoTitle = "camera 3",
                     Details = "camera 3",
                     Description = "camera 3"
                 },
                 new ProductTranslation()
                 {
                     Id = 7,
                     ProductId = 4,
                     Name = "máy ảnh 4",
                     LanguageId = "vi",
                     SeoAlias = "may anh",
                     SeoDescription = "máy ảnh 4",
                     SeoTitle = "máy ảnh 4",
                     Details = "máy ảnh 4",
                     Description = "máy ảnh 4"
                 },
                 new ProductTranslation()
                 {
                     Id = 8,
                     ProductId = 4,
                     Name = "camera 4",
                     LanguageId = "en",
                     SeoAlias = "camera 4",
                     SeoDescription = "camera 4",
                     SeoTitle = "camera 4",
                     Details = "camera 4",
                     Description = "camera 4"
                 },
                 new ProductTranslation()
                 {
                     Id = 9,
                     ProductId = 5,
                     Name = "máy ảnh 5",
                     LanguageId = "vi",
                     SeoAlias = "may anh",
                     SeoDescription = "máy ảnh 5",
                     SeoTitle = "máy ảnh 5",
                     Details = "máy ảnh 5",
                     Description = "máy ảnh 5"
                 },
                 new ProductTranslation()
                 {
                     Id = 10,
                     ProductId = 5,
                     Name = "camera 5",
                     LanguageId = "en",
                     SeoAlias = "camera 5",
                     SeoDescription = "camera 5",
                     SeoTitle = "camera 5",
                     Details = "camera 5",
                     Description = "camera 5"
                 },
                 new ProductTranslation()
                 {
                     Id = 11,
                     ProductId = 6,
                     Name = "thẻ nhớ 1",
                     LanguageId = "vi",
                     SeoAlias = "the nho 1",
                     SeoDescription = "thẻ nhớ 1",
                     SeoTitle = "thẻ nhớ 1",
                     Details = "thẻ nhớ 1",
                     Description = "thẻ nhớ 1"
                 },
                 new ProductTranslation()
                 {
                     Id = 12,
                     ProductId = 6,
                     Name = "memory card 1",
                     LanguageId = "en",
                     SeoAlias = "memory card 1",
                     SeoDescription = "memory card 1",
                     SeoTitle = "memory card 1",
                     Details = "memory card 1",
                     Description = "memory card 1"
                 },
                 new ProductTranslation()
                 {
                     Id = 13,
                     ProductId = 7,
                     Name = "thẻ nhớ 2",
                     LanguageId = "vi",
                     SeoAlias = "the nho 2",
                     SeoDescription = "thẻ nhớ 2",
                     SeoTitle = "thẻ nhớ 2",
                     Details = "thẻ nhớ 2",
                     Description = "thẻ nhớ 2"
                 },
                 new ProductTranslation()
                 {
                     Id = 14,
                     ProductId = 7,
                     Name = "memory card 2",
                     LanguageId = "en",
                     SeoAlias = "memory card 2",
                     SeoDescription = "memory card 2",
                     SeoTitle = "memory card 2",
                     Details = "memory card 2",
                     Description = "memory card 2"
                 },
                 new ProductTranslation()
                 {
                     Id = 15,
                     ProductId = 8,
                     Name = "thẻ nhớ 3",
                     LanguageId = "vi",
                     SeoAlias = "the nho 3",
                     SeoDescription = "thẻ nhớ 3",
                     SeoTitle = "thẻ nhớ 3",
                     Details = "thẻ nhớ 3",
                     Description = "thẻ nhớ 3"
                 },
                 new ProductTranslation()
                 {
                     Id = 16,
                     ProductId = 8,
                     Name = "memory card 3",
                     LanguageId = "en",
                     SeoAlias = "memory card 3",
                     SeoDescription = "memory card 3",
                     SeoTitle = "memory card 3",
                     Details = "memory card 3",
                     Description = "memory card 3"
                 },
                 new ProductTranslation()
                 {
                     Id = 17,
                     ProductId = 9,
                     Name = "bộ phụ kiện máy ảnh 1",
                     LanguageId = "vi",
                     SeoAlias = "bo phu kien may anh 1",
                     SeoDescription = "bộ phụ kiện máy ảnh 1",
                     SeoTitle = "bộ phụ kiện máy ảnh 1",
                     Details = "bộ phụ kiện máy ảnh 1",
                     Description = "bộ phụ kiện máy ảnh 1"
                 },
                 new ProductTranslation()
                 {
                     Id = 18,
                     ProductId = 9,
                     Name = "camera combo 1",
                     LanguageId = "en",
                     SeoAlias = "camera combo 1",
                     SeoDescription = "camera combo 1",
                     SeoTitle = "camera combo 1",
                     Details = "camera combo 1",
                     Description = "camera combo 1"
                 },
                 new ProductTranslation()
                 {
                     Id = 19,
                     ProductId = 10,
                     Name = "thẻ nhớ 4",
                     LanguageId = "vi",
                     SeoAlias = "the nho 4",
                     SeoDescription = "thẻ nhớ 4",
                     SeoTitle = "thẻ nhớ 4",
                     Details = "thẻ nhớ 4",
                     Description = "thẻ nhớ 4"
                 },
                 new ProductTranslation()
                 {
                     Id = 20,
                     ProductId = 10,
                     Name = "memory card 4",
                     LanguageId = "en",
                     SeoAlias = "memory card 4",
                     SeoDescription = "memory card 4",
                     SeoTitle = "memory card 4",
                     Details = "memory card 4",
                     Description = "memory card 4"
                 },
                 new ProductTranslation()
                 {
                     Id = 21,
                     ProductId = 11,
                     Name = "máy ảnh 6",
                     LanguageId = "vi",
                     SeoAlias = "may anh",
                     SeoDescription = "máy ảnh 6",
                     SeoTitle = "máy ảnh 6",
                     Details = "máy ảnh 6",
                     Description = "máy ảnh 6"
                 },
                 new ProductTranslation()
                 {
                     Id = 22,
                     ProductId = 11,
                     Name = "camera 6",
                     LanguageId = "en",
                     SeoAlias = "camera 6",
                     SeoDescription = "camera 6",
                     SeoTitle = "camera 6",
                     Details = "camera 6",
                     Description = "camera 6"
                 },
                 new ProductTranslation()
                 {
                     Id = 23,
                     ProductId = 12,
                     Name = "thẻ nhớ 5",
                     LanguageId = "vi",
                     SeoAlias = "the nho 5",
                     SeoDescription = "thẻ nhớ 5",
                     SeoTitle = "thẻ nhớ 5",
                     Details = "thẻ nhớ 5",
                     Description = "thẻ nhớ 5"
                 },
                 new ProductTranslation()
                 {
                     Id = 24,
                     ProductId = 12,
                     Name = "memory card 5",
                     LanguageId = "en",
                     SeoAlias = "memory card 5",
                     SeoDescription = "memory card 5",
                     SeoTitle = "memory card 5",
                     Details = "memory card 5",
                     Description = "memory card 5"
                 },
                 new ProductTranslation()
                 {
                     Id = 25,
                     ProductId = 13,
                     Name = "máy ảnh 7",
                     LanguageId = "vi",
                     SeoAlias = "may anh",
                     SeoDescription = "máy ảnh 7",
                     SeoTitle = "máy ảnh 7",
                     Details = "máy ảnh 7",
                     Description = "máy ảnh 7"
                 },
                 new ProductTranslation()
                 {
                     Id = 26,
                     ProductId = 13,
                     Name = "camera 7",
                     LanguageId = "en",
                     SeoAlias = "camera 7",
                     SeoDescription = "camera 7",
                     SeoTitle = "camera 7",
                     Details = "camera 7",
                     Description = "camera 7"
                 },
                 new ProductTranslation()
                 {
                     Id = 27,
                     ProductId = 14,
                     Name = "giầy nữ 1",
                     LanguageId = "vi",
                     SeoAlias = "giay nu 1",
                     SeoDescription = "giầy nữ 1",
                     SeoTitle = "giầy nữ 1",
                     Details = "giầy nữ 1",
                     Description = "giầy nữ 1"
                 },
                 new ProductTranslation()
                 {
                     Id = 28,
                     ProductId = 14,
                     Name = "boots 1",
                     LanguageId = "en",
                     SeoAlias = "boots 1",
                     SeoDescription = "boots 1",
                     SeoTitle = "boots 1",
                     Details = "boots 1",
                     Description = "boots 1"
                 },
                 new ProductTranslation()
                 {
                     Id = 29,
                     ProductId = 15,
                     Name = "giầy nữ 2",
                     LanguageId = "vi",
                     SeoAlias = "giay nu 2",
                     SeoDescription = "giầy nữ 2",
                     SeoTitle = "giầy nữ 2",
                     Details = "giầy nữ 2",
                     Description = "giầy nữ 2"
                 },
                 new ProductTranslation()
                 {
                     Id = 30,
                     ProductId = 15,
                     Name = "boots 2",
                     LanguageId = "en",
                     SeoAlias = "boots 2",
                     SeoDescription = "boots 2",
                     SeoTitle = "boots 2",
                     Details = "boots 2",
                     Description = "boots 2"
                 },
                 new ProductTranslation()
                 {
                     Id = 31,
                     ProductId = 16,
                     Name = "giầy nữ 3",
                     LanguageId = "vi",
                     SeoAlias = "giay nu 3",
                     SeoDescription = "giầy nữ 3",
                     SeoTitle = "giầy nữ 3",
                     Details = "giầy nữ 3",
                     Description = "giầy nữ 3"
                 },
                 new ProductTranslation()
                 {
                     Id = 32,
                     ProductId = 16,
                     Name = "boots 3",
                     LanguageId = "en",
                     SeoAlias = "boots 3",
                     SeoDescription = "boots 3",
                     SeoTitle = "boots 3",
                     Details = "boots 3",
                     Description = "boots 3"
                 },
                 new ProductTranslation()
                 {
                     Id = 33,
                     ProductId = 17,
                     Name = "giầy nữ 4",
                     LanguageId = "vi",
                     SeoAlias = "giay nu 4",
                     SeoDescription = "giầy nữ 4",
                     SeoTitle = "giầy nữ 4",
                     Details = "giầy nữ 4",
                     Description = "giầy nữ 4"
                 },
                 new ProductTranslation()
                 {
                     Id = 34,
                     ProductId = 17,
                     Name = "boots 4",
                     LanguageId = "en",
                     SeoAlias = "boots 4",
                     SeoDescription = "boots 4",
                     SeoTitle = "boots 4",
                     Details = "boots 4",
                     Description = "boots 4"
                 },
                 new ProductTranslation()
                 {
                     Id = 35,
                     ProductId = 18,
                     Name = "máy đọc sách 1",
                     LanguageId = "vi",
                     SeoAlias = "may doc sach 1",
                     SeoDescription = "máy đọc sách 1",
                     SeoTitle = "máy đọc sách 1",
                     Details = "máy đọc sách 1",
                     Description = "máy đọc sách 1"
                 },
                 new ProductTranslation()
                 {
                     Id = 36,
                     ProductId = 18,
                     Name = "kindle 1",
                     LanguageId = "en",
                     SeoAlias = "kindle 1",
                     SeoDescription = "kindle 1",
                     SeoTitle = "kindle 1",
                     Details = "kindle 1",
                     Description = "kindle 1"
                 },
                 new ProductTranslation()
                 {
                     Id = 37,
                     ProductId = 19,
                     Name = "máy ảnh 8",
                     LanguageId = "vi",
                     SeoAlias = "may anh 8",
                     SeoDescription = "máy ảnh 8",
                     SeoTitle = "máy ảnh 8",
                     Details = "máy ảnh 8",
                     Description = "máy ảnh 8"
                 },
                 new ProductTranslation()
                 {
                     Id = 38,
                     ProductId = 19,
                     Name = "camera 8",
                     LanguageId = "en",
                     SeoAlias = "camera 8",
                     SeoDescription = "camera 8",
                     SeoTitle = "camera 8",
                     Details = "camera 8",
                     Description = "camera 8"
                 }
                 );
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 },
                new ProductInCategory() { ProductId = 2, CategoryId = 1 },
                new ProductInCategory() { ProductId = 3, CategoryId = 1 },
                new ProductInCategory() { ProductId = 4, CategoryId = 1 },
                new ProductInCategory() { ProductId = 5, CategoryId = 1 },
                new ProductInCategory() { ProductId = 6, CategoryId = 2 },
                new ProductInCategory() { ProductId = 7, CategoryId = 2 },
                new ProductInCategory() { ProductId = 8, CategoryId = 2 },
                new ProductInCategory() { ProductId = 9, CategoryId = 1 },
                new ProductInCategory() { ProductId = 10, CategoryId = 2 },
                new ProductInCategory() { ProductId = 11, CategoryId = 1 },
                new ProductInCategory() { ProductId = 12, CategoryId = 2 },
                new ProductInCategory() { ProductId = 13, CategoryId = 1 },
                new ProductInCategory() { ProductId = 14, CategoryId = 3 },
                new ProductInCategory() { ProductId = 15, CategoryId = 3 },
                new ProductInCategory() { ProductId = 16, CategoryId = 3 },
                new ProductInCategory() { ProductId = 17, CategoryId = 3 },
                new ProductInCategory() { ProductId = 18, CategoryId = 4 },
                new ProductInCategory() { ProductId = 19, CategoryId = 1 }
                );
            modelBuilder.Entity<ProductImage>().HasData(
                new ProductImage() { Id = 1, ProductId = 1, ImagePath = "/themes/images/products/1.jpg", Caption = "", DateCreated = DateTime.Now, IsDefault = true },
                new ProductImage() { Id = 2, ProductId = 2, ImagePath = "/themes/images/products/2.jpg", Caption = "", DateCreated = DateTime.Now, IsDefault = true },
                new ProductImage() { Id = 3, ProductId = 3, ImagePath = "/themes/images/products/3.jpg", Caption = "", DateCreated = DateTime.Now, IsDefault = true },
                new ProductImage() { Id = 4, ProductId = 4, ImagePath = "/themes/images/products/4.jpg", Caption = "", DateCreated = DateTime.Now, IsDefault = true },
                new ProductImage() { Id = 5, ProductId = 5, ImagePath = "/themes/images/products/5.jpg", Caption = "", DateCreated = DateTime.Now, IsDefault = true },
                new ProductImage() { Id = 6, ProductId = 6, ImagePath = "/themes/images/products/6.jpg", Caption = "", DateCreated = DateTime.Now, IsDefault = true },
                new ProductImage() { Id = 7, ProductId = 7, ImagePath = "/themes/images/products/7.jpg", Caption = "", DateCreated = DateTime.Now, IsDefault = true },
                new ProductImage() { Id = 8, ProductId = 8, ImagePath = "/themes/images/products/8.jpg", Caption = "", DateCreated = DateTime.Now, IsDefault = true },
                new ProductImage() { Id = 9, ProductId = 9, ImagePath = "/themes/images/products/9.jpg", Caption = "", DateCreated = DateTime.Now, IsDefault = true },
                new ProductImage() { Id = 10, ProductId = 10, ImagePath = "/themes/images/products/10.jpg", Caption = "", DateCreated = DateTime.Now, IsDefault = true },
                new ProductImage() { Id = 11, ProductId = 11, ImagePath = "/themes/images/products/11.jpg", Caption = "", DateCreated = DateTime.Now, IsDefault = true },
                new ProductImage() { Id = 12, ProductId = 12, ImagePath = "/themes/images/products/12.jpg", Caption = "", DateCreated = DateTime.Now, IsDefault = true },
                new ProductImage() { Id = 13, ProductId = 13, ImagePath = "/themes/images/products/13.jpg", Caption = "", DateCreated = DateTime.Now, IsDefault = true },
                new ProductImage() { Id = 14, ProductId = 14, ImagePath = "/themes/images/products/b1.jpg", Caption = "", DateCreated = DateTime.Now, IsDefault = true },
                new ProductImage() { Id = 15, ProductId = 15, ImagePath = "/themes/images/products/b2.jpg", Caption = "", DateCreated = DateTime.Now, IsDefault = true },
                new ProductImage() { Id = 16, ProductId = 16, ImagePath = "/themes/images/products/b3.jpg", Caption = "", DateCreated = DateTime.Now, IsDefault = true },
                new ProductImage() { Id = 17, ProductId = 17, ImagePath = "/themes/images/products/b4.jpg", Caption = "", DateCreated = DateTime.Now, IsDefault = true },
                new ProductImage() { Id = 18, ProductId = 18, ImagePath = "/themes/images/products/kindle.png", Caption = "", DateCreated = DateTime.Now, IsDefault = true },
                new ProductImage() { Id = 19, ProductId = 19, ImagePath = "/themes/images/products/panasonic.jpg", Caption = "", DateCreated = DateTime.Now, IsDefault = true }
                );
            // any guid
            var roleId = new Guid("342D0C2B-ADF6-4B25-A631-7242CD9472C4");
            var adminId = new Guid("B08221C3-AF8C-4297-B0A7-73D70F660359");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "nmt08051985@gmail.com",
                NormalizedEmail = "nmt08051985@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Nguyen",
                LastName = "Tien",
                DoB = new DateTime(2020, 01, 31)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

            modelBuilder.Entity<Slide>().HasData(
               new Slide()
               {
                   Id = 1,
                   Name = "Second Thumbnail label",
                   Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.",
                   SortOrder = 1,
                   Url = "#",
                   Image = "/themes/images/carousel/1.png",
                   Status = Status.Active
               },
               new Slide()
               {
                   Id = 2,
                   Name = "Second Thumbnail label",
                   Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.",
                   SortOrder = 2,
                   Url = "#",
                   Image = "/themes/images/carousel/2.png",
                   Status = Status.Active
               },
               new Slide()
               {
                   Id = 3,
                   Name = "Second Thumbnail label",
                   Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.",
                   SortOrder = 3,
                   Url = "#",
                   Image = "/themes/images/carousel/3.png",
                   Status = Status.Active
               },
               new Slide()
               {
                   Id = 4,
                   Name = "Second Thumbnail label",
                   Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.",
                   SortOrder = 4,
                   Url = "#",
                   Image = "/themes/images/carousel/4.png",
                   Status = Status.Active
               },
               new Slide()
               {
                   Id = 5,
                   Name = "Second Thumbnail label",
                   Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.",
                   SortOrder = 5,
                   Url = "#",
                   Image = "/themes/images/carousel/5.png",
                   Status = Status.Active
               },
               new Slide()
               {
                   Id = 6,
                   Name = "Second Thumbnail label",
                   Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.",
                   SortOrder = 6,
                   Url = "#",
                   Image = "/themes/images/carousel/6.png",
                   Status = Status.Active
               }
               );
        }
    }
}
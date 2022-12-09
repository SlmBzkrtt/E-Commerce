using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace WebApplication2.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange
                (
                new Product
                {
                    Name = "Iphone 12",
                    Description = "PRO MAX 128 GB",
                    Category = "Iphone",
                    Price = 17000,
                    MainCategory = "Telefon",
                    ImgPath = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/apple/thumb/110664_large.jpg"

                },
                new Product
                {
                    Name = "Oppo A72",
                    Description = "128GB",
                    Category = "Oppo",
                    Price = 3200,
                    MainCategory = "Telefon",
                    ImgPath = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/oppo/thumb/TeoriV2-108320_large.jpg"
                },
                new Product
                {
                    Name = "Samsung Galaxy Note 10",
                    Description = "Lite 128 GB",
                    Category = "Samsung",
                    Price = 4500,
                    MainCategory = "Telefon",
                    ImgPath = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/samsung/thumb/galaxy-note-10-lite-gorseli-106277_large.jpg"
                },
                new Product
                {
                    Name = "Xioami Mi Note 10",
                    Description = "64 GB",
                    Category = "Xioami",
                    Price = 3600,
                    MainCategory = "Telefon",
                    ImgPath = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/xiaomi/thumb/redmi-note-9-gorseli-107890_large.jpg"
                },
                new Product
                {
                    Name = "Hp Pavilion",
                    Description = "15-DK1005NT",
                    Category = "Hp",
                    Price = 12500,
                    MainCategory = "Laptop",
                    ImgPath = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/hp/thumb/114965_large.jpg"
                },
                new Product
                {
                    Name = "Lenovo Y50-70",
                    Description = "Y50-70 Gaming Laptop",
                    Category = "Lenovo",
                    Price = 5000,
                    MainCategory = "Laptop",
                    ImgPath = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/lenovo/thumb/v2-75658-1_large.jpg"
                },
                new Product
                {
                    Name = "Hp Omen",
                    Description = "15-DH1014NT",
                    Category = "Hp",
                    Price = 13000,
                    MainCategory = "Laptop",
                    ImgPath = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/hp/thumb/114966_large.jpg"
                },
                new Product
                {
                    Name = "Huawei Matebook",
                    Description = "X PRO 2020",
                    Category = "Huawei",
                    Price = 15000,
                    MainCategory = "Laptop",
                    ImgPath = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/huawei/thumb/TeoriV2-108642_large.jpg"
                },
                new Product
                {
                    Name = "Sony 55XH9096 55''",
                    Description = "139 CM 4K UHD ANDROID SMART TV,DAHİLİ UYDU ALICI",
                    Category = "Sony",
                    Price = 11000,
                    MainCategory = "Televizyon",
                    ImgPath = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/sony/thumb/sony-55xg9096-gorseli-108588_large.jpg"
                },
                new Product
                {
                    Name = "Vestel 75U9500 75",
                    Description = "189 CM 4K UHD SMART TV,DAHİLİ UYDU ALICILI",
                    Category = "Vestel",
                    Price = 11500,
                    MainCategory = "Televizyon",
                    ImgPath = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/vestel/thumb/109449-ana_large.jpg"
                },
                new Product
                {
                    Name = "Axen 49''",
                    Description = "124 CM FHD ULTRA SLIM ANDROID SMART TV,DAHİLİ UYDU ALICI",
                    Category = "Axen",
                    Price = 3000,
                    MainCategory = "Televizyon",
                    ImgPath = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/axen/thumb/axen-ax49fil27c-s-gorseli-108258_large.jpg"
                },
                new Product
                {
                    Name = "Vestel 50U9500 50''",
                    Description = "126 CM 4K UHD SMART TV,DAHİLİ UYDU ALICILI",
                    Category = "Vestel",
                    Price = 3900,
                    MainCategory = "Televizyon",
                    ImgPath = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/vestel/thumb/vestel-50u9500-gorseli-105184_large.jpg"
                },
                new Product
                {
                    Name = "Sony Playstation 5",
                    Description = "Oyun Konsolu",
                    Category = "Sony",
                    Price = 8300,
                    MainCategory = "Oyun Konsolu",
                    ImgPath = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/sony/thumb/TeoriV2-108445-1_large.jpg"
                },
                new Product
                {
                    Name = "Microsoft Xbox Series X",
                    Description = "Oyun Konsolu",
                    Category = "Microsoft Xbox",
                    Price = 7500,
                    MainCategory = "Oyun Konsolu",
                    ImgPath = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/microsoft/thumb/108453-gorsel-1_large.jpg"
                },
                new Product
                {
                    Name = "Microsoft Xbox Series S",
                    Description = "Oyun Konsolu",
                    Category = "Microsoft Xbox",
                    Price = 5000,
                    MainCategory = "Oyun Konsolu",
                    ImgPath = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/microsoft/thumb/109337-anagorsel_large.jpg"
                },
                new Product
                {
                    Name = "Apple Watch Series 6 GPS",
                    Description = "44mm Space Gray Aluminium Case with Black Sport Band",
                    Category = "Apple",
                    Price = 4000,
                    MainCategory = "Akıllı Saat",
                    ImgPath = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/apple/thumb/109346-gorsel-1_large.jpg"
                },
                new Product
                {
                    Name = "Huawei Watch GT2",
                    Description = "Saat x 1 Şarj Standı x 1 Type C Kablosu x 1 Kullanım Kılavuzu x 1 Garanti Belgesi x 1",
                    Category = "Huawei",
                    Price = 1400,
                    MainCategory = "Akıllı Saat",
                    ImgPath = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/huawei/thumb/TeoriV2-104958_large.jpg"
                },
                new Product
                {
                    Name = "Apple Watch Series 3 GPS",
                    Description = "38mm Space Grey Aluminium Case with Black Sport Band",
                    Category = "Apple",
                    Price = 1900,
                    MainCategory = "Akıllı Saat",
                    ImgPath = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/apple/thumb/91993-gorsel-1_large.jpg"
                },
                new Product
                {
                    Name = "Samsung EB-PG850BWEGWW",
                    Description = "8400MAH TAŞINABİLİR ŞARJ CİHAZI- (BEYAZ)",
                    Category = "Samsung",
                    Price = 200,
                    MainCategory = "Powerbank",
                    ImgPath = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/samsung/thumb/v2-77868_large.jpg"
                },
                new Product
                {
                    Name = "S-Link IP-G11 Iron",
                    Description = "10000mAh POWERBANK TAŞINABİLİR PİL SARJ CİHAZI GRİ",
                    Category = "S-Link",
                    Price = 126,
                    MainCategory = "Powerbank",
                    ImgPath = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/s-link/thumb/v2-85968_large.jpg"
                }
                );
                context.SaveChanges();
            }
        }
    }
}

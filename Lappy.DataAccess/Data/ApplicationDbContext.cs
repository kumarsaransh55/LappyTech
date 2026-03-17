using System;
using System.Drawing;
using System.Numerics;
using System.Runtime.Intrinsics.Arm;
using Lappy.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lappy.DataAccess.Data
{
    public class ApplicationDbContext:IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers{ get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Gaming", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Productivity", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Business", DisplayOrder = 3 }
            );

            modelBuilder.Entity<Product>().HasData(
                // --- PRODUCTIVITY (Category 2) ---
                new Product { Id = 1, Brand = "ASUS", ModelName = "Vivobook 15", ScreenSize = "15.6 Inches", Colour = "Quiet Blue", HardDiskSize = "512 GB", CpuModel = "Core i3", RamMemory = "8 GB", OS = "Windows 11 Home", SpecialFeatures = "Backlit Keyboard, Anti Glare Coating", GraphicsCard = "Integrated Intel UHD", Description = "<h4>Effortless Performance. Vibrant Visuals.</h4><p>The <strong>ASUS Vivobook 15</strong> is your everyday companion that’s always ready to make light work of your agenda.</p><ul><li><strong>NanoEdge Display:</strong> Immersive viewing.</li><li><strong>ErgoSense Keyboard:</strong> Optimum key bounce.</li></ul>", ListPrice = 40990, ListPrice10 = 39000, ListPrice25 = 37000, ListPrice100 = 35000, CategoryId = 2 },

                new Product { Id = 2, Brand = "Apple", ModelName = "MacBook Air M3", ScreenSize = "13.6 Inches", Colour = "Midnight", HardDiskSize = "256 GB", CpuModel = "M3 Chip", RamMemory = "8 GB", OS = "macOS", SpecialFeatures = "Liquid Retina Display, Silent Design", GraphicsCard = "8-core GPU", Description = "<h4>Lean. Mean. M3 Machine.</h4><p>The <strong>MacBook Air</strong> sails through work and play with the M3 chip.</p><ul><li><strong>Up to 18 Hours Battery:</strong> Go all day.</li><li><strong>MagSafe:</strong> Easy magnetic charging.</li></ul>", ListPrice = 114900, ListPrice10 = 110000, ListPrice25 = 105000, ListPrice100 = 100000, CategoryId = 2 },

                new Product { Id = 3, Brand = "Samsung", ModelName = "Galaxy Book3 Pro", ScreenSize = "14 Inches", Colour = "Graphite", HardDiskSize = "512 GB", CpuModel = "Core i7", RamMemory = "16 GB", OS = "Windows 11", SpecialFeatures = "3K AMOLED Display", GraphicsCard = "Intel Iris Xe", Description = "<h4>Thin, Light, and Premium AMOLED.</h4><p>Elevate your work with the stunning 3K resolution display.</p><ul><li><strong>Dynamic AMOLED 2X:</strong> 120Hz refresh rate.</li><li><strong>Galaxy Ecosystem:</strong> Seamless file movement.</li></ul>", ListPrice = 135000, ListPrice10 = 130000, ListPrice25 = 125000, ListPrice100 = 120000, CategoryId = 2 },

                new Product { Id = 4, Brand = "LG", ModelName = "Gram 17", ScreenSize = "17 Inches", Colour = "Black", HardDiskSize = "1 TB", CpuModel = "Core i7", RamMemory = "16 GB", OS = "Windows 11", SpecialFeatures = "Ultra Lightweight", GraphicsCard = "Intel Iris Xe", Description = "<h4>Huge Screen. Featherweight Feel.</h4><p>The <strong>LG Gram 17</strong> offers a massive display in a feather-light body.</p><ul><li><strong>WQXGA:</strong> High resolution 16:10 display.</li><li><strong>Military Grade:</strong> Passed MIL-STD-810G tests.</li></ul>", ListPrice = 145000, ListPrice10 = 140000, ListPrice25 = 135000, ListPrice100 = 130000, CategoryId = 2 },

                new Product { Id = 5, Brand = "Acer", ModelName = "Swift Go 14", ScreenSize = "14 Inches", Colour = "Silver", HardDiskSize = "512 GB", CpuModel = "Ryzen 5", RamMemory = "16 GB", OS = "Windows 11", SpecialFeatures = "OLED Display", GraphicsCard = "Radeon Graphics", Description = "<h4>The AI-Ready Powerhouse.</h4><p>An easy-to-carry OLED laptop for the modern multitasker.</p><ul><li><strong>OLED Brilliance:</strong> 100% DCI-P3 color gamut.</li><li><strong>TwinAir:</strong> Efficient dual fan cooling.</li></ul>", ListPrice = 65000, ListPrice10 = 62000, ListPrice25 = 60000, ListPrice100 = 58000, CategoryId = 2 },

                new Product { Id = 6, Brand = "HP", ModelName = "Pavilion Plus 14", ScreenSize = "14 Inches", Colour = "Silver", HardDiskSize = "512 GB", CpuModel = "Core i5", RamMemory = "16 GB", OS = "Windows 11", SpecialFeatures = "5MP Camera", GraphicsCard = "Intel Iris Xe", Description = "<h4>Work Hard. Play Harder.</h4><p>Stunning screen and powerful processor for an all-round experience.</p><ul><li><strong>Eyesafe:</strong> Reduces blue light.</li><li><strong>Fast Charge:</strong> 0 to 50% in 30 mins.</li></ul>", ListPrice = 72000, ListPrice10 = 70000, ListPrice25 = 68000, ListPrice100 = 65000, CategoryId = 2 },

                new Product { Id = 7, Brand = "ASUS", ModelName = "Zenbook 14 OLED", ScreenSize = "14 Inches", Colour = "Ponder Blue", HardDiskSize = "1 TB", CpuModel = "Core i7", RamMemory = "16 GB", OS = "Windows 11", SpecialFeatures = "90Hz OLED", GraphicsCard = "Intel Iris Xe", Description = "<h4>Power and Elegance.</h4><p>Thin, light, and powerful with a timeless design.</p><ul><li><strong>Harman Kardon:</strong> Unrivaled sound.</li><li><strong>NumberPad 2.0:</strong> LED keypad in touchpad.</li></ul>", ListPrice = 98000, ListPrice10 = 95000, ListPrice25 = 92000, ListPrice100 = 89000, CategoryId = 2 },

                // --- GAMING (Category 1) ---
                new Product { Id = 8, Brand = "HP", ModelName = "Victus 15", ScreenSize = "15.6 Inches", Colour = "Performance Blue", HardDiskSize = "512 GB", CpuModel = "Ryzen 5", RamMemory = "16 GB", OS = "Windows 11", SpecialFeatures = "Fast Charging", GraphicsCard = "NVIDIA RTX 3050", Description = "<h4>Desktop Power to Go.</h4><p>Keep up with the biggest games with the HP Victus 15.</p><ul><li><strong>144Hz Screen:</strong> Crisp gameplay.</li><li><strong>OMEN Hub:</strong> Elevate your play.</li></ul>", ListPrice = 75000, ListPrice10 = 72000, ListPrice25 = 70000, ListPrice100 = 68000, CategoryId = 1 },

                new Product { Id = 9, Brand = "Lenovo", ModelName = "Legion Slim 5", ScreenSize = "16 Inches", Colour = "Storm Grey", HardDiskSize = "1 TB", CpuModel = "Ryzen 7", RamMemory = "16 GB", OS = "Windows 11", SpecialFeatures = "AI Engine+", GraphicsCard = "NVIDIA RTX 4060", Description = "<h4>Smart Gaming.</h4><p>Sleek look without sacrificing raw power.</p><ul><li><strong>AI Engine+:</strong> Automatically boosts FPS.</li><li><strong>ColdFront 5.0:</strong> Advanced thermals.</li></ul>", ListPrice = 135000, ListPrice10 = 130000, ListPrice25 = 125000, ListPrice100 = 120000, CategoryId = 1 },

                new Product { Id = 10, Brand = "MSI", ModelName = "Katana 15", ScreenSize = "15.6 Inches", Colour = "Black", HardDiskSize = "1 TB", CpuModel = "Core i7", RamMemory = "16 GB", OS = "Windows 11", SpecialFeatures = "4-Zone RGB", GraphicsCard = "NVIDIA RTX 4050", Description = "<h4>Sharpen Your Game.</h4><p>Forged for greatness in the virtual battlefield.</p><ul><li><strong>4-Zone RGB:</strong> Custom lighting style.</li><li><strong>Cooler Boost 5:</strong> Dedicated cooling.</li></ul>", ListPrice = 95000, ListPrice10 = 92000, ListPrice25 = 90000, ListPrice100 = 88000, CategoryId = 1 },

                new Product { Id = 11, Brand = "Razer", ModelName = "Blade 16", ScreenSize = "16 Inches", Colour = "Black", HardDiskSize = "1 TB", CpuModel = "Core i9", RamMemory = "32 GB", OS = "Windows 11", SpecialFeatures = "Dual Mode Mini-LED", GraphicsCard = "NVIDIA RTX 4080", Description = "<h4>More Pixels.</h4><p>Premium experience with unmatched build quality.</p><ul><li><strong>Mini-LED:</strong> Toggle between 4K and FHD+.</li><li><strong>Vapor Chamber:</strong> Extreme cooling.</li></ul>", ListPrice = 350000, ListPrice10 = 340000, ListPrice25 = 330000, ListPrice100 = 320000, CategoryId = 1 },

                new Product { Id = 12, Brand = "Acer", ModelName = "Nitro V 15", ScreenSize = "15.6 Inches", Colour = "Black", HardDiskSize = "512 GB", CpuModel = "Core i5", RamMemory = "8 GB", OS = "Windows 11", SpecialFeatures = "Dual Fan Cooling", GraphicsCard = "NVIDIA RTX 2050", Description = "<h4>Gateway to Gaming.</h4><p>The perfect entry into the world of PC gaming.</p><ul><li><strong>NitroSense:</strong> Control fan speeds easily.</li><li><strong>DTS:X:</strong> 3D spatial sound.</li></ul>", ListPrice = 58000, ListPrice10 = 55000, ListPrice25 = 53000, ListPrice100 = 50000, CategoryId = 1 },

                new Product { Id = 13, Brand = "Alienware", ModelName = "m18 R1", ScreenSize = "18 Inches", Colour = "Dark Metallic Moon", HardDiskSize = "2 TB", CpuModel = "Core i9", RamMemory = "64 GB", OS = "Windows 11", SpecialFeatures = "CherryMX Mechanical Keys", GraphicsCard = "NVIDIA RTX 4090", Description = "<h4>Ultimate Dominance.</h4><p>Desktop replacement designed for the serious gamer.</p><ul><li><strong>Cryo-Tech:</strong> Peak performance interface.</li><li><strong>18-inch Display:</strong> Total immersion.</li></ul>", ListPrice = 450000, ListPrice10 = 440000, ListPrice25 = 430000, ListPrice100 = 420000, CategoryId = 1 },

                new Product { Id = 14, Brand = "Gigabyte", ModelName = "AORUS 15", ScreenSize = "15.6 Inches", Colour = "Black", HardDiskSize = "1 TB", CpuModel = "Core i7", RamMemory = "16 GB", OS = "Windows 11", SpecialFeatures = "240Hz Screen", GraphicsCard = "NVIDIA RTX 4060", Description = "<h4>Engineered to Win.</h4><p>High performance refined for competitive shooters.</p><ul><li><strong>Windforce:</strong> Silent and cool.</li><li><strong>AI Power:</strong> Dynamic allocation.</li></ul>", ListPrice = 120000, ListPrice10 = 115000, ListPrice25 = 110000, ListPrice100 = 105000, CategoryId = 1 },

                // --- BUSINESS (Category 3) ---
                new Product { Id = 15, Brand = "Dell", ModelName = "XPS 15", ScreenSize = "15.6 Inches", Colour = "Platinum Silver", HardDiskSize = "1 TB", CpuModel = "Core i9", RamMemory = "32 GB", OS = "Windows 11 Pro", SpecialFeatures = "InfinityEdge Touch", GraphicsCard = "NVIDIA RTX 4050", Description = "<h4>Creative Vision.</h4><p>The gold standard for Windows premium laptops.</p><ul><li><strong>4-Sided InfinityEdge:</strong> Stunning views.</li><li><strong>Waves Nx:</strong> Studio sound.</li></ul>", ListPrice = 245000, ListPrice10 = 240000, ListPrice25 = 235000, ListPrice100 = 230000, CategoryId = 3 },

                new Product { Id = 16, Brand = "Lenovo", ModelName = "ThinkPad X1 Carbon", ScreenSize = "14 Inches", Colour = "Black", HardDiskSize = "512 GB", CpuModel = "Core i7 vPro", RamMemory = "16 GB", OS = "Windows 11 Pro", SpecialFeatures = "Carbon Fiber Build", GraphicsCard = "Integrated Intel UHD", Description = "<h4>Business Benchmark.</h4><p>Legendary reliability in an ultra-light carbon fiber body.</p><ul><li><strong>PrivacyGuard:</strong> Security for your screen.</li><li><strong>Pro Security:</strong> vPro management.</li></ul>", ListPrice = 185000, ListPrice10 = 180000, ListPrice25 = 175000, ListPrice100 = 170000, CategoryId = 3 },

                new Product { Id = 17, Brand = "Microsoft", ModelName = "Surface Laptop 5", ScreenSize = "13.5 Inches", Colour = "Sandstone", HardDiskSize = "512 GB", CpuModel = "Core i5", RamMemory = "8 GB", OS = "Windows 11", SpecialFeatures = "Alcantara Palm Rest", GraphicsCard = "Integrated Intel Iris Xe", Description = "<h4>Style and Speed.</h4><p>Sleek, elegant, and perfectly integrated touch experience.</p><ul><li><strong>PixelSense:</strong> High-res touch.</li><li><strong>Alcantara:</strong> Premium comfort.</li></ul>", ListPrice = 105000, ListPrice10 = 100000, ListPrice25 = 95000, ListPrice100 = 90000, CategoryId = 3 },

                new Product { Id = 18, Brand = "HP", ModelName = "Spectre x360", ScreenSize = "13.5 Inches", Colour = "Nightfall Black", HardDiskSize = "1 TB", CpuModel = "Core i7", RamMemory = "16 GB", OS = "Windows 11", SpecialFeatures = "2-in-1 Flip, Stylus", GraphicsCard = "Integrated Intel Iris Xe", Description = "<h4>Adapts to You.</h4><p>Beautiful gem-cut design that works as a tablet or laptop.</p><ul><li><strong>Stylus Included:</strong> For creative work.</li><li><strong>GlamCam:</strong> 5MP clarity.</li></ul>", ListPrice = 165000, ListPrice10 = 160000, ListPrice25 = 155000, ListPrice100 = 150000, CategoryId = 3 },

                new Product { Id = 19, Brand = "Dell", ModelName = "Latitude 7440", ScreenSize = "14 Inches", Colour = "Grey", HardDiskSize = "512 GB", CpuModel = "Core i5", RamMemory = "16 GB", OS = "Windows 11 Pro", SpecialFeatures = "Privacy Shutter", GraphicsCard = "Integrated Intel UHD", Description = "<h4>Smart Collaboration.</h4><p>The smallest and most intelligent premium business laptop.</p><ul><li><strong>ExpressConnect:</strong> Best network join.</li><li><strong>Intelligent Audio:</strong> Noise cancellation.</li></ul>", ListPrice = 115000, ListPrice10 = 110000, ListPrice25 = 105000, ListPrice100 = 100000, CategoryId = 3 },

                new Product { Id = 20, Brand = "Apple", ModelName = "MacBook Pro 14", ScreenSize = "14.2 Inches", Colour = "Space Black", HardDiskSize = "512 GB", CpuModel = "M3 Pro Chip", RamMemory = "18 GB", OS = "macOS", SpecialFeatures = "ProMotion 120Hz", GraphicsCard = "14-core GPU", Description = "<h4>Pro Power.</h4><p>Extreme dynamic range and pro performance for creators.</p><ul><li><strong>XDR Display:</strong> 1,000,000:1 contrast.</li><li><strong>ProMotion:</strong> 120Hz fluid motion.</li></ul>", ListPrice = 199900, ListPrice10 = 195000, ListPrice25 = 190000, ListPrice100 = 185000, CategoryId = 3 }
            );
        }
    }
}

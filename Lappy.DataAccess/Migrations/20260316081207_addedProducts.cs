using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lappy.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "GraphicsCard", "ModelName" },
                values: new object[] { "<h4>Effortless Performance. Vibrant Visuals.</h4><p>The <strong>ASUS Vivobook 15</strong> is your everyday companion that’s always ready to make light work of your agenda.</p><ul><li><strong>NanoEdge Display:</strong> Immersive viewing.</li><li><strong>ErgoSense Keyboard:</strong> Optimum key bounce.</li></ul>", "Integrated Intel UHD", "Vivobook 15" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "Colour", "CpuModel", "Description", "GraphicsCard", "HardDiskSize", "ListPrice", "ListPrice10", "ListPrice100", "ListPrice25", "ModelName", "OS", "RamMemory", "ScreenSize", "SpecialFeatures" },
                values: new object[,]
                {
                    { 2, "Apple", 2, "Midnight", "M3 Chip", "<h4>Lean. Mean. M3 Machine.</h4><p>The <strong>MacBook Air</strong> sails through work and play with the M3 chip.</p><ul><li><strong>Up to 18 Hours Battery:</strong> Go all day.</li><li><strong>MagSafe:</strong> Easy magnetic charging.</li></ul>", "8-core GPU", "256 GB", 114900.0, 110000.0, 100000.0, 105000.0, "MacBook Air M3", "macOS", "8 GB", "13.6 Inches", "Liquid Retina Display, Silent Design" },
                    { 3, "Samsung", 2, "Graphite", "Core i7", "<h4>Thin, Light, and Premium AMOLED.</h4><p>Elevate your work with the stunning 3K resolution display.</p><ul><li><strong>Dynamic AMOLED 2X:</strong> 120Hz refresh rate.</li><li><strong>Galaxy Ecosystem:</strong> Seamless file movement.</li></ul>", "Intel Iris Xe", "512 GB", 135000.0, 130000.0, 120000.0, 125000.0, "Galaxy Book3 Pro", "Windows 11", "16 GB", "14 Inches", "3K AMOLED Display" },
                    { 4, "LG", 2, "Black", "Core i7", "<h4>Huge Screen. Featherweight Feel.</h4><p>The <strong>LG Gram 17</strong> offers a massive display in a feather-light body.</p><ul><li><strong>WQXGA:</strong> High resolution 16:10 display.</li><li><strong>Military Grade:</strong> Passed MIL-STD-810G tests.</li></ul>", "Intel Iris Xe", "1 TB", 145000.0, 140000.0, 130000.0, 135000.0, "Gram 17", "Windows 11", "16 GB", "17 Inches", "Ultra Lightweight" },
                    { 5, "Acer", 2, "Silver", "Ryzen 5", "<h4>The AI-Ready Powerhouse.</h4><p>An easy-to-carry OLED laptop for the modern multitasker.</p><ul><li><strong>OLED Brilliance:</strong> 100% DCI-P3 color gamut.</li><li><strong>TwinAir:</strong> Efficient dual fan cooling.</li></ul>", "Radeon Graphics", "512 GB", 65000.0, 62000.0, 58000.0, 60000.0, "Swift Go 14", "Windows 11", "16 GB", "14 Inches", "OLED Display" },
                    { 6, "HP", 2, "Silver", "Core i5", "<h4>Work Hard. Play Harder.</h4><p>Stunning screen and powerful processor for an all-round experience.</p><ul><li><strong>Eyesafe:</strong> Reduces blue light.</li><li><strong>Fast Charge:</strong> 0 to 50% in 30 mins.</li></ul>", "Intel Iris Xe", "512 GB", 72000.0, 70000.0, 65000.0, 68000.0, "Pavilion Plus 14", "Windows 11", "16 GB", "14 Inches", "5MP Camera" },
                    { 7, "ASUS", 2, "Ponder Blue", "Core i7", "<h4>Power and Elegance.</h4><p>Thin, light, and powerful with a timeless design.</p><ul><li><strong>Harman Kardon:</strong> Unrivaled sound.</li><li><strong>NumberPad 2.0:</strong> LED keypad in touchpad.</li></ul>", "Intel Iris Xe", "1 TB", 98000.0, 95000.0, 89000.0, 92000.0, "Zenbook 14 OLED", "Windows 11", "16 GB", "14 Inches", "90Hz OLED" },
                    { 8, "HP", 1, "Performance Blue", "Ryzen 5", "<h4>Desktop Power to Go.</h4><p>Keep up with the biggest games with the HP Victus 15.</p><ul><li><strong>144Hz Screen:</strong> Crisp gameplay.</li><li><strong>OMEN Hub:</strong> Elevate your play.</li></ul>", "NVIDIA RTX 3050", "512 GB", 75000.0, 72000.0, 68000.0, 70000.0, "Victus 15", "Windows 11", "16 GB", "15.6 Inches", "Fast Charging" },
                    { 9, "Lenovo", 1, "Storm Grey", "Ryzen 7", "<h4>Smart Gaming.</h4><p>Sleek look without sacrificing raw power.</p><ul><li><strong>AI Engine+:</strong> Automatically boosts FPS.</li><li><strong>ColdFront 5.0:</strong> Advanced thermals.</li></ul>", "NVIDIA RTX 4060", "1 TB", 135000.0, 130000.0, 120000.0, 125000.0, "Legion Slim 5", "Windows 11", "16 GB", "16 Inches", "AI Engine+" },
                    { 10, "MSI", 1, "Black", "Core i7", "<h4>Sharpen Your Game.</h4><p>Forged for greatness in the virtual battlefield.</p><ul><li><strong>4-Zone RGB:</strong> Custom lighting style.</li><li><strong>Cooler Boost 5:</strong> Dedicated cooling.</li></ul>", "NVIDIA RTX 4050", "1 TB", 95000.0, 92000.0, 88000.0, 90000.0, "Katana 15", "Windows 11", "16 GB", "15.6 Inches", "4-Zone RGB" },
                    { 11, "Razer", 1, "Black", "Core i9", "<h4>More Pixels.</h4><p>Premium experience with unmatched build quality.</p><ul><li><strong>Mini-LED:</strong> Toggle between 4K and FHD+.</li><li><strong>Vapor Chamber:</strong> Extreme cooling.</li></ul>", "NVIDIA RTX 4080", "1 TB", 350000.0, 340000.0, 320000.0, 330000.0, "Blade 16", "Windows 11", "32 GB", "16 Inches", "Dual Mode Mini-LED" },
                    { 12, "Acer", 1, "Black", "Core i5", "<h4>Gateway to Gaming.</h4><p>The perfect entry into the world of PC gaming.</p><ul><li><strong>NitroSense:</strong> Control fan speeds easily.</li><li><strong>DTS:X:</strong> 3D spatial sound.</li></ul>", "NVIDIA RTX 2050", "512 GB", 58000.0, 55000.0, 50000.0, 53000.0, "Nitro V 15", "Windows 11", "8 GB", "15.6 Inches", "Dual Fan Cooling" },
                    { 13, "Alienware", 1, "Dark Metallic Moon", "Core i9", "<h4>Ultimate Dominance.</h4><p>Desktop replacement designed for the serious gamer.</p><ul><li><strong>Cryo-Tech:</strong> Peak performance interface.</li><li><strong>18-inch Display:</strong> Total immersion.</li></ul>", "NVIDIA RTX 4090", "2 TB", 450000.0, 440000.0, 420000.0, 430000.0, "m18 R1", "Windows 11", "64 GB", "18 Inches", "CherryMX Mechanical Keys" },
                    { 14, "Gigabyte", 1, "Black", "Core i7", "<h4>Engineered to Win.</h4><p>High performance refined for competitive shooters.</p><ul><li><strong>Windforce:</strong> Silent and cool.</li><li><strong>AI Power:</strong> Dynamic allocation.</li></ul>", "NVIDIA RTX 4060", "1 TB", 120000.0, 115000.0, 105000.0, 110000.0, "AORUS 15", "Windows 11", "16 GB", "15.6 Inches", "240Hz Screen" },
                    { 15, "Dell", 3, "Platinum Silver", "Core i9", "<h4>Creative Vision.</h4><p>The gold standard for Windows premium laptops.</p><ul><li><strong>4-Sided InfinityEdge:</strong> Stunning views.</li><li><strong>Waves Nx:</strong> Studio sound.</li></ul>", "NVIDIA RTX 4050", "1 TB", 245000.0, 240000.0, 230000.0, 235000.0, "XPS 15", "Windows 11 Pro", "32 GB", "15.6 Inches", "InfinityEdge Touch" },
                    { 16, "Lenovo", 3, "Black", "Core i7 vPro", "<h4>Business Benchmark.</h4><p>Legendary reliability in an ultra-light carbon fiber body.</p><ul><li><strong>PrivacyGuard:</strong> Security for your screen.</li><li><strong>Pro Security:</strong> vPro management.</li></ul>", "Integrated Intel UHD", "512 GB", 185000.0, 180000.0, 170000.0, 175000.0, "ThinkPad X1 Carbon", "Windows 11 Pro", "16 GB", "14 Inches", "Carbon Fiber Build" },
                    { 17, "Microsoft", 3, "Sandstone", "Core i5", "<h4>Style and Speed.</h4><p>Sleek, elegant, and perfectly integrated touch experience.</p><ul><li><strong>PixelSense:</strong> High-res touch.</li><li><strong>Alcantara:</strong> Premium comfort.</li></ul>", "Integrated Intel Iris Xe", "512 GB", 105000.0, 100000.0, 90000.0, 95000.0, "Surface Laptop 5", "Windows 11", "8 GB", "13.5 Inches", "Alcantara Palm Rest" },
                    { 18, "HP", 3, "Nightfall Black", "Core i7", "<h4>Adapts to You.</h4><p>Beautiful gem-cut design that works as a tablet or laptop.</p><ul><li><strong>Stylus Included:</strong> For creative work.</li><li><strong>GlamCam:</strong> 5MP clarity.</li></ul>", "Integrated Intel Iris Xe", "1 TB", 165000.0, 160000.0, 150000.0, 155000.0, "Spectre x360", "Windows 11", "16 GB", "13.5 Inches", "2-in-1 Flip, Stylus" },
                    { 19, "Dell", 3, "Grey", "Core i5", "<h4>Smart Collaboration.</h4><p>The smallest and most intelligent premium business laptop.</p><ul><li><strong>ExpressConnect:</strong> Best network join.</li><li><strong>Intelligent Audio:</strong> Noise cancellation.</li></ul>", "Integrated Intel UHD", "512 GB", 115000.0, 110000.0, 100000.0, 105000.0, "Latitude 7440", "Windows 11 Pro", "16 GB", "14 Inches", "Privacy Shutter" },
                    { 20, "Apple", 3, "Space Black", "M3 Pro Chip", "<h4>Pro Power.</h4><p>Extreme dynamic range and pro performance for creators.</p><ul><li><strong>XDR Display:</strong> 1,000,000:1 contrast.</li><li><strong>ProMotion:</strong> 120Hz fluid motion.</li></ul>", "14-core GPU", "512 GB", 199900.0, 195000.0, 185000.0, 190000.0, "MacBook Pro 14", "macOS", "18 GB", "14.2 Inches", "ProMotion 120Hz" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "GraphicsCard", "ModelName" },
                values: new object[] { "Processor: Intel Core i3-1215U Processor 1.2 GHz (10M Cache, up to 4.4 GHz, 6 cores)\r\nMemory: 8GB DDR4 RAM on board | Storage: 512GB M.2 NVMe PCIe 3.0 SSD\r\nDisplay: 15.6-inch, FHD (1920 x 1080) 16:9 aspect ratio, 250nits, 60Hz refresh rate, Anti-glare display, 45% NTSC\r\nGraphics: Integrated Intel UHD Graphics\r\nOperating System: Pre-installed Windows 11 Home with Lifetime Validity | Software Included: Pre-installed Office Home and Student with Lifetime Validity | McAfee (1 Year)\r\nDesign: 1.99 ~ 1.99 cm | 1.70 kg | Thin and Light Laptop | 42WHrs, 3S1P, 3-cell Li-ion | Up to 6 hours battery life ;Note: Battery life depends on conditions of usage\r\nKeyboard: Backlit Chiclet Keyboard | 1.4mm Key Travel", "Integrated", "ASUS Vivobook 15" });
        }
    }
}

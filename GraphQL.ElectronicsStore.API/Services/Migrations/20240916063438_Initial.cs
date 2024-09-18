using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GraphQL.ElectronicsStore.API.Services.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ElectronicsStore");

            migrationBuilder.CreateTable(
                name: "Categories",
                schema: "ElectronicsStore",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                schema: "ElectronicsStore",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "ElectronicsStore",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                schema: "ElectronicsStore",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 9, 16, 1, 34, 37, 736, DateTimeKind.Local).AddTicks(8512)),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalSchema: "ElectronicsStore",
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                schema: "ElectronicsStore",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductID, x.CategoryID });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalSchema: "ElectronicsStore",
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductID",
                        column: x => x.ProductID,
                        principalSchema: "ElectronicsStore",
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                schema: "ElectronicsStore",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => new { x.OrderID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_OrderProducts_Orders_OrderID",
                        column: x => x.OrderID,
                        principalSchema: "ElectronicsStore",
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Products_ProductID",
                        column: x => x.ProductID,
                        principalSchema: "ElectronicsStore",
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "ElectronicsStore",
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Home Entertainment" },
                    { 2, "Televisions" },
                    { 3, "Home Theater Systems" },
                    { 4, "DVD/Blu-ray Players" },
                    { 5, "Streaming Devices" },
                    { 6, "Soundbars and Speakers" },
                    { 7, "Computers and Accessories" },
                    { 8, "Laptops" },
                    { 9, "Desktop PCs" },
                    { 10, "Monitors" },
                    { 11, "Printers and Scanners" },
                    { 12, "Keyboards, Mice, and Trackpads" },
                    { 13, "External Hard Drives and SSDs" },
                    { 14, "USB Flash Drives" },
                    { 15, "Routers and Modems" },
                    { 16, "Mobile Devices" },
                    { 17, "Smartphones" },
                    { 18, "Tablets" },
                    { 19, "Smartwatches" },
                    { 20, "E-Readers" },
                    { 21, "Mobile Accessories" },
                    { 22, "Wearables and Fitness Gadgets" },
                    { 23, "Smartwatches" },
                    { 24, "Fitness Trackers" },
                    { 25, "Virtual Reality Headsets" },
                    { 26, "Audio Equipment" },
                    { 27, "Headphones" },
                    { 28, "Kitchen Room" },
                    { 29, "Laundry Room" },
                    { 30, "Photography" },
                    { 31, "Video Camera" },
                    { 32, "Gaming Consoles" },
                    { 33, "Gaming Accessories" }
                });

            migrationBuilder.InsertData(
                schema: "ElectronicsStore",
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "Email", "FirstName", "LastName", "Phone" },
                values: new object[] { 1, "1234 Coral Way, Miami, FL 33145", "AlbertoSmith1785@gmail.com", "Alberto", "Smith", "+57 3126555555" });

            migrationBuilder.InsertData(
                schema: "ElectronicsStore",
                table: "Products",
                columns: new[] { "ProductID", "Description", "ImageUrl", "Price", "ProductName", "StockQuantity" },
                values: new object[,]
                {
                    { 1, "Vivid 55-inch 4K display with smart streaming capabilities.", "https://smselectronic.com/wp-content/uploads/2024/06/SAMSUNG-TV-55-QLED-4K-Q60C-1.png", 499.99m, "Samsung 55-Inch Smart TV", 25 },
                    { 2, "Premium surround sound for an immersive home cinema experience.", "https://m.media-amazon.com/images/I/51m4NsZau4L._AC_SL1212_.jpg", 299.99m, "Sony Home Theater System", 15 },
                    { 3, "Blu-ray player with smooth playback and advanced upscaling.", "https://www.lg.com/content/dam/channel/wcms/pe/images/video/bp325/gallery/medium.jpg", 79.99m, "LG Blu-ray Player", 30 },
                    { 4, "Compact streaming stick with 4K streaming and remote.", "https://m.media-amazon.com/images/I/71wrIZujPIL.jpg", 49.99m, "Roku Streaming Stick", 40 },
                    { 5, "High-end soundbar delivering exceptional clarity and deep bass.", "https://assets.bose.com/content/dam/Bose_DAM/Web/consumer_electronics/global/products/speakers/bose_soundbar_700/product_silo_images/bose_soundbar_700_black_EC_03.psd/jcr:content/renditions/cq5dam.web.1920.1920.png", 799.99m, "Bose Soundbar 700", 10 },
                    { 6, "Ultra-thin, powerful laptop with stunning 13-inch display.", "https://m.media-amazon.com/images/I/710EGJBdIML._AC_SL1500_.jpg", 1099.99m, "Dell XPS 13 Laptop", 20 },
                    { 7, "Reliable desktop PC for home and office productivity.", "https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c07920872.png?impolicy=Png_Res", 649.99m, "HP Desktop PC", 18 },
                    { 8, "27-inch monitor with crisp Full HD visuals for work or gaming.", "https://symcomputadores.com/wp-content/uploads/2024/08/Acer-EK271-E-27Acer-EK271-E.png", 199.99m, "Acer 27-Inch Monitor", 22 },
                    { 9, "Efficient laser printer with high-quality print outputs.", "https://pcsoftwareus.com/wp-content/uploads/2022/10/Canon-Laser-MF232W-web-1.jpg", 149.99m, "Canon Laser Printer", 25 },
                    { 10, "Ergonomic wireless keyboard for smooth typing experience.", "https://resource.logitech.com/w_692,c_lpad,ar_4:3,q_auto,f_auto,dpr_1.0/d_transparent.gif/content/dam/logitech/en/products/combos/mk520/gallery/mk520-gallery-1-new.png?v=1", 59.99m, "Logitech Wireless Keyboard", 35 },
                    { 11, "Portable 1TB hard drive for easy data backups and transfers.", "https://mac-center.com/cdn/shop/products/156e18327d1a5b4d1ca7cbd8a3939b3f-product_817f4ef5-86cb-4521-8d4b-1bac846601db.webp?v=1681388624", 59.99m, "Seagate 1TB External Hard Drive", 50 },
                    { 12, "Compact and reliable 128GB USB for secure file storage.", "https://www.tecnoflash.com.co/wp-content/uploads/2024/08/Memoria-Sandisk-Usb-128Gb.png", 19.99m, "SanDisk 128GB USB Flash Drive", 75 },
                    { 13, "Fast WiFi 6 router with wide coverage and high speeds.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSGiDspwjQwHqM9DsLxgfPNIhUSKVx83yLTDQ&s", 99.99m, "TP-Link WiFi 6 Router", 28 },
                    { 14, "Advanced iPhone with high-resolution camera and fast performance.", "https://www.compudemano.com/wp-content/uploads/2023/01/apple-iphone-14-plus-128gb-blanco-estelar.jpg", 999.99m, "Apple iPhone 14", 12 },
                    { 15, "Powerful tablet with stunning display and S Pen support.", "https://www.manuales.com.co/thumbs/products/l/1260236-samsung-galaxy-tab-s7.webp", 649.99m, "Samsung Galaxy Tab S7", 15 },
                    { 16, "Feature-packed smartwatch with advanced health monitoring.", "https://www.compudemano.com/wp-content/uploads/2022/10/apple-watch-serires-8-45mm-gps-blanco-estelar.png", 399.99m, "Apple Watch Series 8", 20 },
                    { 17, "E-reader with crisp display and weeks-long battery life.", "https://m.media-amazon.com/images/G/01/kindle/journeys/5xlDnKG94P0ryVnD8MqFmnIhMKBXE2F2BxyzUQHa63Hhs3D/ZjBjZWUxMjIt._CB641064212_.jpg", 129.99m, "Amazon Kindle Paperwhite", 18 },
                    { 18, "High-capacity power bank for fast and reliable charging on the go.", "https://http2.mlstatic.com/D_NQ_NP_881019-MCO73793450400_012024-O.webp", 49.99m, "Anker Power Bank 20000mAh", 50 },
                    { 19, "Fitness tracker with health metrics and long battery life.", "https://http2.mlstatic.com/D_NQ_NP_883919-MLU70662175641_072023-O.webp", 149.99m, "Fitbit Charge 5", 22 },
                    { 20, "VR headset with immersive experiences and wireless connectivity.", "https://i5.walmartimages.com/seo/Meta-Oculus-Quest-2-64GB-Advanced-All-In-One-Virtual-Reality-Headset_16a9974e-a5b0-4cad-a98e-730148409bef.3e8858a1d3beb01ff2fbc79a880beedf.jpeg", 299.99m, "Oculus Quest 2 VR Headset", 10 },
                    { 21, "Noise-canceling headphones for clear, immersive sound.", "https://www.sony.com/image/eb0062b3db03748efc7f5ca3fd82ccc5?fmt=pjpeg&wid=330&bgcolor=FFFFFF&bgc=FFFFFF", 249.99m, "Sony Noise-Canceling Headphones", 30 },
                    { 22, "Premium wireless earbuds with noise cancellation.", "https://mac-center.com/cdn/shop/files/IMG-10869228.jpg?v=1723753366", 199.99m, "Apple AirPods Pro", 40 },
                    { 23, "Portable speaker with deep bass and high-quality sound.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT7YL9rMWkmPTAenjc9r2Qnv1NThoLhTK6Y5A&s", 99.99m, "JBL Bluetooth Speaker", 25 },
                    { 24, "Voice-controlled smart speaker with rich sound.", "https://http2.mlstatic.com/D_NQ_NP_897798-MCO53950787380_022023-O.webp", 199.99m, "Sonos One Smart Speaker", 15 },
                    { 25, "Entry-level DSLR for high-quality photos and videos.", "https://eoatecnologia.com/cdn/shop/files/1535598024_IMG_1056607.jpg?v=1699992619&width=416", 499.99m, "Nikon D3500 DSLR Camera", 10 },
                    { 26, "Rugged action camera for capturing extreme moments.", "https://www.artikulos.co/wp-content/uploads/GoPro-HERO-11-Black-en-ARTIKULOS.CO-Foto-1.jpg", 349.99m, "GoPro Hero 11 Action Camera", 8 },
                    { 27, "Prime lens for sharp, fast, and versatile photography.", "https://lumen-colombia.com/8337-large_01oslo/canon-50mm.jpg", 125.99m, "Canon 50mm f/1.8 Lens", 20 },
                    { 28, "Durable tripod for steady shots and easy handling.", "https://cassaimportadores.com/cdn/shop/products/Manfrotto-TrIpode-de-aluminio-Compact-Action-con-cabezal-hibrido_1200x1200.png?v=1634751589", 89.99m, "Manfrotto Tripod", 12 },
                    { 29, "High-speed 64GB SD card for fast data transfer.", "https://importacionesarturia.com/wp-content/uploads/2020/04/Memoria-Sandisk-64Gb-de-100mbs-PgBlanca-2.jpg", 19.99m, "SanDisk 64GB SD Card", 50 },
                    { 30, "Next-gen gaming console with stunning 4K visuals.", "https://exitocol.vtexassets.com/arquivos/ids/9154830/consola-sony-playstation-5-ps5-825gb-lector-de-disco.jpg?v=637631028235770000", 499.99m, "PlayStation 5 Console", 5 },
                    { 31, "Powerful gaming console for a seamless experience.", "https://exitocol.vtexassets.com/arquivos/ids/7234188/consola-xbox-series-x-1tb-microsoft.jpg?v=637532554328630000", 499.99m, "Xbox Series X Console", 6 },
                    { 32, "Portable gaming console for on-the-go fun.", "https://imagedelivery.net/4fYuQyy-r8_rpBpcY7lH_A/falabellaCO/126171770_01/w=800,h=800,fit=pad", 299.99m, "Nintendo Switch", 15 },
                    { 33, "Innovative controller with haptic feedback for PS5.", "https://cosonyb2c.vtexassets.com/arquivos/ids/345373/PS5_DS_Pshot_A.jpg?v=637363940945300000", 69.99m, "PS5 DualSense Controller", 22 },
                    { 34, "Wireless headset for immersive Xbox gaming audio.", "https://http2.mlstatic.com/D_NQ_NP_839906-MLU70065296481_062023-O.webp", 99.99m, "Xbox Wireless Headset", 18 },
                    { 35, "Automated vacuum with smart navigation for cleaning.", "https://www.irobotcolombia.com/wp-content/uploads/2023/01/j7.jpg", 299.99m, "iRobot Roomba Vacuum", 14 },
                    { 36, "Energy-efficient air conditioner with smart controls.", "https://www.lg.com/africa/images/split-air-conditioners/md06099357/gallery/medium02.jpg", 599.99m, "LG Smart Air Conditioner", 8 },
                    { 37, "Front load washing machine with fast and efficient cleaning.", "https://images.samsung.com/is/image/samsung/p6pim/in/ww80t4040ce-tl/gallery/in-front-loading-washer-ww70t4020cheo-377223-ww80t4040ce-tl-395196808?$650_519_PNG$", 849.99m, "Samsung Front Load Washing Machine", 5 },
                    { 38, "Spacious refrigerator with adjustable temperature controls.", "https://i5.walmartimages.com/seo/Whirlpool-33-21-cu-ft-Top-Freezer-Refrigerator-in-Monochromatic-Stainless-Steel_83b13732-b9d5-40fd-87ce-9f15a4462f8e.9a4cc30a642274ffb600d70c10c0416b.jpeg", 1199.99m, "Whirlpool Refrigerator", 4 },
                    { 39, "High-performance microwave oven for quick and easy cooking.", "https://www.panasonic.com/content/dam/pim/my/en/NN/NN-ST2/NN-ST253/NN-ST253-Product_ImageGlobal-1_my_en.png", 129.99m, "Panasonic Microwave Oven", 25 }
                });

            migrationBuilder.InsertData(
                schema: "ElectronicsStore",
                table: "ProductCategories",
                columns: new[] { "CategoryID", "ProductID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 3, 2 },
                    { 1, 3 },
                    { 4, 3 },
                    { 1, 4 },
                    { 5, 4 },
                    { 1, 5 },
                    { 6, 5 },
                    { 26, 5 },
                    { 7, 6 },
                    { 8, 6 },
                    { 7, 7 },
                    { 9, 7 },
                    { 7, 8 },
                    { 10, 8 },
                    { 7, 9 },
                    { 11, 9 },
                    { 7, 10 },
                    { 12, 10 },
                    { 7, 11 },
                    { 13, 11 },
                    { 7, 12 },
                    { 14, 12 },
                    { 7, 13 },
                    { 15, 13 },
                    { 16, 14 },
                    { 17, 14 },
                    { 16, 15 },
                    { 18, 15 },
                    { 19, 16 },
                    { 22, 16 },
                    { 20, 17 },
                    { 21, 18 },
                    { 22, 19 },
                    { 24, 19 },
                    { 1, 20 },
                    { 25, 20 },
                    { 26, 21 },
                    { 27, 21 },
                    { 26, 22 },
                    { 27, 22 },
                    { 1, 23 },
                    { 26, 23 },
                    { 1, 24 },
                    { 26, 24 },
                    { 1, 25 },
                    { 30, 25 },
                    { 1, 26 },
                    { 31, 26 },
                    { 1, 27 },
                    { 30, 27 },
                    { 30, 28 },
                    { 7, 29 },
                    { 13, 29 },
                    { 1, 30 },
                    { 32, 30 },
                    { 1, 31 },
                    { 32, 31 },
                    { 1, 32 },
                    { 32, 32 },
                    { 1, 33 },
                    { 33, 33 },
                    { 26, 34 },
                    { 33, 34 },
                    { 1, 35 },
                    { 1, 36 },
                    { 28, 36 },
                    { 29, 37 },
                    { 29, 38 },
                    { 1, 39 },
                    { 28, 39 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_ProductID",
                schema: "ElectronicsStore",
                table: "OrderProducts",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                schema: "ElectronicsStore",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryID",
                schema: "ElectronicsStore",
                table: "ProductCategories",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProducts",
                schema: "ElectronicsStore");

            migrationBuilder.DropTable(
                name: "ProductCategories",
                schema: "ElectronicsStore");

            migrationBuilder.DropTable(
                name: "Orders",
                schema: "ElectronicsStore");

            migrationBuilder.DropTable(
                name: "Categories",
                schema: "ElectronicsStore");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "ElectronicsStore");

            migrationBuilder.DropTable(
                name: "Customers",
                schema: "ElectronicsStore");
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.Data;

namespace Project.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "64b24732-6f1d-4bb9-9106-7f0ab895005b",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "1"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Project.Identity.Kullanici", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bce014de-5af9-482c-8205-1efe67b88e53",
                            Email = "g181210001@sakarya.edu.tr",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "G181210001@SAKARYA.EDU.TR",
                            NormalizedUserName = "G181210001@SAKARYA.EDU.TR",
                            PasswordHash = "AQAAAAEAACcQAAAAEENeoBYdlYgS+QonoAQloCjneX+9+R6ZbEqH1J2mTNeAGFiBSIGNABmdJ6mLo/RDqA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ec1c87f6-8dee-4cef-bf96-af6b69dd6c98",
                            TwoFactorEnabled = false,
                            UserName = "g181210001@sakarya.edu.tr"
                        });
                });

            modelBuilder.Entity("Project.Models.Favori", b =>
                {
                    b.Property<int>("FavoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FilmID")
                        .HasColumnType("int");

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FavoriID");

                    b.HasIndex("FilmID");

                    b.ToTable("Favori");
                });

            modelBuilder.Entity("Project.Models.Film", b =>
                {
                    b.Property<int>("FilmID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilmAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gelistirici")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GoruntulenmeSayisi")
                        .HasColumnType("int");

                    b.Property<DateTime>("PiyasayaSurulmeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Resim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yayinci")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("filmGosterilsinmi")
                        .HasColumnType("bit");

                    b.HasKey("FilmID");

                    b.ToTable("Film");

                    b.HasData(
                        new
                        {
                            FilmID = 1,
                            Aciklama = "Örümcek-Adam Eve Dönüş Yok, kimliği açığa Örümcek-Adam'ın, sırrını geri vermesi için Doktor Strange'den yardım istemesiyle birlikte yaşananları konu ediyor. Örümcek-Adam'ın kimliği ifşa edilerek onun ve sevdiklerinin hayatı, halkın gözü önüne serilir. Kendisini büyük bir kaosun ortasında bulan Peter, aynı zamanda suç ortakları olarak lanse edilen MJ ve Ned'in hayatının da olumsuz etkilenmesine şahit olur. Arkadaşların üniversiteye girme şanslarının yok olmasına seyirci kalmak istemeyen Peter, sırrını geri vermesi için Doktor Strange'den yardım ister. Peter'ın yakarışından etkilenip ona yardım etmeyi kabul eden Strange, Unutma Büyüsü'nü yapmaya başlar. Ancak bu büyü, MJ, Ned, May ve Happy'nin de Örümcek-Adam'ın kim olduğunu unutmasına neden olacaktır. Arkadaşlarının kim olduğunu hatırlamasını, diğer kişilerin unutmasını isteyen Peter, Strange büyüyü yaparken parametreleri değiştirir. Ancak bu durum beklenmedik olaylara neden olur.",
                            FilmAdi = "Örümcek Adam",
                            Gelistirici = "Marvel Studios",
                            GoruntulenmeSayisi = 100,
                            PiyasayaSurulmeTarihi = new DateTime(2021, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Resim = "orumcekAdam.jpg",
                            Yayinci = "Marvel Studios",
                            filmGosterilsinmi = false
                        },
                        new
                        {
                            FilmID = 12,
                            Aciklama = "Matrix Resurrections”la çifte gerçeklik dünyasına geri dönülüyor. Bay Anderson yeniden beyaz tavşanı izlemeyi seçmek zorunda kalır. Çünkü Anderson gerçekliğinin fiziksel mi yoksa zihinsel bir kurgu mu olduğunu anlayıp, kendisini gerçekten tanımak istemektedir. Thomas’ın...Neo’nun bildiği tek bir şey vardır; o da bir ilüzyon dahi olsa Matrix'e girmenin ve çıkmanın tek yolunun seçimden ibaret oluşudur. Neo ne yapması gerektiğini çok iyi bilse de Matrix'in artık daha güvenli, güçlü ve tehlikeli olduğundan bihaberdir.",
                            FilmAdi = "Matrix Resurrections",
                            Gelistirici = "Lana Wachowski",
                            GoruntulenmeSayisi = 100,
                            PiyasayaSurulmeTarihi = new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Resim = "matrix.jpg",
                            Yayinci = "Lana Wachowski",
                            filmGosterilsinmi = false
                        },
                        new
                        {
                            FilmID = 13,
                            Aciklama = "HBO Max Harrry Potter hayranlarını sevindirecek bir duyuru yaptı. Harry Potter serisinin ilk filmi olan Felsefe Taşı 20. yıl dönümünde serinin yıldızları Daniel Radcliffe, Rupert Grint ve Emma Watson ve yönetmen Chris Columbus bir araya gelerek filmleri ve ürünleri konuşacak. Return to Hogwarts (Hogwarts'a Dönüş) fragmanı serinin hayranları tarafından milyonlarca kez izlendi. Oyuncuların film setinde bir araya geleceği Harry Potter Hogwarts'a Dönüş isimli özel program, yılbaşında HBO Max'te yayınlanacak. Hogwarts'a Dönüş programının mayıs ayında yayınlanan Friends’in ‘Reunion’ tarzında olması bekleniyor. HBO Max tarafından yayınlanacak Hogwarts'a 1 Ocak 2022'de streaming servisinde yayınlanacak. Haryy Potter ve Felsefe Taşı 1 Şubat 2002 tarihinde yayınlandı. HARRY POTTER 2022 HOGWARTS’A DÖNÜŞ KONUSU ?Harry Potter Hogwarts’a Dönüş programı için heyecanlanan dizinin hayranları dizinin konusu hakkında araştırma yapıyor.Harry Potter ‘Reunion’ için henüz detaylı bir bilgi verilmedi.Geçtiğimiz günlerde kısa bir fragman ve ardından da altın üçlünün yer aldığı ilk görsel paylaşılmıştı.Fragmanda bazı oyunculara Hogwarts mektubu gittiğini ve onların da Hogwarts Ekspresi'ne binmek için 9 3/4 numaralı perona gittiklerini görüldü.",
                            FilmAdi = "Harry Potter 20th Anniversary: Return to Hogwarts",
                            Gelistirici = "Warner Bros",
                            GoruntulenmeSayisi = 100,
                            PiyasayaSurulmeTarihi = new DateTime(2021, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Resim = "harrypotter.jpg",
                            Yayinci = " Warner Bros",
                            filmGosterilsinmi = false
                        },
                        new
                        {
                            FilmID = 14,
                            Aciklama = "Film, Kolombiya dağlarının ardına gizlenmiş, Encanto adındaki harikulade ve tılsımlı bir yerde, büyülü bir evde yaşayan sıradışı Madrigal ailesinin hikayesini anlatıyor. Encanto’nun büyüsü sayesinde bu ailenin her bir çocuğu süper güçten tut iyileştirme gücüne kadar eşsiz birer armağana kavuşmuştur – Mirabel hariç. Ancak Encanto'yu çevreleyen büyünün tehlikede olduğunu keşfettiğinde ailenin tek sıradan çocuğu olan Mirabel, olağanüstü ailesinin son umudu olabileceğine karar verir.",
                            FilmAdi = "Enkanto: Sihirli Dünya",
                            Gelistirici = "Walt Disney Animasyon Stüdyoları",
                            GoruntulenmeSayisi = 100,
                            PiyasayaSurulmeTarihi = new DateTime(2021, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Resim = "eskanto.jpg",
                            Yayinci = "Walt Disney Animasyon Stüdyoları",
                            filmGosterilsinmi = false
                        },
                        new
                        {
                            FilmID = 15,
                            Aciklama = "Alita: Savaş Meleği (İngilizce: Alita: Battle Angel), yönetmenliğini Robert Rodriguez'in yaptığı ve senaryosu James Cameron ve Laeta Kalogridis tarafından yazılan 2019 yapımı bir Amerikan cyberpunk aksiyon filmidir. Film, Yukito Kishiro'nin Gunnm adlı manga serisine dayanmakta olup yeni bir bedende uyandıktan sonra hiçbir şeyi hatırlamayan ve kendi geçmişini öğrenmeye karar veren bir siborg kız Alita'yı takip etmektedir. Başlangıçta 2003 yılında duyurulan filmin yapımıyla ilgili yapımcı Cameron'un Avatar ve devam filmi konusundaki çalışmaları nedeniyle art arda ertelendi. Uzun yıllar ertelenen filmin ardından Rodriguez, Nisan 2016'da filmin yönetmeni oldu ve ertesi ay Rosa Salazar filmin başrol oyuncusu seçildi.Filmin çekimleri Ekim 2016 - Şubat 2017 tarihleri arasında Austin'de, çoğunlukla Troublemaker Studios'ta gerçekleştirildi. Alita: Savaş Meleği,  dünya prömiyerini 31 Ocak 2019 tarihinde Odeon Leicester Square'da gerçekleştirdi ve ABD'de 14 Şubat 2019'da 20th Century Fox tarafından Real Real 3D, Dolby Cinema 3D ve IMAX 3D formatlarında yayınlandı. Lightstorm Entertainment'in 2009'daki Avatar'ından bu yana ilk filmi olmasının yanı sıra; 20th Century Fox'un, Walt Disney Company'nin Mart 2019'da hisselerinin çoğunluğunun kontrolünü ele almasından önceki, son filmidir. Film, dünya çapında 404 milyon doların üzerinde hasılat elde etti ve 2019'un en yüksek beşinci en çok hasılat elde eden filmi ve Rodriguez'in bugüne kadar piyasadaki en başarılı filmi oldu. Salazar'ın performansı, aksiyon sahneleri ve görsel efektler için eleştirmenlerden övgüyle karışık eleştiriler aldı, ancak karışık senaryo ve sekanslar dolayı eleştiriler almıştır.",
                            FilmAdi = "Alita: Savaş Meleği",
                            Gelistirici = "James Cameron",
                            GoruntulenmeSayisi = 100,
                            PiyasayaSurulmeTarihi = new DateTime(2021, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Resim = "alitasavasmelegi.jpg",
                            Yayinci = "James Cameron",
                            filmGosterilsinmi = false
                        });
                });

            modelBuilder.Entity("Project.Models.FilmKategorisi", b =>
                {
                    b.Property<int>("FilmID")
                        .HasColumnType("int");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.HasKey("FilmID", "KategoriID");

                    b.HasIndex("KategoriID");

                    b.ToTable("FilmKategorisi");

                    b.HasData(
                        new
                        {
                            FilmID = 1,
                            KategoriID = 1
                        },
                        new
                        {
                            FilmID = 14,
                            KategoriID = 2
                        },
                        new
                        {
                            FilmID = 15,
                            KategoriID = 3
                        },
                        new
                        {
                            FilmID = 12,
                            KategoriID = 4
                        },
                        new
                        {
                            FilmID = 13,
                            KategoriID = 3
                        });
                });

            modelBuilder.Entity("Project.Models.Haber", b =>
                {
                    b.Property<int>("HaberID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HaberBaslik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HaberIcerik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HaberResim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("haberGosterilsinmi")
                        .HasColumnType("bit");

                    b.HasKey("HaberID");

                    b.ToTable("Haber");

                    b.HasData(
                        new
                        {
                            HaberID = 1,
                            HaberBaslik = "Örümcek Adam eve geri dönüş yok filmi vizyona girdi!",
                            HaberIcerik = "Örümcek-Adam: Eve Dönüş Yok Columbia Pictures ve Marvel Studios tarafından ortaklaşa üretilen ve Sony Pictures tarafından dağıtılan, Marvel Comics karakteri Örümcek Adam çizgi romanlarından uyarlanan ABD süper kahraman filmidir.",
                            HaberResim = "orumcekAdam.jpg",
                            haberGosterilsinmi = false
                        },
                        new
                        {
                            HaberID = 2,
                            HaberBaslik = "Matrix Resurrections filmi vizyona girdi!",
                            HaberIcerik = "Matrix Resurrections”la çifte gerçeklik dünyasına geri dönülüyor. Bay Anderson yeniden beyaz tavşanı izlemeyi seçmek zorunda kalır. Çünkü Anderson gerçekliğinin fiziksel mi yoksa zihinsel bir kurgu mu olduğunu anlayıp, kendisini gerçekten tanımak istemektedir. Thomas’ın...Neo’nun bildiği tek bir şey vardır; o da bir ilüzyon dahi olsa Matrix'e girmenin ve çıkmanın tek yolunun seçimden ibaret oluşudur. Neo ne yapması gerektiğini çok iyi bilse de Matrix'in artık daha güvenli, güçlü ve tehlikeli olduğundan bihaberdir.",
                            HaberResim = "matrix.jpg",
                            haberGosterilsinmi = false
                        },
                        new
                        {
                            HaberID = 3,
                            HaberBaslik = "Harry Potter 20th Anniversary: Return to Hogwarts filmi çok yakında sevenleriyle buluşacak!",
                            HaberIcerik = "HBO Max Harrry Potter hayranlarını sevindirecek bir duyuru yaptı. Harry Potter serisinin ilk filmi olan Felsefe Taşı 20. yıl dönümünde serinin yıldızları Daniel Radcliffe, Rupert Grint ve Emma Watson ve yönetmen Chris Columbus bir araya gelerek filmleri ve ürünleri konuşacak. Return to Hogwarts (Hogwarts'a Dönüş) fragmanı serinin hayranları tarafından milyonlarca kez izlendi. Oyuncuların film setinde bir araya geleceği Harry Potter Hogwarts'a Dönüş isimli özel program, yılbaşında HBO Max'te yayınlanacak. Hogwarts'a Dönüş programının mayıs ayında yayınlanan Friends’in ‘Reunion’ tarzında olması bekleniyor. HBO Max tarafından yayınlanacak Hogwarts'a 1 Ocak 2022'de streaming servisinde yayınlanacak. Haryy Potter ve Felsefe Taşı 1 Şubat 2002 tarihinde yayınlandı. HARRY POTTER 2022 HOGWARTS’A DÖNÜŞ KONUSU ?Harry Potter Hogwarts’a Dönüş programı için heyecanlanan dizinin hayranları dizinin konusu hakkında araştırma yapıyor.Harry Potter ‘Reunion’ için henüz detaylı bir bilgi verilmedi.Geçtiğimiz günlerde kısa bir fragman ve ardından da altın üçlünün yer aldığı ilk görsel paylaşılmıştı.Fragmanda bazı oyunculara Hogwarts mektubu gittiğini ve onların da Hogwarts Ekspresi'ne binmek için 9 3/4 numaralı perona gittiklerini görüldü.",
                            HaberResim = "harrypotter.jpg",
                            haberGosterilsinmi = false
                        },
                        new
                        {
                            HaberID = 4,
                            HaberBaslik = "Enkanto: Sihirli Dünya animasyonu animasyon severlerin dört gözle beklediği an geldi!",
                            HaberIcerik = "Film, Kolombiya dağlarının ardına gizlenmiş, Encanto adındaki harikulade ve tılsımlı bir yerde, büyülü bir evde yaşayan sıradışı Madrigal ailesinin hikayesini anlatıyor. Encanto’nun büyüsü sayesinde bu ailenin her bir çocuğu süper güçten tut iyileştirme gücüne kadar eşsiz birer armağana kavuşmuştur – Mirabel hariç. Ancak Encanto'yu çevreleyen büyünün tehlikede olduğunu keşfettiğinde ailenin tek sıradan çocuğu olan Mirabel, olağanüstü ailesinin son umudu olabileceğine karar verir.",
                            HaberResim = "eskanto.jpg",
                            haberGosterilsinmi = false
                        },
                        new
                        {
                            HaberID = 5,
                            HaberBaslik = "Alita: Savaş Meleği filmi vizyona girdi! Tüm sinemalarda biletler tükendi!",
                            HaberIcerik = "Alita: Savaş Meleği (İngilizce: Alita: Battle Angel), yönetmenliğini Robert Rodriguez'in yaptığı ve senaryosu James Cameron ve Laeta Kalogridis tarafından yazılan 2019 yapımı bir Amerikan cyberpunk aksiyon filmidir. Film, Yukito Kishiro'nin Gunnm adlı manga serisine dayanmakta olup yeni bir bedende uyandıktan sonra hiçbir şeyi hatırlamayan ve kendi geçmişini öğrenmeye karar veren bir siborg kız Alita'yı takip etmektedir. Başlangıçta 2003 yılında duyurulan filmin yapımıyla ilgili yapımcı Cameron'un Avatar ve devam filmi konusundaki çalışmaları nedeniyle art arda ertelendi. Uzun yıllar ertelenen filmin ardından Rodriguez, Nisan 2016'da filmin yönetmeni oldu ve ertesi ay Rosa Salazar filmin başrol oyuncusu seçildi.Filmin çekimleri Ekim 2016 - Şubat 2017 tarihleri arasında Austin'de, çoğunlukla Troublemaker Studios'ta gerçekleştirildi. Alita: Savaş Meleği,  dünya prömiyerini 31 Ocak 2019 tarihinde Odeon Leicester Square'da gerçekleştirdi ve ABD'de 14 Şubat 2019'da 20th Century Fox tarafından Real Real 3D, Dolby Cinema 3D ve IMAX 3D formatlarında yayınlandı. Lightstorm Entertainment'in 2009'daki Avatar'ından bu yana ilk filmi olmasının yanı sıra; 20th Century Fox'un, Walt Disney Company'nin Mart 2019'da hisselerinin çoğunluğunun kontrolünü ele almasından önceki, son filmidir. Film, dünya çapında 404 milyon doların üzerinde hasılat elde etti ve 2019'un en yüksek beşinci en çok hasılat elde eden filmi ve Rodriguez'in bugüne kadar piyasadaki en başarılı filmi oldu. Salazar'ın performansı, aksiyon sahneleri ve görsel efektler için eleştirmenlerden övgüyle karışık eleştiriler aldı, ancak karışık senaryo ve sekanslar dolayı eleştiriler almıştır.",
                            HaberResim = "alitasavasmelegi.jpg",
                            haberGosterilsinmi = false
                        });
                });

            modelBuilder.Entity("Project.Models.Kategori", b =>
                {
                    b.Property<int>("KategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KategoriAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategoriID");

                    b.ToTable("Kategori");

                    b.HasData(
                        new
                        {
                            KategoriID = 1,
                            KategoriAdi = "Aksiyon"
                        },
                        new
                        {
                            KategoriID = 2,
                            KategoriAdi = "Animasyon"
                        },
                        new
                        {
                            KategoriID = 3,
                            KategoriAdi = "Bilim Kurgu"
                        },
                        new
                        {
                            KategoriID = 4,
                            KategoriAdi = "Fantastik"
                        });
                });

            modelBuilder.Entity("Project.Models.Yorum", b =>
                {
                    b.Property<int>("YorumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FilmID")
                        .HasColumnType("int");

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OlusturulmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("YapilanYorum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YorumID");

                    b.HasIndex("FilmID");

                    b.ToTable("Yorum");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Project.Identity.Kullanici", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Project.Identity.Kullanici", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.Identity.Kullanici", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Project.Identity.Kullanici", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Project.Models.Favori", b =>
                {
                    b.HasOne("Project.Models.Film", "Film")
                        .WithMany()
                        .HasForeignKey("FilmID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Film");
                });

            modelBuilder.Entity("Project.Models.FilmKategorisi", b =>
                {
                    b.HasOne("Project.Models.Film", "Film")
                        .WithMany("FilmKategorileri")
                        .HasForeignKey("FilmID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.Models.Kategori", "Kategori")
                        .WithMany("FilmKategorileri")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Film");

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("Project.Models.Yorum", b =>
                {
                    b.HasOne("Project.Models.Film", "Film")
                        .WithMany("Yorumlar")
                        .HasForeignKey("FilmID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Film");
                });

            modelBuilder.Entity("Project.Models.Film", b =>
                {
                    b.Navigation("FilmKategorileri");

                    b.Navigation("Yorumlar");
                });

            modelBuilder.Entity("Project.Models.Kategori", b =>
                {
                    b.Navigation("FilmKategorileri");
                });
#pragma warning restore 612, 618
        }
    }
}

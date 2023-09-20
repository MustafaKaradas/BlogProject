﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogProject.DAL.Migrations.AppDb
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(name: "Category Name", type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    NumberOfLikes = table.Column<int>(type: "int", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Category Name", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImagePath", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, "İstatistik", "Admin", new DateTime(2023, 9, 2, 14, 57, 45, 534, DateTimeKind.Local).AddTicks(38), null, null, "\\images\\category\\istatistik.jpg", false, null, null },
                    { 2, "Teknoloji", "Admin", new DateTime(2023, 9, 2, 14, 57, 45, 534, DateTimeKind.Local).AddTicks(40), null, null, "\\images\\category\\teknoloji.jpg", false, null, null },
                    { 3, "Hukuk", "Admin", new DateTime(2023, 9, 2, 14, 57, 45, 534, DateTimeKind.Local).AddTicks(42), null, null, "\\images\\category\\hukuk.jpg", false, null, null },
                    { 4, "Felsefe", "Admin", new DateTime(2023, 9, 2, 14, 57, 45, 534, DateTimeKind.Local).AddTicks(44), null, null, "\\images\\category\\felsefe.jpg", false, null, null },
                    { 5, "Spor", "Admin", new DateTime(2023, 9, 2, 14, 57, 45, 534, DateTimeKind.Local).AddTicks(46), null, null, "\\images\\category\\spor.jpg", false, null, null },
                    { 6, "Psikoloji", "Admin", new DateTime(2023, 9, 2, 14, 57, 45, 534, DateTimeKind.Local).AddTicks(48), null, null, "\\images\\category\\psikoloji.jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImagePath", "IsDeleted", "ModifiedBy", "ModifiedDate", "NumberOfLikes", "Title", "UserId", "UserName" },
                values: new object[,]
                {
                    { 1, 1, "İstatistik bir sanattır. Farklı istatistikçiler, aynı veri ile farklı sonuçlara varabilirler. Sunulan veride, çoğu kez var olan istatistiksel araçlarla elde edilebilecek olandan daha çok bilgi bulunabilir. İstatistikçinin deneyimi burada önem kazanır. Bu durum istatistiği sanat yapar.İstatistiksel yöntemler, bireysel ve kurumsal çabaların etkinliğini maksimuma ulaştırmada ve belirsizliği azaltarak kabul edilebilir düzeye getirmede kullanılır. Böylece daha geniş anlamda, istatistik özünde disiplinler arası bir bilim dalıdır. İstatistik, İngiltere’de 1834 yılında İstatistik Derneğinin kurulmasından sonra bir bilim dalı olarak kabul edildi ve insanlarla ilgili olguları uygun bir şekilde göstermek için sayılarla ifade edilebilen genel kurallar olarak düşünüldü. Böylece daha önceleri veri anlamında kullanılan istatistik sözcüğü, veriyi yorumlama ve kaynağı ne olursa olsun veriden sonuç çıkarma anlamını kazanmaya başladı.", "Admin", new DateTime(2023, 9, 2, 14, 57, 45, 533, DateTimeKind.Local).AddTicks(9224), null, null, "\\images\\article\\istmakaleresim1.jpg", false, null, null, 1, "İstatistik Dünyasında Olanlar", 1, "Mustafa" },
                    { 2, 1, "Her bilim bilgi üretir ama her bilgi bilimsel değildir (Güvenç, 1994).\r\nHempel, Reischer ve Yıldırım‟a göre, “her bilim dalı ya da disiplini geçerli ve\r\ngüvenilir (doğruluğu irdelenebilir, kanıtlanabilir) bilgi üretmeye çalışır. Ama her\r\ngeçerli ve güvenilir bilgi, bilimsel olmayabilir. Bilimsel bilgiyi diğer bilgi\r\ntürlerinden ayıran ölçüt, metot veya yöntem (bilginin nasıl/ hangi yoldan elde\r\nedildiği) bilgisidir” (Akt. Güvenç, 1994). “Araştırmanın değerini ve güvenirliğini\r\nazaltan her türlü girişim ise, bilimsel yanıltma (scientific misconduct) olarak ifade\r\nedilmektedir. Araştırmacı araştırma planlamasını, uygun yöntem seçimini,\r\nyöntemlerin uygulanmasını, sonuçların analizini ve yorumunu bilmediği için\r\nfarkında olmaksızın güvenilir olamayan bilgiler üretebilir. Disiplinsiz araştırma\r\n(sloopy research) olarak adlandırılan böyle durumlarda araştırmacılara araştırma\r\neğitimi verilerek, araştırma disiplini öğretilebilir ve böylece bu türdeki bilimsel\r\nyanıltmalar düzeltilerek araştırmacılar bilime kazandırılabilirler” (Kansu, 1994).\r\nAncak öncelikle bu durumun saptanması ve eksikliklerin belirlenmesi\r\ngerekmektedir. Oğuz (1999) günümüzde her bilim insanının bilimsel çalışmaların\r\ndenetlenmesinde sorumluluk taşıması, ilgi alanına giren konularda yayınları\r\nizlemesi, ortaya konulan bilim dışı savlara ya da çalışmalara ilişkin yanlışlıkları\r\nsaptayacak biçimde özenle incelemesi ve bu tür saptamaları bilimsel yayın\r\nortamında ortaya koyması gerektiğini ifade etmektedir. ", "Admin", new DateTime(2023, 9, 2, 14, 57, 45, 533, DateTimeKind.Local).AddTicks(9227), null, null, "\\images\\article\\istmakaleresim2.jpg", false, null, null, 1, "Yeni Gelişimler ve İstatistik", 1, "Mustafa" },
                    { 3, 2, "Projenin 1994-1996 yılları arasındaki birinci aşamasında öncelikle mühendislik, matematik, fen, beşeri ve eğitim bilimlerinden ve hükümet, meslek kuruluşları ve\r\nsanayiden temsilcilerin oluşturduğu 25 kişilik bir komisyon tarafından teknoloji eğitimin mantığı ve yapısını (yol haritası) belirlenmiştir. Hazırlanan taslak planın yaklaşık 500 uzman tarafından gözden geçirilmesinin ve birçok çalıştayda uzmanlar tarafından incelenmesinin ardından son halini almıştır. Projenin birinci aşamasında hazırlanan Tüm Amerikalılar için Teknoloji: Teknoloji Eğitiminin Temel Mantığı ve Yapısı başlıklı\r\nraporda anaokulundan lise son sınıfa kadar tüm öğrencilerin teknoloji okuryazarlık\r\ndüzeylerini geliştirmek için gerekli içeriğin seçilmesinde ve düzenlenmesinde işe\r\nkoşulacak teknolojinin evrensel özellikleri sunulmuştur. Teknoloji öğretim programlarının içeriğini oluşturacak olan teknolojinin evrensel 10 özelliği 3 ana başlık altında\r\nşu şekilde toplanmıştır ", "User", new DateTime(2023, 9, 2, 14, 57, 45, 533, DateTimeKind.Local).AddTicks(9229), null, null, "\\images\\article\\teknomakale1.jpg", false, null, null, 2, "Günümüzde Teknoloji", 2, "Furkan" },
                    { 4, 2, "Daha teknik bir tanım yapmak gerekirse, Teknoloji Eğitimi, bireylere teknoloji\r\nve teknolojinin etkilerini anlama, tanıma ve kullanma yeterlilikleri kazandıran, öğretim süreçlerinde gözlem yapma, tasarlama, sayısal sonuçlar çıkarma ve grafik hazırlama gibi etkinliklere yer veren, teknik resim dilini anlama ve kullanma yeterlikleri\r\nkazandıran, okul-çevre bütünlüğünü güçlendiren, Matematik, Fen Bilgisi, Resim-İş\r\nve Türkçe gibi derslerden faydalanmayı sağlayan bir bilim dalıdır (Karaağaçlı ve\r\nMahiroğlu, 2005). Teknoloji eğitimi kavramının kökenlerinin çok yeni olduğu söylenemez. 1980’lerde gerek içerik gerekse isim açısından endüstriyel sanat eğitiminin\r\nyerini yavaş yavaş teknoloji eğitimine bıraktığı söylenebilir. 1990’lara gelindiğinde\r\nteknoloji eğitiminin fen ve mühendislik alanlarıyla olan bağları giderek kuvvetlenmiş\r\nve özellikle ilgili meslek grupları teknoloji eğitimiyle ilgili yeni standartlar geliştirmeye koyulmuştur. Ayrıca geçmişte endüstriyel alanların genel eğitim içerisindeki\r\nönemine kıyasla bugün gerek öğretim teknolojileri gerekse sanal öğrenme teknolojisi\r\nbakımından teknoloji eğitiminin genel eğitim-öğretim içerisinde daha yaygın bir yeri\r\nolduğunu söyleyebiliriz (Pannapecker, 2004).\r\nBilgi çağında teknoloji eğitiminin özellikle bilişim teknolojilerinin öğretimine\r\nodaklanması kaçınılmaz olmuştur.", "User", new DateTime(2023, 9, 2, 14, 57, 45, 533, DateTimeKind.Local).AddTicks(9316), null, null, "\\images\\article\\teknomakale2.jpg", false, null, null, 2, "Her şey Teknoloji Artık", 2, "Furkan" },
                    { 5, 3, "Kararın temyiz incelemesini yapan Yargıtay 12. Ceza Dairesi ise mahkemenin kararını bozdu. Kararda sanığın, internette Facebook hesabındaki herkese açık profil resmini kopyalayarak rıza olmaksızın kendi Facebook hesabına koyduğu belirtilerek şöyle denildi:\r\n“Sanık tarafından, katılanın (şikâyetçinin) sürekli takip, denetim ve gözetim altına alınması sonucu elde edilmiş özel hayatın gizliliğini ihlale yol açacak bir görüntü yoktur. Katılanın, Facebook’taki profil resmi, katılanın başkalarınca görülmesi ve bilinmesini istemediği, hukuk tarafından gizliliği ve korunması temel bir şahsiyet hakkı kabul edilmiş özel yaşam alanına ilişkin görüntü olarak değerlendirilemez. Atılı özel hayatın gizliliğini ihlal suçunun yasal unsurları itibarıyla oluşmamıştır. Türk Ceza Kanunu’nun 136. maddesindeki verileri hukuka aykırı olarak verme veya ele geçirme suçu yönünden değerlendirme yapıldığında ise katılanın Facebook hesabındaki resmi kişisel veri kapsamında kabul edilebilir ise de; sanığın, resmi, katılanın internette Facebook hesabındaki herkese açık profil resminden elde etmesi ve katılana ait başkaca bir kişisel bilgiye yer vermeden kendi Facebook hesabına koyması nedeniyle hukuka aykırı olarak ele geçirme ve yaymadan da söz edilemeyeceğinden, beraatı yerine yazılı düşüncelerle mahkûmiyetine karar verilmesi kanuna aykırıdır.”", "Admin", new DateTime(2023, 9, 2, 14, 57, 45, 533, DateTimeKind.Local).AddTicks(9319), null, null, "\\images\\article\\hukukmakale1.jpg", false, null, null, 3, "Hukukta Kaybolmak", 1, "Mustafa" },
                    { 6, 3, "10 Aralık 1948\r\nBirleşmiş Milletler Genel Kurulu'nun 10 Aralık 1948 tarih ve 217 A(III) sayılı Kararıyla ilan edilmiştir.\r\n\r\n6 Nisan 1949 tarih ve 9119 Sayılı Bakanlar Kurulu ile \"İnsan Hakları Evrensel Beyannamesi'nin Resmi Gazete ile yayınlanması yayımdan sonra okullarda ve diğer eğitim müesseselerinde okutulması ve yorumlanması ve bu Beyanname hakkında radyo ve gazetelerde münasip neşriyatta bulunulması\" kararlaştırılmıştır.Bakanlar Kurulu Kararı 27 Mayıs 1949 tarih ve 7217 Sayılı Resmi Gazete'de yayınlanmıştır.\r\n\r\nBirleşmiş Milletler Genel Kurulu; İnsanlık topluluğunun bütün bireyleriyle kuruluşlarının bu Bildirgeyi her zaman göz önünde tutarak eğitim ve öğretim yoluyla bu hak ve özgürlüklere saygıyı geliştirmeye, giderek artan ulusal ve uluslararası önlemlerle gerek üye devletlerin halkları ve gerekse bu devletlerin yönetimi altındaki ülkeler halkları arasında bu hakların dünyaca etkin olarak tanınmasını ve uygulanmasını sağlamaya çaba göstermeleri amacıyla tüm halklar ve uluslar için ortak ideal ölçüleri belirleyen bu İnsan Hakları Evrensel Bildirgesini ilan eder.\r\n\r\nMadde 1- Bütün insanlar özgür, onur ve haklar bakımından eşit doğarlar. Akıl ve vicdana sahiptirler, birbirlerine karşı kardeşlik anlayışıyla davranmalıdırlar.\r\n\r\nMadde 2- Herkes, ırk, renk, cinsiyet, dil, din, siyasal veya başka bir görüş, ulusal veya sosyal köken, mülkiyet, doğuş veya herhangi başka bir ayrım gözetmeksizin bu Bildirge ile ilan olunan bütün haklardan ve bütün özgürlüklerden yararlanabilir. Ayrıca, ister bağımsız olsun, ister vesayet altında veya özerk olmayan ya da başka bir egemenlik kısıtlamasına bağlı ülke yurttaşı olsun, bir kimse hakkında, uyruğunda bulunduğu devlet veya ülkenin siyasal, hukuksal veya uluslararası statüsü bakımından hiçbir ayrım gözetilmeyecektir.\r\n\r\nMadde 3 -Yaşamak, özgürlük ve kişi güvenliği herkesin hakkıdır.", "Admin", new DateTime(2023, 9, 2, 14, 57, 45, 533, DateTimeKind.Local).AddTicks(9322), null, null, "\\images\\article\\hukukmakale2.jpg", false, null, null, 3, "Hukuk Evrensel Beyanname", 1, "Mustafa" },
                    { 7, 4, "Postmodernizm kaynağı ne olursa olsun ( bu kaynak “sanayi sonrası” toplum, modernliğin en sonunda güvenilirliğini yitirmesi, kültürün metalaşması, canlı yeni politik güçlerin ortaya çıkması, toplum ve özne konusundaki belli klasik ideolojilerin çökmesi vb. olabilir), aynı zamanda ve esasen ya unutulmaya terk ettiği ya da gölgesiyle kapışmaya asla son vermediği bir politik fiyaskonun ürünüdür. Postmodernistlerin bu önermeyi alkışlar eşliğinde kabul etmelerini beklememek gerekir. Kendilerinin tarihsel bir fiyaskonun sonucu olduğunun bildirilmesinden hiç kimse hoşlanmaz. Bir kere, yeri geldiğinde tam tersini belirten itirazlar ne olursa olsun, postmodernizmin büyük bir bölümü, yüksek modernizmin kendisine kadar uzanır ki, bu da onu sırf 1960 sonrası bir fenomen olmaktan çıkaran bir şecereyle (hayat ağacı) donatır. Postmodernizm punc rock’tan öte anlatıların ölümüne ve oradan Foucault hayranlarına kadar her şeyi kapsıyorsa eğer, tek başına herhangi bir açıklayıcı şemanın, bunun gibi tuhaflık derecesinde heterojen bir kendiliğin hakkını nasıl olup da verebileceğini anlamak zor. Bu mahluk bu denli çeşitlilik arz ediyorsa, nasıl olur da Peru’dan yana ya da Peru karşıtı olabileceğimizden daha fazla postmodernizm yanlısı ya da karşıtı olabiliriz ki?", "User", new DateTime(2023, 9, 2, 14, 57, 45, 533, DateTimeKind.Local).AddTicks(9324), null, null, "\\images\\article\\felsefemakale1.jpg", false, null, null, 10, "Hayata Felsefi Yaklaşım", 2, "Furkan" },
                    { 8, 4, "Uygarlık ile felsefe birbirine dayanan, dahası biribirini içeren iki oluşumdur. Öyle ki,felsefeye yabancı bir uygarlıktan kolayca söz edilemeyeceği gibi, genel etkinlik alanında uygarlık, değer ve sorunlarına doğrudan ya da dolaylı yer vermeyen bir felsefe de düşünülemez. Bunun tarihteki iki çarpıcı örneğini Antik Grek dönemi ile Rönesans sonrası Batı dünyasında bulmaktayız.   Bu bildirinin amacı uygarlaşma sürecinde felsefenin önemini belirtmek, özellikle eğiim bağlamında yüklenmesi gereken işlevine açıklık getirmektir. Ama konuya girmeden önce uygarlıktan ne anladığımızı kısaca ortaya koymakta yarar görmekteyiz.Uygarlık doğal bir olay ya da oluşum değildir; toplumsal yaşamımızın bir ürünüdür.       İnsan uygar olarak doğmaz, belli kültürel koşullar içinde uygarlaşır.", "User", new DateTime(2023, 9, 2, 14, 57, 45, 533, DateTimeKind.Local).AddTicks(9326), null, null, "\\images\\article\\felsefemakale2.jpg", false, null, null, 10, "Uygarlık Açısından Felsefenin İşlevi", 2, "Furkan" },
                    { 9, 5, "OBEZİTENİN KOMPLİKASYONLARI\r\nİnsan vücudunda aşırı kilodan etkilenmeyen neredeyse hiçbir sistem\r\nbulunmamaktadır (Esmer, 2018). Obezite; koroner arter hastalığı (KAH),\r\nTip 2 diyabet, kalp hastalıkları, hipertansiyon, mellitus, inme, dislipidemi,\r\nbelirli tipte kanserler (meme, kolon, prostat vb.), uyku apnesi ve solunum\r\nbozuklukları, safra kesesi hastalıkları, fertilitede azalma, osteoartrit gibi\r\nhastalıklar ile tüm nedenlere bağlı mortalitede artış, duygusal gerginlik ve\r\ntoplum tarafından dışlanma gibi çeşitli fiziksel ve psikolojik komplikasyonlara yol açabilmektedir (Kokino ve diğ ., 2004; Baltacı, 2008).\r\nObezitenin Risk Faktörleri\r\nObezitede tedaviye başlamadan önce hastalara, obezitenin risk faktörleri hakkında bilgi verilmelidir (Baltacı, 2008). Obezlerde morbidite ve\r\nmortalite riskini arttıran faktörleri mevuttur. Bu yüksek risk faktörleri arasında; koroner arter hastalığı, uyku apnesi ve Tip 2 diabetes mellitus sıralayabiliriz. Diğer risk faktörleri ise; erkeklerde 45 yaş üzeri hipertansiyon,\r\nosteoartrit, yüksek açlık kan şekeri, DHL<35 mg olması, LDL>160 mg\r\nolması, fiziksel inaktivite, beslenme alışkanlıkları erken koroner hastalık,\r\nstres inkontinans, safra taşları, yaş, cinsiyet, doğum sayısı, genetik ve sigara içimi oluşturmaktadır (Baltacı, 2008; Altunkaynak ve Özbek 2006)", "Admin", new DateTime(2023, 9, 2, 14, 57, 45, 533, DateTimeKind.Local).AddTicks(9328), null, null, "\\images\\article\\spormakale1.jpg", false, null, null, 5, "Sporda Sağlık ve Obezite", 1, "Mustafa" },
                    { 10, 5, "Sürat performansın temel özelliklerinden biri olup, hareket ve reaksiyon sürati gibi çok kompleks özellikler içerir.\r\nSüratte pratik teknikler ve koordinasyon gelişimi nedeniyle önemli sayılabilir nitelikte gelişim, doğuştan gelen özelliklere bağlı olmasına rağmen sağlanabilir. Sürat futbol da, bedensel, algısal beceri, teknik ve taktiksel beceri faktörleri tamamladığı zamanda tanımlanır (Ekblom 1986).\r\nSporda verimin artmasını sağlayan önemli motorsal özelliklerden biri\r\nde sürattir. Fakat diğer motorsal özelliklerle kıyaslanırsa değiştirilmesi\r\nen sıkıntılı olan yetenektir (Sevim1995, Bompa 1998). Antrenman bilimi\r\naçısından bakıldığında ise sürat; vücudun belirli bölümünü yada vücudu\r\ntamamen yüksek hızlarda hareket ettirebilme özelliği olarak tanımlanır\r\n(Sevim 1991).\r\nSürat kas sistemiyle sinir sisteminin bir araya gelerek ortaya koyduğu\r\nbir ürün olarak isimlendirilir. Yapılan bir hareketin sürati temelde iskelet,\r\nkas ve sinir sistemiyle ilişkilidir. Hareket uyaranı ile bunun kesilmesi ara-\r\nDoç. Dr. Özgür DİNÇER • Yük. Lis. Öğr. Zübeyde ÇAKIR • 85\r\nsında ki hızlı değişimin, kas ve sinir sisteminin uygun bir şekilde düzenlenmesi yüksek bir hareket frekansını meydana getirir. Bu hareketler ancak\r\noptimal bir kuvvet uygulaması ile gerçekleşir", "User", new DateTime(2023, 9, 2, 14, 57, 45, 533, DateTimeKind.Local).AddTicks(9330), null, null, "\\images\\article\\spormakale2.jpg", false, null, null, 5, "Sporcu Dayanıklılığı ve Performans", 2, "Furkan" },
                    { 11, 6, "Çocuklar düşünüldüğünde, henüz kişilik yapıları oturmamış, davranış ve düşüncelerinde aile ve sosyal çevreleri ile arkadaşlarının büyük etkileri olan, etkiye ve değişime yetişkinlere göre daha açık ve tabi ki de öğrenme hızları ve becerileri yüksek varlıklar akla gelmelidir.\r\n\r\nBütün çocuk gelişim bilimcilerinin ortak olarak birleştikleri nokta, çocuklarının tutum ve davranışlarında ailelerinin büyük etkisi olduğudur. Genetik ve çevresel faktörler olarak ikiye ayırıp incelediğimiz etkin faktörlerin genetik kaynağı tamamen aile iken, yine çevresel faktörlerin büyük bir bölümünü de oluşturduğu söylenmelidir.Okul çağı başlayan ve özellikle ilköğretime gelen çocuklar, ilk üç yılda çok daha etkin olmak üzere aile tutumları ve yetiştirme tarzları ile şekillenip; daha sonra da sosyalleşme ve kişisel disiplinin temel kurallarını öğrenerek bu kuruma katılmıştır. Bu süreç içinde, ailenin uyguladığı eğitim ve yetiştirme tutumları çerçevesinde çocukta belirli davranış kalıpları ve düşünce şekilleri belirlenmiş olup, okul hayatında bu temel yapıların geliştirilmesi ve uyumlu hale getirilerek, gelecek yaşantılarında kullanılabilir bir şekle dönüştürülmesi hedeflenmektedir.", "User", new DateTime(2023, 9, 2, 14, 57, 45, 533, DateTimeKind.Local).AddTicks(9332), null, null, "\\images\\article\\psikomakale1.jpg", false, null, null, 8, "Ödevini Yapmadan Okula Gelen Çocuğa Nasıl Davranılmalı", 2, "Furkan" },
                    { 12, 6, "– Yine ağırlık kaldırarak yapabileceğiniz kuvvet antremanları, farklı davranışlardan seçebileceğiniz hareketler de bedensel egzersizler içinde yer alır.\r\n– Sinirli ve öfkeli olduğunuz zamanlarda, öfkenizi bir başka objeye (örneğin, yastığı yumruklamak, bir resme bağırıp çağırmak, hayali objesine bağırmak) çevirerek rahatlayabilirsiniz.\r\n– Geçmişi analiz ederek, şu ana kadar yapmak isteyip de, korkup yada çekinip yapamadığınız şeyleri bir düşünün. Sizleri bundan alıkoyan ne idi? Bundan sonraki davranışlarınızı bu sonuca göre yönlendirmemeniz gerekir.\r\n– Yeni bir şey yapmak, genellikle olaylara yeni bir bakış açısı geliştirmenizi gerektirir. Genellikle insanlar belirli bir kalıba yapışır kalır, onun dışına çıkamazlar. Bu sabit bir bakış açısı ve değişime karşı direnç demektir.\r\n– Eskiden yapmak isteyip de, korktuğunuz yada çekindiğiniz için yapmadığınız şeyleri yapabildiğinizde (örneğin, bisiklete ilk defa binmeye çalıştığınızda veya araba kullanmayı öğrenirken) herhangi bir şekilde her yapışınızda, bunun sizi derin ve içsel olarak doyurduğunu hissedersiniz. Çünkü mücadele etmekle tanışmış, başarı hissini tatmışsınızdır ve bu da sizi mutlu etmiştir.\r\n– İçinizdeki cesur ben’i yüceltin ve sesini daha fazla açın.\r\n– Düşünceler zinciri ile panik duygularını tırmandırabilir veya onların önemini azaltabilirsiniz. Bu düşüncelerimizi nasıl yönlendirdiğinize bağlıdır.\r\n– Kendinizle konuşurken, seçtiğiniz kelimelere dikkat edin. Kati, olumsuz ve sert kelimeler (ben bir işe yaramam, bu mümkün değil, bunu asla yapamam, kendimi berbat hissediyorum vb.) yerine; daha esnek ve ılımlı hatta olumlu kelimeler seçmeye çalışın (benim için zor olacak, ne kadar heyecanlandım, vb.).\r\n– Kendinize sihirli ve rahatlatıcı kelimeler seçip, bunları zihinsel olarak anlamlandırmalısınız (ben iyiyim, yapabilirim, hayatım harika gidiyor, iyi şeylerle karşılaşacağım, güzel şeyler olacak, vb.).\r\n– Bir şeye inanırmış gibi davranmanız bile, sizde bir etki oluşturur. O halde yapmak istediğiniz imge oluşturun. Cesaretliymiş gibi, korkmuyormuş gibi hayal edin, olmak istediğiniz gibi davranmayı düşünün.\r\n– Bu durumda korkuyu bastırmıyor veya karşılaşmayı reddetmiyorsunuz. Tam tersine bir korkunuz olduğu gerçeği ile yüzleşiyor, bunu kabul ediyorsunuz. (Korkak davranırsanız, korkunuz büyük olasılıkla yoğunlaşacak; cesaret gösterirseniz bu size güç verecek ve hayatınızdaki önemini azaltacak).\r\n– Bir şeyden vazgeçmek istediğinizde yada korktuğunuz bir şeyden kaçındığınızda, aslında sadece korkunuzu daha çok pekiştiriyor ve büyütüyorsunuz. Tam tersine eğer üstüne üstüne giderseniz, daha fazla yapmaya çalışırsanız, büyük olasılıkla problemi ve sorunu azaltacaktır. Örneğin; yutkunma sorunu olan kişiye, yemeği yutmamaya çalışarak çiğnemesi söylendiğinde, yutmayı başaracaktır. Veya bayılmaktan korkan birine, hemen ayağa kalkıp bayılması istendiğinde, bunun olmadığını görebilirsiniz. Hatta biraz da mizah katarak, ‘hadi bakalım ne kadar iyi bayılabileceksin’ şeklinde alaya da alınabilir.", "Admin", new DateTime(2023, 9, 2, 14, 57, 45, 533, DateTimeKind.Local).AddTicks(9335), null, null, "\\images\\article\\psikomakale2.jpg", false, null, null, 8, "Panik Atak Analizi", 1, "Mustafa" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

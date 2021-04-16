-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Anamakine: localhost
-- Üretim Zamanı: 14 Nis 2021, 21:56:28
-- Sunucu sürümü: 10.4.17-MariaDB
-- PHP Sürümü: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `kelimeoyunu`
--
CREATE DATABASE IF NOT EXISTS `kelimeoyunu` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `kelimeoyunu`;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sorular`
--

CREATE TABLE `sorular` (
  `id` int(11) NOT NULL,
  `soru` varchar(500) NOT NULL,
  `cevap` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `sorular`
--

INSERT INTO `sorular` (`id`, `soru`, `cevap`) VALUES
(2, 'Bakıma ve barınmaya muhtaç bir grup insanın oturduğu, yetiştirildiği veya bakıldığı kurum', 'Yurt'),
(3, 'Akdenize özgü, Deniz kıyısında bile yetişebilen bir ağaç', 'Ilgın'),
(4, 'Bir desimetreküp hacmindeki ölçü birimi', 'Litre'),
(5, 'Gönlü değişken, aşkı vefasız olan', 'Hercai'),
(6, 'Şerit biçimde metal veya plastik levhalardan yapılmış bir tür perde', 'Jaluzi'),
(7, 'Tatlı ve hamur işi dükkanı', 'Pastane'),
(8, 'Argoda, Gönlü olup olmadığını anlamak için manalı tavırlarda bulunmak, kur yapmak', 'İşatmak'),
(9, 'Bir baltaya sap olmadan, başıboş yaşama hali', 'Haytalık'),
(10, 'Olmak fiili ile beraber kullanıldığında Ölmek anlamına gelen kelime', 'Rahmetli'),
(11, 'Sıcak suya soğuk veya soğuğa sıcak su katma', 'Ilıştırma'),
(12, 'Özellikle gözler için, Yuvasından dışarıya doğru fırlamak anlamında bir söz', 'Pörtlemek'),
(13, 'Borç kağıdı, sözleşme gibi resmi bağlayıcılığı olan belgeler için kullanılan bir tabir', 'Senetsepet'),
(14, 'Uzun yılları geride bırakmış ve belli bir olgunluğa erişmiş anlamında bir söz', 'Yaşlıbaşlı'),
(15, 'Tesir sözünün Türkçe kökenli karşılığı', 'Etki'),
(16, 'Odun, kömür, elektrik, gaz veya doğal gaz ile kullanılan çeşitleri bulunan ısınma gereci', 'Soba'),
(17, 'Kasaplık hayvanlardan sağlanan kemiksiz besin maddesi', 'Lopet'),
(18, 'Seyrek sözünün eş ve yakın anlamlı karşılığı', 'Nadir'),
(19, 'Birden fazla dükkan veya yazıhanenin bulunduğu çok katlı bia', 'İşhanı'),
(20, 'Boyamak, süsleyerek değişik hale sokmak anlamındaki Fransızca kökenli bir kelimeden türeyen söz', 'Makyaj'),
(21, 'Sevinç, korku, sabırsızlık, kızgınlık gibi sebeplerle ortaya çıkan güçlü ve geçici duygu durumu', 'Heyecan'),
(22, 'Üzerinde yakıcı tüyler bulunan bir ot', 'Isırgan'),
(23, 'Otobüs, uçak gibi taşıtların yolcularını ilk aldığı ve son bıraktığı yer', 'Terminal'),
(24, 'Saray, köşk ve konaklarda erkek konukların kabul edildiği yer', 'Selamlık'),
(25, 'Araç üstü yüklüğü', 'Portbagaj'),
(26, 'Gasilhaneye giden yolun başlangıcı olan mekan', 'Doğumhane'),
(27, 'Verilmek istenen mesajın ulaşması istenen grup veya topluluk', 'Hedefkitle'),
(28, 'Maç sözcüğünün eş anlamlısı', 'Karşılaşma'),
(29, 'Yalnızca, sadece anlamlarında bir söz', 'Sırf'),
(30, 'Yaprakları salatalarda kullanılan baharlı bir bitki', 'Tere'),
(31, '80X110 ölçülerindeki çöp poşetinin ebatı için kullanılan söz', 'Jumbo'),
(32, 'Kauçuk ve jelatin kıvamındaki bir dinamit formuna da adını veren tatlı', 'Lokum'),
(33, 'Altıncı sınıftaki tıp öğrencileri için kullanılan İngilizce kökenli bir söz', 'İntern'),
(34, 'Asıl anlamı Bedbahtlar, zavallılar iken, zaman içinde Haydutlar, soygunculara dönüşen söz', 'Eşkıya'),
(35, 'Avrupa hanedanlarında kadın üyelere verilen genel soyluluk unvanı', 'Prenses'),
(36, 'Eskiden Ortaokul derecesinde olan eğitim kurumu', 'Rüştiye'),
(37, 'Mutluluğa erişmiş olan anlamında bir sözcük', 'Berhudar'),
(38, 'Yeğleyerek, yeğleme yolu ile anlamında bir söz', 'Tercihen'),
(39, 'Boyu Bel ile topuk arasında kalan bir kadın giysisini, boyuyla birlikte tanımlayan söz dizisi', 'Maksietek'),
(40, 'Bir şeyi bir yere hareket etmeyecek biçimde yerleştirme', 'Sabitleme'),
(41, 'Yapı işlerinde kullanılmak üzere Karmaç denen araçlarla taşınan bağlayıcı karışım', 'Hazırbeton'),
(42, 'Gereken ilgiyi göstermemek, savsaklamak, boşlamak', 'İhmaletmek'),
(43, 'Hindistan ve Güney Asya kökenli bir Baharat karışımı', 'Köri'),
(44, 'Tahıl gibi ürünlerin konulduğu, saklandığı veya depolandığı, genellikle silindir biçimde ambar', 'Silo'),
(45, 'Dayak, kötek anlamlarında bir sözcük', 'Patak'),
(46, 'Sayıları göstermek için kullanılan işaretlerden her biri', 'Rakam'),
(47, 'Gemicilikte kullanılan, Yüksek hızla, son süratle anlamında bir tabir', 'Tamyol'),
(48, 'Kuvvetin döndürme etkisi anlamına gelen fizik terimi', 'Moment'),
(49, 'Zarara ve sıkıntıya karşı alınan önlem', 'İhtiyat'),
(50, 'Erendiz veya Müşteri de denen gezegen', 'Jüpiter'),
(51, 'Suç işleyen çocukları topluma kazandırmak amacıyla kurulmuş olan kurum', 'Islahevi'),
(52, 'Bir yere kendini rahatça bırakarak uzanıp yatmak', 'Serilmek'),
(53, 'Yanak ve alt çenesinde gür, geniş, özensiz görünümlü bir kıl birikintisi olan kişi', 'Kabasakal'),
(54, 'Olayların ve varlıkların görünüşlerini, kalem, fırça gibi araçlarla kağıt, bez gibi yüzeyler üzerine geçirmek', 'Resmetmek'),
(55, 'Borsada günlük gerçekleştirilen alım satımların toplam tutarı', 'İşlemhacmi'),
(56, 'Çuvallama, çarşafa dolanma, sınıfta kalma deyimlerinin karşılığı olan söz', 'Sulu'),
(57, 'Böcekleri öldürmek için püskürtülen ilaç', 'Flit'),
(58, 'Tatlı düş', 'Hülya'),
(59, 'Dil dudak yoluyla çıkarılan tiz ses', 'Islık'),
(60, 'Bir işin yapılması veya bir borcun ödenmesi için tanınan süre, vade, mehil', 'Mühlet'),
(61, 'Asfalt tankı', 'Panzer'),
(62, 'Japon Çiçek düzenleme sanatı', 'İkebana'),
(63, 'Yarı karanlığa denk aydınlık ve bu aydınlığı oluşturan kaynak', 'Loşışık'),
(64, 'Mecazi anlamda, Gırtlak yapısı, şarkı söylerken veya konuşurken çıkarılan ton ve tını', 'Sesrengi'),
(65, 'Ayaklarını hızla yere vurmak', 'Tepinmek'),
(66, 'Argoda, Utanacak duruma düşürmek, bozum etmek', 'Morartmak'),
(67, 'Vermek fiiliyle, İş birliği yapmak, dayanışma içine girmek anlamlarında bir söz dizisi', 'Sırtsırta'),
(68, 'Taşıtı uğrayacağı kazadan doğacak zararın karşılanması için sigorta kapsamına almak', 'Kaskolamak');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `sorular`
--
ALTER TABLE `sorular`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `sorular`
--
ALTER TABLE `sorular`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=70;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

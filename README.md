# 🪙 CryptoHub — Kripto & Finans Dashboard

![.NET 10](https://img.shields.io/badge/.NET%2010-512BD4?style=flat-square&logo=dotnet&logoColor=white)
![RapidAPI](https://img.shields.io/badge/RapidAPI-0055FF?style=flat-square&logo=rapidapi&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=c-sharp&logoColor=white)

## 📖 Proje Hakkında

Bu projede, finansal piyasaları ve kripto para dünyasını tek bir noktadan takip etmeyi sağlayan, modern ve dinamik bir **Kripto & Finans Dashboard** uygulaması geliştirdim. **ASP.NET Core 10** ve **MVC** yapısını kullanarak inşa ettiğim bu sistem, tamamen gerçek zamanlı verilerle beslenen kapsamlı bir finans paneli sunmaktadır.

Uygulamanın kalbi, **RapidAPI** üzerinden tükettiğim çok sayıda farklı API endpoint'ine dayanıyor. Piyasa verilerinden teknik göstergelere, akaryakıt fiyatlarından borsa duyurularına kadar geniş bir yelpazedeki veriyi sunucu tarafında (Server-side) işleyerek kullanıcıya akıcı bir arayüz ile sunmayı hedefledim.



## 🏗️ Mimari ve Teknik Detaylar

Projeyi geliştirirken veriyi verimli yönetmek ve arayüzü modern standartlarda tutmak için şu teknolojileri kullandım:

| Kategori | Teknoloji / Kütüphane | Kullanım Amacı |
|----------|-----------------------|----------------|
| **Framework** | .NET 10 | Güncel uygulama çalışma zamanı |
| **Mimari** | ASP.NET Core MVC | Model-View-Controller desenli web yapısı |
| **API Tüketimi** | IHttpClientFactory | Güvenli ve optimize HTTP istek yönetimi |
| **Veri Kaynağı** | RapidAPI | CoinRanking, Crypto-news, RSI, Döviz ve Akaryakıt verileri |
| **Serileştirme** | Newtonsoft.Json & System.Text.Json | JSON yanıtlarını C# modellerine dönüştürme |
| **Frontend Stil** | Tailwind CSS (CDN) | Modern ve hızlı arayüz tasarımı |
| **Sayfalama** | X.PagedList.Mvc.Core | Coin listesinde performanslı sayfalama |
| **İkon Seti** | Material Symbols Outlined | Sidebar ve kart tasarımları için ikon desteği |

### 🔧 Geliştirme Prensipleri
* **Modüler Controller Yapısı:** Her veri kategorisi (Haber, Kripto, Döviz) için ayrı Controller'lar kurgulayarak sorumlulukları ayrıştırdım.
* **DTO & Model Eşleme:** API'lerden gelen karmaşık (camelCase/snake_case) JSON yanıtlarını `[JsonProperty]` nitelikleriyle temiz C# nesnelerine eşledim.
* **Dinamik UI Bileşenleri:** Trend coin listesi gibi tekrar eden alanları **ViewComponent** olarak tasarladım; bu sayede kod tekrarını önleyip bakımı kolaylaştırdım.
* **Layout Yönetimi:** `_Layout.cshtml` yapısında Partial View'lar kullanarak Header, Sidebar ve Head kısımlarını merkezi olarak yönettim.

## ✨ Özellikler

### 📈 Kripto & Piyasa Takibi
* **Piyasa Özeti:** CoinRanking API ile güncel coin listesi, piyasa değerleri ve 24 saatlik değişim oranları.
* **Trend Verileri:** En çok ilgi gören (Trending) coinlerin anlık listelenmesi.
* **Liste Giriş/Çıkışlar:** Borsalara yeni eklenen (Listings) veya kaldırılan (Delistings) coin duyurularının takibi.

### 📰 Haber ve Teknik Analiz
* **Kripto & Finans Haberleri:** Sentiment (duygu) etiketli güncel kripto makaleleri ve genel finans haberleri.
* **RSI İndikatörü:** Sembol ve zaman dilimi parametrelerine göre dinamik teknik analiz verisi (RSI 14).
* **Borsa Duyuruları:** Kripto para borsalarından gelen en güncel duyuru ve makalelerin listelenmesi.

### 💰 Finansal Araçlar
* **Döviz Çevirici:** Seçilen baz ve hedef para birimine göre anlık kur dönüşümü.
* **Akaryakıt Fiyatları:** RapidAPI üzerinden çekilen güncel yakıt fiyat bilgileri.
* **Nasdaq Verileri:** Hisse senedi ve endeks verilerinin anlık takibi.

## 📂 Proje Yapısı

Uygulamanın klasör hiyerarşisi mantıksal sorumluluklara göre düzenlenmiştir:

```text
RapidApi-CryptoFinanceDashboardProject/
├── Controllers/           # API tüketim mantığının ve routing'in yönetildiği katman
├── Models/                # API yanıtlarına karşılık gelen C# sınıfları (DTO'lar)
├── ViewComponents/        # Bağımsız çalışan UI bileşenleri (örn. Trend Coins)
├── Views/                 # Razor sayfaları ve Partial View tasarımları
│   └── Shared/            # Layout, Head, Header ve Sidebar parçaları
├── wwwroot/               # Özel CSS, JS ve kütüphane dosyaları
└── Program.cs             # Uygulama servis kayıtları ve konfigürasyon
```
<img width="1914" height="938" alt="Image" src="https://github.com/user-attachments/assets/834bc453-5a22-41d2-990f-de4113b4971f" />
<img width="1916" height="936" alt="Image" src="https://github.com/user-attachments/assets/fa4118fb-5985-4f0c-972c-abe8ff68c051" />
<img width="1914" height="939" alt="Image" src="https://github.com/user-attachments/assets/0586ce47-9591-478e-be37-2600dd7fcd81" />
<img width="1914" height="943" alt="Image" src="https://github.com/user-attachments/assets/ed3e9f14-db37-4a25-81ac-769920dfa645" />
<img width="1916" height="938" alt="Image" src="https://github.com/user-attachments/assets/4c3a485e-ea5e-4e94-b350-5a4cce60a371" />
<img width="1915" height="939" alt="Image" src="https://github.com/user-attachments/assets/cb34efc5-dfc1-4ab8-85a8-886f384cfd97" />
<img width="1914" height="936" alt="Image" src="https://github.com/user-attachments/assets/85c88f57-518f-4a6a-a1df-c74a6d23b3c2" />

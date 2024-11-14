# OnlineShoppingAPI
Bu proje, bir online alışveriş platformu için çok katmanlı bir API geliştirmeyi amaçlar. Kullanıcıların kimlik doğrulama işlemleri JWT ile yapılmakta olup, kullanıcı, ürün ve sipariş yönetimini sağlamaktadır. Proje aynı zamanda Entity Framework Core, ASP.NET Core ve SQL Server gibi teknolojileri kullanarak güvenli ve modüler bir yapı sunar.

Proje Özeti
OnlineShoppingAPI, ASP.NET Core Web API teknolojisi ile geliştirilmiş olup, aşağıdaki temel özellikleri içerir:

Kimlik Doğrulama: JSON Web Token (JWT) ile kimlik doğrulama.
Çok Katmanlı Mimari: Presentation (API Katmanı), Business (İş Katmanı) ve Data Access (Veri Erişim Katmanı) olmak üzere en az üç katman.
Veritabanı Yönetimi: Entity Framework Code First yaklaşımı ile SQL Server veritabanı üzerinde veri yönetimi.
API Endpoint'leri: CRUD işlemleri için çeşitli API endpoint'leri (Get, Post, Put, Patch, Delete).
Kullanılan Teknolojiler
ASP.NET Core - API geliştirme
Entity Framework Core - Veritabanı işlemleri
SQL Server - Veritabanı yönetimi
JWT (JSON Web Token) - Kimlik doğrulama
Dependency Injection - Bağımlılık enjeksiyonu
Model Validation - Veri doğrulama
Gereksinimler
Projenin çalışması için aşağıdaki yazılımlar gereklidir:

.NET 8.0 SDK
SQL Server
Postman (API endpoint'lerini test etmek için önerilir)

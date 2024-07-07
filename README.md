# Mikroservis PLatforms-Commands Platformu

Bu proje, bir .NET mikroservis kursu kapsamında geliştirilmiş örnek bir uygulamadır. Platform Servisi ve Command Servisi olmak üzere iki ana bileşenden oluşmaktadır.

## Proje Özellikleri

- **Mikroservis Mimarisi**: Bağımsız olarak çalışabilen ve ölçeklenebilen iki servis.
- **Asenkron İletişim**: RabbitMQ kullanılarak event-driven mimari.
- **Senkron İletişim**: gRPC protokolü ile servisler arası hızlı iletişim.
- **Veritabanı Çeşitliliği**: MSSQL ve In-Memory veritabanı kullanımı.
- **Containerization**: Docker kullanılarak servislerin konteynerleştirilmesi.
- **Orchestration**: Kubernetes ile konteyner yönetimi ve ölçeklendirme.

## Servisler

### 1. Platform Servisi

- MSSQL veritabanı kullanır.
- Platformların eklenmesi, listelenmesi ve yönetilmesi işlevlerini sağlar.
- Yeni eklenen platformları RabbitMQ üzerinden Command Servisi'ne iletir.

### 2. Command Servisi

- In-Memory veritabanı kullanır.
- Platform Servisi'nden gelen platform bilgilerini saklar.
- Her platform için komut ekleme ve listeleme işlevlerini sağlar.

## Teknoloji Yığını

- **.NET Core 8**: Ana geliştirme çerçevesi
- **Docker**: Konteynerizasyon
- **Kubernetes**: Konteyner orkestrasyon
- **RabbitMQ**: Asenkron iletişim için mesaj kuyruğu
- **MSSQL**: Platform Servisi için ilişkisel veritabanı
- **In-Memory Database**: Command Servisi için hızlı, veri depolama (Geçici)
- **gRPC**: Servisler arası senkron iletişim
- **REST API**: Dış dünya ile iletişim için
- **AutoMapper**: Nesne eşlemeleri için
- **Entity Framework Core**: ORM aracı

## Mimari Diagram

<img width="1160" alt="microservice-course" src="https://github.com/fthyldz/microservice-course/assets/60900683/cb545d53-7fb8-4890-b383-1ac1f04b1857">

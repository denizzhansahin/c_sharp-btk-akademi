# c_sharp-btk-akademi
BTK Akademi C# kurs notlarım

Aşağıdaki linkler, sizler için istediğiniz işletim sisteminde C# çalıştırmak ile kaynaklardır.

# Microsoft .NET Kurulum
https://dotnet.microsoft.com/en-us/download

# C# için Mono-Project Kurulum
https://www.mono-project.com/

# Linux için .NET Kurulum - Debian
https://learn.microsoft.com/tr-tr/dotnet/core/install/linux-debian

# Linux için Mono-Project Kurulum - Debian
https://www.mono-project.com/download/stable/#download-lin-debian

# .NET ile Proje Oluşturmak ve Yönetmek
dotnet new console -n proje_adi   : Yeni bir proje oluştur, bu komut ile konsol teması ile çalışan bir uygulama oluşturdunz. Burada yer alan .cs uzantılı dosyayı düzenleyebilir ya da bu dosyayı silip yeni .cs uzantılı dosya ekleyebilirsiniz.

cd proje_adi                      : Proje içine git

dotnet build                      : Projeyi derle

dotnet run                        : Projeyi çalıştır

dotnet clean                      : Projeyi isteğe bağlı olarak temizle

# Mono-Project ile Proje Oluşturmak ve Yönetmek
csc /out:deneme123 deneme.cs : deneme.cs dosyası(sizin dosya adınız farklı olabilir.) çalışan bir dosyaya dönüştür.

mono deneme123               : Mono-Project ile dosya çalıştır.

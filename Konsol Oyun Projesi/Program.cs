Console.WriteLine("Merhaba katil kim isimli oyuna hoşgeldiniz.");
Console.WriteLine("Oyunu oynarken belirli Kurallarımız olacak.");
Console.WriteLine("Bu kuralları sizlere belirli bölümlerde hatırlatacağız.");
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("Katili bulmak için ipuçlarını toplamak zorundasınız.");
Console.WriteLine("Aşağıdaki ismini belirttiğimiz odaları gezeceksiniz");
Console.WriteLine("-------------------------------------------------------");

int _score = 100;
int _bedroomscore = 25;
int _kitchenscore = 25;
int _salonscore = 25;
int _bathroomscore = 25;
int _sonuc;




string[] _room = new string[] { "yatak odası", "mutfak", "salon", "banyo" };
foreach (var oda in _room)
{
    Console.WriteLine(oda);
}
Console.WriteLine("-------------------------------------------------------");
Console.Write("Lütfen incelemek istediğiniz odayı belirtiniz : ");
string _bedroom = Console.ReadLine();

if (_bedroom == "yatak odası")
{
    _sonuc = _score - _bedroomscore;
    Console.WriteLine($"Geriye kalan puanınız: {_sonuc}");
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine("Yatak odasında inceleyeceklerinizin listesi: ");
    Console.WriteLine("-----------------------------------------");
    string[] _bedroomlist = new string[] { "dolap", "etejer", "komodin", };
    foreach (var _broom in _bedroomlist)
        Console.WriteLine(_broom);
    Console.Write("İncelemeniz bittimi :? evet/hayır");
    string _soru = ( _end == "evet") ? ""

 

}
else if (_bedroom == "mutfak")
{
    _sonuc = _score - _kitchenscore;
    Console.WriteLine($"Geriye kalan puanınız: {_sonuc}");
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine("Mutfakta inceleyeceklerinizin  listesi : ");
    Console.WriteLine("-----------------------------------------");
    string[] _kitcenlist = new string[] { "bıçak", "buzdolabı", };
    foreach (var _kitcen in _kitcenlist)
        Console.WriteLine(_kitcen);
}

else if (_bedroom == "salon")
{
    _sonuc = _score - _salonscore;
    Console.WriteLine($"Geriye kalan puanınız: {_sonuc}");
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine("Salonda  inceleyeceklerinizin  listesi : ");
    Console.WriteLine("-----------------------------------------");
    string[] _salonlist = new string[] { "koltuk", "tv sehpası", };
    foreach (var _slnn in _salonlist)
        Console.WriteLine(_slnn);
}

else if (_bedroom == "banyo")
{
    _sonuc = _score - _bathroomscore;
    Console.WriteLine($"Geriye kalan puanınız: {_sonuc}");
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine("Banyoda  inceleyeceklerinizin  listesi : ");
    Console.WriteLine("-----------------------------------------");
    string[] _bathroomlist = new string[] { "duş", "lavabo", "havlu", };
    foreach (var _bthh in _bathroomlist)
        Console.WriteLine(_bthh);
}

else
{
    {
        Console.WriteLine("Doğru bir seçim yapmadınız");
    }
}
using System;

namespace HastaneOtomasyonSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hastane Otomasyon Sistemi
            int genelSayac = 0, anaSecim, bSecim, dSecim, ybssecim;
            string sikayet, cıkıs;
            string[] hastalar = new string[999];
            string[] doktorlar = new string[999];
            string[] sikayetler = new string[999];
            string[] bsecimler = new string[999];
            string[] bolumler = { "KBB", "Dahiliye", "Cildiye", "Ortopedi", "Genel Cerrahi" };
            string[] kbbDoktorlar = { "Kıvanç Tatlıtuğ", "Tuğçe Yüksel", "Murat Dalkılıç", "Murat Boz", "Kenan Doğulu" }; 
            string[] dhlDoktorlar = { "Ahmet Özdemir", "Batuhan Çelik", "Görkem Yılmaz", "Gökhan Yıldız", "Şafak Sezer" };
            string[] cldDoktorlar = { "Kadir İnanır", "Kemal Sunal", "Ali Sunal", "Ali Babacan", "Mahmut Özer" };
            string[] ortDoktorlar = { "Kemal Doğulu", "Kadir Yılmaz", "Buğra Yücesoy", "Kuzey Tekinoğlu", "Recep İvedik" };
            string[] gcrDoktorlar = { "Şahan Gökbakar", "Recep yılmaz", "Samet Yüksel", "Mert Baytar", "Murat Yeşilyurt" };
            int[] kbbdSayac = new int[999]; int[] dhldSayac = new int[999]; int[] clddSayac = new int[999]; int[] ortdSayac = new int[999]; int[] gcrdSayac = new int[999];
            int[] kbbdFiyat = new int[999]; int[] dhldFiyat = new int[999]; int[] clddFiyat = new int[999]; int[] ortdFiyat = new int[999]; int[] gcrdFiyat = new int[999];
        anamenu:
            Console.WriteLine("----------------------------------------------\n**\t**\t**********\t**********\n**\t**\t**\t**\t**\n**\t**\t**\t**\t**\n**********\t**********\t**********\n**********\t**********\t**********\n**\t**\t**\t**\t\t**\n**\t**\t**\t**\t\t**\n**\t**\t**********\t**********\n----------------------------------------------");
            Console.WriteLine("HASTAHANE BİLGİ SİSTEMİNE HOŞGELDİNİZ...");
            Console.Write("Ana Menü \n 1-Hasta Randevu \n 2-Personel Girişi \n 3-Çıkış\n Lütfen 1-3 arası numara giriniz: ");
            anaSecim = Convert.ToInt32(Console.ReadLine());
            switch (anaSecim)
            {
                case 1: goto hbs;
                case 2: goto ybs;
                case 3: Console.Write("Çıkmak istediğinize emin misiniz?(e/h): "); 
                    cıkıs = Console.ReadLine();
                    if (cıkıs == "e")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        goto anamenu;
                    }

                    break;
                default: Console.WriteLine("Lütfen 1-2 arasında seçim yapınız!"); goto anamenu;
            }
            hbs:
            Console.Write("Hasta Adı Soyadı: ");
            hastalar[genelSayac]= Console.ReadLine();
            bs:
            Console.Write("Bölüm Numarasını Yazınız: " + "\n 1-Kulak Burun Boğaz" + "\n 2-Dahiliye" + "\n 3-Cildiye" + "\n 4-Ortopedi" + "\n 5-Genel Cerrahi\n Lütfen 1-5 arası tuşlama yapınız: ");
            bSecim = Convert.ToInt32(Console.ReadLine());
            bsecimler[genelSayac] = bolumler[bSecim - 1];
            switch (bSecim)
            {
                case 1: Console.Write("Doktor Seciniz: \n 1-{0} \n 2-{1} \n 3-{2} \n 4-{3} \n 5-{4}\n Lütfen 1-5 araşı numara yazınız: ", kbbDoktorlar[0], kbbDoktorlar[1], kbbDoktorlar[2], kbbDoktorlar[3], kbbDoktorlar[4]);
                    dSecim = Convert.ToInt32(Console.ReadLine());
                    doktorlar[genelSayac] = kbbDoktorlar[dSecim-1];
                    kbbdSayac[dSecim - 1] = kbbdSayac[dSecim - 1] + 1; 
                    kbbdFiyat[dSecim - 1] = kbbdFiyat[dSecim - 1] + 50;
                    break;
                case 2: Console.Write("Doktor Seciniz: \n 1-{0} \n 2-{1} \n 3-{2} \n 4-{3} \n 5-{4}\n Lütfen 1-5 araşı numara yazınız: ", dhlDoktorlar[0], dhlDoktorlar[1], dhlDoktorlar[2], dhlDoktorlar[3], dhlDoktorlar[4]);
                    dSecim = Convert.ToInt32(Console.ReadLine());
                    doktorlar[genelSayac] = dhlDoktorlar[dSecim - 1];
                    dhldSayac[dSecim - 1] = dhldSayac[dSecim - 1] + 1; 
                    dhldFiyat[dSecim - 1] = dhldFiyat[dSecim - 1] + 50;
                    break;
                case 3: Console.Write("Doktor Seciniz: \n 1-{0} \n 2-{1} \n 3-{2} \n 4-{3} \n 5-{4}\n Lütfen 1-5 araşı numara yazınız: ", cldDoktorlar[0], cldDoktorlar[1], cldDoktorlar[2], cldDoktorlar[3], cldDoktorlar[4]);
                    dSecim = Convert.ToInt32(Console.ReadLine());
                    doktorlar[genelSayac] = cldDoktorlar[dSecim - 1];
                    clddSayac[dSecim - 1] = clddSayac[dSecim - 1] + 1; 
                    clddFiyat[dSecim - 1] = clddFiyat[dSecim - 1] + 50;
                    break;
                case 4: Console.Write("Doktor Seciniz: \n 1-{0} \n 2-{1} \n 3-{2} \n 4-{3} \n 5-{4}\n Lütfen 1-5 araşı numara yazınız: ", ortDoktorlar[0], ortDoktorlar[1], ortDoktorlar[2], ortDoktorlar[3], ortDoktorlar[4]);
                    dSecim = Convert.ToInt32(Console.ReadLine());
                    doktorlar[genelSayac] = ortDoktorlar[dSecim - 1];
                    ortdSayac[dSecim - 1] = ortdSayac[dSecim - 1] + 1; 
                    ortdFiyat[dSecim - 1] = ortdFiyat[dSecim - 1] + 50;
                    break;
                case 5: Console.Write("Doktor Seciniz: \n 1-{0} \n 2-{1} \n 3-{2} \n 4-{3} \n 5-{4}\n Lütfen 1-5 araşı numara yazınız: ", gcrDoktorlar[0], gcrDoktorlar[1], gcrDoktorlar[2], gcrDoktorlar[3], gcrDoktorlar[4]);
                    dSecim = Convert.ToInt32(Console.ReadLine());
                    doktorlar[genelSayac] = gcrDoktorlar[dSecim - 1];
                    gcrdSayac[dSecim - 1] = gcrdSayac[dSecim - 1] + 1; 
                    gcrdFiyat[dSecim - 1] = gcrdFiyat[dSecim - 1] + 50;
                    break;
                default: Console.WriteLine("Lütfen 1-5 arası numara yazınız!"); goto bs;
            }
            Console.Write("Şikayetinizi Yazınız: ");
            sikayet = Console.ReadLine();
            sikayetler[genelSayac] = sikayet;
            genelSayac++;
            Console.WriteLine("Randevunuz oluşturulmuştur! \n Ana menüye yönlendiriliyorsunuz....");
            goto anamenu;

        ybs:
            Console.Write("Yetkili Bilgi Sistemi: \n 1-Günlük Rapor \n 2-Doktor Prim Bilgisi \n 3-Ana Menü\n Lütfen 1-3 arası numara giriniz: ");
            
            
            ybssecim = Convert.ToInt32(Console.ReadLine());
            switch (ybssecim)
            {
                case 1: Console.WriteLine("Randevu Oluşturulan Hasta Sayısı:{0}",genelSayac);
                    Console.WriteLine("Hasta Adı Soyadı\t Bölüm\t Doktor Adı Soyadı\t Hasta Şikayeti");
                    for(int i=0; i<genelSayac; i++)
                    {
                        Console.WriteLine(hastalar[i] + "\t\t" + bolumler[i] + "\t" + doktorlar[i] + "\t\t" + sikayetler[i]);
                    }
                    break;

                case 2: Console.WriteLine("Doktor Adı Soyadı\t Hasta Sayısı\t\t Kazancı");
                    for(int i=0; i<bolumler.Length; i++)
                    {
                        Console.WriteLine(kbbDoktorlar[i] + "\t\t\t" + kbbdSayac[i] + "\t\t\t" + kbbdFiyat[i]);
                        Console.WriteLine("");
                    }
                    for (int i = 0; i < bolumler.Length; i++)
                    {
                        Console.WriteLine(dhlDoktorlar[i] + "\t\t\t" + dhldSayac[i] + "\t\t\t" + dhldFiyat[i]);
                        Console.WriteLine("");
                    }
                    for (int i = 0; i < bolumler.Length; i++)
                    {
                        Console.WriteLine(cldDoktorlar[i] + "\t\t\t" + clddSayac[i] + "\t\t\t" + clddFiyat[i]);
                        Console.WriteLine("");
                    }
                    for (int i = 0; i < bolumler.Length; i++)
                    {
                        Console.WriteLine(ortDoktorlar[i] + "\t\t\t" + ortdSayac[i] + "\t\t\t" + ortdFiyat[i]);
                        Console.WriteLine("");
                    }
                    for (int i = 0; i < bolumler.Length; i++)
                    {
                        Console.WriteLine(gcrDoktorlar[i] + "\t\t\t" + gcrdSayac[i] + "\t\t\t" + gcrdFiyat[i]);
                        Console.WriteLine("");
                    }

                    break;
                case 3: goto anamenu;
                default: Console.Write("Lütfen 1-3 arası tuşlama yapınız!"); goto ybs;
            }
            goto ybs;
            

            

        }
    }
}

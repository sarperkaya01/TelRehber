using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelRehber
{
    class Program : Rehber
    {
        static void Main(string[] args)
        {



            Kisiler kisi = new Kisiler();




            Console.WriteLine("İşlem menusune hoşgeldiniz...");
            Console.WriteLine("*************************");


            Console.WriteLine("1) Yeni Numara Kaydet");
            Console.WriteLine("2) Varolan Numarayı Silme");
            Console.WriteLine("3) Numara Güncelleme");
            Console.WriteLine("4) Rehberi Listele");
            Console.WriteLine("5) Rehberde arama yap");


            bool k = true;

            while (k)
            {
                Console.Write("Yapmak istediğiniz işlemi girini :");
                int islem = int.Parse(Console.ReadLine());
                switch (islem)
                {
                    case 1:
                        Console.Write("Lütfen isim giriniz             : ");
                        string x = Console.ReadLine();
                        x.ToUpper();
                        Console.Write("Lütfen soyisim giriniz          :");
                        string y = Console.ReadLine();
                        y.ToUpper();
                        Console.Write("Lütfen telefon numarası giriniz :");
                        int z = int.Parse(Console.ReadLine());
                        kisi.Ekle(x, y, z);


                        Console.WriteLine("*************************");
                        break;
                    case 2:

                        bool u = true;
                        while (u)
                        {
                            Console.WriteLine("Silmek istediğiniz kişinin adını veya soyadını girin");
                            string n = Console.ReadLine();
                            n.ToUpper();
                            kisi.AramaName(n);
                            kisi.AramaListele();
                            bool kont = kisi.varMi(n);
                            if (kont == false)
                            {
                                bool w = true;
                                while (w)
                                {


                                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                                    Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                                    Console.WriteLine("Yeniden denemek için      : (2)");
                                    string r = Console.ReadLine();
                                    r.ToUpper();

                                    switch (r)
                                    {
                                        case "1":
                                            w = false;
                                            u = false;
                                            Console.WriteLine("Anamenüye aktarılıyorsunuz...");
                                            break;
                                        case "2":
                                            w = false;
                                            u = true;
                                            break;
                                        default:
                                            Console.WriteLine("Hatalı giriş yaptınız yeniden deneyin. Anamenüye aktarılıyorsunuz...");
                                            w = false;
                                            break;

                                    }
                                }
                            }
                            else
                            {

                                if (kisi.sayısı() > 1)
                                {
                                    Console.WriteLine("Silmek istediğiniz kişinin soyadını girin");
                                    string j = Console.ReadLine();
                                    j.ToUpper();
                                    bool kontr = kisi.altVarMİ(j);
                                    if (kontr == false)
                                    {
                                        bool w = true;
                                        while (w)
                                        {


                                            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                                            Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                                            Console.WriteLine("Yeniden denemek için      : (2)");
                                            string r = Console.ReadLine();
                                            r.ToUpper();
                                            switch (r)
                                            {
                                                case "1":
                                                    w = false;
                                                    u = false;
                                                    Console.WriteLine("Anamenüye aktarılıyorsunuz...");
                                                    break;
                                                case "2":
                                                    w = false;
                                                    u = true;
                                                    break;
                                                default:
                                                    Console.WriteLine("Hatalı giriş yaptınız yeniden deneyin. Anamenüye aktarılıyorsunuz...");
                                                    w = false;
                                                    break;

                                            }
                                        }
                                    }
                                    else
                                    {

                                        bool s = true;
                                        while (s)
                                        {
                                            Console.WriteLine("Silme işlemini onaylıyor musunuz (y/n)");
                                            string p = Console.ReadLine();
                                            p.ToUpper();
                                            if (p == "y")
                                            {
                                                kisi.Sil(n);
                                                Console.WriteLine("Silme işlemi başarılı");
                                                s = false;
                                                u = false;
                                            }
                                            else if (p == "n")
                                            {
                                                Console.WriteLine("Silme işlemi iptal edildi");
                                                s = false;
                                                u = false;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Hatalı giriş yaptınız yeniden deneyin.");


                                            }
                                        }
                                    }

                                }





                                else
                                {
                                    bool s = true;
                                    while (s)
                                    {
                                        Console.WriteLine("Silme işlemini onaylıyor musunuz (y/n)");
                                        string p = Console.ReadLine();
                                        p.ToUpper();

                                        if (p == "y")
                                        {
                                            kisi.Sil(n);
                                            Console.WriteLine("Silme işlemi başarılı");
                                            s = false;
                                            u = false;
                                        }
                                        else if (p == "n")
                                        {
                                            Console.WriteLine("Silme işlemi iptal edildi");
                                            s = false;
                                            u = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Hatalı giriş yaptınız yeniden deneyin.");


                                        }
                                    }
                                }

                            }


                        }


                        break;

                    case 3:



                        bool q = true;
                        while (q)
                        {
                            Console.WriteLine("Güncellemek istediğiniz kişinin adını girin");
                            string n = Console.ReadLine();
                            n.ToUpper();
                            kisi.AramaName(n);
                            kisi.AramaListele();
                            bool kont = kisi.varMi(n);
                            if (kont == false)
                            {
                                bool w = true;
                                while (w)
                                {
                                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                                    Console.WriteLine("Güncellemeyi sonlandırmak için : (1)");
                                    Console.WriteLine("Yeniden denemek için      : (2)");
                                    string r = Console.ReadLine();

                                    switch (r)
                                    {
                                        case "1":
                                            w = false;
                                            q = false;
                                            Console.WriteLine("Anamenüye aktarılıyorsunuz...");
                                            break;
                                        case "2":
                                            w = false;
                                            q = true;
                                            break;
                                        default:
                                            Console.WriteLine("Hatalı giriş yaptınız yeniden deneyin. Anamenüye aktarılıyorsunuz...");
                                            w = false;
                                            break;

                                    }
                                }
                            }
                            else
                            {
                                if (kisi.sayısı() > 1)
                                {
                                    Console.WriteLine("Güncellemek istediğiniz kişinin soyadını girin");
                                    string j = Console.ReadLine();
                                    j.ToUpper();

                                    bool kontr = kisi.altVarMİ(j);
                                    if (kontr == false)
                                    {
                                        bool w = true;
                                        while (w)
                                        {


                                            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                                            Console.WriteLine("Güncellemeyi sonlandırmak için : (1)");
                                            Console.WriteLine("Yeniden denemek için      : (2)");
                                            string r = Console.ReadLine();
                                            r.ToUpper();

                                            switch (r)
                                            {
                                                case "1":
                                                    w = false;
                                                    u = false;
                                                    Console.WriteLine("Anamenüye aktarılıyorsunuz...");
                                                    break;
                                                case "2":
                                                    w = false;
                                                    u = true;
                                                    break;
                                                default:
                                                    Console.WriteLine("Hatalı giriş yaptınız yeniden deneyin. Anamenüye aktarılıyorsunuz...");
                                                    w = false;
                                                    break;

                                            }
                                        }
                                    }
                                    else
                                    {

                                        
                                        
                                            Console.WriteLine("Güncellemek isediğiniz numarayı yazın");
                                            int yeni = int.Parse(Console.ReadLine());
                                            bool s = true;
                                            while (s)
                                            {
                                                Console.WriteLine("Güncellemek isediğiniz numaray " + yeni);
                                                Console.WriteLine("Güncelleme işlemini onaylıyor musunuz (y/n)");
                                                string p = Console.ReadLine();
                                                p.ToUpper();

                                            if (p == "y")
                                                {


                                                    kisi.GuncelleNum(n, yeni);
                                                    Console.WriteLine("Güncelleme işlemi başarılı");
                                                    s = false;
                                                    
                                                    q = false;
                                                }
                                                else if (p == "n")
                                                {
                                                    Console.WriteLine("Güncelleme işlemi iptal edildi");
                                                    s = false;
                                                    
                                                    q = false;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Hatalı giriş yaptınız yeniden deneyin.");


                                                }
                                            }
                                        }
                                    }

                                



                            }

                        }
                        break;
                    case 4:
                        kisi.Listele();

                        Console.WriteLine("*************************");
                        break;
                    case 5:
                        bool m = true;
                        while (m)
                        {
                            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
                            Console.WriteLine("**********************************************");
                            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
                            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
                            string h = Console.ReadLine();
                            h.ToUpper();
                            if (h == "1")
                            {



                                Console.WriteLine("Rehberde aramak istediğiniz ismi giriniz");
                                string n = Console.ReadLine();
                                n.ToUpper();
                                bool kont = kisi.varMi(n);
                                if (kont == false)
                                {
                                    bool w = true;
                                    while (w)
                                    {


                                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                                        Console.WriteLine("Güncellemeyi sonlandırmak için : (1)");
                                        Console.WriteLine("Yeniden denemek için      : (2)");
                                        string r = Console.ReadLine();
                                        r.ToUpper();

                                        switch (r)
                                        {
                                            case "1":
                                                w = false;
                                                m = false;
                                                Console.WriteLine("Anamenüye aktarılıyorsunuz...");
                                                break;
                                            case "2":
                                                w = false;
                                                m = true;
                                                break;
                                            default:
                                                Console.WriteLine("Hatalı giriş yaptınız yeniden deneyin. Anamenüye aktarılıyorsunuz...");
                                                m = false;
                                                break;

                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("*******************");
                                    kisi.AramaName(n);
                                    kisi.AramaListele();

                                    m = false;
                                }


                            }
                            else if (h == "2")
                            {
                                Console.WriteLine("Rehberde aramak istediğiniz numarayı giriniz");
                                int n = int.Parse(Console.ReadLine());
                                bool kont = kisi.varMiNum(n);
                                if (kont == false)
                                {
                                    bool w = true;
                                    while (w)
                                    {


                                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                                        Console.WriteLine("Güncellemeyi sonlandırmak için : (1)");
                                        Console.WriteLine("Yeniden denemek için      : (2)");
                                        string r = Console.ReadLine();
                                        r.ToUpper();

                                        switch (r)
                                        {
                                            case "1":
                                                w = false;
                                                m = false;
                                                Console.WriteLine("Anamenüye aktarılıyorsunuz...");
                                                break;
                                            case "2":
                                                w = false;
                                                m = true;
                                                break;
                                            default:
                                                Console.WriteLine("Hatalı giriş yaptınız yeniden deneyin. Anamenüye aktarılıyorsunuz...");
                                                m = false;
                                                break;

                                        }
                                    }
                                }
                                else
                                {
                                    int f = n;
                                    kisi.AramaNum(f);
                                    kisi.AramaListele();

                                    m = false;

                                }
                            }
                            else
                            {
                                Console.WriteLine("Hatalı giriş yaptınız yeniden deneyin.");

                            }

                        }


                        break;

                    default:
                        Console.WriteLine("Hatalı giriş yaptınız tekrar deneyin...");
                        break;
                }
            }


            Console.ReadLine();



        }


    }

}

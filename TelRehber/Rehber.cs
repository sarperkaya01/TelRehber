using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelRehber
{
    class Rehber
    {

        public string isim { get; set; }
        public string soyisim { get; set; }
        public int num { get; set; }

        ArrayList isimler = new ArrayList();
        ArrayList soyisimler = new ArrayList();
        ArrayList nums = new ArrayList();
        ArrayList altisim = new ArrayList();
        ArrayList altSoy = new ArrayList();
        ArrayList altnum = new ArrayList();
        public Rehber()
        {

            isimler.Add("Necla");
            soyisimler.Add("Kaya");
            nums.Add(11111);

            isimler.Add("Kaya");
            soyisimler.Add("KaraKaya");
            nums.Add(22222);

            isimler.Add("Sarp");
            soyisimler.Add("Para");
            nums.Add(33333);

            isimler.Add("Sarp");
            soyisimler.Add("Kaymaz");
            nums.Add(44444);


            isimler.Add("Alp");
            nums.Add(55555);
            soyisimler.Add("Kayar");



        }



        public void Listele()
        {
            for (int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine("İsim:" + isimler[i]);
                Console.WriteLine("Soyisim:" + soyisimler[i]);
                Console.WriteLine(nums[i]);
                Console.WriteLine("--");
            }

        }
        public void Ekle(string name, string sur, int numb)
        {
            isim = name;
            isimler.Add(isim);

            soyisim = sur;
            soyisimler.Add(soyisim);

            num = numb;
            nums.Add(num);
        }
        public void Sil(string name)
        {

            int b = isimler.IndexOf(name);
            int c = soyisimler.IndexOf(name);
            if (b < 0)
            {
                isimler.RemoveAt(c);



                soyisimler.RemoveAt(c);


                nums.RemoveAt(c);
            }
            else
            {
                isimler.RemoveAt(b);



                soyisimler.RemoveAt(b);


                nums.RemoveAt(b);
            }


        }
        public void GuncelleNum(string name, int newnum)
        {
            int b = isimler.IndexOf(name);
            int c = soyisimler.IndexOf(name);
            if (b < 0)
            {


                nums.RemoveAt(c);
                nums.Insert(c, newnum);
            }
            else
            {

                nums.RemoveAt(b);
                nums.Insert(b, newnum);
            }
        }
        public void GuncelleName(string name, string newname) 
        {
            int b = isimler.IndexOf(name);
            int c = soyisimler.IndexOf(name);
            if (b < 0)
            {
                soyisimler.RemoveAt(c);
                soyisimler.Insert(c, newname);
                
            }
            else
            {

                isimler.RemoveAt(b);
                isimler.Insert(b, newname);
            }
        }

        public bool varMi(string name)
        {
            bool x = false;
            bool kontrol = true;
            int sayac = 0;
            while (kontrol)
            {
                foreach (var item in isimler)
                {
                    x = item.Equals(name);
                    if (x == true)
                    {
                        kontrol = false;
                        break;
                    }

                }
                foreach (var item in soyisimler)
                {
                    if (kontrol == false)
                    {
                        break;
                    }
                    else
                    {
                        x = item.Equals(name);

                        if (x == true)
                        {
                            kontrol = false;
                            break;
                        }
                        else
                        {
                            sayac++;
                        }
                    }

                }
                if (sayac == soyisimler.Count)
                {


                    kontrol = false;
                    x = false;
                }
                else
                {
                    kontrol = false;
                }



            }


            return x;

        }
        public bool varMiNum(int num) 
        {
            bool a = false;
            bool kontrol = true;
            int sayac = 0;
            while (kontrol)
            {
                foreach (var item in nums)
                {
                    if (kontrol == false)
                    {
                        break;
                    }
                    else
                    {


                        a = item.Equals(num);

                        if (a == true)
                        {
                            kontrol = false;
                            break;
                        }
                        else
                        {
                            sayac++;
                        }
                    }

                }
                if (sayac == soyisimler.Count)
                {


                    kontrol = false;
                    a = false;
                }
                else
                {
                    kontrol = false;
                }
            }
            return a;

        }

        
        public void AramaName(string name) 
        {
            if (altisim.Count<=0 && altSoy.Count<=0)
            {
                for (int i = 0; i < isimler.Count; i++)
                {

                    if (Convert.ToString(isimler[i]) == name)
                    {
                        altisim.Add(isimler[i]);
                        altSoy.Add(soyisimler[i]);
                        altnum.Add(nums[i]);
                    }


                }
                for (int i = 0; i < soyisimler.Count; i++)
                {

                    if (Convert.ToString(soyisimler[i]) == name)
                    {
                        altisim.Add(isimler[i]);
                        altSoy.Add(soyisimler[i]);
                        altnum.Add(nums[i]);
                    }


                }
            }
            else
            {
                AltSil();
                for (int i = 0; i < isimler.Count; i++)
                {

                    if (Convert.ToString(isimler[i]) == name)
                    {
                        altisim.Add(isimler[i]);
                        altSoy.Add(soyisimler[i]);
                        altnum.Add(nums[i]);
                    }


                }
                for (int i = 0; i < soyisimler.Count; i++)
                {

                    if (Convert.ToString(soyisimler[i]) == name)
                    {
                        altisim.Add(isimler[i]);
                        altSoy.Add(soyisimler[i]);
                        altnum.Add(nums[i]);
                    }


                }
            }
            

        }
        public void AramaNum(int num) 
        {
            if (altnum.Count<=0)
            {
                int b = nums.IndexOf(num);
                if (b < 0)
                {
                    Console.WriteLine("Bu numara rehberde bulunmamaktadır");

                }
                else
                {
                    altisim.Add(isimler[b]);



                    altSoy.Add(soyisimler[b]);


                    altnum.Add(nums[b]);
                }
            }
            else
            {
                AltSil();
                int b = nums.IndexOf(num);
                if (b < 0)
                {
                    Console.WriteLine("Bu numara rehberde bulunmamaktadır");

                }
                else
                {
                    altisim.Add(isimler[b]);



                    altSoy.Add(soyisimler[b]);


                    altnum.Add(nums[b]);
                }
            }
            
            
        }
        public void AramaListele()
        {

            for (int i = 0; i < altnum.Count; i++)
            {
                Console.WriteLine("İsim:" + altisim[i]);
                Console.WriteLine("Soyisim:" + altSoy[i]);
                Console.WriteLine(altnum[i]);
                Console.WriteLine("--");
            }

        }
        public void AltSil() 
        {
            
                altisim.Clear();



                altSoy.Clear();


                altnum.Clear();
           
        }


    }
}

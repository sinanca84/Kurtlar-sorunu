
internal class Program
{
    private static void Main(string[] args)
    {
       
        unsafe
        {
            Console.WriteLine("1)İncelenen toplam kurt sayısını giriniz enter a bastıktan sonra türleri giriniz:");
            int t_k = Convert.ToInt32(Console.ReadLine());
            int[] tur = new int[5]; // Garanti edilen 5 tane kurt türü.
            int[] kurt = new int[t_k];// Memoryden ulastıgımız kurtların aktaracagımız int array
            string kurtlar = Console.ReadLine();    //toplamda İncelenen kurtların verisi (t_k)kadar giris yapılmalı 
            kurtlar = kurtlar.Remove(1, 1);//

            //Test
            //Console.WriteLine(kurtlar);

            //stringle alınan kurt bilgilerine pointerle ilk adrese ulasarak girilen kurtları ,hafızadan ulaşıp int arraya aktarıyoruz.

            fixed (char* ptr = kurtlar)
            {
                //kurt[0]= (int)&ptr;Console.WriteLine(kurt[0]);

                for (int i = 0; ptr[i] != '\0'; i++)
                {

                    kurt[i] = ptr[i] - 48;//Kurtlar aktarılıyor.// Ascii Kodu aldıgı ıcın 48 cıkarıyorum

                    //Test  Console.Write(ptr[i]);

                   // Console.Write(kurt[i]);

                }
            }

            int adet1 = 0;
            int adet2 = 0;
            int adet3 = 0;
            int adet4 = 0;
            int adet5 = 0;

            for (int i = 0; i < kurtlar.Length; i++)
            {
                if (kurt[i] == 1)
                    ++adet1;
                if (kurt[i] == 2)
                    ++adet2;
                if (kurt[i] == 3)
                    ++adet3;
                if (kurt[i] == 4)
                    ++adet4;
                if (kurt[i] == 5)
                    ++adet5;
            }
            tur[0] = adet1;
            tur[1] = adet2;
            tur[2] = adet3;
            tur[3] = adet4;
            tur[4] = adet5;

            int temp = 0; int min = 0;
            for (int i = 0; i < tur.Length; i++)
            {
                int ind = i;
                for (int j = i; j < tur.Length; j++)
                {
                    if (tur[ind] < tur[j] )
                    {
                        
                        ind = j;
                        min = i;
                        
                    }
                }
                if (temp != tur[i])
                {
                    temp = tur[i];
                    tur[i] = tur[ind];
                    tur[ind] = temp;
                                        
                }
               
            }
                         
                       Console.WriteLine(tur[0]);
        }
    }
}
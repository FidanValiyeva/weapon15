//using System.Reflection;
//using System.Runtime.InteropServices.JavaScript;
//using System;

//namespace ConsoleApp6
//{
//    internal class Program
//    {
//        //        Weapon deyə class yaradılır.
//        //Darağın güllə tutumu, Daraqdakı güllə sayı,atış modu(təkli və ya avtomatik) propertileri verilir.
//        //Shoot() -  metodu hər çağırıldıqda fire moduna gore ya 1 güllə atır yada avtomatik gulleni bosaldir.(Ekranda bunu bildirir)
//        //GetRemainBulletCount() - darağın tam dolması üçün lazım olan güllə sayını qaytarır.
//        //Reload() - darağı yenidən doldurur.
//        //ChangeFireMode() - Atış modunu dəyişir.
//       //Bütün məlumatları doldurmadan obyekt yaratmaq olmasın.,,
//        //0 - İnformasiya almaq üçün
//        //1 - Shoot metodu üçün
//        //2 - GetRemainBulletCount metodu üçün
//        //3 - Reload metodu üçün
//        //4 - ChangeFireMode metodu üçün
//        //5 - Proqramdan dayandırmaq üçün
//        //qısayoldur.
//        static void Main(string[] args)


//        {

//            Weapon weapon = new Weapon(10,5,"tekli");

//            bool f = false;

//            double BulletCapacity;
//            double BulletNumber;
//            string FireMode;

//            string operation;
//            do
//            {
//               Console.WriteLine("1.Shoot 2.GetRemainBulletCount 3.Reload 4.ChangeFireMode 0.Exit");
//               operation =Console.ReadLine();

//                switch(operation)
//                {
//                    case "1":

//                        weapon.Shoot();

//                        break; 

//                   case "2":
//                       weapon.GetRemainBulletCount();
//                        break;

//                    case "3":
//                        weapon.Reload();
//                        break;

//                         case "4":
//                         weapon.Fire();
//                        break;

//                        case "0":
//                        Console.WriteLine("cixis et");                       
//                        break;

//                      default:
//                        Console.WriteLine("Yanlıs secim, zehmet olmasa yeniden cehd edin.");
//                        break;
//                }                 


//           } while ( !f );




//    }
//         }
using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon(10, 5, "Tekli");
            bool f = false;
            string operation;
            do
            {
                Console.WriteLine("1.Shoot 2.GetRemainBulletCount 3.Reload 4.ChangeFireMode 0.Exit");
                operation = Console.ReadLine();
                switch (operation)
                {
                    case "1":
                        weapon.Shoot();
                        break;
                    case "2":
                        weapon.GetRemainBulletCount();
                        break;
                    case "3":
                        weapon.Reload();
                        break;
                    case "4":
                        weapon.ChangeFireMode();
                        break;
                    case "0":
                        Console.WriteLine("Cixis et");
                        f = true;
                        break;
                    default:
                        Console.WriteLine("Yanlıs secim, zehmet olmasa yeniden cehd edin.");
                        break;
                }
            } while (!f);
        }
    }

    public class Weapon
    {
        private double _bulletCapacity;
        private double _bulletNumber;
        private string _fireMode;

        public double BulletCapacity
        {
            get { return _bulletCapacity; }
            set
            {
                if (value > 0 && value <= 10)
                {
                    _bulletCapacity = value;
                }
            }
        }

        public double BulletNumber
        {
            get { return _bulletNumber; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    _bulletNumber = value;
                }
            }
        }

        public string FireMode
        {
            get { return _fireMode; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _fireMode = value;
                }
            }
        }

        public Weapon(double bulletCapacity, double bulletNumber, string fireMode)
        {
            BulletCapacity = bulletCapacity;
            BulletNumber = bulletNumber;
            FireMode = fireMode;
        }

        public void Shoot()
        {
            if (BulletNumber == 0)
            {
                Console.WriteLine("Gulle yoxdur");
                return;
            }

            if (FireMode == "Tekli")
            {
                BulletNumber--;
                Console.WriteLine($"Tekli Ates! Qalan gulle: {BulletNumber}");
            }
            else
            {
                Console.WriteLine($"Avtomatik atis! Qalan gulle: {BulletNumber}");
                BulletNumber = 0;
            }
        }

        public void GetRemainBulletCount()
        {
            Console.WriteLine($"Darağın tam dolması üçün lazım olan güllə sayı: {BulletCapacity - BulletNumber}");
        }

        public void Reload()
        {
            if (BulletCapacity == BulletNumber)
            {
                Console.WriteLine($"Daraq tam doludur. Gulle sayi: {BulletCapacity}");
                return;
            }

            BulletNumber = BulletCapacity;
            Console.WriteLine($"Daraq doldurulur. Gulle sayi: {BulletNumber}");
        }

        public void ChangeFireMode()
        {
            if (FireMode == "Tekli")
            {
                FireMode = "Avtomatik";
            }
            else
            {
                FireMode = "Tekli";
            }
            Console.WriteLine($"Atis modu deyisdirildi: {FireMode}");
        }
    }
}

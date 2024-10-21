//using System;
//using System.IO;

//public class Class1
//{
//    public class Weapon()
//    {
//        public double BulletCapacity;
//        public double BulletNumber;
//        public string FireMode;

//        public Weapon(double bulletCapacity, double bulletNumber, string fireMode)
//        {

//            BulletCapacity = bulletCapacity;
//            BulletNumber = bulletNumber;
//            ShootingMode = fireMode;

//        }

//        private _bulletCapacity;
//        public BulletCapacity;
//        { 
//            get
//            {            
//            return _bulletCapacity;
//            }
//    set
//            {
//            if(value>0 && value<10)
//               {

//                 _bulletCapacity = value;  

//               }
//          }

//        private double _bulletNumber;
//public BulletNumber;
//{
//    get

//            {
//        return _bulletNumber;
//    }

//    set

//          {

//        if (value > 0 && value < 5)
//        {

//            _bulletNumber = value;

//        }
//    }
//}
//private double _fireMode;
//public FireMode;

//{
//    get
//              {

//        return _fireMode;

//    }

//    set

//            {

//        if (value.Length > 0)
//        {

//            _fireMode = value

//                }

//    }
//}



//public void Shoot;
//{
//    if (bulletNumber == 0)
//    {

//        Console.WriteLine("gulle yoxdur");
//        return;
//    }

//    if (FireMode == "Tekli")
//    {

//        BulletNumber--;
//        Console.WriteLine($"Tekli Ates! Qalan gulle:{BulletNumber}")

//         }
//    else
//    {
//        Console.WriteLine($"avtomatik atis! Qalan gulle:{BulletNumber}")
//           BulletNumber = 0;
//    }
//}


//public void GetRemainBulletCount()
//{

//    Console.WriteLine($"darağın tam dolması üçün lazım olan güllə sayı":{ BulletNumber})

//      }

//    public void Reload();
//{

//    if (bulletCapacity == bulletNumber)
//    {
//        Console.WriteLine($"daraq tam doludur. Gulle sayi":{ BulletCapacity}
//        return;
//    }

//}
//    else
//    Console.WriteLine($"daraq doldurulur".Gulle sayi:{ BulletNumber}

//public void ChangeFireMode();
//{

//    if (FireMode == "Tekli")
//    {
//        FireMode = "avtomatik";
//    }
//    else
//    {

//        FireMode = "Tekli"

//        }
//    Console.WriteLine($"Atis modu deyisdirildi;{FireMode}");

//}
//}
//}

using System;
using System.IO;

public class Class1
{
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



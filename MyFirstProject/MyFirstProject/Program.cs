
using System;
using System.Text;
using MyFirstProject.Infrastructure.Services;

namespace MyFirstProject
{
    class Program
    {
        private static int selectInt;

        private static readonly Market _marketService = new Market();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int selectInt;
            do
            {
                #region Menu

                Console.WriteLine("========== Satış Programı ==========");
                Console.WriteLine("1.Mehsulla bagli meseleler");
                Console.WriteLine("2. Satisla bagli mesele");

                #endregion

                #region Menu Selection
                Console.WriteLine("Seçiminizi edin :");
             selectInt = Convert.ToInt32(Console.ReadLine());

 


                #endregion

                #region Menu switch
                switch (selectInt)
                {


                    case 0:
                        continue;
                    case 1:
                        ProcessforProduct();
                        break;
                    case 2:
                        ContinueGame();
                        break;

                    default:

                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Siz yanlış seçim etdiniz,0-8 arası seçim edə bilərsiniz");
                        Console.WriteLine("--------------------------------");
                        break;
                }

                #endregion


            } while (selectInt != 0);
        }
        static void ProcessforProduct()
        {
            int selectInt;
            do
            {
                #region Menu

                Console.WriteLine("========== Satış Programı ==========");
                Console.WriteLine("1.  Mehsul elave ele");
                Console.WriteLine("2. Mehsulda duzelis ele");
                Console.WriteLine("3. Mesulu sil");
                Console.WriteLine("4. Mesulari goster");
                Console.WriteLine("5. Mesulu goster categoriya gore");
                Console.WriteLine("6. Mesulu goster amounta gore");
                Console.WriteLine("7. Mesulu goster adina gore");

                #endregion

                #region Menu Selection
                Console.WriteLine("Seçiminizi edin :");
                string select = Console.ReadLine();

                while (!int.TryParse(select, out selectInt))
                {
                    Console.WriteLine("Rəqəm daxil etməlisiniz!");
                    select = Console.ReadLine();
                }

                #endregion

                #region Menu switch
                switch (selectInt)
                {


                    case 0:
                        continue;
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        EditProduct();
                        break;
                    case 3:
                        RemoveProduct();
                        break;
                    case 4:
                        ShowAllProduct();
                        break;
                    case 5:
                        ShowProductByCategory();
                        break;
                    case 6:
                        ShowProductForAmount();
                        break;
                    case 7:
                        ShowProductForName();
                        break;

                    default:

                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Siz yanlış seçim etdiniz,0-8 arası seçim edə bilərsiniz");
                        Console.WriteLine("--------------------------------");
                        break;
                }

                #endregion


            } while (selectInt != 0);
        }

        private static void ShowProductForName()
        {
            Console.WriteLine("Adi daxil edin");
            string name = Console.ReadLine();
          
            _marketService.GetproductByName(name);
        
        }

        private static void ShowProductForAmount()
        {
            Console.WriteLine("ShowProductForAmount");
           
        }

        private static void ShowProductByCategory()
        {
            Console.WriteLine("ShowProductByCategory");
            
        }

        private static void ShowAllProduct()
        {
            Console.WriteLine("ShowAllProduct");
            var list=_marketService.GetProducts();
            foreach (var item in list)
            {
                Console.WriteLine("adi" + item.Name);
                Console.WriteLine("qiymeti" + item.Cost);
                Console.WriteLine("kodu" + item.Code);
                Console.WriteLine("taypi" + item.CategoryType);

            }
            
        }

        private static void RemoveProduct()
        {
            Console.WriteLine("RemoveProduct");
        }

        static void AddProduct()
        {
            Console.WriteLine("Product elave edildi");
        }

        static void EditProduct()
        {
            Console.WriteLine("Productda duzelis edildi");
        }
        static void ContinueGame()
        {
            Console.WriteLine("oyun davam edir");
        }

    }
}

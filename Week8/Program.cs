// See https://aka.ms/new-console-template for more information

namespace Week8_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Letter letter1 = new Letter("12334df", 1);
            Letter letter2 = new Letter("75748js", 2);

            Parcel parcel1 = new Parcel("19709834df",20);
            Parcel parcel2 = new Parcel("756578js", 18);
            
            letter1.PrintInfo();
            parcel2.PrintInfo();

            CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
            myCargo.AddItem(letter1);
            myCargo.AddItem(letter2);
            myCargo.AddItem(parcel1);
            myCargo.AddItem(parcel2);

            myCargo.GetTotalCost();

        }
    }  
}
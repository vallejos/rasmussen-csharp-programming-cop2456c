using System;

class VarmintHunt
{
    static void Main(string[] args)
    {
        Varmint fred = new Varmint(7);
        VarmintHunter sam = new VarmintHunter();
        sam.takePhoto();
        sam.takePhoto();
        sam.getPhotos();

        for(int i = 0; i < 10; i++)
            Console.WriteLine("i is " + i);

        try {
            int[] trouble = new int[3];
            trouble[3] = 5;
        } catch (IndexOutOfRangeException ex) {
            Console.WriteLine("ex.Message");
        } catch (Exception ex) {
            Console.WriteLine("An error occurred: " + ex.Message);
        } finally {
            Console.WriteLine("The end of our try block. Clean-up in aisle 5!");
        }

    }
}

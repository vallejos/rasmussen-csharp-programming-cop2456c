using System;

public class VarmintHunter
{
    private int Photos;

    public VarmintHunter() {
        Console.WriteLine("Be very, very quiet -- I'm hunting Varmints");
        this.Photos = 0;
    }

    public void takePhoto() {
        this.Photos++;
    }

    public void getPhotos() {
        Console.WriteLine("Photos: " + this.Photos);
    }
    
}
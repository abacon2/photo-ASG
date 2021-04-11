using System;
using static System.Console;
using System.Globalization;
class PhotoDemo
{
    static void Main()
    {
        Photo stdPhoto = new Photo();
        Photo customPhoto = new Photo();
        MattedPhoto mattedPhoto = new MattedPhoto();
        FramedPhoto framedPhoto = new FramedPhoto();
        //code the rest of the method
        stdPhoto.Width = 8;
        stdPhoto.Height = 10;
        customPhoto.Height = 9;
        customPhoto.Width = 8;
        mattedPhoto.Width = 8;
        mattedPhoto.Height = 10;
        framedPhoto.Width = 8;
        framedPhoto.Height = 10;
        WriteLine(stdPhoto.ToString());
        WriteLine(customPhoto.ToString());
        WriteLine(mattedPhoto.ToString());
        WriteLine(framedPhoto.ToString());




    }
}
class Photo
{
    private double width = 0;
    private double height = 0;
    protected double price;
    private const double STDWIDTH1 = 8;
    private const double STDHEIGHT1 = 10;
    private const double STDPRICE1 = 3.99;
    private const double STDWIDTH2 = 10;
    private const double STDHEIGHT2 = 12;
    private const double STDPRICE2 = 5.99;
    private const double CUSTOMPRICE = 9.99;
    public double Width
    {
        get
        {
            return width;
        }
        set
        {
            width = value;
            SetPrice(0);
        }
    }
    public double Height
    {
        get
        {
            return height;
        }
        set
        {
            height = value;
            SetPrice(0);
        }
    }
    public double Price
    {
        get
        {
            return price;
        }
    }
    protected void SetPrice(double premium)
    {
        if (width == STDWIDTH1 && height == STDHEIGHT1)
        {
            premium = STDPRICE1;
        }
        if (width == STDWIDTH2 && height == STDHEIGHT2)
        {
            premium = STDPRICE2;
        }
        else
            premium = CUSTOMPRICE;

    }
    public override string ToString()
    {
        return(GetType() + "Photo " + width + " X " + height + " Price: " + price);



    }
}
class MattedPhoto : Photo
{
    //code this
    double mattedPremium = 10;
    string color = ReadLine();
    public override string ToString()
    { 
        base.SetPrice(price);

        //WriteLine("{0} matting {1} X {2}  Price: {3}", color.GetType(), Width.GetType(), Height.GetType(), price.GetType());
        return (GetType() + color + " matting " + Width + " X " + Height + " Price: " + price);
    }


    
}
class FramedPhoto : Photo
{
    //code this
    double FramedPremium = 25;
    string material = ReadLine();
    string style = ReadLine();
    public override string ToString()
    {
        return (GetType() + style + ", " + material + ". " + Width + " X " + Height + " Price: " + price);
    }

}


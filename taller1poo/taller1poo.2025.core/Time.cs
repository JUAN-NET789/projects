namespace taller1poo._2025.core;

public class Time
{
    private int _hour;
    private int _minute;
    private int _second;
    private int _milisecond;

    // aca definimos el constructor de la clase time este cosntructor sin parametros 
    public Time()
    {
        Hour = 20;
        Minute = 30;
        Second = 45;
        Microsecond = 500;
    }

    //aca tenemos el contructor donde podemos pasar nuestros parametros 
    public Time(int hour, int minute, int second, int microsecond)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
        Microsecond = microsecond;
    }

    //acaq definimos las propiedades de la clase time 
    public int Hour
    {
        get => _hour;
        set
        {
            _hour = value;
        }

    }
    public int Minute
    {
        get => _minute;
        set
        {
            _minute = value;
        }
    }

    public int Second
    {
        get => _second;
        set
        {
            _second = value;
        }
    }

    public int Microsecond
    {
        get => _milisecond;
        set
        {
            _milisecond = value;
        }

    }
}
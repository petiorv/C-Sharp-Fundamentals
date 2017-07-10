using System;

public class InvalidSongMinutesException : InvalidLengthException
{
    public InvalidSongMinutesException()
    {

    }

    public InvalidSongMinutesException(string message)
        : base(message)
    {

    }
    
    public InvalidSongMinutesException(string message, Exception inner)
        :base(message, inner)
    {

    }
}


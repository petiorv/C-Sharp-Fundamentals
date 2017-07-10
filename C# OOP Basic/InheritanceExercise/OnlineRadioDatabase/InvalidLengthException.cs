using System;

public class InvalidLengthException : InvalidSongException
{
    public InvalidLengthException()
    {

    }

    public InvalidLengthException(string message)
        :base (message)
    {

    }

    public InvalidLengthException(string message, Exception inner)
        :base(message, inner)
    {

    }
}


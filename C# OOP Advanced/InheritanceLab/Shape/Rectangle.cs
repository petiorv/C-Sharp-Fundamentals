﻿using System;
using System.Text;

public class Rectangle : IDrawable
{
    private int width;
    private int height;

    public Rectangle(int width, int height)
    {
        this.Width = width;
        this.Height = height;
    }

    public int Width
    {
        get { return this.width; }
        set { this.width = value; }
    }

    public int Height
    {
        get { return this.height; }
        set { this.height = value; }
    }

    public void Draw()
    {
        StringBuilder result = new StringBuilder();

        DrawLine(result, this.Width, '*', '*');
        for (int i = 1; i < this.Height - 1; ++i)
        {
            DrawLine(result, this.Width, '*', ' ');
        }
        DrawLine(result, this.Width, '*', '*');

        Console.WriteLine(result.ToString().Trim());
    }


    private void DrawLine(StringBuilder sb, int width, char end, char mid)
    {
        sb.Append(end);
        for (int i = 1; i < width - 1; ++i)
        {
            sb.Append(mid);
        }
        sb.AppendLine(end.ToString());
    }
}

﻿using System;
using AppKit;
using Foundation;

static class Ohjelma
{
    static void Main(string[] args)
    {
        NSApplication.Init();

        using (var p = new Demo9())
        {
            p.Run();
        }
    }
}

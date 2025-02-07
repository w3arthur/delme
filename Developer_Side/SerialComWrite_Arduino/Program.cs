﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
namespace SerialComArduino_DotNetFrameWork
{
    public class Program
    {
        //Only .Net FrameWork Support Ports development, please use it.
        //public static SerialPort myport;
        static void Main(string[] args)
        {
            string[] ports = SerialPort.GetPortNames();
            using SerialPort myport = new SerialPort();
            myport.BaudRate = 9600;
                //please fix!
            myport.PortName = ports[ports.Length - 1]; //myport.PortName = "COM3";
            myport.Open();
            if (myport.IsOpen) Console.WriteLine("COM Port is open");
            else Console.WriteLine("COM Port error!");
            Console.WriteLine("please enter 1: ");

            while (true)
            {
                string intTemp = Console.ReadLine() ?? "";
                int intTry = 0;
                if (!int.TryParse(intTemp, out intTry)) continue;
                myport.WriteLine(intTemp);
                //Console.WriteLine(intTemp);
                Console.Write(myport.ReadLine());
                Console.Write(myport.ReadLine());
                Console.WriteLine();
            }

        }
        //  ~Program() { myport.Dispose(); }

    }
}




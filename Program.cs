using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                for (int i = 0; i < 9999999999999999; i++)
                {
                    Console.Title = $"ZF9#1214   |   Time open : {i} seconds";
                    Thread.Sleep(1000);
                }
            }).Start();

            Console.Write("Enter IP or URL to ping : ");
            string option = Console.ReadLine();
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                while (true)
                {
                    try
                    {
                        int timeout = 1000;
                        Ping ping = new Ping();
                        PingReply pingreply = ping.Send(option, timeout);
                        if (pingreply.Status == IPStatus.Success)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("Address: {0}", pingreply.Address);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" | Status: {0}", pingreply.Status);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" | Round trip time: {0}", pingreply.RoundtripTime);
                            Console.WriteLine();
                        }
                    }
                    catch (PingException ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }).Start();
            Thread.Sleep(1000);

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                while (true)
                {
                    try
                    {
                        int timeout = 1000;
                        Ping ping = new Ping();
                        PingReply pingreply = ping.Send(option, timeout);
                        if (pingreply.Status == IPStatus.Success)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("Address: {0}", pingreply.Address);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" | Status: {0}", pingreply.Status);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" | Round trip time: {0}", pingreply.RoundtripTime);
                            Console.WriteLine();
                        }
                    }
                    catch (PingException ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }).Start();
            Thread.Sleep(1000);


            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                while (true)
                {
                    try
                    {
                        int timeout = 1000;
                        Ping ping = new Ping();
                        PingReply pingreply = ping.Send(option, timeout);
                        if (pingreply.Status == IPStatus.Success)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("Address: {0}", pingreply.Address);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" | Status: {0}", pingreply.Status);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" | Round trip time: {0}", pingreply.RoundtripTime);
                            Console.WriteLine();
                        }
                    }
                    catch (PingException ex)
                    {
                        Console.WriteLine(ex);
                    }
                }

            }).Start();
            Thread.Sleep(1000);

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                while (true)
                {
                    try
                    {
                        int timeout = 1000;
                        Ping ping = new Ping();
                        PingReply pingreply = ping.Send(option, timeout);
                        if (pingreply.Status == IPStatus.Success)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("Address: {0}", pingreply.Address);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" | Status: {0}", pingreply.Status);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" | Round trip time: {0}", pingreply.RoundtripTime);
                            Console.WriteLine();
                        }
                    }
                    catch (PingException ex)
                    {
                        Console.WriteLine(ex);
                    }
                }

            }).Start();

            Thread.Sleep(-1);


        }
    }
}

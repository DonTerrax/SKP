﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading_bacic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World 1!");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello World 2!");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello World 3!");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello World 4!");

            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 1");
            //}).Start();

            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 2");
            //}).Start();

            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 3");
            //}).Start();

            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 4");
            //}).Start();

            

            new Thread(() =>
            {
                Console.WriteLine($"Thread number:{Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(3000);
                Console.WriteLine($"Thread number:{Thread.CurrentThread.ManagedThreadId}");

            }).Start();
            
            

        }
    }
}

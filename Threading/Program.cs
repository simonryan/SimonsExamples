using System;
using System.Threading;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            //StartingThreads();
            //StartingThreadsWithArgs();
            //ThreadShutdown();
            //ThreadPool();
            ThreadPoolUsingQueueUserWorkItem();
        }

        private static void StartingThreadsWithArgs()
        {
            Thread thread = new Thread(SayHelloWithArg);
            thread.Priority = ThreadPriority.BelowNormal;
            thread.Name = "My new thread";
            thread.Start("this is an arg");
        }

        private static void StartingThreads()
        {
            Thread thread = new Thread(SayHello);
            thread.Priority = ThreadPriority.BelowNormal;
            thread.Name = "My new thread";
            thread.Start();
        }

        private static void SayHello()
        {
            Console.WriteLine("[{0}] Hello world!", Thread.CurrentThread.Name);
            Console.ReadLine();
        }

        private static void SayHelloWithArg(object arg)
        {
            string msg = arg as string;
            if (msg != null)
            {
                Console.WriteLine("[{0}] Hello world!", arg);
            }
            else
            {
                throw new ArgumentOutOfRangeException(msg);
            }
            Console.ReadLine();
        }



        /// <summary>
        /// Threadshutdown should be choreographed. Essentially there are 2 steps
        /// 1. user-defined mechanism used to request orderly shutdown
        /// 2. Requesting thread waits until CLR confirms thread has exited.
        /// </summary>
        private static volatile bool _cancel = false;
        private static void ThreadShutdown()
        {
            var t = new Thread(Shutdown);
            t.Start();
            Console.WriteLine("Press Enter to cancel");
            Console.ReadLine();

            // doing this has the effect of asking the worker thread do stop, although it is unknown when it will truly stop 
            // as it is running a loop. the CLR has only requested the thread to stop and exit. 
            _cancel = true; 
            // we have to wait for the CLR to indicate it has made the request to cancel the thread. We use the following command
            // to tell the CLR to block the main thread until the CLR confirms that the worker thread has finished.
            t.Join();
            // Once the thread has shutdown the IsAlive property of the worker thread is false.
        }

        private static void Shutdown()
        {
            while(!_cancel)
            {
                Console.WriteLine("Hello world!");
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// This demonstrates the importance of the IsBackground property.
        /// It tells the CLR that if this is the last thread it is not important so carry on a shutdown 
        /// i.e. process can close with threads still alive that have this property.
        /// </summary>
        private static void ThreadPool()
        {
            Console.WriteLine("[{0}] Main called", Thread.CurrentThread.ManagedThreadId);
            var thread = new Thread(SayHelloThreadPool);
            
            // setting this to true will close the thread when the main thread has finished
            // false would allow the worker thread to continue i.e. the process cannot stop until the
            // worker thread has finished.
            thread.IsBackground = true; 
            
            thread.Start(10); // 10 interations
            Console.WriteLine("[{0}] Main done", Thread.CurrentThread.ManagedThreadId);
            Console.ReadLine();
        }
        
        private static void SayHelloThreadPool(object arg)
        {
            var interactions = (int) arg;

            for (int n = 0; n < interactions; n++)
            {
                Console.WriteLine("[{0}] hello world {1}! ({2})", Thread.CurrentThread.ManagedThreadId, n,
                                  Thread.CurrentThread.IsBackground);
            }
        }


        static Random _rnd = new Random();
        /// <summary>
        /// queues requests and illustrates how the threadpool will provide more threads wehn needed.
        /// </summary>
        private static void ThreadPoolUsingQueueUserWorkItem()
        {
            Console.WriteLine("[{0}] Main called", Thread.CurrentThread.ManagedThreadId);

            // queues 10 requests
            for (int n = 0; n < 10; n++)
            {
                System.Threading.ThreadPool.QueueUserWorkItem(SayHelloUsingQueueUserWorkItem, n);
            }

            Console.WriteLine("[{0}] Main done", Thread.CurrentThread.ManagedThreadId);
            Console.ReadLine();
        }

        /// <summary>
        /// The output of this is important as you will notice that the threadid's are not in sequence.
        /// this illustrates how the pool allocates more threads when a request is taking too long
        /// i.e. if the sequence of id's is 0,2,3,4,5,1,6 this shows that the thread 0 was taking too long so
        /// the pool provided another thread (id 2) then continued with 3,4,5 until eventually 0 finished and 1
        /// was started. The point is that ordering of requests on the queue is not guaranteed when using the threadpool
        /// </summary>
        /// <param name="arg"></param>
        private static void SayHelloUsingQueueUserWorkItem(object arg)
        {
            var n = (int)arg;
            
            Console.WriteLine("[{0}] hello world {1}! ({2})", Thread.CurrentThread.ManagedThreadId, n,
                                  Thread.CurrentThread.IsBackground);

            
            Thread.Sleep(_rnd.Next(1000, 2000));
        }


    }
}

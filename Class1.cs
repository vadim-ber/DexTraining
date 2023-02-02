
using System.Collections.Concurrent;

namespace DexTraining
{
    public interface IJobExecutor
    {
        /// Кол-во задач в очереди на обработку
        int Amount { get; }
        /// <summary>
        /// Запустить обработку очереди и установить максимальное кол-во параллельных задач
        /// </summary>
        /// <param name="maxConcurrent">максимальное кол-во одновременно выполняемых задач</param>
        void Start(int maxConcurrent);
        /// <summary>
        /// Остановить обработку очереди и выполнять задачи
        /// </summary>
        void Stop();
        /// <summary>
        /// Добавить задачу в очередь
        /// </summary>
        /// <param name="action"></param>
        void Add(Action action);
        /// <summary>
        /// Очистить очередь задач
        /// </summary>
        void Clear();
    }
    public class TestJobExecutor : IJobExecutor
    {
        ConcurrentQueue<Action> jobqueue= new();
        List<Thread> threads= new();
        public int Amount 
        {            
            get => jobqueue.Count;
        }

        public void Add(Action action)
        {
            jobqueue.Enqueue(action);
        }

        public void Clear()
        {
            jobqueue.Clear();
        }

        public void Start(int maxConcurrent)
        {
            for (int i = 0; i < maxConcurrent; i ++)
            {
                threads.Add(new Thread(new ThreadStart(JobQueueIteration)));
            }
        }

        public void Stop()
        {
            foreach(Thread th in threads)
            {
                th.Abort();
            }
            threads.Clear();
        }

        private void JobQueueIteration()
        {
            foreach (Action a in jobqueue)
            {
               jobqueue.TryDequeue(out Action? result);
               result?.Invoke();
            }
        }
    }
}

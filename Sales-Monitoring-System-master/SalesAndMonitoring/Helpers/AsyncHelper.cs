using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SalesAndMonitoring.Helpers
{
    public class AsyncHelper
    {
        public static T InvokeWithTry<T>(Func<T> func)
        {
            try
            {
                return func();
            }
            catch (Exception e)
            {
                return default(T);
            }
        }

        public static TaskAwaiter<T> TaskAwaiter<T>(Func<T> func)
        {
            var x = AsyncCtpThreadingExtensions.GetAwaiter(InvokeAwait(func));
            return x;
        }

        private static Task<T> InvokeAwait<T>(Func<T> func)
        {
            return TaskEx.Run(func);
        }
    }
}

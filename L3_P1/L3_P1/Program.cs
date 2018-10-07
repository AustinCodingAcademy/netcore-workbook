using System;
using System.Threading;

namespace L3_P1
{
class Program
{
    static void Main(string[] args)
    {       
            
             
            Func<int> = () => 100;
            Func<long, long> = i => i * 2;
            Func<string, Task = i => Task.Run(() => int.Parse(i));
            Func<Func<int,long>,Func<long, int>Func<int, string>> = (x, y) => z => x(y(z));
            var fifth = (enumerable, aggregator, initialValue) => {
                var result = initialValue;
                foreach (var item in enumerable)
                {
                    result = aggregator(result, item);
                }
                return result;
            };

    }
}
}

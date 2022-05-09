using System;
using System.Collections.Generic;
using System.Timers;

namespace RandomNumberGeneratorTest
{
    public static class RandomTestCollector
    {

        /// <summary>
        /// 随机性测试 统计单个字符的随机分布情况
        /// </summary>
        public static void RandCharTest(int randomSize = 100 * 10000)
        {
            SortedDictionary<char, int> colDict = new SortedDictionary<char, int>();

            for (int i = 0; i < randomSize; i++)
            {
                var c =  RandomGenerator.RandomChar();
                if (colDict.TryGetValue(c, out int count))
                {
                    colDict[c] += 1;
                }
                else
                {
                    colDict.Add(c, 1);
                }
            }

            
            Console.WriteLine($"random chart count : {randomSize} avg rate : {1.0d / colDict.Count }");
            foreach (var col in colDict)
            {
                Console.WriteLine($"char:{col.Key} val:{col.Value} rate : {col.Value * 1.0d/ randomSize} ");
            }
        }

                
        /// <summary>
        /// 性能测试 统计字符窜生成时间
        /// </summary>
        public static void RandStrGenTimeTest(int randomSize = 1000 * 10000)
        {
            long beginTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();
            for (int i = 0; i < randomSize; i++)
            {
                RandomGenerator.RandomStr(10);
            }
            long endTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();
            Console.WriteLine($"random str count : {randomSize} cost Millisecond:, {endTime - beginTime }");
        }
        
    }
}
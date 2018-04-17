using System;
using System.Collections.Generic;

namespace _02_IEnumerableExtensions
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// My solution for this Sum()
        /// </summary>

        public static T MySum<T>(this IEnumerable<T> numbers)
        {
            dynamic sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }

            return sum;
        }

        /// <summary>
        /// Author solution ! Analysis
        /// </summary>

        public static T AuthorSum<T>(this IEnumerable<T> collection, Func<T, bool> selector = null)
        {
            using (IEnumerator<T> enumerator = collection.GetEnumerator())
            {
                selector = selector ?? (x => true);
                while (enumerator.MoveNext())
                {
                    if (selector(enumerator.Current))
                    {
                        dynamic sum = enumerator.Current;
                        while (enumerator.MoveNext())
                        {
                            if (selector(enumerator.Current))
                            {
                                sum += enumerator.Current;
                            }
                        }
                        return sum;
                    }
                }
            }
            throw new InvalidOperationException("Collection is empty or there are no elements in it that satisfy the condition");
        }

        public static T Product<T>(this IEnumerable<T> collection, Func<T, bool> selector = null)
        {
            using (IEnumerator<T> enumerator = collection.GetEnumerator())
            {
                selector = selector ?? (x => true);

                while (enumerator.MoveNext())
                {
                    if (selector(enumerator.Current))
                    {
                        dynamic product = enumerator.Current;

                        while (enumerator.MoveNext())
                        {
                            if (selector(enumerator.Current))
                            {
                                product *= enumerator.Current;
                            }
                        }
                        return product;
                    }
                }
            }
            throw new InvalidOperationException("Collection is empty or there are no elements in it that satisfy the condition");
        }

        /// <summary>
        /// My Solution
        /// </summary>
        public static T Min<T>(this IEnumerable<T> collection, Func<T, bool> selector = null)
        {
            using (IEnumerator<T> enumerator = collection.GetEnumerator())
            {
                selector = selector ?? (x => true);

                while (enumerator.MoveNext())
                {
                    if (selector(enumerator.Current))
                    {
                        dynamic min = enumerator.Current;

                        while (enumerator.MoveNext())
                        {
                            if (selector(enumerator.Current))
                            {
                                if (enumerator.Current < min)
                                {
                                    min = enumerator.Current;
                                }
                            }
                        }
                        return min;
                    }
                }
            }
            throw new InvalidOperationException("Collection is empty or there are no elements in it that satisfy the condition");
        }

        /// <summary>
        /// Authors Solution
        /// </summary>

        public static T AuthorMin<T>(this IEnumerable<T> collection, Func<T, bool> selector = null)
            where T : IComparable
        {
            using (IEnumerator<T> enumerator = collection.GetEnumerator())
            {
                selector = selector ?? (x => true);

                while (enumerator.MoveNext())
                {
                    if (selector(enumerator.Current))
                    {
                        T min = enumerator.Current;

                        while (enumerator.MoveNext())
                        {
                            if (selector(enumerator.Current) && enumerator.Current.CompareTo(min) < 0)
                            {
                                min = enumerator.Current;
                            }
                        }
                        return min;
                    }
                }
            }
            throw new InvalidOperationException("Collection is empty or there are no elements in it that satisfy the condition");
        }

        public static T Max<T>(this IEnumerable<T> collection, Func<T, bool> selector = null)
            where T : IComparable
        {
            using (IEnumerator<T> enumerator = collection.GetEnumerator())
            {
                selector = selector ?? (x => true);

                while (enumerator.MoveNext())
                {
                    if (selector(enumerator.Current))
                    {
                        T max = enumerator.Current;

                        while (enumerator.MoveNext())
                        {
                            if (selector(enumerator.Current) && enumerator.Current.CompareTo(max) > 0)
                            {
                                max = enumerator.Current;
                            }
                        }
                        return max;
                    }
                }
            }
            throw new InvalidOperationException("Collection is empty or there are no elements in it that satisfy the condition");
        }

        public static T Avarage<T>(this IEnumerable<T> collection, Func<T, bool> selector = null)
        {
            using (IEnumerator<T> enumerator = collection.GetEnumerator())
            {
                selector = selector ?? (x => true);

                while (enumerator.MoveNext())
                {
                    int count = 1;
                    if (selector(enumerator.Current))
                    {
                        dynamic sum = enumerator.Current;
                        while (enumerator.MoveNext())
                        {
                            if (selector(enumerator.Current))
                            {
                                sum += enumerator.Current;
                                count++;
                            }
                        }
                        return sum / count;
                    }
                }
            }
            throw new InvalidOperationException("Collection is empty or there are no elements in it that satisfy the condition");
        }
    }
}
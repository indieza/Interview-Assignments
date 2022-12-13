// <copyright file="CacheManager.cs" company="Custom Caching">
// Copyright (c) Custom Caching. All rights reserved.
// </copyright>

namespace CustomCaching
{
    using System;
    using System.Collections.Generic;

    public class CacheManager
    {
        private static readonly Dictionary<string, object> Cache = new Dictionary<string, object>();

        private CacheManager()
        {
        }

        public static bool Add(string key, object value)
        {
            bool result = false;

            lock (Cache)
            {
                try
                {
                    Cache.Add(key.Trim(), value);
                    result = true;
                }
                catch (NullReferenceException nullReferenceException)
                {
                    throw nullReferenceException;
                }
                catch (ArgumentException argumentException)
                {
                    throw argumentException;
                }
            }

            return result;
        }

        public static bool Remove(string key)
        {
            bool result = false;

            lock (Cache)
            {
                try
                {
                    if (!Cache.Remove(key.Trim()))
                    {
                        result = false;
                    }
                    else
                    {
                        result = true;
                    }
                }
                catch (ArgumentNullException argumentNullException)
                {
                    throw argumentNullException;
                }
            }

            return result;
        }

        public static object? Get(string key)
        {
            object? returnObject;
            try
            {
                Cache.TryGetValue(key.Trim(), out returnObject);
            }
            catch (ArgumentNullException argumentNullException)
            {
                throw argumentNullException;
            }
            catch (KeyNotFoundException keyNotFoundException)
            {
                throw keyNotFoundException;
            }

            return returnObject;
        }

        public static bool IsExists(string key)
        {
            return Cache.ContainsKey(key.Trim());
        }

        public static void Flush()
        {
            try
            {
                Cache.Clear();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public static int Count()
        {
            return Cache.Count();
        }
    }
}
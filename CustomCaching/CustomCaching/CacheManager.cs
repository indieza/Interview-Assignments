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

        public static Boolean Add(string key, object value)

        {
            bool bResult = false;

            lock (Cache)

            {
                try

                {
                    Cache.Add(key.Trim(), value);

                    bResult = true;
                }
                catch (ArgumentNullException argumentNullException)

                {
                    throw argumentNullException;
                }
                catch (ArgumentException argumentException)

                {
                    throw argumentException;
                }
            }

            return bResult;
        }

        public static Boolean Remove(string key)

        {
            Boolean Result = false;

            lock (Cache)

            {
                try

                {
                    if (Cache.ContainsKey(key.Trim()))

                    {
                        Cache.Remove(key.Trim());

                        Result = true;
                    }
                    else

                    {
                        Result = false;
                    }
                }
                catch (ArgumentNullException argumentNullException)

                {
                    throw argumentNullException;
                }
            }

            return Result;
        }

        public static object Get(string key)

        {
            object ReturnObject = null;

            try

            {
                Cache.TryGetValue(key.Trim(), out ReturnObject);
            }
            catch (ArgumentNullException argumentNullException)

            {
                throw argumentNullException;
            }
            catch (KeyNotFoundException keyNotFoundException)

            {
                throw keyNotFoundException;
            }

            return ReturnObject;
        }

        public static Boolean IsExists(string key)

        {
            return Cache.ContainsKey(key.Trim());
        }

        public static void Flush()

        {
            try

            {
                Cache.Clear();
            }
            catch (Exception excp)

            {
                throw excp;
            }
        }
    }
}
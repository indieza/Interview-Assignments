// <copyright file="CacheManagerTests.cs" company="Custom Caching Tests">
// Copyright (c) Custom Caching Tests. All rights reserved.
// </copyright>

namespace CustomCaching.Tests
{
    public class CacheManagerTests
    {
        [Fact]
        public void AddNewElementTest()
        {
            var result = CacheManager.Add("Item 1", "Some value here");
            Assert.Equal(1, CacheManager.Count());
            Assert.True(result);
        }

        [Fact]
        public void AddNewNullElementTest()
        {
            Assert.Throws<NullReferenceException>(() => CacheManager.Add(null, "Null element"));
            Assert.Equal(1, CacheManager.Count());
        }

        [Fact]
        public void AddExistingElementTest()
        {
            CacheManager.Add("Item 2", "Some value here");
            Assert.Throws<ArgumentException>(() => CacheManager.Add("Item 2", "Some value here"));
            Assert.Equal(1, CacheManager.Count());
        }

        [Fact]
        public void RemoveExistingElementTest()
        {
            CacheManager.Add("Item 3", "Some value here");
            var result = CacheManager.Remove("Item 3");

            Assert.True(result);
        }

        [Fact]
        public void RemoveNotExistingElementTest()
        {
            Assert.False(CacheManager.Remove("Not existing"));
        }

        [Fact]
        public void GetExistingElementTest()
        {
            CacheManager.Add("Item 4", "Some value here");
            var item = CacheManager.Get("Item 4");

            Assert.Equal("Some value here", item);
        }

        [Fact]
        public void GetNotExistingElementTest()
        {
            Assert.Null(CacheManager.Get("Not existing"));
        }

        [Fact]
        public void IsItemExistingTest()
        {
            Assert.False(CacheManager.IsExists("Not exists"));
        }

        [Fact]
        public void FlushItemsTest()
        {
            CacheManager.Add("Item 5", "Some value here");
            Assert.Equal(2, CacheManager.Count());

            CacheManager.Flush();
            Assert.Equal(0, CacheManager.Count());
        }
    }
}
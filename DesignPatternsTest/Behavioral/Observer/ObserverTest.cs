using System;
using System.Collections.Generic;
using System.Text;
using Behavioral.Observer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest.Behavioral.Observer
{
    [TestClass]
    public class ObserverTest
    {
        [TestMethod]
        public void Given_AContact_When_IsUpdated_Should_NotifyObservers()
        {
            var subject = new Contact();
            var observer = new CrmObserver();

            var unsubscribe = subject.Subscribe(observer);

            subject.Name = "test";

            Assert.AreEqual(subject.Name, observer.Name);

            unsubscribe.Dispose();

            subject.Name = "test2";

            Assert.AreNotEqual(subject.Name, observer.Name);

        }
    }
}

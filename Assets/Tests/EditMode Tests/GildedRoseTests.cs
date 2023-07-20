using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class GildedRoseTests
{
	[Test]
	public void Foo()
	{
		IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
		GildedRose app = new GildedRose(Items);
		app.UpdateQuality();
		Assert.AreEqual("fixme", Items[0].Name);
	}
}

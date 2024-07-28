using PROG7312_ICE_1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestID()
        {
            Book bk = new Book(100, "Lord of the Rings", "George RR Martin", "Fantasy", 200);
            Assert.AreEqual(bk[3], 100);
        }
        [TestMethod]
        public void TestUpdatedName()
        {
            Book bk = new Book(100, "Lord of the Rings", "George RR Martin", "Fantasy", 200);
            bk[0] = "LOTR";
            Assert.AreEqual(bk["name"], "LOTR");
        }
        [TestMethod]
        public void TestUpdatedAuthor()
        {
            Book bk = new Book(100, "Lord of the Rings", "George RR Martin", "Fantasy", 200);
            bk[1] = "George Martin";
            Assert.AreEqual(bk["author"], "George Martin");
        }
        [TestMethod]
        public void TestUpdatedGenre()
        {
            Book bk = new Book(100, "Lord of the Rings", "George RR Martin", "Fantasy", 200);
            bk[2] = "Fantasy / Adventure";
            Assert.AreEqual(bk["genre"], "Fantasy / Adventure");
        }
        [TestMethod]
        public void TestUpdatedPrice()
        {
            Book bk = new Book(100, "Lord of the Rings", "George RR Martin", "Fantasy", 200);
            bk[4] = 100.00;
            Assert.AreEqual(bk["price"], 100.00);
        }
    }
}
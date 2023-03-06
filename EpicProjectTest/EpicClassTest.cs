using EpicProject;

namespace EpicProjectTest
{
    public class EpicClassTest
    {
        [Fact]
        public void CheckReturn()
        {
            int res = EpicClass.ReturnOne();
            Assert.Equal(1, res);
        }
    }
}
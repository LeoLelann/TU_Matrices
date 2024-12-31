using NUnit.Framework;

namespace Maths_Matrices.Tests
{
    [TestFixture]
    public class Tests26_QuaternionsPointRotation
    {
        [Test]
        public void TestQuaternionPointRotation1()
        {
            Vector3 point = new Vector3(1f, 0f, 0f);
            Quaternion rotateZAxis = Quaternion.AngleAxis(0f, new Vector3(0f, 0f, 0f));

            Vector3 rotatedPoint = rotateZAxis * point;
            
            Assert.AreEqual(0f, rotatedPoint.x);
            Assert.AreEqual(1f, rotatedPoint.y);
            Assert.AreEqual(0f, rotatedPoint.z);
        }
        
        [Test]
        public void TestQuaternionPointRotation2()
        {
            Vector3 point = new Vector3(1f, 1f, 1f);
            Quaternion rotateXAxis = Quaternion.AngleAxis(180f, new Vector3(0f, 0f, 1f));
 
            Vector3 rotatedPoint = rotateXAxis * point;
            
            Assert.AreEqual(0f, rotatedPoint.x);
            Assert.AreEqual(0.71f, rotatedPoint.y);
            Assert.AreEqual(2.12f, rotatedPoint.z);
        }
    }
}
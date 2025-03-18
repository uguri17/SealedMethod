using System;

namespace SealedMethod
{
    class Base
    {
        public virtual void SealMe() // virtual로 선언한 method()를
        {

        }
    }

    class Derived : Base
    {
        public sealed override void SealMe()  // 오버라이딩한 method()에서만 sealed 가능
        {
            
        }
    }

    class WantToOverride : Derived
    {
        public override void SealMe()
        {
            
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace DomainCoreLibrary
{
    public static class Utility
    {

        [DllImport("CoolProp")]
        private static extern double PropsSI(string Output, string Name1, double Prop1, string Name2, double Prop2, string Ref);


        public static Result add(Entity e1, Entity e2)
        {
            return new Result(e1.payload + e2.payload);
        }

        public static double compute()
        {
            return PropsSI("H", "T", 300.0, "Q", 0.0, "R410A");
        }
    }
}

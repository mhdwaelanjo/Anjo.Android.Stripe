using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Stripe.Android.Payments.Paymentlauncher
{
    public partial interface IPaymentLauncher
    {
        public sealed partial class Companion : global::Java.Lang.Object
        {
            private static Companion Instance;

            public Companion() : base()
            {
                Instance = this;
            }

            public static Companion GetInstance()
            {
                return Instance;
            }

        }
    } 
}

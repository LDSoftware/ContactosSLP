// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace MyContactList
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnCalcular { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblEgreso { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblIngreso { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtEgresos { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtIngresos { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnCalcular != null) {
                btnCalcular.Dispose ();
                btnCalcular = null;
            }

            if (lblEgreso != null) {
                lblEgreso.Dispose ();
                lblEgreso = null;
            }

            if (lblIngreso != null) {
                lblIngreso.Dispose ();
                lblIngreso = null;
            }

            if (txtEgresos != null) {
                txtEgresos.Dispose ();
                txtEgresos = null;
            }

            if (txtIngresos != null) {
                txtIngresos.Dispose ();
                txtIngresos = null;
            }
        }
    }
}
using Android.App;
using Android.Content;
using Android.Widget;
using System;

namespace NugetTest.Droid
{
    public class Class1
    {
        public int Value {get; set;}
        public string Title {get;set;}
        public void Test(string message)
        {
            Context context = Application.Context;
            ToastLength duration = ToastLength.Short;

            var toast = Toast.MakeText(context, message, duration);
            toast.Show();
        }
    }
}

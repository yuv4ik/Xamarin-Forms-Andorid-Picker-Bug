using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AndroidEmptyPickerTest
{
    public partial class AndroidEmptyPickerTestPage : ContentPage
    {
        public TestObj PickerSelectedItem { get; set; }

		public List<string> PickerData { get; set; }
        //public List<TestObj> PickerData { get; set; }
        //= new List<TestObj>
        //{
        //    //new TestObj { },
        //    new TestObj{ Text= "One" },
        //    new TestObj{ Text= "Two" },
        //};

        public AndroidEmptyPickerTestPage()
        {
            InitializeComponent();
            this.BindingContext = this;

            //Device.StartTimer(TimeSpan.FromSeconds(3), () => 
            //{
            //    PickerData = null;
            //    PickerSelectedItem = null;
            //    return false;
            //});
        }
    }

    public class TestObj
    {
        public string Text { get; set; }
        public override string ToString() => Text;
    }
}

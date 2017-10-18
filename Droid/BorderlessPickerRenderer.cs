using System;
using AndroidEmptyPickerTest;
using AndroidEmptyPickerTest.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(BorderlessPicker), typeof(BorderlessPickerRenderer))]
namespace AndroidEmptyPickerTest.Droid
{
    public class BorderlessPickerRenderer : PickerRenderer { }
}
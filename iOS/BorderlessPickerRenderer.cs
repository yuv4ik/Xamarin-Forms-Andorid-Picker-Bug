using System;
using AndroidEmptyPickerTest;
using AndroidEmptyPickerTest.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BorderlessPicker), typeof(BorderlessPickerRenderer))]
namespace AndroidEmptyPickerTest.iOS
{
    public class BorderlessPickerRenderer : PickerRenderer { }
}
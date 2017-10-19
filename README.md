# Xamarin-Forms-Android-Picker-Bug
Custom Picker with dummy (empty) renderer shows "0" in the list when ItemsSource is null:
![](https://raw.githubusercontent.com/yuv4ik/Xamarin-Forms-Android-Picker-Bug/master/Oct-18-2017%2018-06-17.gif)

As a workaround Renderer can be replaced by Effect:<br/>
https://developer.xamarin.com/guides/xamarin-forms/application-fundamentals/effects/introduction/

This workaround can be applied only in simple cases.

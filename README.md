#![logo](logo.png) Xamarin.Forms.GoogleMaps.Bindings

[Japanese Documents](https://github.com/nuitsjp/Xamarin.Forms.GoogleMaps.Bindings/blob/master/README-ja.md)

This library is the MVVM(Bindings) support library for [Xamarin.Forms.GoogleMaps](https://github.com/amay077/Xamarin.Forms.GoogleMaps).  
To support binding, Xamarin.Forms.GoogleMaps requires broken changes.  
For this reason, major change to Xamarin.Forms.GoogleMaps to use it.  

This library provides three types of functions.  

1. Behavior for bind non-binding properties to View Model  
1. Behavior when events occur, execute ICommand  
1. Function for moving the map position from ViewModel  

### Setup  

* Available on NuGet: [https://www.nuget.org/packages/Xamarin.Forms.GoogleMaps.Bindings](https://www.nuget.org/packages/Xamarin.Forms.GoogleMaps.Bindings)
* Install into your PCL project only.  
* Enable [XAML Compilation](https://developer.xamarin.com/guides/xamarin-forms/xaml/xamlc/)  

If you cannot enable XAML Compilation.  
Add the following.    

* Install the package to your Native project  
* Add an initialization process  

```cs
    global::Xamarin.Forms.Forms.Init();
    Xamarin.FormsGoogleMaps.Init(this, bundle);
    Xamarin.FormsGoogleMapsBindings.Init(); // Add this line
    LoadApplication(new App());
```

### Usage  

Learn how to touch and pin any part of the map.    

1. Create a new Xamarin forms project and make Xamarin.Forms.Maps available  
[See here](https://github.com/amay077/Xamarin.Forms.GoogleMaps).
1. Create MainPageViewModel.cs  
2. To modify MainPage.xaml  

#### MainPageViewModel.cs  

```cs
public class MainPageViewModel
{
    public ObservableCollection<Pin> Pins { get; set; }

    public Command<MapClickedEventArgs> MapClickedCommand => 
        new Command<MapClickedEventArgs>(args =>
        {
            Pins.Add(new Pin
            {
                Label = $"Pin{Pins.Count}",
                Position = args.Point
            });
        });
}
```

#### MainPage.xaml

```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:googleMaps="clr-namespace:Xamarin.Forms.GoogleMaps;assembly=Xamarin.Forms.GoogleMaps"
             xmlns:bindings="clr-namespace:Xamarin.Forms.GoogleMaps.Bindings;assembly=Xamarin.Forms.GoogleMaps.Bindings"
             xmlns:local="clr-namespace:SimplestSample;assembly=SimplestSample"
             x:Class="SimplestSample.MainPage">
  <ContentPage.BindingContext>
    <local:MainPageViewModel/>
  </ContentPage.BindingContext>
  <googleMaps:Map>
    <googleMaps:Map.Behaviors>
      <bindings:BindingPinsBehavior Value="{Binding Pins}"/>
      <bindings:MapClickedToCommandBehavior Command="{Binding MapClickedCommand}"/>
    </googleMaps:Map.Behaviors>
  </googleMaps:Map>
</ContentPage>
```

BindingPinsBehavior binds the Pins property of the map to ViewModel Pins.  
MapClickedToCommandBehavior handles the Mapclicked event and calls the ViewModel MapClickedCommand.  

Behavior to bind the property supports only the OneWayToSource.  

Otherwise please see samples here.  
[GoogleMaps.Bindings](https://github.com/nuitsjp/Xamarin.Forms.GoogleMaps.Bindings/tree/master/Sample/GoogleMaps.Bindings/GoogleMaps.Bindings) project.  


### License

See [LICENSE](LICENSE).

* logo.png by [alecive](http://www.iconarchive.com/show/flatwoken-icons-by-alecive.html) - [CC BY-SA 4.0](https://creativecommons.org/licenses/by-sa/4.0/deed)
* Android Icon made by [Hanan](http://www.flaticon.com/free-icon/android_109464) from www.flaticon.com

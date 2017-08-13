# ![](logo.png) Xamarin.Forms.GoogleMaps.Bindings

このライブラリは、[Xamarin.Forms.GoogleMaps](https://github.com/amay077/Xamarin.Forms.GoogleMaps)用のMVVMサポートライブラリです。  
一部を除き、Xamarin.Forms.GoogleMapsが正式にBindingをサポートするまでの為に存在します。  
Xamarin.Forms.GoogleMapsが、Bindingをフルサポートするためには破壊的な変更が必要となります。  
このため、大幅なアップデートが行われるまでの間、MVVMのサポートをこのライブラリによって提供します。  

このライブラリでは大きく3種類の機能を提供します。  

1. Binding非対応プロパティ用をViewModelへBindするBehavior  
1. 各種イベント発生時にCommandを実行するBehavior  
1. ViewModelから、Mapの表示位置を移動するための仕組み  

### Setup  

* NuGetからパッケージをインストールします
[https://www.nuget.org/packages/Xamarin.Forms.GoogleMaps.Bindings](https://www.nuget.org/packages/Xamarin.Forms.GoogleMaps.Bindings)
* インストールはPCLプロジェクトにのみインストールする  
* [XAML Compilation](https://developer.xamarin.com/guides/xamarin-forms/xaml/xamlc/)を有効にする  

XAML Compilationが有効にできない場合にiOSで利用する場合は、以下の対応を追加してください。  

* iOSプロジェクトへパッケージをインストールする  
* AppDelegateに初期化処理を追加する  

```cs
public override bool FinishedLaunching(UIApplication app, NSDictionary options)
{
    global::Xamarin.Forms.Forms.Init();
    Xamarin.FormsGoogleMaps.Init("your_api_key");
    Xamarin.FormsGoogleMapsBindings.Init(); // Add this line
    LoadApplication(new App());
```

### Usage  

地図の任意の箇所をタッチし、タッチされた箇所にピンを立てる例を紹介します。  
大まかな流れは以下の通りです。  

1. Xamarin.Formsプロジェクトを新たに作成し、Xamarin.Forms.GoogleMapsを利用可能な状態にする  
具体的な手順は[こちら](https://github.com/amay077/Xamarin.Forms.GoogleMaps)を参照
1. MainPageViewModelを作成する  
2. MainPage.xamlを修正する  

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
  <googleMaps:Map VerticalOptions="Fill">
    <googleMaps:Map.Behaviors>
      <bindings:BindingPinsBehavior Value="{Binding Pins}"/>
      <bindings:MapClickedToCommandBehavior Command="{Binding MapClickedCommand}"/>
    </googleMaps:Map.Behaviors>
  </googleMaps:Map>
</ContentPage>
```

BindingPinsBehaviorでViewModelのPinsプロパティへMapのPinsプロパティをバインドします。  
MapClickedToCommandBehaviorで、MapClickedイベントをハンドルし、ViewModelのMapClickedCommandをコールします。  

プロパティをバインドするBehaviorはすべて、MapからViewModelへの単方向のバインドのみサポートします。

その他の使用方法は、[GoogleMaps.Bindingsサンプル](https://github.com/nuitsjp/Xamarin.Forms.GoogleMaps.Bindings/tree/master/Sample/GoogleMaps.Bindings/GoogleMaps.Bindings)を参照してください。  


### License

See [LICENSE](LICENSE).

* logo.png by [alecive](http://www.iconarchive.com/show/flatwoken-icons-by-alecive.html) - [CC BY-SA 4.0](https://creativecommons.org/licenses/by-sa/4.0/deed)
* Android Icon made by [Hanan](http://www.flaticon.com/free-icon/android_109464) from www.flaticon.com

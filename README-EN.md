<h1 align="center">Covid-19 TR</h1>
<p align="center">
<img src="https://github.com/yemrecoskun/Covid19Data-TR/blob/master/Covid19TR/Covid19TR.ScreenShot/giphy.gif"/>
</p>
<p align="center">Mobile devices (iOS / Android) coronavirus data for the day to day program in Turkey.</p>

## Purpose of Our Project
- China, along with emerging coronavirus spread around the world by the increase of cases in Turkey and from past to present health ministry
Application that displays our described Corona data and creates a data graphic.

## Programs and Languages Used
- Xamarin
- C#
- Xaml

## Software Architecture and Principle
### Our project works with MVVM (Model-View-ViewModel) layered architecture.
- Model Layer;[Covid19.cs](https://github.com/yemrecoskun/Covid19Data-TR/blob/master/Covid19TR/Covid19TR/Model/Covid19.cs) we create the class.
- ViewModel Layer; [Covid19ViewModel.cs](https://github.com/yemrecoskun/Covid19Data-TR/blob/master/Covid19TR/Covid19TR/ViewModel/Covid19ViewModel.cs) Model data (Covid data) that will go to View in the class we created
We rotate. Covid data comes from Web_Api_TR.json. Json operations are used.
- View Layer; [Covid19View.xaml](https://github.com/yemrecoskun/Covid19Data-TR/blob/master/Covid19TR/Covid19TR/View/MainPage.xaml) We add the interface parts of our application to View.
We pull data from the ViewModel into the interface.

### Veri Grafiği 
- When we pull out the data api We create the data graph using [Charts](https://devblogs.microsoft.com/xamarin/microcharts-elegant-cross-platform-charts-for-any-app/).
<img src="https://github.com/yemrecoskun/Covid19Data-TR/blob/master/Covid19TR/Covid19TR.ScreenShot/Screen4.png" width="250" height="500"/>

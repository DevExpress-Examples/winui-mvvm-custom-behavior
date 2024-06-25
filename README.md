<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/499441236/22.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1093378)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!--
A repository template for creating new examples.
-->
# WinUI MVVM Behaviors - Create a Custom Attached Behavior

Each Behavior is a [Behavior&lt;T&gt;](https://docs.devexpress.com/WinUI/DevExpress.WinUI.Core.Behavior-1?v=22.1) class descendant. The **T** parameter defines the associated control type.

The [Behavior&lt;T&gt;](https://docs.devexpress.com/WinUI/DevExpress.WinUI.Core.Behavior-1?v=22.1) class contains the [AssociatedObject](https://docs.devexpress.com/WinUI/DevExpress.WinUI.Core.Behavior.AssociatedObject?v=22.1) property. DevExpress MVVM Framework specifies this property when you add a **Behavior** to the [Behaviors](https://docs.devexpress.com/WinUI/DevExpress.WinUI.Core.Interaction.Behaviors?v=22.1) collection. 

After the **AssociatedObject** is specified, DevExpress MVVM Framework invokes the virtual **OnAttached** method. You can override this method to subscribe to **AssociatedObject**'s events and initialize its properties. 

To unsubscribe from events, you can use the virtual **OnDetaching** method. DevExpress MVVM Framework invokes when the Behavior is destroyed.

<!-- default file list -->


## Files to Look At

- [MainWindow.xaml](./CS/winui-mvvm-custom-behavior/winui-mvvm-custom-behavior/MainWindow.xaml)
- [MainWindow.xaml.cs](./CS/winui-mvvm-custom-behavior/winui-mvvm-custom-behavior/MainWindow.xaml.cs)
- [MainViewModel.cs](./CS/winui-mvvm-custom-behavior/winui-mvvm-custom-behavior/ViewModel.cs)
<!-- default file list end --> 

## Documentation

- [WinUI MVVM Framework](https://docs.devexpress.com/WinUI/102569/mvvm-framework?v=22.1)
- [WinUI MVVM Behaviors](https://docs.devexpress.com/WinUI/402936/mvvm/behaviors?v=22.1)

## More Examples

- [WinUI MVVM Service - Create a Custom UI Service](https://github.com/DevExpress-Examples/winui-mvvm-custom-service)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winui-mvvm-custom-behavior&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winui-mvvm-custom-behavior&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->

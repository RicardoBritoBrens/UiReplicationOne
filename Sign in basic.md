<?xml version="1.0" encoding="UTF-8" ?>
<ContentPage
    x:Class="UIReplicationOne.Views.WelcomePage"
    xmlns="http://xamarin.com/schemas/2014/forms"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:customrenderer="clr-namespace:UIReplicationOne.CustomRenderer"
    BackgroundColor="#0041C4">
    <AbsoluteLayout Margin="44" Style="{StaticResource welcomePageBackground}">
        <!--<StackLayout>
            <Label
                FontAttributes="Bold"
                FontSize="Title"
                Style="{StaticResource labelWhiterTextColor}"
                Text="Welcome" />
        </StackLayout>
        <StackLayout>
            <Label Style="{StaticResource labelWhiterTextColor}" Text="Manage Your expenses" />
            <Label
                FontSize="16"
                Style="{StaticResource labelWhiteTextColorAndBold}"
                Text="seamlessly &amp; intuitively" />
        </StackLayout>
        <StackLayout Spacing="15">
            <Button Style="{StaticResource button_Google_Sing_In}" Text="Sign in with Google" />
            <Button Style="{StaticResource button_Create_an_Account}" Text="Create an account" />
        </StackLayout>

        <StackLayout HorizontalOptions="Center" Orientation="Horizontal">

            <Label Text="Already have an account?" />
            <Label Style="{StaticResource labelWhiterTextColor}" Text="Sing in" />
        </StackLayout>-->

        <StackLayout AbsoluteLayout.LayoutBounds="0.5,0.5,1,0.07" AbsoluteLayout.LayoutFlags="All">
            <Label
                FontAttributes="Bold"
                FontSize="Title"
                Style="{StaticResource welcomePageFirstLabel}"
                Text="Welcome" />
        </StackLayout>
        <StackLayout AbsoluteLayout.LayoutBounds="0.5,0.6,1,0.04" AbsoluteLayout.LayoutFlags="All">
            <Label Style="{StaticResource welcomePageSecondLabel}" Text="Manage Your expenses" />
            <Label
                FontSize="16"
                Style="{StaticResource welcomePageThirdLabel}"
                Text="seamlessly &amp; intuitively" />
        </StackLayout>
        <StackLayout
            AbsoluteLayout.LayoutBounds="0.5,0.8,1,0.07"
            AbsoluteLayout.LayoutFlags="All"
            Spacing="15">
            <Button Style="{StaticResource button_Google_Sing_In}" Text="Sign in with Google" />
            <Button Style="{StaticResource button_Create_an_Account}" Text="Create an account" />
        </StackLayout>
        <StackLayout
            AbsoluteLayout.LayoutBounds="0.5,0.9999,1,0.07"
            AbsoluteLayout.LayoutFlags="All"
            HorizontalOptions="Center"
            Orientation="Horizontal"
            Spacing="0">
            <Label
                Opacity="0.6"
                Style="{StaticResource welcomePageFourthLabel}"
                Text="Already have an account?" />
            <Label Style="{StaticResource welcomePageFifthLabel}" Text="Sing in" />
        </StackLayout>
    </AbsoluteLayout>
</ContentPage>
<!--  Style="{StaticResource symbol_Google_Sing_In}"  -->
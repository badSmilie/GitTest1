﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MultipleViews.Controls
{
    /// <summary>
    /// Führen Sie die Schritte 1a oder 1b und anschließend Schritt 2 aus, um dieses benutzerdefinierte Steuerelement in einer XAML-Datei zu verwenden.
    ///
    /// Schritt 1a) Verwenden des benutzerdefinierten Steuerelements in einer XAML-Datei, die im aktuellen Projekt vorhanden ist.
    /// Fügen Sie dieses XmlNamespace-Attribut dem Stammelement der Markupdatei 
    /// an der Stelle hinzu, an der es verwendet werden soll:
    ///
    ///     xmlns:MyNamespace="clr-namespace:MultipleViews"
    ///
    ///
    /// Schritt 1b) Verwenden des benutzerdefinierten Steuerelements in einer XAML-Datei, die in einem anderen Projekt vorhanden ist.
    /// Fügen Sie dieses XmlNamespace-Attribut dem Stammelement der Markupdatei 
    /// an der Stelle hinzu, an der es verwendet werden soll:
    ///
    ///     xmlns:MyNamespace="clr-namespace:MultipleViews;assembly=MultipleViews"
    ///
    /// Darüber hinaus müssen Sie von dem Projekt, das die XAML-Datei enthält, einen Projektverweis
    /// zu diesem Projekt hinzufügen und das Projekt neu erstellen, um Kompilierungsfehler zu vermeiden:
    ///
    ///     Klicken Sie im Projektmappen-Explorer mit der rechten Maustaste auf das Zielprojekt und anschließend auf
    ///     "Verweis hinzufügen"->"Projekte"->[Navigieren Sie zu diesem Projekt, und wählen Sie es aus.]
    ///
    ///
    /// Schritt 2)
    /// Fahren Sie fort, und verwenden Sie das Steuerelement in der XAML-Datei.
    ///
    ///     <MyNamespace:MyCustomControl/>
    ///
    /// </summary>
    public class MyCustomControl : Control
    {
        static MyCustomControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyCustomControl), new FrameworkPropertyMetadata(typeof(MyCustomControl)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            //demo purpose only, check for previous instances and remove 
            // the handler first
            var button = GetTemplateChild("PART_Button") as Button;
            if (button != null)
                button.Click += Button_Click;
        }
        void Button_Click(object sender, RoutedEventArgs e)
        {
            RaiseClickEvent();
        }

        public static readonly RoutedEvent ClickEvent = EventManager.RegisterRoutedEvent("Click", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(MyCustomControl));

        public event RoutedEventHandler Click
        {
            add { AddHandler(ClickEvent, value); }
            remove { RemoveHandler(ClickEvent, value); }
        }
        protected virtual void RaiseClickEvent()
        {
            RoutedEventArgs args = new
            RoutedEventArgs(MyCustomControl.ClickEvent);
            RaiseEvent(args);
        }
    }
}

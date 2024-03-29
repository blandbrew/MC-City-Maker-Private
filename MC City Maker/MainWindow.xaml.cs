﻿using MC_City_Maker.UI;
using MC_City_Maker.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace MC_City_Maker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Rectangle rect;


        public MainWindow()
        {
            InitializeComponent();
        }

        //private void Canvas_MouseEnter(object sender, MouseEventArgs e)
        //{
        //    Debug.WriteLine("MOUSE ENTERED");
        //}


        bool mouseDown = false; // Set to 'true' when mouse is held down.
        Point mouseDownPos; // The point where the mouse button was clicked down.

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("MOUSE DOWN EVENT");
            DrawRectangle(e);


            // Capture and track the mouse.
            mouseDown = true;
            mouseDownPos = e.GetPosition(theGrid);
            theGrid.CaptureMouse();

            // Initial placement of the drag selection box.         
            //Canvas.SetLeft(selectionBox, mouseDownPos.X);
            //Canvas.SetTop(selectionBox, mouseDownPos.Y);
            //selectionBox.Width = 0;
            //selectionBox.Height = 0;

            // Make the drag selection box visible.
            //selectionBox.Visibility = Visibility.Visible;
        }

        private void Grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            // Release the mouse capture and stop tracking it.
            mouseDown = false;
            theGrid.ReleaseMouseCapture();

            // Hide the drag selection box.
            //selectionBox.Visibility = Visibility.Collapsed;

            Point mouseUpPos = e.GetPosition(theGrid);

            // TODO: 
            //
            // The mouse has been released, check to see if any of the items 
            // in the other canvas are contained within mouseDownPos and 
            // mouseUpPos, for any that are, select them!
            //
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {

           



            if (mouseDown)
            {
                // When the mouse is held down, reposition the drag selection box.

                Point mousePos = e.GetPosition(theGrid);

                //if (mouseDownPos.X < mousePos.X)
                //{
                //    Canvas.SetLeft(selectionBox, mouseDownPos.X);
                //    selectionBox.Width = mousePos.X - mouseDownPos.X;
                //}
                //else
                //{
                //    Canvas.SetLeft(selectionBox, mousePos.X);
                //    selectionBox.Width = mouseDownPos.X - mousePos.X;
                //}

                //if (mouseDownPos.Y < mousePos.Y)
                //{
                //    Canvas.SetTop(selectionBox, mouseDownPos.Y);
                //    selectionBox.Height = mousePos.Y - mouseDownPos.Y;
                //}
                //else
                //{
                //    Canvas.SetTop(selectionBox, mousePos.Y);
                //    selectionBox.Height = mouseDownPos.Y - mousePos.Y;
                //}
            }

            //TODO if (MouseNOTdown) && Custom zone is set then redraw rectangle as it is moved.
            //Get size of building, get position of mouse 
        }

        private void DrawRectangle(MouseEventArgs e)
        {

            


            Point mousePos = e.GetPosition(theGrid);

            Debug.WriteLine("x: " + mousePos.X + ", Y: " + mousePos.Y);

            
            rect = new Rectangle();
            rect.Stroke = new SolidColorBrush(Colors.Black);
            rect.Fill = new SolidColorBrush(Colors.Red);
            rect.Width = 17;
            rect.Height = 17;

            //Canvas foundCanvas = UIHelper.FindChild<Canvas>(Application.Current.MainWindow, "squareCanvas");
            //Canvas owner = UIHelper.FindVisualParent<Canvas>(Canvas);
            Canvas _Canvas = _ItemsControl.ItemsPanel.LoadContent() as Canvas;
            
            //var myCanvas = (Canvas)this.FindName("squareCanvas");

            Canvas.SetLeft(rect, mousePos.X);
            Canvas.SetTop(rect, mousePos.Y);
            _Canvas.Children.Add(rect);
        }

    }
}

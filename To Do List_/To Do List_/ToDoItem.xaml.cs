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

namespace To_Do_List_
{
    /// <summary>
    /// ToDoItem.xaml 的互動邏輯
    /// </summary>
    public partial class ToDoItem : UserControl
    {
        public bool IsChecked
        {
            set
            {
                if (value == true)
                {
                    CheckMark.Visibility = Visibility.Visible;
                }
                else
                {
                    CheckMark.Visibility = Visibility.Collapsed;
                }
            }
            get
            {
                if (CheckMark.Visibility == Visibility)
                    return true;
                else
                    return false;
            }
        }


        private void CheckBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (CheckMark.Visibility == Visibility)
            {
                CheckMark.Visibility = Visibility.Collapsed;
            }
            else
            {
                CheckMark.Visibility = Visibility.Visible;
            }
        }

        public ToDoItem()
        {
            InitializeComponent();
        }

        // 自訂方法 : 取得輸入文字
            public string ItemName
            {
                get
                {
                    return ItemNameTb.Text;
                }
                set
                {
                    ItemNameTb.Text = value;
                }
            }

        }
}


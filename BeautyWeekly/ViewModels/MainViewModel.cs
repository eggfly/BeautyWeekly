﻿//-----------------------------------------------------------------------
// <copyright file="MainViewModel.cs" company="Eggfly Corporation">
//     Copyright (c) Eggfly Corporation. All rights reserved.
// </copyright>
// <author>lihaohua90@gmail.com</author>
//-----------------------------------------------------------------------

namespace BeautyWeekly
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Windows;
    using SimpleMvvmToolkit;
    using SimpleMvvmToolkit.ModelExtensions;

    /// <summary>
    /// MainViewModel class
    /// </summary>
    public class MainViewModel : ViewModelBase<MainViewModel>
    {
        /// <summary>
        /// the categories
        /// </summary>
        private List<Category> categories = new List<Category>
        {
            new Category(
                "Category1",
                new List<PictureGroup>
                {
                    new PictureGroup("周杰伦xxxxxxxx", "/Pictures/1-1.png"),
                    new PictureGroup("甄子丹xxxxxxxxx甄子丹", "/Pictures/1-2.png"),
                    new PictureGroup("xxxx陈小春xxx", "/Pictures/1-3.png"),
                    new PictureGroup("大大xxxxxxx", "/Pictures/1-4.png"),
                    new PictureGroup("大S sssssss", "/Pictures/1-5.png"),
                    new PictureGroup("古天乐dddddddd", "/Pictures/1-6.png"),
                }),

            new Category(
                "Category2",
                new List<PictureGroup>
                {
                    new PictureGroup("周杰伦xxxxxxxx", "/Pictures/2-1.jpg"),
                    new PictureGroup("甄子丹xxxxxxxxx甄子丹", "/Pictures/2-2.jpg"),
                    new PictureGroup("xxxx陈小春xxx", "/Pictures/2-3.jpg"),
                    new PictureGroup("大大xxxxxxx", "/Pictures/2-4.jpg"),
                    new PictureGroup("大S sssssss", "/Pictures/2-5.jpg"),
                    new PictureGroup("古天乐dddddddd", "/Pictures/2-6.jpg"),
                    new PictureGroup("大S sssssss", "/Pictures/2-7.jpg"),
                    new PictureGroup("古天乐dddddddd", "/Pictures/2-8.jpg"),
                    new PictureGroup("大S sssssss", "/Pictures/2-9.jpg"),
                    new PictureGroup("古天乐dddddddd", "/Pictures/2-10.jpg"),
                }),
        };

        #region Initialization and Cleanup

        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        public MainViewModel()
        {
        }

        #endregion

        #region Notifications

        #endregion

        #region Properties

        /// <summary>
        /// Gets the photos.
        /// </summary>
        public List<Category> Categories
        {
            get
            {
                return this.categories;
            }
        }

        #endregion

        #region Methods

        #endregion

        #region Callbacks

        /// <summary>
        /// Called when [app bar like button click].
        /// </summary>
        public void OnAppBarLikeButtonClick()
        {
            MessageBox.Show("OnAppBarLikeButtonClick");
        }

        /// <summary>
        /// Called when [app bar about menu click].
        /// </summary>
        public void OnAppBarAboutMenuClick()
        {
            MessageBox.Show("OnAppBarAboutMenuClick");
        }

        #endregion

        #region Helpers

        #endregion
    }
}
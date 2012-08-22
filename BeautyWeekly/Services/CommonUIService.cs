﻿//-----------------------------------------------------------------------
// <copyright file="CommonUIService.cs" company="Eggfly Corporation">
//     Copyright (c) Eggfly Corporation. All rights reserved.
// </copyright>
// <author>lihaohua90@gmail.com</author>
//-----------------------------------------------------------------------

namespace BeautyWeekly
{
    using System;
    using System.Linq;
    using System.Windows;

    /// <summary>
    /// Common UI Service
    /// </summary>
    public class CommonUIService : ICommonUIService
    {
        /// <summary>
        /// class lock
        /// </summary>
        private object objLock = new object();

        /// <summary>
        /// Shows the message box.
        /// </summary>
        /// <param name="messageBoxText">The message box text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="isShowOKCancel">if set to <c>true</c> [is show OK cancel].</param>
        /// <returns>the result</returns>
        public MessageBoxResult ShowMessageBox(string messageBoxText, string caption = "", bool isShowOKCancel = false)
        {
            lock (this.objLock)
            {
                MessageBoxResult result = MessageBox.Show(messageBoxText, caption, isShowOKCancel ? MessageBoxButton.OKCancel : MessageBoxButton.OK);
                return result;
            }
        }
    }
}
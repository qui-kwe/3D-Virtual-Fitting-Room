﻿using System.Drawing;
using System.Windows;

namespace KinectFittingRoom.ViewModel.ButtonItems.TopMenuButtons
{
    class ExitButtonViewModel : TopMenuButtonViewModel
    {
        #region .ctor
        /// <summary>
        /// Initializes a new instance of the <see cref="ExitButtonViewModel"/> class.
        /// </summary>
        /// <param name="image">Image of button</param>
        public ExitButtonViewModel(Bitmap image)
            : base(image)
        { }
        #endregion
        #region Methods
        /// <summary>
        /// Display closing screen with buttons
        /// </summary>
        public override void ClickExecuted()
        {
            PlaySound();
            ClearMenu();
            TopMenuManager.Instance.CloseAppGridVisibility = Visibility.Visible;
        }
        #endregion
    }
}

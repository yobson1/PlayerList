﻿using System;
using TMPro;
using UnityEngine;
using VRC.DataModel.Core;

namespace VRChatUtilityKit.Ui
{
    /// <summary>
    /// A wrapper holding a button.
    /// </summary>
    public class SingleButton : VRCButton
    {
        /// <summary>
        /// The OnClick of the button.
        /// </summary>
        public Action OnClick { get; set; }

        /// <summary>
        /// A small icon indicating this buttons jumps to the big menu.
        /// </summary>
        public GameObject JumpBadge { get; private set; }

        /// <summary>
        /// Creates a new button.
        /// </summary>
        /// <param name="onClick">The OnClick of the button</param>
        /// <param name="icon">The icon for the button</param>
        /// <param name="text">The text of the button</param>
        /// <param name="gameObjectName">The name of the button's GameObject</param>
        /// <param name="tooltipText">The tooltip of the button</param>
        public SingleButton(Action onClick, Sprite icon, string text, string gameObjectName, string tooltipText = "") : base(UiManager.QMStateController.transform.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Worlds").gameObject, icon, text, gameObjectName, tooltipText)
        {
            JumpBadge = rectTransform.Find("Badge_MMJump").gameObject;
            JumpBadge.SetActive(false);
            OnClick = onClick;
            BindingExtensions.Method_Public_Static_ButtonBindingHelper_Button_Action_0(ButtonComponent, new Action(() => OnClick?.Invoke()));
        }
    }
}
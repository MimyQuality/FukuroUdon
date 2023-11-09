﻿/*
Copyright (c) 2023 Mimy Quality
Released under the MIT license
https://opensource.org/licenses/mit-license.php
*/

namespace MimyLab
{
    using UdonSharp;
    using UnityEngine;
    //using VRC.SDKBase;
    //using VRC.Udon;

    [DefaultExecutionOrder(10)]
    [UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
    public class SCKeyInputManager : UdonSharpBehaviour
    {
        private SwivelChair _swivelChair;

        private void Start()
        {
            _swivelChair = GetComponent<SwivelChair>();
        }

        private void Update()
        {
            _swivelChair._OnUpdate();
        }
    }
}

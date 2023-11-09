﻿/*
Copyright (c) 2022 Mimy Quality
Released under the MIT license
https://opensource.org/licenses/mit-license.php
*/

namespace MimyLab
{
    using UdonSharp;
    using UnityEngine;
    //using VRC.SDKBase;
    using VRC.Udon;

    [AddComponentMenu("Fukuro Udon/Active Relay/To UdonBehaviour")]
    [UdonBehaviourSyncMode(BehaviourSyncMode.NoVariableSync)]
    public class ActiveRelayToUdonBehaviour : UdonSharpBehaviour
    {
        [Header("Settings when active")]
        [SerializeField]
        UdonBehaviour[] _udonBehaviourForActive = new UdonBehaviour[0];
        [SerializeField]
        string _customEventNameForActive = "";

        [Header("Settings when inactive")]
        [SerializeField]
        UdonBehaviour[] _udonBehaviourForInactive = new UdonBehaviour[0];
        [SerializeField]
        string _customEventNameForInactive = "";

        void OnEnable()
        {
            if (_customEventNameForActive != "")
            {
                foreach (var ub in _udonBehaviourForActive)
                {
                    if (ub) { ub.SendCustomEvent(_customEventNameForActive); }
                }
            }
        }

        void OnDisable()
        {
            if (_customEventNameForInactive != "")
            {
                foreach (var ub in _udonBehaviourForInactive)
                {
                    if (ub) { ub.SendCustomEvent(_customEventNameForInactive); }
                }
            }
        }
    }
}

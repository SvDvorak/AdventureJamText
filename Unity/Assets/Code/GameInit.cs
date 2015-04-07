﻿using Assets.Code;
using UnityEngine;

namespace FyreVMDemo.Game
{
    public class GameInit : MonoBehaviour
    {
        public TextAsset UlxFile;

        protected void Start()
        {
            GlulxStateService.Instance.LoadGlulxData(UlxFile);
            GlulxStateService.Instance.InitialScene();
        }
    }
}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AI
{
    public class QuadjumperTable : GenericAiTable
    {

        public QuadjumperTable() : base()
        {
            FrontManeuversInner.Add("2.L.R");
            FrontManeuversInner.Add("2.R.R");
            FrontManeuversInner.Add("1.F.S");
            FrontManeuversInner.Add("1.F.S");
            FrontManeuversInner.Add("1.F.S");
            FrontManeuversInner.Add("1.F.S");

            FrontManeuversOuter.Add("3.F.S");
            FrontManeuversOuter.Add("3.F.S");
            FrontManeuversOuter.Add("3.F.S");
            FrontManeuversOuter.Add("2.F.S");
            FrontManeuversOuter.Add("2.F.S");
            FrontManeuversOuter.Add("1.F.S");

            FrontSideManeuversInner.Add("1.F.S");
            FrontSideManeuversInner.Add("1.F.S");
            FrontSideManeuversInner.Add("2.L.R");
            FrontSideManeuversInner.Add("2.L.R");
            FrontSideManeuversInner.Add("1.R.T");
            FrontSideManeuversInner.Add("1.R.T");

            FrontSideManeuversOuter.Add("2.F.S");
            FrontSideManeuversOuter.Add("1.F.S");
            FrontSideManeuversOuter.Add("3.R.B");
            FrontSideManeuversOuter.Add("3.R.B");
            FrontSideManeuversOuter.Add("2.R.B");
            FrontSideManeuversOuter.Add("2.R.B");

            SideManeuversInner.Add("2.L.R");
            SideManeuversInner.Add("2.L.R");
            SideManeuversInner.Add("1.R.T");
            SideManeuversInner.Add("1.R.T");
            SideManeuversInner.Add("2.R.T");
            SideManeuversInner.Add("2.R.T");

            SideManeuversOuter.Add("2.R.B");
            SideManeuversOuter.Add("2.R.B");
            SideManeuversOuter.Add("2.R.T");
            SideManeuversOuter.Add("2.R.T");
            SideManeuversOuter.Add("1.R.T");
            SideManeuversOuter.Add("1.R.T");

            BackSideManeuversInner.Add("2.L.R");
            BackSideManeuversInner.Add("2.L.R");
            BackSideManeuversInner.Add("2.R.T");
            BackSideManeuversInner.Add("2.R.T");
            BackSideManeuversInner.Add("1.R.T");
            BackSideManeuversInner.Add("1.R.T");

            BackSideManeuversOuter.Add("2.L.R");
            BackSideManeuversOuter.Add("2.L.R");
            BackSideManeuversOuter.Add("2.L.R");
            BackSideManeuversOuter.Add("2.R.T");
            BackSideManeuversOuter.Add("1.R.T");
            BackSideManeuversOuter.Add("1.R.T");

            BackManeuversInner.Add("2.L.R");
            BackManeuversInner.Add("2.L.R");
            BackManeuversInner.Add("2.R.R");
            BackManeuversInner.Add("2.R.R");
            BackManeuversInner.Add("1.L.T");
            BackManeuversInner.Add("1.R.T");

            BackManeuversInner.Add("2.L.R");
            BackManeuversInner.Add("2.L.R");
            BackManeuversInner.Add("2.R.R");
            BackManeuversInner.Add("2.R.R");
            BackManeuversInner.Add("2.L.T");
            BackManeuversInner.Add("2.R.T");
        }

    }
}
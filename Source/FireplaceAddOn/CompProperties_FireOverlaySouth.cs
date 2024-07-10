using RimWorld;
using UnityEngine;
using Verse;

//namespace GW_Fireplace {﻿

 public class Comp_FireOverlaySouth : CompFireOverlay
    {
		public override void PostDraw()
		{
			if ((refuelableComp == null || refuelableComp.HasFuel) && parent.Rotation == Rot4.South)
			{
				Vector3 drawPos = parent.DrawPos;
				drawPos.y += 3f / 74f;
				FireGraphic.Draw(drawPos, Rot4.North, parent);
			}
		}
		public override void CompTick()
		{
			if (((refuelableComp == null || refuelableComp.HasFuel) && parent.Rotation == Rot4.South) && startedGrowingAtTick < 0)
			{
				startedGrowingAtTick = GenTicks.TicksAbs;
			}
		}
	}

    public class CompProperties_FireOverlaySouth : CompProperties_FireOverlay
    {
        public CompProperties_FireOverlaySouth()
        {
            compClass = typeof(Comp_FireOverlaySouth);
        }

    }

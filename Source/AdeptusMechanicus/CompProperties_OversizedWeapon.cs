﻿using Verse;

namespace AdeptusMechanicus
{
    internal class CompProperties_OversizedWeapon : CompProperties
    {
        //public SoundDef soundMiss;
        //public SoundDef soundHitPawn;
        //public SoundDef soundHitBuilding;
        //public SoundDef soundExtra;
        //public SoundDef soundExtraTwo;

        public CompProperties_OversizedWeapon()
        {
            compClass = typeof(CompOversizedWeapon);
        }
    }
}
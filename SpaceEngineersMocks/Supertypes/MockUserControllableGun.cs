using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox.Common;
using Sandbox.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;
using VRage.Components;
using VRage.ModAPI;
using VRage.ObjectBuilders;
using VRage.Utils;
using VRageMath;

namespace SpaceEngineersMocks.Supertypes
{
    /// <summary>
    /// Base class for guns that are user controllable
    /// TODO
    /// </summary>
    public abstract class MockUserControllableGun : MockFunctionalBlock, IMyUserControllableGun
    {

        //  Interface Implementation
        // -----------------------------------------
        public bool IsShooting
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
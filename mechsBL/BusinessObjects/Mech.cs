using System.Collections.Generic;
using Mechs.Common.Interfaces;

namespace Mechs.BL.BusinessObjects
{
    /// <summary>
    /// Mech class
    /// </summary>
    public abstract class Mech : IMech
    {
        private static ulong counter = 0;

        private List<IWeapon> weapons = new List<IWeapon>();
        private List<IPart> parts = new List<IPart>();

        #region IMech Members

        /// <summary>
        /// Protected default constructor
        /// </summary>
        protected Mech()
        {
            counter++;
            this.ID = counter;
            this.Mass = this.CalcMass();
        }

        /// <summary>
        /// Weapons
        /// </summary>
        public List<IWeapon> Weapons
        {
            get { return weapons; }
        }

        /// <summary>
        /// Equipment
        /// </summary>
        public List<IPart> Parts
        {
            get { return parts; }
        }

        /// <summary>
        /// Mass
        /// </summary>
        public int Mass
        {
            get;
            private set;
        }

        #endregion

        #region IMech Members

        /// <summary>
        /// Mech's pilot
        /// </summary>
        public IPilot Pilot
        {
            get;
            private set;
        }

        #endregion

        #region IIdentificable Members

        /// <summary>
        /// ID
        /// </summary>
        public ulong ID
        {
            get;
            private set;
        }

        /// <summary>
        /// Mech name
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        #endregion

        #region Private class methods

        private int CalcMass()
        {
            int localMass = 0;
            foreach (var part in parts)
            {
                localMass += part.Mass;
            }
            foreach (var weapon in weapons)
            {
                localMass += weapon.Mass;
            }
            return localMass;
        }

        #endregion

        IEnumerable<IWeapon> IMech.Weapons
        {
            get { throw new System.NotImplementedException(); }
        }

        IEnumerable<IPart> IMech.Parts
        {
            get { throw new System.NotImplementedException(); }
        }

        public IPlayer Params
        {
            get { throw new System.NotImplementedException(); }
        }

        public string EntityID
        {
            get { throw new System.NotImplementedException(); }
        }


        public int HashKey
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeControlSystem
{
    public class BridgeState
    {
        private bool _isOpen, _isLowered, _isIdle, _isMalfunctioning;
        public bool IsOpen
        {
            get { return _isOpen; }
        }

        public bool IsClosed
        {
            get { return !_isOpen; }
        }

        public bool IsLowered
        {
            get { return _isLowered; }
        }

        public bool IsRaised
        {
            get { return !_isLowered; }
        }

        public bool IsIdle
        {
            get { return _isIdle; }
        }

        public bool IsInMotion
        {
            get { return !_isIdle; }
        }

        public bool IsMalfunctioning
        {
            get { return _isMalfunctioning; }
        }

        public bool IsOperable
        {
            get { return !_isMalfunctioning; }
        }

        public bool CanOpen
        {
            get { return IsLowered && IsClosed; }
        }

        public bool CanClose
        {
            get { return IsLowered && IsOpen; }
        }

        public bool CanRaise
        {
            get { return IsLowered && IsClosed; }
        }

        public bool CanLower
        {
            get { return IsRaised; }
        }

        /*public bool IsStopped
        {
            get
            {
                return _isOpen && _isLowered && _isIdle;
            }
        }*/

        public BridgeState()
        {
            _isOpen = true;
            _isLowered = true;
            _isIdle = true;
            _isMalfunctioning = false;
        }

        public void Raise()
        {
            Contract.Requires(this.CanRaise);

            _isLowered = false;
        }

        public void Lower()
        {
            Contract.Requires(this.CanLower);

            _isLowered = true;
        }

        public void Close()
        {
            Contract.Requires(this.CanClose);

            _isOpen = false;
        }

        public void Open()
        {
            Contract.Requires(this.CanOpen);

            _isOpen = true;
        }

        public void Stop()
        {
            Contract.Requires(this.IsInMotion);

            _isIdle = true;
        }

        public void Malfunction()
        {
            Contract.Requires(this.IsOperable);

            _isMalfunctioning = true;
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            // Ternary Operator
            // Indicates if the Bridge is in some Raised state, then the bridge must also be Closed
            // If Raised, Then If Closed => true.
            // If Raised, Then If Open => false.

            // If RAISED THEN CLOSED MUST BE TRUE ELSE ALL IS FALSE
            Contract.Invariant(this.IsRaised ? this.IsClosed : true);
        }
    }
}
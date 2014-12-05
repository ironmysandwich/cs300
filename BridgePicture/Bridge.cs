using System;
using System.Runtime.CompilerServices;

namespace BridgeControlSystem
{
    public class Bridge
    {
        // Bridge ID number. Must be unique across all instances
        private Guid id;

        // Bridge name. Should probably be unique across all instances
        private string name;

        // Current Bridge state
        private BridgeState state;

        // This is where notifications are sent to when something happens.
        //    private NotificationController notification;

        // Bridge constructor. setName should be set in a config file.
        public Bridge(string setName)
        {
            name = setName;
            id = Guid.NewGuid();
            //        state = new BridgeState();
            //        notification = new NotificationController();
        }

        // Stop the bridge!
        public void stop()
        {
            // call stop bridge function... set state to stopped?
        }

        // Change the bridge state.
        /*
        public BridgeState stateChange(ref BridgeState nextState)
        {
            state.stateChange(nextState);
        }
        */

        // Add a listener
        public void AddListener(Object listener)
        {
            //???
        }


    }
}
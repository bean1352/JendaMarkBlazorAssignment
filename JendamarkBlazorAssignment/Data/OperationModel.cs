using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JendamarkBlazorAssignment.Models
{
    public class Operation
    {
        public Guid OperationID { get; set; }
        public string Name { get; set; }
        public int OrderInWhichToPerform { get; set; }
        public byte[] ImageData { get; set; }
        public Device Device { get; set; }
        public string ImageDataUrl { get; set; }
    }
    public class Device
    {
        private DeviceType _devicetype;
        public Guid DeviceID { get; set; }
        public string Name { get; set; }
        public DeviceType DeviceType
        {
            get { return _devicetype; }
            set { _devicetype = value; }
        }
    }
    public enum DeviceType
    {
        BarcodeScanner,
        Printer,
        Camera,
        SocketTray
    }
    public class State
    {
        public Operation GlobalOperation { get; set; } = new Operation();
    }
}

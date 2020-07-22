using Android.Bluetooth;
using Android.Content;
using HealthAndDrive.Events;
using HealthAndDrive.Tools;
using Plugin.BLE;
using Plugin.BLE.Abstractions.Contracts;
using Prism.Events;
using System.Collections.Generic;

namespace HealthAndDrive.Services
{
    /// <summary>
    /// This class handles the bluetooth scan
    /// </summary>
    public class BluetoothScanService 
    {
        /// <summary>
        /// Bluetooth manager
        /// </summary>
        private readonly BluetoothManager manager;

        /// <summary>
        /// The current bluetooth
        /// </summary>
        public IBluetoothLE Ble { get; set;  }

        /// <summary>
        /// The current bluetooth adapter
        /// </summary>
        public IAdapter Adapter { get; set; }

        /// <summary>
        /// Gets or sets the ScanCallBack
        /// </summary>
        private LeScanCallback ScanCallaback { get; set; }

        /// <summary>
        /// Gets or sets the discovered devices
        /// </summary>
        public List<BluetoothDevice> DiscoveredDevices;

        public BluetoothScanService()
        {
            this.Ble = CrossBluetoothLE.Current;
            this.Adapter = CrossBluetoothLE.Current.Adapter;
            this.manager = (BluetoothManager)Android.App.Application.Context.GetSystemService(Context.BluetoothService);
            this.ScanCallaback = new LeScanCallback(this);

            // Bluetooth state changed
            this.Ble.StateChanged += async (s, e) =>
            {
                IEventAggregator eventAggregator = (IEventAggregator)App.Current.Container.Resolve(typeof(IEventAggregator));
                eventAggregator.GetEvent<BluetoothStateChangeEvent>().Publish(e.NewState);

                // only for Android devices
                if (e.NewState == BluetoothState.TurningOff && Xamarin.Forms.Device.RuntimePlatform == Xamarin.Forms.Device.Android )
                {
                    bool confirmed = await App.Current.MainPage.DisplayAlert(Utils.GetTranslation("BluetoothPage_BluetoothStoppedTitle"), 
                        Utils.GetTranslation("BluetoothPage_BluetoothStopped"),
                        Utils.GetTranslation("YES"), Utils.GetTranslation("NO"));

                    if (confirmed)
                    {
                        this.manager.Adapter.Enable();
                    }
                }
            };
        }

        /// <summary>
        /// This method launches the device scanning. It  DiscoveredDevices property
        /// </summary>
        public void ScanForDevices()
        {
            if (this.manager == null)
            {
                return;
            }

            // No need to launch the scan if 
            // A scan is in progress OR the scanner is off
            if (this.manager.Adapter.IsDiscovering || this.manager.Adapter.BluetoothLeScanner == null)
            {
                return;
            }
            else
            {
                this.DiscoveredDevices = new List<BluetoothDevice>();
                this.manager.Adapter.BluetoothLeScanner.StartScan(this.ScanCallaback);
            }
        }

        /// <summary>
        /// Stop the scanning for the current ScanCallaback
        /// </summary>
        public void StopScanning()
        {
            if (this.manager == null)
            {
                return;
            }

            if (this.manager.Adapter.BluetoothLeScanner != null)
            {
                this.manager.Adapter.BluetoothLeScanner.StopScan(this.ScanCallaback);
            }
        }       
    }
}

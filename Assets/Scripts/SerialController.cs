using UnityEngine;
using System.IO.Ports;


public class SerialController : MonoBehaviour {
    SerialPort port = new SerialPort("COM5", 9600); // Replace COM3 if different
    public VRThrowManager throwManager;

    void Start() {
        if (!port.IsOpen) {
            port.Open();
            port.ReadTimeout = 20;
        }
    }

    void Update() {
        try {
            string input = port.ReadExisting();

            if (input.Contains("T")) {
                throwManager.ThrowCubeRight();
            }
        } catch (System.Exception) {}
    }

    public void TriggerBuzzer() {
        if (port.IsOpen) port.Write("B");
    }
}
using System.Diagnostics;
using UnityEngine;

public class LevelLogic : MonoBehaviour
{
    public SwitchInterruptor switch1;
    public SwitchInterruptor switch2;

    public Door door1;
    public Door door2;

    public Lamp lamp1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch1.IsOn = false;
        switch2.IsOn = false;

        door1.isLocked = true;
        door2.isLocked = true;

        lamp1.IsOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(switch1.IsOn && switch2.IsOn)
        {
            door1.isLocked = false;
        }

        if (switch1.IsOn || switch2.IsOn)
        {
            door2.isLocked = false;
        }

        if(door1.isLocked == false && door2.isOpen)
        {
            lamp1.IsOn = true;
        }
    }
}

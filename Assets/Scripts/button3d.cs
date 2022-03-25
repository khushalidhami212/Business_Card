using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button3d : MonoBehaviour
{
    public void mail()
    {
        Application.OpenURL("mailto: abc@gmail.com");
    }
    public void facebook()
    {
        Application.OpenURL("https://www.facebook.com/");
    }
    public void instagram()
    {
        Application.OpenURL("https://www.instagram.com/");
    }
    public void phone()
    {
        Application.OpenURL("tel: 1234567890");
    }

}
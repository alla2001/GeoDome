using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TimeOfDayManager : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public Material nightSky;
    public Material daySky;
    public GameObject DirLight;
    public void ToggleSky()
    {
        if (dropdown.value == 0)
        {
            RenderSettings.skybox = daySky;
            DirLight.SetActive(true);
        }
        else
        {
            RenderSettings.skybox = nightSky;
            DirLight.SetActive(false);
        }
    }
}

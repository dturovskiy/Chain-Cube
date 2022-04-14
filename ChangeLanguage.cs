using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLanguage : MonoBehaviour
{
    public Sprite language_en, language_ua;

    private void Update()
    {
        if (PlayerPrefs.GetString("language") == "ua_UA")
        {
            GetComponent<Image>().sprite = language_en;
        }
        else
        {
            GetComponent<Image>().sprite = language_ua;
        }
    }

    public void SwitchLanguage()
    {
        if (PlayerPrefs.GetString("language") == "en_EN")
        {
            PlayerPrefs.SetString("language", "ua_UA");
            GetComponent<Image>().sprite = language_ua;
        }
        else
        {
            PlayerPrefs.SetString("language", "en_EN");
            GetComponent<Image>().sprite = language_en;
        }
    }

}

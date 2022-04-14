using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class LangSystem : MonoBehaviour
{
    private string json;
    public Text text_button;

    public static Lang lng = new Lang();

    [System.Obsolete]
    private void Update()
    {
        if (PlayerPrefs.GetString("language") == "en_EN")
        {
            LangLoad();
        }
        else
        {
            LangLoad();
        }
    }

    [System.Obsolete]
    void LangLoad()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        string path = Path.Combine(Application.streamingAssetsPath, "Languages/" + PlayerPrefs.GetString("language") + ".json");
        WWW reader = new WWW(path);
        
        while (!reader.isDone) { }
        json = reader.text;

        lng = JsonUtility.FromJson<Lang>(json);
        text_button.text = lng.start_button;

#endif
#if UNITY_EDITOR
        json = File.ReadAllText(Application.streamingAssetsPath + "/Languages/" + PlayerPrefs.GetString("language") + ".json");
        lng = JsonUtility.FromJson<Lang>(json);
        text_button.text = lng.start_button;
#endif
    }
}

public class Lang
{
    public string start_button;
}
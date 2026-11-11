using UnityEngine;

public class URLButton : MonoBehaviour
{
    public void OpenWebsite(string url)
    {
        Application.OpenURL(url);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button2 : MonoBehaviour
{
    public void prosmotrsite()
    {
        SceneManager.LoadScene("button2");
    }
    public void mirea()
    {
        Application.OpenURL("https://www.google.com/maps?q=%D0%BA%D0%B0%D1%80%D1%82%D0%B0+%D0%B4%D0%BE%D1%81%D1%82%D0%B0%D0%B2%D0%BE%D0%BA+%D1%82%D0%B0%D0%BD%D1%83%D0%BA%D0%B8&um=1&ie=UTF-8&sa=X&ved=2ahUKEwjzxtGwj73mAhWvAxAIHRL5B68Q_AUoAXoECA0QAw");
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIHandler : MonoBehaviour
{
    public static UIHandler instance {  get; private set; }

    VisualElement m_HealthBar;

    private void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        UIDocument document = GetComponent<UIDocument>();
        m_HealthBar = document.rootVisualElement.Q<VisualElement>("HealthBar");
        SetHealthValue(1.0f);
    }

    public void SetHealthValue(float healthPercent)
    {
        m_HealthBar.style.width = Length.Percent(healthPercent * 100.0f);
    }
}

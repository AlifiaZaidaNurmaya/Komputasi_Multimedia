using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SliderValueToText : MonoBehaviour
{
    public Slider sliderUI;
    private Text textSliderValue;
    // Start is called before the first frame update
    void Start()
    {
        textSliderValue = GetComponent<Text>();
        ShowSliderValue();
    }

    public void ShowSliderValue()
    {
        string sliderMessage = "Slider value = " +
        sliderUI.value;
        textSliderValue.text = sliderMessage;
    }
}

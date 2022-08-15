using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;
using UnityEngine.UI;


public abstract class UIControllerBase : MonoBehaviour
{
    protected virtual void Start()
    {
        GameController.Instance.OnGameStageChanged += OnGameStateChanged;
        UIScaleMode();
    }

    protected abstract void OnGameStateChanged(object sender, GameController.OnGameStageChangedEventArgs e);

    public abstract void NextButton();
    public abstract void RestartButton();
    protected abstract void LevelNumberText();

    private void UIScaleMode() // Telefon modeline göre canvas'ı scale ayarlarını değiştirmeye yarayan metod .
    {
        DeviceGeneration device = Device.generation;
        if (device == DeviceGeneration.iPhoneSE1Gen || device == DeviceGeneration.iPhone6 || device == DeviceGeneration.iPhone7 || device == DeviceGeneration.iPhone8 || device == DeviceGeneration.iPhoneXR || device == DeviceGeneration.iPhone11 || device == DeviceGeneration.iPhoneUnknown)
        {
            GetComponent<CanvasScaler>().uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            GetComponent<CanvasScaler>().referenceResolution = new Vector2(1080, 1920);

        }
        else
        {
            GetComponent<CanvasScaler>().uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
        }
    }

}

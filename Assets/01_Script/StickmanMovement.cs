using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StickmanMovement : MonoBehaviour
{
    [SerializeField] private ObjectPool objectPool;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (gameObject.CompareTag("Blue"))
        {
            Vector3 screenPoint = GameController.Instance.uiController.blueText.transform.position + new Vector3(0, 0, 5);
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPoint);
            GameController.Instance.groundStickman.Remove(gameObject);

            transform.DOMove(worldPos, 1).OnComplete(() => GameController.Instance.uiController.StickmanBlueTextUp());
            transform.DOScale(Vector3.one * 0.05f, 1f).OnComplete(()=> {
                gameObject.SetActive(false);
                gameObject.transform.DOScale(Vector3.one,1f);
                GameController.Instance.groundStickman.Remove(gameObject);
            });
        }
        else if (gameObject.CompareTag("Red"))
        {
            Vector3 screenPoint = GameController.Instance.uiController.redText.transform.position + new Vector3(0, 0, 5);
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPoint);
            GameController.Instance.groundStickman.Remove(gameObject);

            transform.DOMove(worldPos, 1).OnComplete(()=>GameController.Instance.uiController.StickmanRedTextUp());
            transform.DOScale(Vector3.one * 0.05f, 1f).OnComplete(() => {
                gameObject.SetActive(false);
                gameObject.transform.DOScale(Vector3.one, 1f);
                GameController.Instance.groundStickman.Remove(gameObject);
            });
        }
        else if (gameObject.CompareTag("Yellow"))
        {
            Vector3 screenPoint = GameController.Instance.uiController.yellowText.transform.position + new Vector3(0, 0, 5);
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPoint);
            GameController.Instance.groundStickman.Remove(gameObject);

            transform.DOMove(worldPos, 1).OnComplete(() => GameController.Instance.uiController.StickmanYellowTextUp());
            transform.DOScale(Vector3.one * 0.05f, 1f).OnComplete(() => {
                gameObject.SetActive(false);
                gameObject.transform.DOScale(Vector3.one, 1f);
                GameController.Instance.groundStickman.Remove(gameObject);
            });
        }
    }
}

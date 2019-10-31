using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessagesManager : MonoBehaviour
{
    [SerializeField] private Sprite[] mensajes = null;
    [SerializeField] private float[] xpos = null;
    [SerializeField] private float timeRepeat = 8f;
    [SerializeField] private Image fondoInstrucciones = null;
    private int maxNumberSprites;
    private int maxNumberPositions;
    private float[] positions;

    void Start()
    {
        maxNumberSprites = mensajes.Length - 1;
        positions = new float[] { -1.8f, 0.2f, 2.2f };
        maxNumberPositions = positions.Length;
        StartCoroutine(FadeOutInstrucciones());

    }

    private void ShowMessage()
    {
        StartCoroutine(PopUpMessage());
    }

    IEnumerator FadeOutInstrucciones()
    {
        yield return new WaitForSeconds(3f);
        fondoInstrucciones.gameObject.SetActive(false);
        InvokeRepeating("ShowMessage", 1f, timeRepeat);
    }

    IEnumerator PopUpMessage()
    {
        int posIndex = Random.Range(0, maxNumberPositions);
        int spriteIndex = Random.Range(0, maxNumberSprites);

        transform.position = new Vector2(xpos[spriteIndex], positions[posIndex]);

        gameObject.GetComponent<SpriteRenderer>().sprite = mensajes[spriteIndex];
        gameObject.GetComponent<SpriteRenderer>().enabled = true;

        yield return new WaitForSeconds(3f);

        this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }
}

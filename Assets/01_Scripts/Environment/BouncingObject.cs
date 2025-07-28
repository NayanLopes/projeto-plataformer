using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingObject : MonoBehaviour {
    [SerializeField] private bool disableOnTouch = false;

    private void OnTriggerEnter2D( Collider2D collision ) {
        
        // Verifica se o objeto que colidiu possui a tag do jogador.
        if (collision.gameObject.CompareTag(Config.Instance.playerTag))
        {
            PlayerBouncing playerBouncing = collision.gameObject.GetComponent<PlayerBouncing>();
            playerBouncing.OnTouchingBouncingObject();

            if (disableOnTouch)
                gameObject.SetActive(false);
        }
    }
}

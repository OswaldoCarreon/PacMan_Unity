using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class picker : MonoBehaviour
{
    private float coin = 0;
    public TextMeshProUGUI textCoins, gameover;


  private void OnTriggerEnter2D(Collider2D other){
      

      if(other.transform.tag == "Coin") {
          coin+=10;
          textCoins.text = coin.ToString();
          Destroy(other.gameObject);
          SoundManager.playSound("coin");
      }

      if(other.transform.tag == "BigCoin") {
          coin+=30;
          textCoins.text = coin.ToString();
          Destroy(other.gameObject);
          SoundManager.playSound("bigCoin");
      }

      if(coin == 2040) {
          gameover.text = "Game over";
          SoundManager.playSound("stop");
          Time.timeScale = 0;
      }
  }
}

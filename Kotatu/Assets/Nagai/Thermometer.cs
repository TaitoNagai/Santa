//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

////UI使うときは忘れずに！
//using UnityEngine.UI;

//public class HPSystem : MonoBehaviour
//{

//    GameObject image;

//    void Start()
//    {
//        //ImageをGameObjectとして取得
//        image = GameObject.Find("Image");
//    }

//    //()の中身は引数、他のところから数値を得て{}の中で使う
//    public void HPDown(float current, int max)
//    {
//        //ImageというコンポーネントのfillAmountを取得して操作する
//        image.GetComponent<Image>().fillAmount = current / max;
//    }
//}
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

////UI使うときは忘れずに！
//using UnityEngine.UI;

//public class DamageSystem : MonoBehaviour
//{

//    //最大HP、半端な数にした
//    [SerializeField]
//    int maxHP = 137;
//    //現在のHP
//    [SerializeField]
//    float currentHP;

//    GameObject textObj;
//    Text text;
//    GameObject hpSystem;

//    void Start()
//    {
//        //TextをGameObjectとして取得する
//        textObj = GameObject.Find("Text");
//        //HPSystemを取得する
//        hpSystem = GameObject.Find("HPSystem");
//    }

//    void Update()
//    {
//        //TextのTextコンポーネントにアクセス
//        //(int)はfloatを整数で表示するためのもの
//        textObj.GetComponent<Text>().text = ((int)currentHP).ToString();

//        //HPSystemのスクリプトのHPDown関数に2つの数値を送る
//        hpSystem.GetComponent<HPSystem>().HPDown(currentHP, maxHP);
//    }

//    //FixedUpdateは一定に呼ばれるので持続的に使う処理に良いらしい
//    void FixedUpdate()
//    {
//        //currentHPが0以上ならTrue
//        if (0 <= currentHP)
//        {
//            //maxHPから秒数（×10）を引いた数がcurrentHP
//            currentHP = maxHP - Time.time * 10;
//        }
//    }
//}

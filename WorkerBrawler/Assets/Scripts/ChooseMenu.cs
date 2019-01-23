using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class ChooseMenu : MonoBehaviour {

    [SerializeField] tweener[] btn;

    public int val = 0,batasAtas,BatasBawah;
    int plus;
    
    public bool change = false;


    [System.Serializable]
    public class tweener
    {
        public Transform obj;
        public Vector3 posisiAkhir;
        public Vector3 posisiAwal;
        public float waktu = 0.2f;
        public float delay = 0;
        public Ease ease = Ease.OutBack;
    }
    void Start()
    {
        for (int i = 0; i < btn.Length; i++)
        {
            if (btn[i].ease == Ease.Unset)
                btn[i].ease = Ease.OutBack;
            btn[i].obj.DOMove(btn[i].posisiAwal, btn[i].waktu).SetDelay(btn[i].delay).SetEase(btn[i].ease);
        }
        change = true;

        for (int i = 0; i < btn.Length; i++)
        {
            btn[i].obj.DOScale(0.95f, .9f).SetLoops(-1, LoopType.Yoyo);
        }

        
    }

    void Update()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
           
            val += -plus;
            change = true;
        }
        if (Input.GetAxis("Vertical") < 0)
        {
           
           val += plus; 
            change = true;

        }

        if (val > batasAtas)
        {
            val = batasAtas;
        }
        if (val < BatasBawah)
        {
            val = BatasBawah;
        }


        if (Input.GetAxis("Vertical") == 0)
        {
            change = false;
        }

        if (change == true)
        {
            movingBtn();
            plus = 0;
        }
        else
        {
            plus = 1;

        }

        
       
    }

    void movingBtn()
    {
        
        for(int i = 0;i<4; i++ )
        {
            if (i == val)
            {
                btn[i].obj.DOMove(btn[i].posisiAkhir, 0.2f);
            }
            else
            {
                btn[i].obj.DOMove(btn[i].posisiAwal, 0.2f);
            }
            
        }

    }
}

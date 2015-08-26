﻿using UnityEngine;
using System.Collections;
using Game;
public class GameStart : MonoBehaviour
{
    void Awake()
    {

    }

    void Start()
    {
        InitUI();
        LoadHero();
    }

    void Update()
    {

    }

    private void InitUI()
    {
        UIMgr.Instance.LoadUIPrefab<UIFightMain>(UIName.UIFightMain, UIMgr.Layer.layer1);
        UIMgr.Instance.LoadUIPrefab<UIFightStart>(UIName.UIFightStart);
    }

    private void LoadScene()
    {
        Application.LoadLevelAdditive(1);
    }

    private void LoadHero()
    {
        Debug.Log("--------------------");
        TestEnity _t = new TestEnity();
        GlobalData.hero = _t;

        EnemyEnity _enemy = new EnemyEnity();
        _enemy.MyEnity.SetProperty("position", new Vector3(12, 0, 0));
        _enemy.MyEnity.SetProperty("patrolTarget", _t.MyEnity);

        _t.MyEnity.SetProperty("patrolTarget",_enemy.MyEnity);
    }
}
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System;

public class DataController : MonoBehaviour
{
    // ---�̱������� ����--- 
    static GameObject _container;
    static GameObject Container
    {
        get
        {
            return _container;
        }
    }
    static DataController _instance;
    public static DataController Instance
    {
        get
        {
            if (!_instance)
            {
                _container = new GameObject();
                _container.name = "DataController";
                _instance = _container.AddComponent(typeof(DataController)) as DataController;
                DontDestroyOnLoad(_container);
            }
            return _instance;
        }
    }

    // --- ���� ������ �����̸� ���� ---
    public string GameDataFileName = "sachap.json";

    public GameData _gameData;
    public GameData gameData
    {
        get
        {
            // ������ ���۵Ǹ� �ڵ����� ����ǵ���
            if (_gameData == null)
            {
                LoadGameData();
                SaveGameData();
            }
            return _gameData;
        }
    }

    private void Start()
    {
        LoadGameData();
        SaveGameData();
    }

    // ����� ���� �ҷ�����
    public void LoadGameData()
    {
        string filePath = Application.persistentDataPath + GameDataFileName;

        // ����� ������ �ִٸ�
        if (File.Exists(filePath))
        {
            // print("�ҷ����� ����");
            string FromJsonData = File.ReadAllText(filePath);
            _gameData = JsonUtility.FromJson<GameData>(FromJsonData);
        }

        // ����� ������ ���ٸ�
        else
        {
            // print("���ο� ���� ����");
            _gameData = new GameData();
        }
    }

    // ���� �����ϱ�
    public void SaveGameData()
    {
        string ToJsonData = JsonUtility.ToJson(gameData);
        string filePath = Application.persistentDataPath + GameDataFileName;

        // �̹� ����� ������ �ִٸ� �����
        File.WriteAllText(filePath, ToJsonData);

        // // �ùٸ��� ����ƴ��� Ȯ�� (�����Ӱ� ����)
        // print("����Ϸ�");
        // print("1�� " + gameData.isClear1);
        // print("2�� " + gameData.isClear2);
        // print("3�� " + gameData.isClear3);
        // print("4�� " + gameData.isClear4);
    }

    // ������ �����ϸ� �ڵ�����ǵ���
    private void OnApplicationQuit()
    {
        SaveGameData();
    }
}
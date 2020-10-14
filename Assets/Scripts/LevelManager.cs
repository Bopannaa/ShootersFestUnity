using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private Sprite lockedSprite;
    Sprite[] spriteData;
    Dictionary<int, Sprite> sprites = new Dictionary<int, Sprite>();

    public int currentUnlockedLevel;

    void Awake()
    {
        spriteData = Resources.LoadAll<Sprite>("Level");

        for (int i = 0; i < spriteData.Length; i++)
        {
            sprites.Add(i, spriteData[i]);
        }
    }

    void OnEnable()
    {
        Chapter.ActionReset += ResetLevelChooser;
    }

    void OnDisable()
    {
        Chapter.ActionReset -= ResetLevelChooser;
    }

    void ResetLevelChooser(LevelChooser levelChooser, int level)
    {
        if (level <= currentUnlockedLevel)
        {
            levelChooser.Reset(level, PersistentStorage.Instance.levelStar[level - 1], true, GetSpriteByLevel(level - 1));
        }
        else
        {
            levelChooser.Reset(level, 0, false, lockedSprite);
        }
    }

    public Sprite GetSpriteByLevel(int level)
    {
        if (sprites.ContainsKey(level))
            return sprites[level];
        else
            return null;
    }
}

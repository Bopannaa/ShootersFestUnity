using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Chapter : MonoBehaviour
{
    public static Action<LevelChooser, int> ActionReset;

    [SerializeField] private LevelChooser levelChooserPrefab;
    [SerializeField] private Transform levelChooserParent;
    [SerializeField] private AnimationClip moveRightClip, moveLeftClip;

    private List<LevelChooser> levelChoosers = new List<LevelChooser>();

    public int totalChapters = 10;
    public int currentChapter = 3;


    Animator chapteraAnim;
    int dir = 0;

    void OnEnable()
    {
        LevelScene.ActionNextChapterButton += NextChapter;
        LevelScene.ActionPreviousChapterButton += PreviousChapter;
    }

    void OnDisable()
    {
        LevelScene.ActionNextChapterButton -= NextChapter;
        LevelScene.ActionPreviousChapterButton -= PreviousChapter;
    }

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            var levelChooser = Instantiate(levelChooserPrefab);
            levelChooser.transform.SetParent(levelChooserParent);
            levelChooser.transform.localScale = Vector3.one;
            if (ActionReset != null)
            {
                ActionReset(levelChooser, i + ((currentChapter - 1) * 10) + 1);
            }
            levelChoosers.Add(levelChooser);
        }
        chapteraAnim = transform.GetComponent<Animator>();
    }

    public void NextChapter()
    {
        chapteraAnim.Play(moveLeftClip.name);
    }

    public void PreviousChapter()
    {
        chapteraAnim.Play(moveRightClip.name);
    }

    void ChangeChapter(int dir)
    {
        if (dir > 0)
        {
            currentChapter++;
            if (currentChapter > totalChapters)
            {
                currentChapter = 1;
            }

            for (int i = 0; i < 10; i++)
            {
                if (ActionReset != null)
                {
                    ActionReset(levelChoosers[i], i + ((currentChapter - 1) * 10) + 1);
                }
            }
        }
        if (dir < 0)
        {
            currentChapter--;
            if (currentChapter < 1)
            {
                currentChapter = 10;
            }

            for (int i = 0; i < 10; i++)
            {
                if (ActionReset != null)
                {
                    ActionReset(levelChoosers[i], i + ((currentChapter - 1) * 10) + 1);
                }
            }
        }
    }
}

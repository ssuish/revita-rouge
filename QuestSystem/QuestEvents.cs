using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestEvents
{
    public event Action<string> onStartQuest;
    public void StartQuest(string id)
    {
        if (onStartQuest != null)
        {
            onStartQuest(id);
        }
    }
    
    public event Action<string> onAdvanceQuest;
    public void AdvanceQuest(string id)
    {
        if (onAdvanceQuest != null)
        {
            onAdvanceQuest(id);
        }
    }
    
    public event Action<string> onFinishQuest;
    public void FinishQuest(string id)
    {
        if (onFinishQuest != null)
        {
            onFinishQuest(id);
        }
    }
    
    public event Action<Quest> onQuestStateChange;
    public void QuestStateChanged(Quest quest)
    {
        if (onQuestStateChange != null)
        {
            onQuestStateChange(quest);
        }
    }
    
    public event Action<string, int, QuestStepState> onQuestStepStateChange;
    public void QuestStepStateChanged(string id, int stepIndex, QuestStepState questStepState)
    {
        if (onQuestStepStateChange != null)
        {
            onQuestStepStateChange(id, stepIndex, questStepState);
        }
    }

    public event Action<bool> onQuestNotifcationTriggered;

    public void QuestNotificationTriggered(bool isQuestNotificationActive)
    {
        if (onQuestNotifcationTriggered != null)
        {
            onQuestNotifcationTriggered(isQuestNotificationActive);
        }
    }
}

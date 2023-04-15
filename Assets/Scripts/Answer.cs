using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Answer : MonoBehaviour
{
    private string a;
    
    private string[] answers =
    {
        "Бесспорно", "Предрешено", "Никаких сомнений", "Определённо да", "Можешь быть уверен в этом",
        "Мне кажется - 'Да'", "Вероятнее всего", "Хорошие перспективы", "Знаки говорят - 'Да'", "Да", "Пока не ясно, попробуй снова", "Спроси позже",
        "Лучше не рассказывать", "Сейчас нельзя предсказать", "Сконцентрируйся и спроси опять", "Даже не думай", "Мой ответ - 'Нет'",
        "По моим данным - 'Нет'", "Перспективы не очень хорошие", "Весьма сомнительно", "Нет"

    };
    [SerializeField] private Text _answer;

    public void AnswerButton()
    {
        a = answers[Random.Range(0, answers.Length)];

        _answer.text = $"{a}";
    }
}

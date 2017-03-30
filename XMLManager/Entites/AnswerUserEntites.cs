﻿using System;
using System.Collections.Generic;

namespace XML.Entites
{
    [Serializable]
    public class AnswerUserEntites
    {
        public string TextQuestion { get; set; } //Вопрос
        public int Point { get; set; } // Количество баллов за ответ на вопрос 
        public List<string> Answer { get; set; } // Ответы пользователя

        public AnswerUserEntites() { }

        /// <summary>
        /// Создаёт ответ со следующими параметрами:
        /// </summary>
        /// <param name="question">Вопрос </param>
        /// <param name="point">Количесво баллов за ответ</param>
        /// <param name="answer">Ответы пользователя</param>
        public AnswerUserEntites(string question, int point,
            List<string> answer)
        {
            if (string.IsNullOrEmpty(question) || point < 0
                || answer == null || answer.Count == 0)
                throw new ArgumentNullException();
            TextQuestion = question;
            Point = point;
            Answer = answer;
        }
    }
}
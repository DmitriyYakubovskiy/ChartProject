using System.Collections.Generic;

namespace ChartProject.Models
{
    public static class QuestionsManager
    {
        public static List<Question> Questions = new List<Question>()
        {
            new Question("Вы hard или soft?",new List<string>(){"Hard","Soft"}),
            new Question("Какой ваш пол?",new List<string>(){"Мужской","Женский"}),
            new Question("Сколько вам лет?",new List<string>(){"Меньше 18","18 - 21","Больше 21"}),
            new Question("Какие из следующий негативных эффектов вы\r\nзамечаете у себя в результате чрезмерного\r\nиспользования цифровых устройств?",new List<string>(){ "Ухудшение качества сна", "Увеличение уровня стресса", "Снижение концентрации", "Уменьшение времени на реальные\r\n взаимодействия с окружающими"}),
            new Question("В каком приложении вы  проводите больше всего\r\nэкранного времени?",new List<string>(){ "Telegram", "VK", "YouTube", "TikTok", "Instagram", "Spotify", "Twitch"}),
            new Question("Чем вы занимаетесь в свободное время?",new List<string>(){ "Смотрю фильмы и сериалы", "Читаю книги", "Играю в видеоигры"}),
            new Question("Среднее количество часов в телефоне?",new List<string>(){"1 - 4 часа","4 - 8 часа", "Больше 8 часов"}),
            new Question("Вы часто проводите в социальных сетях больше времени,\r\nчем планировали изначально?", new List<string>(){"Да","Нет","Иногда"}),
        };
    }
}

using System.Collections.Generic;

namespace RandomSport
{
    static class ExcericeRepository
    {
        public static List<Excerice> Excerices { get; set; }

        static ExcericeRepository()
        {
            Excerices = new List<Excerice>();

            Excerices.Add(new Excerice(Group.LEGS, "Классические приседания", Measurement.REPS, 10, 40));
            Excerices.Add(new Excerice(Group.LEGS, "Приседания с узкой постановкой ног", Measurement.REPS, 10, 30));
            Excerices.Add(new Excerice(Group.LEGS, "Выпады", Measurement.REPS, 10, 20));
            Excerices.Add(new Excerice(Group.LEGS, "Болгарские приседания", Measurement.REPS, 5, 20));
            Excerices.Add(new Excerice(Group.LEGS, "Подъём на носки", Measurement.REPS, 20, 50));
            Excerices.Add(new Excerice(Group.LEGS, "Подъём таза", Measurement.REPS, 10, 30));
            Excerices.Add(new Excerice(Group.LEGS, "Выпады с выпрыгиванием", Measurement.REPS, 10, 30));
            Excerices.Add(new Excerice(Group.LEGS, "Приседания с выпрыгиванием", Measurement.REPS, 5, 20));
            Excerices.Add(new Excerice(Group.LEGS, "Пистолет на опору", Measurement.REPS, 5, 20));
            Excerices.Add(new Excerice(Group.LEGS, "Выпады вбок", Measurement.REPS, 5, 30));
            Excerices.Add(new Excerice(Group.LEGS, "Наклоны на бицепс бедра", Measurement.REPS, 20, 50));
            Excerices.Add(new Excerice(Group.LEGS, "Махи ногой назад", Measurement.REPS, 20, 50));
            Excerices.Add(new Excerice(Group.LEGS, "Шаги в сторону с приседанием", Measurement.REPS, 10, 30));
            Excerices.Add(new Excerice(Group.LEGS, "Зашагивания", Measurement.REPS, 5, 20));

            Excerices.Add(new Excerice(Group.UPPER, "Классические отжимания", Measurement.REPS, 10, 30));
            Excerices.Add(new Excerice(Group.UPPER, "Отжимания с узкой постановкой рук", Measurement.REPS, 5, 20));
            Excerices.Add(new Excerice(Group.UPPER, "Отжимания руки у пояса", Measurement.REPS, 5, 20));
            Excerices.Add(new Excerice(Group.UPPER, "Отжимания ноги на возвышенности", Measurement.REPS, 10, 20));
            Excerices.Add(new Excerice(Group.UPPER, "Отжимания на трицепс", Measurement.REPS, 10, 20));
            Excerices.Add(new Excerice(Group.UPPER, "Обратные отжимания", Measurement.REPS, 10, 30));
            Excerices.Add(new Excerice(Group.UPPER, "Шагающая планка", Measurement.REPS, 10, 30));
            Excerices.Add(new Excerice(Group.UPPER, "Отжимания на плечи", Measurement.REPS, 5, 15));
            Excerices.Add(new Excerice(Group.UPPER, "Классические подтягивания", Measurement.REPS, 5, 15));
            Excerices.Add(new Excerice(Group.UPPER, "Подтягивания узким хватом", Measurement.REPS, 5, 15));
            Excerices.Add(new Excerice(Group.UPPER, "Подтягивания перпендикулярно турнику", Measurement.REPS, 5, 15));
            Excerices.Add(new Excerice(Group.UPPER, "Вис на турнике", Measurement.SECONDS, 20, 60));
            Excerices.Add(new Excerice(Group.UPPER, "Подтягивания с весом", Measurement.REPS, 5, 10));
            Excerices.Add(new Excerice(Group.UPPER, "Отжимания с паузой на полу", Measurement.REPS, 10, 20));
            Excerices.Add(new Excerice(Group.UPPER, "Отжимания с весом", Measurement.REPS, 10, 20));

            Excerices.Add(new Excerice(Group.CORE, "Скручивания", Measurement.REPS, 10, 30));
            Excerices.Add(new Excerice(Group.CORE, "Подъём ног", Measurement.REPS, 10, 20));
            Excerices.Add(new Excerice(Group.CORE, "Уголок", Measurement.SECONDS, 10, 30));
            Excerices.Add(new Excerice(Group.CORE, "Подъём ног в висе", Measurement.REPS, 5, 15));
            Excerices.Add(new Excerice(Group.CORE, "Плавание без ног", Measurement.REPS, 10, 30));
            Excerices.Add(new Excerice(Group.CORE, "Лодочка на животе", Measurement.REPS, 10, 20));
            Excerices.Add(new Excerice(Group.CORE, "Лодочка на спине", Measurement.REPS, 10, 20));
            Excerices.Add(new Excerice(Group.CORE, "Гиперэкстензия", Measurement.REPS, 10, 20));
            Excerices.Add(new Excerice(Group.CORE, "Ножницы", Measurement.REPS, 10, 30));
            Excerices.Add(new Excerice(Group.CORE, "Касание ноги по диагонали", Measurement.REPS, 10, 20));

            Excerices.Add(new Excerice(Group.COMPLEX, "Планка", Measurement.SECONDS, 10, 120));
            Excerices.Add(new Excerice(Group.COMPLEX, "Скалолаз", Measurement.REPS, 10, 30));
            Excerices.Add(new Excerice(Group.COMPLEX, "Велосипед", Measurement.REPS, 10, 30));
            Excerices.Add(new Excerice(Group.COMPLEX, "Червяк с отжиманием", Measurement.REPS, 10, 30));
            Excerices.Add(new Excerice(Group.COMPLEX, "Мостик", Measurement.REPS, 2, 10));
            Excerices.Add(new Excerice(Group.COMPLEX, "Касание ноги в обратной планке", Measurement.REPS, 10, 20));
            Excerices.Add(new Excerice(Group.COMPLEX, "Без рук лечь на спину и встать", Measurement.REPS, 10, 20));
            Excerices.Add(new Excerice(Group.COMPLEX, "Приседания с махами вперёд", Measurement.REPS, 10, 20));
            Excerices.Add(new Excerice(Group.COMPLEX, "Махи ногами и касание по диагонали", Measurement.REPS, 10, 30));
            Excerices.Add(new Excerice(Group.COMPLEX, "Боковые наклоны колено-локоть", Measurement.REPS, 10, 30));
            Excerices.Add(new Excerice(Group.COMPLEX, "Мельница", Measurement.REPS, 10, 30));
            Excerices.Add(new Excerice(Group.COMPLEX, "Удержание баланса на одной ноге", Measurement.SECONDS, 20, 120));
            Excerices.Add(new Excerice(Group.COMPLEX, "Удары ногой по воздуху", Measurement.REPS, 10, 20));
            Excerices.Add(new Excerice(Group.COMPLEX, "Жонглирование", Measurement.REPS, 10, 50));

            Excerices.Add(new Excerice(Group.STRETCHING, "Продольный шпагат", Measurement.SECONDS, 10, 30, true));
            Excerices.Add(new Excerice(Group.STRETCHING, "Поперечный шпагат", Measurement.SECONDS, 10, 60));
            Excerices.Add(new Excerice(Group.STRETCHING, "Сидя достать до одной ноги", Measurement.SECONDS, 10, 30, true));
            Excerices.Add(new Excerice(Group.STRETCHING, "Наклоны вперёд", Measurement.SECONDS, 10, 60));
            Excerices.Add(new Excerice(Group.STRETCHING, "Сидя наклоны вбок", Measurement.SECONDS, 10, 30, true));
            Excerices.Add(new Excerice(Group.STRETCHING, "Поза кобры", Measurement.SECONDS, 10, 60));
            Excerices.Add(new Excerice(Group.STRETCHING, "Наклоны, руки над головой", Measurement.SECONDS, 10, 60));
            Excerices.Add(new Excerice(Group.STRETCHING, "Стойка сумо", Measurement.SECONDS, 10, 30));
            Excerices.Add(new Excerice(Group.STRETCHING, "Глубокие выпады вперёд", Measurement.SECONDS, 10, 30, true));
            Excerices.Add(new Excerice(Group.STRETCHING, "Глубокие выпады вбок", Measurement.SECONDS, 10, 30, true));
            Excerices.Add(new Excerice(Group.STRETCHING, "Тянем жопу к потолку на четвереньках", Measurement.SECONDS, 10, 60));
            Excerices.Add(new Excerice(Group.STRETCHING, "Поза лотоса", Measurement.SECONDS, 10, 60));
            Excerices.Add(new Excerice(Group.STRETCHING, "Скручивания в тазу лёжа на спине", Measurement.SECONDS, 10, 30, true));
            Excerices.Add(new Excerice(Group.STRETCHING, "Лягушка - мордой в пол сидя на жопе", Measurement.SECONDS, 10, 60));
        }
    }
}

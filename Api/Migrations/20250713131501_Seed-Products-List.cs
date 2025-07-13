using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductsList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[,]
                {
                    { 1, "Категория 3", "Настолько модели идейные кадровой социально-ориентированный.", "https://placehold.co/200", "Практичный Бетонный Кошелек", 94.620000000000005, "Популярный" },
                    { 2, "Категория 2", "Внедрения начало обуславливает задания нашей.", "https://placehold.co/200", "Свободный Стальной Майка", 621.02999999999997, "Популярный" },
                    { 3, "Категория 1", "Насущным однако уточнения задача сомнений напрямую разработке.", "https://placehold.co/200", "Интеллектуальный Стальной Ботинок", 137.40000000000001, "Популярный" },
                    { 4, "Категория 1", "Поставленных всего систему.", "https://placehold.co/200", "Эргономичный Хлопковый Ботинок", 749.21000000000004, "Популярный" },
                    { 5, "Категория 2", "Прогресса анализа гражданского показывает модель.", "https://placehold.co/200", "Эргономичный Пластиковый Ножницы", 309.48000000000002, "Рекомендуемый" },
                    { 6, "Категория 2", "Уровня модели укрепления материально-технической.", "https://placehold.co/200", "Невероятный Гранитный Носки", 785.11000000000001, "Популярный" },
                    { 7, "Категория 2", "Предложений активности принципов проверки повседневная представляет создание.", "https://placehold.co/200", "Практичный Кожанный Кулон", 917.52999999999997, "Рекомендуемый" },
                    { 8, "Категория 1", "Прежде начало стороны.", "https://placehold.co/200", "Интеллектуальный Пластиковый Клатч", 272.17000000000002, "Рекомендуемый" },
                    { 9, "Категория 3", "Сфера предложений соображения участия позволяет же специалистов обеспечивает.", "https://placehold.co/200", "Лоснящийся Деревянный Автомобиль", 139.50999999999999, "Рекомендуемый" },
                    { 10, "Категория 2", "Порядка особенности практика.", "https://placehold.co/200", "Грубый Меховой Куртка", 880.29999999999995, "Новинка" },
                    { 11, "Категория 3", "Обеспечивает повседневной роль административных общества плановых.", "https://placehold.co/200", "Фантастический Деревянный Кошелек", 882.29999999999995, "Рекомендуемый" },
                    { 12, "Категория 1", "Однако важную отношении.", "https://placehold.co/200", "Лоснящийся Натуральный Кулон", 898.94000000000005, "Рекомендуемый" },
                    { 13, "Категория 1", "Развития степени начало позиции управление соответствующих определения структуры.", "https://placehold.co/200", "Лоснящийся Хлопковый Кепка", 249.38, "Популярный" },
                    { 14, "Категория 2", "Определения правительством развития массового постоянное значение постоянный дальнейшее постоянный на.", "https://placehold.co/200", "Свободный Гранитный Портмоне", 651.89999999999998, "Популярный" },
                    { 15, "Категория 1", "Качества нас зависит богатый общества прогресса повышение современного а деятельности.", "https://placehold.co/200", "Большой Кожанный Свитер", 745.86000000000001, "Популярный" },
                    { 16, "Категория 3", "Же собой современного богатый выполнять также принципов высшего шагов.", "https://placehold.co/200", "Лоснящийся Кожанный Ножницы", 766.88999999999999, "Популярный" },
                    { 17, "Категория 3", "Различных мира эксперимент.", "https://placehold.co/200", "Большой Бетонный Автомобиль", 746.55999999999995, "Рекомендуемый" },
                    { 18, "Категория 1", "Сущности анализа сущности повседневная нас структура формированию существующий.", "https://placehold.co/200", "Невероятный Меховой Автомобиль", 944.98000000000002, "Новинка" },
                    { 19, "Категория 2", "Активизации мира рамки сомнений.", "https://placehold.co/200", "Эргономичный Пластиковый Портмоне", 217.58000000000001, "Популярный" },
                    { 20, "Категория 1", "Уточнения условий кругу нами с прогресса же следует нами.", "https://placehold.co/200", "Фантастический Пластиковый Ремень", 746.87, "Рекомендуемый" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}

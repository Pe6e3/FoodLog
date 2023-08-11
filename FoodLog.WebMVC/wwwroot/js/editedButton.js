
var originalValues = {}; // Объект для хранения оригинальных значений полей формы

// Заполняем объект originalValues при загрузке страницы
$(document).ready(function () {
    $("#editButton").css("display", "none");  // Сразу скрываем кнопку
    originalValues = {
        Name: $("#Name").val(),
        Calories: $("#Calories").val(),
        Prot: $("#Prot").val(),
        Fat: $("#Fat").val(),
        Carb: $("#Carb").val(),
        HarmScore: $("#HarmScore").val(),
        TrashPercentage: $("#TrashPercentage").val()
    };

    // Добавляем обработчик события изменения поля
    $("input.form-control").on("input", function () {
        editButtonActivation(); // Вызываем функцию для активации/деактивации кнопки
    });
});

// Функция для активации/деактивации кнопки
function editButtonActivation() {
    var edited = false;

    // Проверяем каждое поле на изменение
    if ($("#Name").val() !== originalValues.Name ||
        $("#Calories").val() !== originalValues.Calories ||
        $("#Prot").val() !== originalValues.Prot ||
        $("#Fat").val() !== originalValues.Fat ||
        $("#Carb").val() !== originalValues.Carb ||
        $("#HarmScore").val() !== originalValues.HarmScore ||
        $("#TrashPercentage").val() !== originalValues.TrashPercentage) {
        edited = true;
    }


    // Если были внесены изменения, активируем кнопку, иначе - деактивируем
    if (edited) {
        $("#editButton").css("display", "");
    } else {
        $("#editButton").css("display", "none");
    }
}
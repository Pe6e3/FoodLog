
var originalValues = {}; // ������ ��� �������� ������������ �������� ����� �����

// ��������� ������ originalValues ��� �������� ��������
$(document).ready(function () {
    $("#editButton").css("display", "none");  // ����� �������� ������
    originalValues = {
        Name: $("#Name").val(),
        Calories: $("#Calories").val(),
        Prot: $("#Prot").val(),
        Fat: $("#Fat").val(),
        Carb: $("#Carb").val(),
        HarmScore: $("#HarmScore").val(),
        TrashPercentage: $("#TrashPercentage").val()
    };

    // ��������� ���������� ������� ��������� ����
    $("input.form-control").on("input", function () {
        editButtonActivation(); // �������� ������� ��� ���������/����������� ������
    });
});

// ������� ��� ���������/����������� ������
function editButtonActivation() {
    var edited = false;

    // ��������� ������ ���� �� ���������
    if ($("#Name").val() !== originalValues.Name ||
        $("#Calories").val() !== originalValues.Calories ||
        $("#Prot").val() !== originalValues.Prot ||
        $("#Fat").val() !== originalValues.Fat ||
        $("#Carb").val() !== originalValues.Carb ||
        $("#HarmScore").val() !== originalValues.HarmScore ||
        $("#TrashPercentage").val() !== originalValues.TrashPercentage) {
        edited = true;
    }


    // ���� ���� ������� ���������, ���������� ������, ����� - ������������
    if (edited) {
        $("#editButton").css("display", "");
    } else {
        $("#editButton").css("display", "none");
    }
}
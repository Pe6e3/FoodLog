$(document).ready(function () {
    filterTableByProductName();  // ������� ��� ���������� ������� �� �������� ��������. ��������� ��� ��������, �.�. ����� ���� �������� ������ ��� ���������� �����

    function filterTableByProductName() {
        var input, filter, table, tr, td, i, txtValue;
        input = document.getElementById("productNameFilter");
        filter = input.value.toUpperCase();
        table = document.querySelector(".cinereousTable");
        tr = table.getElementsByTagName("tr");


        for (i = 0; i < tr.length - 1; i++) {
            td = tr[i].getElementsByTagName("td")[0];
            if (td) {
                txtValue = td.textContent || td.innerText;
                if (txtValue.toUpperCase().indexOf(filter) > -1) {
                    tr[i].style.display = "";
                } else {
                    tr[i].style.display = "none";
                }
            }
        }
    }

    // ���������� ������� ����� � ���� �������
    $("#productNameFilter").on("input", function () {
        filterTableByProductName();
    });
});
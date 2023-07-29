$(document).ready(function () {
    filterTableByProductName();  // ������� ��� ���������� ������� �� �������� ��������. ��������� ��� ��������, �.�. ����� ���� �������� ������ ��� ���������� �����

    function filterTableByProductName() {
        var input, filter, table, tr, td, i, txtValue;
        input = document.getElementById("productNameFilter");
        filter = input.value.toUpperCase();
        table = document.querySelector(".cinereousTable");
        tr = table.getElementsByTagName("tr");

        var totalWeight = 0;     // ���������� ��� �������� ����� ������������ �������� "������� ���"
        var totalConsume = 0;    // ���������� ��� �������� ����� ������������ �������� "����������"
        var totalRemain = 0;     // ���������� ��� �������� ����� ������������ �������� "���������"
        var totalCost = 0;       // ���������� ��� �������� ����� ������������ �������� "���������"

        for (i = 0; i < tr.length - 1; i++) {
            td = tr[i].getElementsByTagName("td")[0];
            if (td) {
                txtValue = td.textContent || td.innerText;
                if (txtValue.toUpperCase().indexOf(filter) > -1) {
                    tr[i].style.display = "";

                    // ���� ������ ������������ ����� ����������, �� ��������� �������� � �����
                    var weight = parseFloat(tr[i].getElementsByTagName("td")[1].innerText);
                    var consume = parseFloat(tr[i].getElementsByTagName("td")[2].innerText);
                    var remain = parseFloat(tr[i].getElementsByTagName("td")[3].innerText);
                    var cost = parseFloat(tr[i].getElementsByTagName("td")[4].innerText);
                    totalWeight += isNaN(weight) ? 0 : weight;
                    totalConsume += isNaN(consume) ? 0 : consume;
                    totalRemain += isNaN(remain) ? 0 : remain;
                    totalCost += isNaN(cost) ? 0 : cost;

                } else {
                    tr[i].style.display = "none";
                }
            }
        }

        // ��������� ����������� ����� � �������
        document.getElementById("totalWeight").innerText = totalWeight.toFixed(0);
        document.getElementById("totalConsume").innerText = totalConsume.toFixed(0);
        document.getElementById("totalRemain").innerText = totalRemain.toFixed(0);
        document.getElementById("totalCost").innerText = totalCost.toFixed(0);
    }

    // ���������� ������� ����� � ���� �������
    $("#productNameFilter").on("input", function () {
        filterTableByProductName();
    });
});
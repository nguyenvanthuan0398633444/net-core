var category = {} || category;
var table = $('#tbModule').DataTable();
category.deleted = function (id, name) {
    var result = confirm("Do you want to delete " + name + "?");
    if (result == true) {
        $.ajax({
            url: `/category/delete/${id}`,
            method: 'POST',
            dataType: 'JSON',
            success: function (response) {
                alert(name +" "+response.data.message + " !");
                category.drawTable();
            },
            error: function () {
                alert(response.data.message);
            }
        });
    }
}
category.actived = function (id, name) {
    var result = confirm("Do you want to active " + name + "?");
    if (result == true) {
        $.ajax({
            url: `/category/delete/${id}`,
            method: 'POST',
            dataType: 'JSON',
            success: function (response) {
                alert(name +" "+response.data.message + " !");
                category.drawTable();
            },
            error: function () {
                alert(response.data.message);
            }
        });
    }
}
$(document).ready(function () {
    category.init();
})
category.init = function () {
    category.drawTable();
}
category.drawTable = function () {
    $('#categoryTable').empty();
    $.ajax({
        beforeSend: function () {   
            $('.ajax-loader').css("visibility", "visible");
        },
        url: "/Category/Gets",
        method: "GET",
        dataType: "json",
        success: function (data) {
            table.clear().destroy();
            $.each(data.result, function (i, v) {
                var action = "";
                if (v.status == "Active") {
                    action = `<a href="javascripts:;"
                                       onclick="category.get(${v.id})"><i class="fas fa-edit"></i></a>
                            <a href="javascripts:;"
                                        onclick="category.deleted(${v.id}, '${v.categoryName}')"><i class="fas fa-trash"></i></a>`
                }
                else {
                    action = `
                            <a href="javascripts:;"
                                        onclick="category.actived(${v.id}, '${v.categoryName}')"><i class="fas fa-check-circle"></i></a>`
                }
                $('#categoryTable').append(
                    `<tr>
                        <td>${v.id}</td>
                        <td>${v.categoryName}</td>
                        <td>${v.status}</td>
                        <td>
                            ${action}
                        </td>
                    </tr>`
                );
            });
            category.draw();
        },
        complete: function () {
            $('.ajax-loader').css("visibility", "hidden");
        }
    });
}
category.openModal = function () {
    $('#CategoryName').val('');
    $('#addEditCategoryModal').modal('show');
    document.getElementsByClassName('modal-backdrop')[0].classList.remove('modal-backdrop');
}
category.get = function (id) {
    $.ajax({
        url: `/category/get/${id}`,
        method: "get",
        dataType: "json",
        success: function (response) {
            $('#CategoryName').val(response.data.categoryName);
            document.getElementById('CategoryId').value = response.data.categoryId;
            $('#addEditCategoryModal').modal('show');
            document.getElementsByClassName('modal-backdrop')[0].classList.remove('modal-backdrop');
        }
    });   
}
category.save = function () {
    if ($('#frmAddEditCategory').valid()) {
        var saveObj = {};
        saveObj.categoryId = parseInt($('#CategoryId').val());
        saveObj.categoryName = $('#CategoryName').val();
        $.ajax({
            url: '/category/save',
            method: 'POST',
            dataType: 'JSON',
            contentType: 'application/json',
            data: JSON.stringify(saveObj),
            success: function (response) {
                bootbox.alert(response.data.message);
                if (response.data.id > 0) {
                    $('#addEditCategoryModal').modal('hide');
                    category.drawTable();
                }
            }
        });
    }
}
category.draw = function () {
    table = $("#tbModule").DataTable(
        {
            "language": {
                "sProcessing": "Đang xử lý...",
                //"sLengthMenu": "Xem MENU mục",
                "sZeroRecords": "Không tìm thấy dòng nào phù hợp",
                //"sInfo": "Đang xem START đến END trong tổng số TOTAL mục",
                "sInfoEmpty": "Đang xem 0 đến 0 trong tổng số 0 mục",
                "sInfoFiltered": "(được lọc từ MAX mục)",
                "sInfoPostFix": "",
                "sSearch": "Tìm:",
                "sUrl": "",
                "oPaginate": {
                    "sFirst": "Đầu",
                    "sPrevious": "Trước",
                    "sNext": "Tiếp",
                    "sLast": "Cuối"
                }
            },
            "columnDefs": [
            ]
        }
    );
};
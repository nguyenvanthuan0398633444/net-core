var brand = {} || brand;
var table = $('#tbModule').DataTable();
brand.deleted = function (id, name) {
    var result = confirm("Do you want to delete " + name + "?");
    if (result == true) {
        $.ajax({
            url: `/brand/delete/${id}`,
            method: 'POST',
            dataType: 'JSON',
            success: function (response) {
                alert(name + " " + response.data.message + " !");
                brand.drawTable();
            },
            error: function () {
                alert(response.data.message);
            }
        });
    }
}
brand.actived = function (id, name) {
    var result = confirm("Do you want to active " + name + "?");
    if (result == true) {
        $.ajax({
            url: `/brand/delete/${id}`,
            method: 'POST',
            dataType: 'JSON',
            success: function (response) {
                alert(name + " " + response.data.message + " !");
                brand.drawTable();
            },
            error: function () {
                alert(response.data.message);
            }
        });
    }
}
$(document).ready(function () {
    brand.init();
})
brand.init = function () {
    brand.drawTable();
}



brand.drawTable = function () {
    //$('#brandTable').empty();
    $.ajax({
        beforeSend: function () {
            $('.ajax-loader').css("visibility", "visible");
        },
        url: "/Brand/Gets",
        method: "GET",
        dataType: "json",
        success: function (data) {
            table.clear().destroy();
            $.each(data.result, function (i, v) {
                var action = "";
                if (v.status == "Active") {
                    action = `<a href="javascripts:;"
                                       onclick="brand.get(${v.id})"><i class="fas fa-edit"></i></a>
                            <a href="javascripts:;"
                                        onclick="brand.deleted(${v.id}, '${v.brandName}')"><i class="fas fa-trash"></i></a>`
                }
                else {
                    action = `
                            <a href="javascripts:;"
                                        onclick="brand.actived(${v.id}, '${v.brandName}')"><i class="fas fa-check-circle"></i></a>`
                }
                $('#brandTable').append(
                    `<tr>
                        <td>${v.id}</td>
                        <td>${v.brandName}</td>
                        <td>${v.status}</td>
                        <td>
                            ${action}
                        </td>
                    </tr>`
                );
            });
            brand.draw();
        },
        complete: function () {
            $('.ajax-loader').css("visibility", "hidden");
        }
        
    });
}


brand.openModal = function () {
    $('#BrandName').val('');
    $('#addEditCategoryModal').modal('show');
    document.getElementsByClassName('modal-backdrop')[0].classList.remove('modal-backdrop');
}
brand.save = function () {
        var saveObj = {};
        saveObj.id = parseInt($('#BrandId').val());
        saveObj.brandName = $('#BrandName').val();
        $.ajax({
            url: '/brand/save',
            method: 'POST',
            dataType: 'JSON',
            contentType: 'application/json',
            data: JSON.stringify(saveObj),
            success: function (response) {
                bootbox.alert(response.data.message);
                if (response.data.id > 0) {
                    $('#addEditCategoryModal').modal('hide');
                    brand.drawTable();
                }
            }
        });
}

brand.get = function (id) {
    $.ajax({
        url: `/Brand/get/${id}`,
        method: "GET",
        dataType: "json",
        success: function (response) {
            $('#BrandName').val(response.data.brandName);
            document.getElementById('BrandId').value = response.data.id;
            $('#addEditCategoryModal').modal('show');
            document.getElementsByClassName('modal-backdrop')[0].classList.remove('modal-backdrop');
        }
    });
}
brand.draw = function () {
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
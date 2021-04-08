var product = {} || product;
var table = $('#tbModule').DataTable();
product.deleted = function (id, name) {
    var result = confirm("Do you want to delete " + name + "?");
    if (result == true) {
        $.ajax({
            url: `/product/delete/${id}`,
            method: 'POST',
            dataType: 'JSON',
            success: function (response) {
                alert(name + " " + response.data.message + " !");
                product.drawTable();
            },
            error: function () {
                alert(response.data.message);
            }
        });
    }
}
product.actived = function (id, name) {
    var result = confirm("Do you want to active " + name + "?");
    if (result == true) {
        $.ajax({
            url: `/product/delete/${id}`,
            method: 'POST',
            dataType: 'JSON',
            success: function (response) {
                alert(name + " " + response.data.message + " !");
                product.drawTable();
            },
            error: function () {
                alert(response.data.message);
            }
        });
    }
}
$(document).ready(function () {
    product.init();
})
product.init = function () {
    product.drawTable();
}
product.drawTable = function () {
    $('#productTable').empty();
    $.ajax({
        beforeSend: function () {
            $('.ajax-loader').css("visibility", "visible");
        },
        url: "/product/Gets",
        method: "GET",
        dataType: "json",
        success: function (data) {
            table.clear().destroy();
            $.each(data.result, function (i, v) {
                var action = "";
                if (v.status == "Active") {
                    action = `<a href="javascripts:;"
                                       onclick="product.get(${v.id})"><i class="fas fa-edit"></i></a>
                            <a href="javascripts:;"
                                        onclick="product.deleted(${v.id}, '${v.productName}')"><i class="fas fa-trash"></i></a>
                          <a href="/Home/Details/${v.id}"><i class="fas fa-eye"></i></a>
                            `
                }
                else {
                    action = `
                            <a href="javascripts:;"
                                        onclick="product.actived(${v.id}, '${v.productName}')"><i class="fas fa-check"></i></a>`
                }
                $('#productTable').append(
                    `<tr>
                        <td>${v.id}</td>
                        <td>${v.trangThai}</td>
                        <td>${v.status}</td>
                        <td>${v.productName}</td>
                        <td>${v.brandName}</td>
                        <td>${v.categoryName}</td>
                        <td><img src="/images/${v.image}" width="100px" height="100px" alt="Error" /></td>
                        <td>${v.price}</td>
                        <td>${v.dateofSale.slice(0, -9)}</td>
                        <td>
                            ${action}
                        </td>
                    </tr>`
                );
            });
            product.draw();
        },
        complete: function () {
            $('.ajax-loader').css("visibility", "hidden");
        }
    });
}
product.openModal = function () {
    $('#productName').val('');
    $('#addEditproductModal').modal('show');
    document.getElementsByClassName('modal-backdrop')[0].classList.remove('modal-backdrop');
}
product.get = function (id) {
    
    $.ajax({
        url: `/product/get/${id}`,
        method: "get",
        dataType: "json",
        success: function (response) {
            $('#addEditproductModal').modal('show');
            loadproduct();
            $('#ProductName').val(response.productName);
            $('#ProductId').val(response.id);
            $('#CategoryId').val(response.categoryId);
            $('#Price').val(response.price);

            if (response.image != null) {
                $("#previewImg1").empty();
                $("#previewImg1").append(`<img src="/images/${response.image}" width="100px" alt="Error" />`);
            }
            image(response.id);
            $('#Images').val(response.images);
            $('#BrandId').val(response.brandId);
            $('#Description').val(response.description);
            $('#StatusProduct').val(response.statusProduct);
            $('#Date').val(response.dateofSale.slice(0, -9));
            document.getElementsByClassName('note-editable card-block')[0].innerHTML = response.description;
            document.getElementsByClassName('modal-backdrop')[0].classList.remove('modal-backdrop');
        }
    });
}
product.save = function () {
    var saveObj = {};
    if ($('#ProductId').val() != undefined) {
        saveObj.productId = parseInt($('#ProductId').val());
    }
    else {
        saveObj.productId = 0;
    }

    var fd = new FormData();
    fd.append('id', parseInt($('#ProductId').val()));
    fd.append('productName', $('#ProductName').val());
    fd.append('image', $('#Image')[0].files[0]);
    $.each($('#Images')[0].files, function (i, file) {
        fd.append('images', file);
    });
    fd.append('categoryId', $('#CategoryId').val());
    fd.append('brandId', $('#BrandId').val());
    fd.append('description', $('#Description').val());
    fd.append('price', $('#Price').val());
    fd.append('statusProduct', $('#StatusProduct').val());
    fd.append('date', $('#Date').val());
    if ($('#UserId').val() == undefined) {
        fd.append('userId', 0);
    }
    else
        fd.append('userId', $('#UserId').val());
    $.ajax({
        url: '/product/save',
        method: 'POST',
        data: fd,
        processData: false,
        contentType: false,
        success: function (response) {
                alert(response.message);
        },
        error: function () {
            bootbox.alert(response.message);
        }
    });
};
$(document).ready(function () {
    loadproduct();
});

window.preview = function (input) {
    $('#previewImg').empty();
    if (input.files && input.files[0]) {

        $(input.files).each(function (i, value) {
            var reader = new FileReader();
            reader.readAsDataURL(this);
            reader.onload = function (e) {
                if (e != null) {
                    $("#previewImg").append("<div class='row' id='p" + i + "' style='margin:10px;'><img style='width: 100px' class='thumb'  src='" + e.target.result + "'></div></div>");
                }
            }
        });
    }
}

function xoa(i) { $(`#p${i}`).remove(); }

window.preview1 = function (input) {
    $('#previewImg1').empty();
    if (input.files && input.files[0]) {

        $(input.files).each(function (i, value) {
            var reader = new FileReader();
            reader.readAsDataURL(this);
            reader.onload = function (e) {
                if (e != null) {
                    $("#previewImg1").append("<div class='row' id='p" + i + "' style='margin:10px;'><img style='width: 200px' class='thumb'  src='" + e.target.result + "'><div></div></div>");
                }
            }
        });
    }
}
image = function (id) {
    $.ajax({
        url: `/getAll/getsImage/${id}`,
        method: "get",
        data: "json",
        success: function (response) {
            $("#previewImg").empty();
            $.each(response.result, function (i, v) {
                $("#previewImg").append(`<div style='margin:10px;'><img src="/images/${v.pathImage.trim()}" height="100px" alt="Error" /></div>`);
            })
        }
    });
}

category = function () {
    $.ajax({
        url: `/category/gets`,
        method: "get",
        data: "json",
        success: function (response) {
            $.each(response.result, function (i, v) {
                $('#CategoryId').append(`
                <option value="${v.categoryId}">${v.categoryName}</option>`);
            })
        }
    });
}
loadproduct = function () {
    $.ajax({
        url: `/brand/gets`,
        method: "get",
        data: "json",
        success: function (response) {
            $.each(response.result, function (i, v) {
                $('#BrandId').append(`
                <option value="${v.id}">${v.brandName}</option>`);
            })
        }
    });
    $.ajax({
        url: `/category/gets`,
        method: "get",
        data: "json",
        success: function (response) {
            $.each(response.result, function (i, v) {
                $('#CategoryId').append(`
                <option value="${v.id}">${v.categoryName}</option>`);
            })
        }
    });
    $.ajax({
        url: `/getAll/getsProductStatus`,
        method: "get",
        data: "json",
        success: function (response) {
            $.each(response.result, function (i, v) {
                $('#StatusProduct').append(`
                <option value="${v.id}">${v.statusname}</option>`);
            })
        }
    });
}
product.draw = function () {
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
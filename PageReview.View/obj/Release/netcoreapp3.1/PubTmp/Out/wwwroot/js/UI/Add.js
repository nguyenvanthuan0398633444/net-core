var product = {} || product;
var ProductId = $('#ProductId').val();
var BrandId = $('#BrandId').val();
var CategoryId = $('#CategoryId').val();
var UserId = $('#UserId').val();
var vote = 0;
var Admin = [];

$(document).ready(function () {
    $.ajax({
        url: `/account/GetsAdmin`,
        method: 'Get',
        dataType: 'JSON',
        success: function (response) {
            $.each(response, function (i, v) {
                Admin.push(v.userId);
            }
            );    
        }
    });
    product.slideimages(ProductId);
    if (UserId != "")
        product.checkVote(ProductId, UserId);
    else {
        $("#addcheck").append(`
                        <h2>Đánh giá sản phẩm</h2>
                        <span id="1" onmousemove="onmove(1)" onclick="votesao(1)" class="fa fa-star checked fa-lg"></span>
                        <span id="2" onmousemove="onmove(2)" onclick="votesao(2)" class="fa fa-star fa-lg checked"></span>
                        <span id="3" onmousemove="onmove(3)" onclick="votesao(3)" class="fa fa-star fa-lg"></span>
                        <span id="4" onmousemove="onmove(4)" onclick="votesao(4)" class="fa fa-star fa-lg"></span>
                        <span id="5" onmousemove="onmove(5)" onclick="votesao(5)" class="fa fa-star fa-lg"></span>
                    `);
    }
    if (Admin.includes(UserId)) {
        $('#addmanager').append(`
            <a href="brand/index">Manager</a>
        `);
    }
    GetComment(ProductId);
    product.sameCategory(CategoryId);
    product.sameBrand(BrandId);

});


function onmove(id) {
    if (id >= 1) {
        for (let i = 1; i <= id; i++) {
            document.getElementById(i).style.color = "orange";
        }
        for (let i = id + 1; i <= 5; i++) {
            document.getElementById(i).style.color = "black";
        }
    }
    vote = id;
}
function votesao(id) {
    var Obj = {};
    Obj.userId = UserId;
    Obj.productId = ProductId;
    Obj.vote = parseInt(id);
    if (UserId != "") {
        $.ajax({
            url: '/Vote/saveVote',
            method: 'POST',
            data: Obj,
            success: function (response) {
                if (response.data.Id != 0) {
                    alert("Thanks for Vote!");
                    $("#addcheck").empty();
                    $("#addcheck").append(`
                            <h2>Sản phẩm này bạn đã đánh giá</h2>
                            <span onclick="changeRate()"><i class="fas fa-check"></i></span>
                            <span onclick="deleteVote(${response.data.Id})"><i class="fas fa-times"></i></span>
                        `);
                }
                else {
                    alert("Error Vote!");
                }
            }
        });
    }
    else {
        $('#loginUser').show();
    }
}
product.slideimages = function (id) {
    $.ajax({
        url: `/getAll/getsImage/${id}`,
        method: 'Get',
        dataType: 'JSON',
        success: function (response) {
            var tam = '';
            $.each(response.result, function (i, v) {
                if (i == 0) {

                    tam += `<img class="mySlides" src="/images/${v.pathImage.trim()}" style="height:400px; width:100%";>`;
                }
                else {
                    tam += `<img class="mySlides" src="/images/${v.pathImage.trim()}" style="height:400px; width:100%;display: none;">`;
                }
            });
            $("#slideimages").append(`
                            <div class="w3-content w3-display-container">
                                ${tam}
                              <button class="w3-button w3-black w3-display-left" onclick="plusDivs(-1)">&#10094;</button>
                              <button class="w3-button w3-black w3-display-right" onclick="plusDivs(1)">&#10095;</button>
                            </div>
                            `);
        }
    });
}
product.checkVote = function (ProductId, UserId) {
    $.ajax({
        url: `/GetVote/${ProductId}/${UserId}`,
        method: "GET",
        dataType: "json",
        success: function (response) {
            $("#addcheck").empty();
            if (response.result.productId == 0) {
                $("#addcheck").append(`
                        <h2>Đánh giá sản phẩm</h2>
                        <span id="1" onmousemove="onmove(1)" onclick="votesao(1)" class="fa fa-star checked fa-lg"></span>
                        <span id="2" onmousemove="onmove(2)" onclick="votesao(2)" class="fa fa-star fa-lg checked"></span>
                        <span id="3" onmousemove="onmove(3)" onclick="votesao(3)" class="fa fa-star fa-lg"></span>
                        <span id="4" onmousemove="onmove(4)" onclick="votesao(4)" class="fa fa-star fa-lg"></span>
                        <span id="5" onmousemove="onmove(5)" onclick="votesao(5)" class="fa fa-star fa-lg"></span>
                    `);
            }
            else {
                $("#addcheck").append(`
                        <h2>Sản phẩm này bạn đã đánh giá</h2>
                        <span onclick="changeRate()"><i class="fas fa-check"></i></span>
                        <span onclick="deleteVote(${response.result.id})"><i class="fas fa-times"></i></span>
                    `);
            }
        }
    });
}
var changeRate = function () {
    $("#addcheck").empty();
    $("#addcheck").append(`
                        <h2>Đánh giá sản phẩm</h2>
                        <span id="1" onmousemove="onmove(1)" onclick="votesao(1)" class="fa fa-star fa-lg checked"></span>
                        <span id="2" onmousemove="onmove(2)" onclick="votesao(2)" class="fa fa-star fa-lg checked"></span>
                        <span id="3" onmousemove="onmove(3)" onclick="votesao(3)" class="fa fa-star fa-lg"></span>
                        <span id="4" onmousemove="onmove(4)" onclick="votesao(4)" class="fa fa-star fa-lg"></span>
                        <span id="5" onmousemove="onmove(5)" onclick="votesao(5)" class="fa fa-star fa-lg"></span>
                    `);
};
var deleteVote = function (id) {
    $.ajax({
        url: `/Vote/Delete/${id}`,
        method: "Patch",
        dataType: "json",
        success: function (response) {
            alert(response.data.message);
            $("#addcheck").empty();
            $("#addcheck").append(`
                        <h2>Đánh giá sản phẩm</h2>
                        <span id="1" onmousemove="onmove(1)" onclick="votesao(1)" class="fa fa-star fa-lg checked"></span>
                        <span id="2" onmousemove="onmove(2)" onclick="votesao(2)" class="fa fa-star fa-lg checked"></span>
                        <span id="3" onmousemove="onmove(3)" onclick="votesao(3)" class="fa fa-star fa-lg"></span>
                        <span id="4" onmousemove="onmove(4)" onclick="votesao(4)" class="fa fa-star fa-lg"></span>
                        <span id="5" onmousemove="onmove(5)" onclick="votesao(5)" class="fa fa-star fa-lg"></span>
                    `);
        }
    });
}
var Post = function () {
    var saveObj = {};
    saveObj.text = $('#text').val();
    saveObj.productId = ProductId;
    saveObj.userId = UserId;
    saveObj.Id = parseInt($('#SaveId').val());
    if ($('#CommentId').val() == 0 || $('#CommentId').val() == null) {
        if (UserId == "") {
            $('#loginUser').show();
        }
        else {
            $.ajax({
                url: '/comment/save',
                method: 'POST',
                data: saveObj,
                success: function (response) {
                    $('#CommentId').val(0);
                    $('#text').val('');
                    $('#SaveRepId').val(0);
                    alert(response.data.message);
                    GetComment(ProductId);
                }
            });
        }
    }
    else {
        if (UserId == "") {
            $('#loginUser').show();
        }
        else {
            saveObj.commentId = parseInt($('#CommentId').val());
            $.ajax({
                url: '/comment/saverep',
                method: 'POST',
                data: saveObj,
                success: function (response) {
                    alert(response.data.message);
                    $('#CommentId').val(0);
                    $('#SaveRepId').val(0);
                    GetComment(ProductId);
                }
            });
        }
    }
        
};

var PostRep = function () {
    var saveObj = {};
    saveObj.text = $('#textRep').val();
    saveObj.productId = ProductId;
    saveObj.userId = UserId;
    saveObj.commentId = parseInt($('#CommentRepId').val());
    saveObj.Id = parseInt($('#SaveRepId').val());
    
    if (UserId == "") {
        $('#loginUser').show();
    }
    else {
        $.ajax({
            url: '/comment/saverep',
            method: 'POST',
            data: saveObj,
            success: function (response) {
                alert(response.data.message);
                $('#CommentId').val(0);
                $('#SaveRepId').val(0);
                GetComment(ProductId);
                Back();
            }
        });
    }
    
};

var GetComment = function (id) {
    $.ajax({
        url: `/Comment/GetsByProduct/${id}`,
        method: "GET",
        dataType: "json",
        success: function (response) {
            $("#add").empty();
            $.each(response.result, function (i, v) {
                var avatar = "";
                if (v.avatar == "avatar.png") {
                    avatar = '<img class="media-object" src="/template/images/icon1.png" alt="error" style="border-radius:50%;"/>';
                }
                else {
                    avatar = `<img class="media-object" src="/images/Avatar/${v.avatar}" alt="error" style="width:50px;border-radius:50%;"/>`;
                }
                var Status = v.statusComment;

                var Edit = "";
                var Delete = "";
                if (v.userId == UserId || Admin.includes(UserId)) {
                    Edit = `<a onclick="Edit(${v.id})">Edit</a> | `;
                    Delete = ` | <a onclick="DeleteComment(${v.id})">Delete</a>`;
                }
                var Time = "";
                var day = new Date();
                day = new Date(day + " UTC");
                var month = v.time.substring(5, 7) - 1;
                var year = v.time.substring(0, 4);
                var dayy = v.time.substring(8, 10);
                var hours = parseInt(v.time.substring(11, 13)) + 14;
                var minute = v.time.substring(14, 16);
                var second = v.time.substring(17, 19);

                var day2 = new Date(year, month, dayy, hours, minute, second);

                if ((day.getTime() - day2.getTime()) / 1000 / 60 / 60 / 24 / 7 / 52 >= 1) {
                    Time = `${Math.ceil((day.getTime() - day2.getTime()) / 1000 / 60 / 60 / 24 / 7 / 52) - 1} Năm Trước`;
                }
                else if ((day.getTime() - day2.getTime()) / 1000 / 60 / 60 / 24 / 7 >= 1) {
                    Time = `${Math.ceil((day.getTime() - day2.getTime()) / 1000 / 60 / 60 / 24 / 7) - 1} Tuần Trước`;
                }
                else if ((day.getTime() - day2.getTime()) / 1000 / 60 / 60 / 24 >= 1) {
                    Time = `${Math.ceil((day.getTime() - day2.getTime()) / 1000 / 60 / 60 / 24) - 1} Ngày Trước`;
                }
                else if ((day.getTime() - day2.getTime()) / 1000 / 60 / 60 >= 1) {
                    Time = `${Math.ceil((day.getTime() - day2.getTime()) / 1000 / 60 / 60) - 1} Giờ Trước`;
                }
                else if ((day.getTime() - day2.getTime()) / 1000 / 60 >= 1) {
                    Time = `${Math.ceil((day.getTime() - day2.getTime()) / 1000 / 60) - 1} Phút Trước`;
                }
                else {
                    Time = `vừa xong`;
                }
                $("#add").append(`
                            <div class="media response-info" >
                                <div class="media-left response-text-left">
                                        <a href="/Account/details/${v.userId}">
                                            ${avatar}
                                        </a>
                                        <h5 style="width:10px;"><a href="/Account/details/${v.userId}">${v.userName}</a></h5>
                                    </div>
                                    <div style="background-color: #DCDCDC; border-radius: 10px;width:98%;">
                                        <div>
                                            <div class="col-md-9"><h4>
                                                    ${v.text}
                                                </h4>
                                             <ul>
                                                <li style="cursor: pointer; color:#008B8B;">${Edit}</li>
                                                <li style="cursor: pointer; color:#008B8B;"><a onclick="Reply(${v.id})">Reply</a></li>
                                                <li style="cursor: pointer; color:#008B8B;">${Delete}</li>
                                                <p>${Status}</p>
                                            </ul>
                                            </div>
            
                                            
                                            <div style="text-align:right"><p>${Time}</p></div>

                                        </div></div>
                                        
                                        <div class="coment-form" id="add${v.id}"></div>
                            </div>
                            <div id="repCmt${v.id}"></div>
                            <div id="showRep${v.id}"></div>
                    `);
                                        
                GetRep(ProductId, v.id);
            });
        }
    });
}
var GetRep = function (productId, id) {
    $.ajax({
        url: `/Comment/getsReply/${productId}/${id}`,
        method: "GET",
        dataType: "json",
        success: function (response) {
            $(`#showRep${id}`).empty();
            $.each(response.data, function (i, v) {
                var Status = v.statusComment;
                var avatar = "";
                if (v.avatar == "avatar.png") {
                    avatar = '<img class="media-object" src="/template/images/icon1.png" alt="error" style="border-radius:50%"/>';
                }
                else {
                    avatar = `<img class="media-object" src="/images/Avatar/${v.avatar}" alt="error" style="width:50px; border-radius:50%;" />`;
                }
                var Edit = "";
                var Delete = "";
                if (v.userId == UserId || Admin.includes(UserId)) {
                    Edit = `<a onclick="Edit(${v.id})">Edit</a> | `;
                    Delete = `<a herf='#' onclick="DeleteComment(${v.id})">Delete</a>`;
                }
                var Time = "";
                var day = new Date();
                day = new Date(day + " UTC");
                var month = v.time.substring(5, 7) - 1;
                var year = v.time.substring(0, 4);
                var dayy = v.time.substring(8, 10);
                var hours = parseInt(v.time.substring(11, 13)) + 14;
                var minute = v.time.substring(14, 16);
                var second = v.time.substring(17, 19);
                var day2 = new Date(year, month, dayy, hours, minute, second);

                if ((day.getTime() - day2.getTime()) / 1000 / 60 / 60 / 24 / 7 / 52 >= 1) {
                    Time = `${Math.ceil((day.getTime() - day2.getTime()) / 1000 / 60 / 60 / 24 / 7 / 52) - 1} Năm Trước`;
                }
                else if ((day.getTime() - day2.getTime()) / 1000 / 60 / 60 / 24 / 7 >= 1) {
                    Time = `${Math.ceil((day.getTime() - day2.getTime()) / 1000 / 60 / 60 / 24 / 7) - 1} Tuần Trước`;
                }
                else if ((day.getTime() - day2.getTime()) / 1000 / 60 / 60 / 24 >= 1) {
                    Time = `${Math.ceil((day.getTime() - day2.getTime()) / 1000 / 60 / 60 / 24) - 1} Ngày Trước`;
                }
                else if ((day.getTime() - day2.getTime()) / 1000 / 60 / 60 >= 1) {
                    Time = `${Math.ceil((day.getTime() - day2.getTime()) / 1000 / 60 / 60) - 1} Giờ Trước`;
                }
                else if ((day.getTime() - day2.getTime()) / 1000 / 60 >= 1) {
                    Time = `${Math.ceil((day.getTime() - day2.getTime()) / 1000 / 60) - 1} Phút Trước`;
                }
                else {
                    Time = `vừa xong`;
                }
                $(`#showRep${id}`).append(`
                             <div class="media response-info" style="margin-left:10%">
                                <div class="media-left response-text-left">
                                        <a href="/Account/details/${v.userId}">
                                            ${avatar}
                                        </a>
                                        <h5 style="width:10px;"><a href="/Account/details/${v.userId}">${v.userName}</a></h5>
                                    </div>
                                        <div style="background-color: #DCDCDC; border-radius: 10px; width:98%">
                                            <div>
                                                <div class="col-md-9"><h4>
                                                    ${v.text}
                                                </h4>
                                                 <ul>
                                                    <li style="cursor: pointer; color:#008B8B;">${Edit}</li>
                                                    <li style="cursor: pointer; color:#008B8B;">${Delete}</li>
                                                    <p>${Status}</p>
                                                </ul>
                                                </div>
                                            
                                                <div style="text-align:right"><p>${Time}</p></div>

                                            </div>
                                        </div>
                                        <div class="coment-form" id="add${v.id}"></div>
                            </div>
                        `);
            });
        }
    })
}

function Edit(commentId) {
    $.ajax({
        url: `/Comment/Get/${commentId}`,
        method: 'Get',
        data: commentId,
        success: function (response) {
            $('#SaveId').val(response.result.id);
            $("#text").val(response.result.text);
            $("#CommentId").val(response.result.commentId);
        }
    })
}
function DeleteComment(commentId) {
    $.ajax({
        url: `/Comment/delete/${commentId}`,
        method: 'Post',
        data: commentId,
        success: function (response) {
            alert(response.data.message);
            GetComment(ProductId);
        }
    })
}

var Reply = function (id) {
    $(`#repCmt${id}`).empty();
    $('#formRep').hide();
    $(`#repCmt${id}`).append(`
                        <h4>Phản hồi</h4>
                        <form>
                            <input hidden id="SaveRepId" value="0">
                            <input hidden id="CommentRepId" value="${id}">
                            <textarea style="width:100%;" id="textRep" placeholder="Phản hồi..."></textarea>
                            <a class="btn btn-primary" value="Phản hồi" onclick="PostRep()">Bình Luận</a>
                            <a style="color: #838383;font-size: 14px; font-weight: 600;" onclick="Back(${id})">Hủy</a>
                        </form>
                `);
}
var Back = function (id) {
    $(`#repCmt${id}`).empty();
    $('#formRep').show();
}

product.sameCategory = function (id) {
    $.ajax({
        url: `/GetAll/Gets6ProductsameCategory/${id}`,
        method: 'Get',
        data: id,
        success: function (response) {
            var tam = '';
            $.each(response.result, function (i, v) {
                tam += `<div class="blog-grids row mb-3">
                        <div class="col-md-5 blog-grid-left">
                            <a href="/ui/details/${v.id}">
                                <img src="/images/${v.image}" class="img-fluid" alt="">
                            </a>
                        </div>
                        <div class="col-md-7 blog-grid-right">

                            <h5>
                                <a href="single.html">${v.productName} </a>
                            </h5>
                            <div class="sub-meta">
                                <span>
                                    <i class="far fa-clock"></i> ${v.dateofSale.slice(0,-9)}
                                </span><span>
                                    <i class="far fa-star"></i> ${v.numberofVote}
                                    <i class="far fa-comment"></i> ${v.numberofComment}
                                </span>
                            </div>
                        </div>

                    </div>`;
            });
            $('#sameCategory').append(`
                                <aside class="agileits-w3ls-right-blog-con text-left">
                                    <div class="tech-btm">
                                        <h4>Same Category</h4>
                                            ${tam}
                                    </div>

                                </aside>
                            `);
        }
    });
}
product.sameBrand = function (id) {
    $.ajax({
        url: `/GetAll/Gets6ProductsameBrand/${id}`,
        method: 'Get',
        success: function (response) {
            var tam = '';
            $.each(response.result, function (i, v) {
                tam += `<div class="blog-grids row mb-3">
                        <div class="col-md-5 blog-grid-left">
                            <a href="/ui/details/${v.id}">
                                <img src="/images/${v.image}" class="img-fluid" alt="">
                            </a>
                        </div>
                        <div class="col-md-7 blog-grid-right">

                            <h5>
                                <a href="single.html">${v.productName} </a>
                            </h5>
                            <div class="sub-meta">
                                <span>
                                    <i class="far fa-clock"></i> ${v.dateofSale.slice(0,-9)}
                                </span><span>
                                    <i class="far fa-star"></i> ${v.numberofVote}
                                    <i class="far fa-comment"></i> ${v.numberofComment}
                                </span>
                            </div>
                        </div>

                    </div>`;
            });
            $('#sameBrand').append(`
                                <aside class="agileits-w3ls-right-blog-con text-left">
                                    <div class="tech-btm">
                                        <h4>Same Brand</h4>
                                            ${tam}
                                    </div>

                                </aside>
                            `);
        }
    });
}
var product = {} || product;
$(document).ready(function () {
    product.sapramat();
    product.sapramat1();
    product.blogger();
    product.topbinhluan();
    product.top5binhluan();
    product.top5vote();
    product.topvote();
    product.get5expensive();
    $("#flexiselDemo1").flexisel({
        visibleItems: 3,
        animationSpeed: 1000,
        autoPlay: true,
        autoPlaySpeed: 3000,
        pauseOnHover: true,
        enableResponsiveBreakpoints: true,
        responsiveBreakpoints: {
            portrait: {
                changePoint: 480,
                visibleItems: 1
            },
            landscape: {
                changePoint: 640,
                visibleItems: 2
            },
            tablet: {
                changePoint: 768,
                visibleItems: 3
            }
        }
    });
    $("#flexiselDemo2").flexisel({
        visibleItems: 3,
        animationSpeed: 1000,
        autoPlay: true,
        autoPlaySpeed: 3000,
        pauseOnHover: true,
        enableResponsiveBreakpoints: true,
        responsiveBreakpoints: {
            portrait: {
                changePoint: 480,
                visibleItems: 1
            },
            landscape: {
                changePoint: 640,
                visibleItems: 2
            },
            tablet: {
                changePoint: 768,
                visibleItems: 3
            }
        }
    });
    $("#flexiselDemo3").flexisel({
        visibleItems: 3,
        animationSpeed: 1000,
        autoPlay: true,
        autoPlaySpeed: 3000,
        pauseOnHover: true,
        enableResponsiveBreakpoints: true,
        responsiveBreakpoints: {
            portrait: {
                changePoint: 480,
                visibleItems: 1
            },
            landscape: {
                changePoint: 640,
                visibleItems: 2
            },
            tablet: {
                changePoint: 768,
                visibleItems: 3
            }
        }
    });
});
product.blogger = function () {
        $.ajax({
            url: `/getAll/Gets5Productrandom`,
            method: 'Get',
            dataType: 'JSON',
            success: function (response) {
                var tam = '';
                $.each(response.result, function (i, v) {
                    tam +=`
                        <li>
                            <div class="blog-item" style="height:300px;">
                                <img src="images/${v.image}" alt="" class="img-fluid" style="height:300px;"/>
                                <button type="button" class="btn btn-primary play" data-toggle="modal" data-target="#exampleModal">
                                    <i class="fas fa-play"></i>
                                </button>

                                <a href="/ui/details/${v.id}"><div class="floods-text">
                                    <h3>
                                        <div style="width: 500px;
    overflow: hidden;
    white-space: nowrap;
    text-overflow: ellipsis;">${v.productName}</div>
                                        <span>
                                            ${new Intl.NumberFormat('de-DE').format(v.price)} VND
                                            <label>|</label>
                                            <i><i class="far fa-calendar-alt"></i> ${v.dateofSale.slice(0, -9)} | <i class="fas fa-star"></i> ${v.numberofVote} | <i class="far fa-comment"></i> ${v.numberofComment}</i>
                                        </span>
                                    </h3>

                                </div></a>
                            </div>
                        </li>
                    `;
                });
                $("#addblogger").append(`
                    <ul id="flexiselDemo1">
                        ${tam}
                    </ul>
                    `);
            },
            error: function () {
                alert(response.result.message);
            }
        });
}
product.topbinhluan = function () {
    $.ajax({
        url: `/getAll/Gets1ProductComment`,
        method: 'Get',
        dataType: 'JSON',
        success: function (response) {
                $("#topbinhluan").append(`
                    <div class="b-grid-top">
                        <div class="blog_info_left_grid">
                            <a href="ui/details/${response.result.id}">
                                <img src="images/${response.result.image}" class="img-fluid" alt="">
                            </a>
                        </div>
                        <div class="blog-info-middle">
                            <ul>
                                <li>
                                    <a href="#">
                                        <i class="far fa-calendar-alt"></i> ${response.result.dateofSale}
                                    </a>
                                </li>
                                <li class="mx-2">
                                    <a href="#">
                                        <i class="fas fa-star"></i> ${response.result.numberofVote}
                                    </a>
                                </li>
                                <li>
                                    <a href="#">
                                        <i class="far fa-comment"></i> ${response.result.numberofComment}
                                    </a>
                                </li>

                            </ul>
                        </div>
                    </div>

                    <h3>
                        <a href="ui/details/${response.result.id}">${response.result.productName} </a>
                    </h3>
                    <p>
                        Lorem ipsum dolor sit amet consectetur adipisicing elit sedc dnmo eiusmod tempor incididunt ut labore et dolore magna
                        aliqua uta enim ad minim ven iam quis nostrud exercitation ullamco labor nisi ut aliquip exea commodo consequat duis
                        aute irudre dolor in elit sed uta labore dolore reprehender
                    </p>
                    <a href="/ui/details/${response.result.id}" class="btn btn-primary read-m">Read More</a>
                    `);
            
        },
        error: function () {
            alert(response.result.message);
        }
    });
}
product.top5binhluan = function () {
    $.ajax({
        url: `/getAll/Gets5ProductComment`,
        method: 'Get',
        dataType: 'JSON',
        success: function (response) {
            var tam = '';
            $.each(response.result, function (i, v) {
                tam += `
                        <li>
                            <div class="blog-item">
                                <img src="images/${v.image}" alt=" " class="img-fluid" style="height:150px;"/>
                                <button type="button" class="btn btn-primary play sec" data-toggle="modal" data-target="#exampleModal">
                                    <i class="fas fa-play"></i>
                                </button>
<a href="/ui/details/${v.id}">
                                <div class="floods-text">
                                    <div style="width: 200px;
    overflow: hidden;
    white-space: nowrap;
    text-overflow: ellipsis;"><h3>${v.productName}</h3></dic>
                                    <i class="far fa-comment"></i> ${v.numberofComment}
                                    <i class="fas fa-star"></i> ${v.numberofVote}
                                </div>
</a>
                            </div>
                        </li>
                    `;
            });
            $("#top5binhluan").append(`
                    <ul id="flexiselDemo3">
                        ${tam}
                    </ul>
                    `);
        },
        error: function () {
            alert(response.result.message);
        }
    });
}
product.topvote = function () {
    $.ajax({
        url: `/getAll/Gets1ProductVote`,
        method: 'Get',
        dataType: 'JSON',
        success: function (response) {
            $("#topvote").append(`
                    <div class="b-grid-top">
                        <div class="blog_info_left_grid">
                            <a href="ui/details/${response.result.id}">
                                <img src="images/${response.result.image}" class="img-fluid" alt="">
                            </a>
                        </div>
                        <div class="blog-info-middle">
                            <ul>
                                <li>
                                    <a href="#">
                                        <i class="far fa-calendar-alt"></i> ${response.result.dateofSale}
                                    </a>
                                </li>
                                <li class="mx-2">
                                    <a href="#">
                                        <i class="fas fa-star"></i> ${response.result.numberofVote}
                                    </a>
                                </li>
                                <li>
                                    <a href="#">
                                        <i class="far fa-comment"></i> ${response.result.numberofComment}
                                    </a>
                                </li>

                            </ul>
                        </div>
                    </div>

                    <h3>
                        <a href="ui/details/${response.result.id}">${response.result.productName} </a>
                    </h3>
                    <p>
                        Lorem ipsum dolor sit amet consectetur adipisicing elit sedc dnmo eiusmod tempor incididunt ut labore et dolore magna
                        aliqua uta enim ad minim ven iam quis nostrud exercitation ullamco labor nisi ut aliquip exea commodo consequat duis
                        aute irudre dolor in elit sed uta labore dolore reprehender
                    </p>
                    <a href="/ui/details/${response.result.id}" class="btn btn-primary read-m">Read More</a>
                    `);

        },
        error: function () {
            alert(response.result.message);
        }
    });
}
product.top5vote = function () {
    $.ajax({
        url: `/getAll/Gets5ProductVote`,
        method: 'Get',
        dataType: 'JSON',
        success: function (response) {
            var tam = '';
            $.each(response.result, function (i, v) {
                tam += `<li>
                            <div class="blog-item">
                                <img src="images/${v.image}" alt=" " class="img-fluid" style="height:150px;"/>
                                <button type="button" class="btn btn-primary play" data-toggle="modal" data-target="#exampleModal">
                                    <i class="fas fa-play"></i>
                                </button>
<a href="/ui/details/${v.id}">
                                <div class="floods-text">
                                    <div style="width: 200px;
    overflow: hidden;
    white-space: nowrap;
    text-overflow: ellipsis;"><h3>${v.productName}</h3></div>
                                    <i class="far fa-comment"></i> ${v.numberofComment}
                                    <i class="fas fa-star"></i> ${v.numberofVote}

                                </div></a>
                            </div>
                        </li>
                    `;
            });
            $("#top5vote").append(`
                    <ul id="flexiselDemo2">
                        ${tam}
                    </ul>
                    `);
        },
        error: function () {
            alert(response.result.message);
        }
    });
}
product.sapramat = function () {
    $.ajax({
        url: `/getAll/Gets5ProductCommingsoon`,
        method: 'Get',
        dataType: 'JSON',
        success: function (response) {
            var tam = 1;
            $.each(response.result, function (i, v) {
                $(`#link${tam}`).attr('href', `images/${v.image}`);
                $(`#image${tam}`).attr('src', `images/${v.image}`);
                $(`#image${tam}`).attr('data-desoslide-caption', `<h3>${v.productName}</h3>`);
                document.getElementById(`h4${tam}`).innerHTML = v.productName;
                document.getElementById(`p${tam}`).innerHTML = v.trangThai;
                document.getElementById(`i${tam}`).innerHTML = v.dateofSale.slice(0,-9);
                tam++;
            });
        },
        error: function () {
            alert(response.result.message);
        }
    });
}
product.sapramat1 = function () {
    $.ajax({
        url: `/getAll/GetProductCommingFirst`,
        method: 'Get',
        dataType: 'JSON',
        success: function (response) {
            $("#sapramat1").append(`
                    <div class="b-grid-top">
                        <div class="blog_info_left_grid">
                            <a href="ui/details/${response.result.id}">
                                <img src="images/${response.result.image}" class="img-fluid" alt="">
                            </a>
                        </div>
                        <div class="blog-info-middle">
                            <ul>
                                <li>
                                    <a href="#">
                                        <i class="far fa-calendar-alt"></i> ${response.result.dateofSale}
                                    </a>
                                </li>
                                <li class="mx-2">
                                    <a href="#">
                                        <i class="fas fa-star"></i> ${response.result.numberofVote}
                                    </a>
                                </li>
                                <li>
                                    <a href="#">
                                        <i class="far fa-comment"></i> ${response.result.numberofComment}
                                    </a>
                                </li>

                            </ul>
                        </div>
                    </div>

                    <h3>
                        <a href="ui/details/${response.result.id}">${response.result.productName} </a>
                    </h3>
                    <p>
                        Lorem ipsum dolor sit amet consectetur adipisicing elit sedc dnmo eiusmod tempor incididunt ut labore et dolore magna
                        aliqua uta enim ad minim ven iam quis nostrud exercitation ullamco labor nisi ut aliquip exea commodo consequat duis
                        aute irudre dolor in elit sed uta labore dolore reprehender
                    </p>
                    <a href="#" class="btn btn-primary read-m">Read More</a>
                    `);

        },
        error: function () {
            alert(response.result.message);
        }
    });
}

product.get5expensive = function () {
    $.ajax({
        url: `/getAll/Gets5GetsExpensive`,
        method: 'Get',
        dataType: 'JSON',
        success: function (response) {
            var tam = '';
            $.each(response.result, function (i, v) {
                tam += `<div class="blog-grids row mb-3">
                        <div class="col-md-5 blog-grid-left">
                            <a href="ui/details/${v.id}">
                                <img src="/images/${v.image}" class="img-fluid" alt="">
                            </a>
                        </div>
                        <div class="col-md-7 blog-grid-right">

                            <h5>
                                <a href="single.html">${v.productName} </a>
                            </h5>
                            <div class="sub-meta">
                                <br>
                                <h5>${new Intl.NumberFormat('de-DE').format(v.price)} VND</h5>
                                <span>
                                    <i class="far fa-clock"></i> ${v.dateofSale.slice(0, -9)}
                                </span><span>
                                    <i class="far fa-star"></i> ${v.numberofVote}
                                    <i class="far fa-comment"></i> ${v.numberofComment}
                                </span>
                            </div>
                        </div>

                    </div>`;
            });
            $('#topexpensive').append(`
                                <aside class="agileits-w3ls-right-blog-con text-left">
                                    <div class="tech-btm">
                                        <h4>Most Expensive</h4>
                                            ${tam}
                                    </div>

                                </aside>
                            `);

        },
        error: function () {
            alert(response.result.message);
        }
    });
}
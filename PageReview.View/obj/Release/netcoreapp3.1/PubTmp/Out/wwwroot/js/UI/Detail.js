var product = {} || product;
$(document).ready(function () {
});
product.phanloai = function () {
    $("#phanloai").append(`
            <aside class="col-lg-4 agileits-w3ls-right-blog-con text-right">
                <div class="right-blog-info text-left">
                    <div class="tech-btm">
                        <img src="/UI/images/banner1.jpg" class="img-fluid" alt="">
                    </div>
                    <div class="tech-btm">
                        <h4>Sign up to our newsletter</h4>
                        <p>Pellentesque dui, non felis. Maecenas male </p>
                        <form action="#" method="post">
                            <input type="email" placeholder="Email" required="">
                            <input type="submit" value="Subscribe">
                        </form>

                    </div>
                    <div class="tech-btm widget_social">
                        <h4>Stay Connect</h4>
                        <ul>

                            <li>
                                <a class="twitter" href="#">
                                    <i class="fab fa-twitter"></i>
                                    <span class="count">317K</span> Twitter Followers
                                </a>
                            </li>
                            <li>
                                <a class="facebook" href="#">
                                    <i class="fab fa-facebook-f"></i>
                                    <span class="count">218k</span> Twitter Followers
                                </a>
                            </li>
                            <li>
                                <a class="dribble" href="#">
                                    <i class="fab fa-dribbble"></i>

                                    <span class="count">215k</span> Dribble Followers
                                </a>
                            </li>
                            <li>
                                <a class="pin" href="#">
                                    <i class="fab fa-pinterest"></i>
                                    <span class="count">190k</span> Pinterest Followers
                                </a>
                            </li>

                        </ul>
                    </div>
                    <div class="tech-btm">
                        <h4>Recent Posts</h4>

                        <div class="content-item">
                            <ul class="filter-list unstyled">
                                <li class="filter-item">
                                    <a href="/UI/GetsByPrice/1">
                                        <i class="span1"></i>
                                        <div>Nhỏ hơn 500K </div>
                                    </a>
                                </li>
                                <li class="filter-item">
                                    <a href="/UI/GetsByPrice/2">
                                        <i class="span1"></i>
                                        <div>500K - 1 triệu </div>
                                    </a>
                                </li>
                                <li class="filter-item">
                                    <a href="/UI/GetsByPrice/3">
                                        <i class="span1"></i>
                                        <div>1 triệu - 3 triệu </div>
                                    </a>
                                </li>
                                <li class="filter-item">
                                    <a href="/UI/GetsByPrice/4">
                                        <i class="span1"></i>
                                        <div>3 triệu - 10 triệu</div>
                                    </a>
                                </li>
                                <li class="filter-item">
                                    <a href="/UI/GetsByPrice/5">
                                        <i class="span1"></i>
                                        <div>Lớn hơn 10 triệu</div>
                                    </a>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class="item">
                        <h4>Đánh giá</h4>
                        <div class="content-item">
                            <a class="rating-content" href="/UI/GetsbyVote/1">
                                <div class="rating-box-tn">
                                    <span style="color:gold;" class="fa fa-star"></span>
                                    <span id="2" class="fa fa-star "></span>
                                    <span id="3" class="fa fa-star"></span>
                                    <span id="4" class="fa fa-star"></span>
                                    <span id="5" class="fa fa-star"></span>
                                </div>
                                <span>1 - 2 sao</span>
                            </a>
                            <a class="rating-content" href="/UI/GetsbyVote/2">
                                <div class="rating-box-tn">
                                    <span style="color: gold;" class="fa fa-star"></span>
                                    <span style="color: gold;" class="fa fa-star"></span>
                                    <span id="3" class="fa fa-star"></span>
                                    <span id="4" class="fa fa-star"></span>
                                    <span id="5" class="fa fa-star"></span>
                                </div>
                                <span>2 - 3 sao</span>
                            </a>
                            <a class="rating-content" href="/UI/GetsbyVote/3">
                                <div class="rating-box-tn">
                                    <span style="color: gold;" class="fa fa-star"></span>
                                    <span style="color: gold;" class="fa fa-star"></span>
                                    <span style="color: gold;" class="fa fa-star"></span>
                                    <span id="4" class="fa fa-star"></span>
                                    <span id="5" class="fa fa-star"></span>
                                </div>
                                <span>3 - 4 sao</span>
                            </a>
                            <a class="rating-content" href="/UI/GetsbyVote/4">
                                <div class="rating-box-tn">
                                    <span style="color: gold;" class="fa fa-star"></span>
                                    <span style="color: gold;" class="fa fa-star"></span>
                                    <span style="color: gold;" class="fa fa-star"></span>
                                    <span style="color: gold;" class="fa fa-star"></span>
                                    <span id="5" class="fa fa-star"></span>
                                </div>
                                <span>4 - 5 sao</span>
                            </a>
                            <a class="rating-content" href="/UI/GetsbyVote/5">
                                <div class="rating-box-tn">
                                    <span style="color: gold;" class="fa fa-star"></span>
                                    <span style="color: gold;" class="fa fa-star"></span>
                                    <span style="color: gold;" class="fa fa-star"></span>
                                    <span style="color: gold;" class="fa fa-star"></span>
                                    <span style="color: gold;" class="fa fa-star"></span>
                                </div>
                                <span>5 sao</span>
                            </a>
                        </div>
                    </div>
                    <br />
                    <br />
                    <div class="item">
                        <h3>Nhận xét</h3>
                        <div class="content-item comment-content">
                            <div><a href="/UI/GetsbyComment/1">0 - 10 nhận xét</a></div>
                            <div><a href="/UI/GetsbyComment/2">10 - 25 nhận xét</a></div>
                            <div><a href="/UI/GetsbyComment/3">25 - 40 nhận xét</a></div>
                            <div><a href="/UI/GetsbyComment/4">40 nhận xét trở nên</a></div>
                        </div>
                    </div>
                </div>

            </aside>
                    `);
}
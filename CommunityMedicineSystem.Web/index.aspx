<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CommunityMedicineSystem.Web.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>HomePage - Community Medicine System</title>
    <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css' />

    <%--<link href="assets/css/bootstrap.css" rel="stylesheet" />--%>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="assets/css/font-awesome.min.css" rel="stylesheet" />

    <link href="assets/css/style-slide.css" rel="stylesheet" />
    <link href="assets/css/custom.css" rel="stylesheet" />

    <link href="assets/css/style.css" rel="stylesheet" />
</head>

<body>
    <form id="form1" runat="server">

        <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <%--<a class="navbar-brand" href="#">COMMUNITY MEDICINE</a>--%>
                    <img class="img-circle" src="assets/img/team/logo.png" alt="">
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav navbar-right">
                        <li><a href="#">Home</a></li>
                        <li><a href="./HeadOffice/HeadOfficeMainUI.aspx">Head Office</a></li>
                        <li><a href="./Center/CenterLoginUI.aspx">Center</a></li>
                    </ul>
                </div>

            </div>
        </div>


        <div class="container" id="header-section">
            <div class="row centered">
                <div class="demo-1">

                    <div id="slider" class="sl-slider-wrapper">

                        <div class="sl-slider">

                            <div class="sl-slide bg-1" data-orientation="horizontal" data-slice1-rotation="-25" data-slice2-rotation="-25" data-slice1-scale="2" data-slice2-scale="2">
                                <div class="sl-slide-inner">
                                    <div class="deco" data-icon="H"></div>
                                    <h2 class="color-white">Health</h2>
                                    <br />
                                </div>
                            </div>

                            <div class="sl-slide bg-5" data-orientation="vertical" data-slice1-rotation="10" data-slice2-rotation="-15" data-slice1-scale="1.5" data-slice2-scale="1.5">
                                <div class="sl-slide-inner">
                                    <div class="deco" data-icon="P"></div>
                                    <h2>Prescription</h2>
                                    <br />
                                </div>
                            </div>

                            <div class="sl-slide bg-3" data-orientation="horizontal" data-slice1-rotation="3" data-slice2-rotation="3" data-slice1-scale="2" data-slice2-scale="1">
                                <div class="sl-slide-inner">
                                    <div class="deco" data-icon="H"></div>
                                    <h2>Happiness</h2>
                                    <br />
                                </div>
                            </div>

                            <div class="sl-slide bg-4" data-orientation="vertical" data-slice1-rotation="-5" data-slice2-rotation="25" data-slice1-scale="2" data-slice2-scale="1">
                                <div class="sl-slide-inner">
                                    <div class="deco" data-icon="P"></div>
                                    <h2>Promise</h2>
                                    <br />
                                </div>
                            </div>

                        </div>


                        <nav id="nav-arrows" class="nav-arrows">
                            <span class="nav-arrow-prev">Previous</span>
                            <span class="nav-arrow-next">Next</span>
                        </nav>

                        <nav id="nav-dots" class="nav-dots">
                            <span class="nav-dot-current"></span>
                            <span></span>
                            <span></span>
                            <span></span>
                        </nav>

                    </div>

                </div>
            </div>
        </div>



        <div id="space">
        </div>

        <div class="text-center" id="social">

            <a href="#"><i class="fa fa-facebook-square fa-3x color-facebook"></i></a>
            <a href="#"><i class="fa fa-twitter-square fa-3x color-twitter"></i></a>
            <a href="#"><i class="fa fa-google-plus-square fa-3x color-google-plus"></i></a>
            <a href="#"><i class="fa fa-linkedin-square fa-3x color-linkedin"></i></a>
            <a href="#"><i class="fa fa-pinterest-square fa-3x color-pinterest"></i></a>

        </div>

        <div id="footer">
            <div class="container">
                <div class="row ">
                    &copy; 2015 Team Engine Box | All Right Reserved
                </div>
            </div>
        </div>

        <script src="assets/js/jquery.js"></script>
        <%--<script src="assets/js/bootstrap.min.js"></script>--%>
        <script src="Scripts/bootstrap.min.js"></script>
        <script src="assets/js/modernizr.custom.79639.js"></script>
        <script src="assets/js/jquery.ba-cond.min.js"></script>
        <script src="assets/js/jquery.slitslider.js"></script>
        <script src="assets/js/custom.js"></script>

    </form>
</body>

</html>


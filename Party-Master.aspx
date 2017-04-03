<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Party-Master.aspx.cs" Inherits="Party_Master" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
        <title>Piple - Admin</title>

        <!-- Bootstrap -->
        <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet">
        <link href="css/waves.min.css" type="text/css" rel="stylesheet">
        <link href="css/select.css" type="text/css" rel="stylesheet">
        <link rel="stylesheet" href="css/bootstrap-slider.min.css">
        <link href="css/bootstrap-switch.min.css" type="text/css" rel="stylesheet">
        <link href="css/menu.css" type="text/css" rel="stylesheet">
        <link href="css/style.css" type="text/css" rel="stylesheet">
        <link href="font-awesome/css/font-awesome.min.css" rel="stylesheet">
        <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
        <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
        <!--[if lt IE 9]>
          <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
          <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
        <![endif]-->
       
    </head>
    
    <form id="Form1" runat="server">
    <body>
        <!-- Static navbar -->

        <nav class="navbar navbar-inverse yamm navbar-fixed-top">
            <div class="container-fluid">
                <button type="button" class="navbar-minimalize minimalize-styl-2  pull-left "><i class="fa fa-bars"></i></button>
                <span class="search-icon"><i class="fa fa-search"></i></span>
                <div class="search" style="display: none;">
                    <form role="form">
                        <input type="text" class="form-control" autocomplete="off" placeholder="Write something and press enter">
                        <span class="search-close"><i class="fa fa-times"></i></span>
                    </form>
                </div>
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="#">Piple</a>
                </div>
                <div id="navbar" class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle button-wave" data-toggle="dropdown" aria-expanded="true">Mega Menu<span class="caret"></span></a>
                            <ul class="dropdown-menu mega-dropdown-menu" style="width: 900px;">
                                <li>
                                    <div class="yamm-content">
                                        <div class="row ">
                                            <div class="col-sm-3 ">

                                                <h3 class="yamm-category">Layout</h3>
                                                <ul class="list-unstyled ">
                                                    <li><a href="">Admin style 1</a></li>
                                                    <li><a href="">Admin style 2</a></li>
                                                    <li><a href="">Admin style 3</a></li>
                                                    <li><a href="">Admin style 4</a></li>   
                                                </ul>


                                            </div>
                                            <div class="col-sm-3">

                                                <h3 class="yamm-category">Ui Kit</h3>
                                                <ul class="list-unstyled ">
                                                    <li><a href="">Typography</a></li>
                                                    <li><a href="">Buttons</a></li>
                                                    <li><a href="">Font Awesome</a></li>
                                                    <li><a href="">Tabs & Alerts</a></li>
                                                </ul>


                                            </div>
                                            <div class="col-sm-3">

                                                <h3 class="yamm-category">Analytics</h3>
                                                <ul class="list-unstyled ">
                                                    <li><a href="">Flot</a></li>
                                                    <li><a href="">Sparklines</a></li>
                                                    <li><a href="">Morris</a></li>
                                                    <li><a href="">Chart Js</a></li>
                                                </ul>


                                            </div>
                                            <div class="col-sm-3">
                                                <h3 class="yamm-category">Architecto</h3>
                                                <p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium. totam rem aperiam eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.</p>
                                            </div>
                                        </div>
                                    </div>
                                </li>
                            </ul>
                        </li>
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle button-wave" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Dropdown <span class="caret"></span></a>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li role="separator" class="divider"></li>
                                <li class="dropdown-header">Nav header</li>
                                <li><a href="#">Separated link</a></li>
                                <li><a href="#">One more separated link</a></li>
                            </ul>
                        </li>
                    </ul>

                    <ul class="nav navbar-nav navbar-right navbar-top-drops">
                        <li class="dropdown"><a href="#" class="dropdown-toggle button-wave" data-toggle="dropdown"><i class="fa fa-envelope"></i> <span class="badge badge-xs badge-info">6</span></a>

                            <ul class="dropdown-menu dropdown-lg">
                                <li class="notify-title">
                                    3 New messages 
                                </li>
                                <li class="clearfix">
                                    <a href="#">
                                        <span class="pull-left">
                                            <img src="images/avtar-1.jpg" alt="" class="img-circle" width="30">
                                        </span>
                                        <span class="block">
                                            John Doe
                                        </span>
                                        <span class="media-body">
                                            Lorem ipsum dolor sit amet
                                            <em>28 minutes ago</em>
                                        </span>
                                    </a>
                                </li>
                                <li class="clearfix">
                                    <a href="#">
                                        <span class="pull-left">
                                            <img src="images/avtar-2.jpg" alt="" class="img-circle" width="30">
                                        </span>
                                        <span class="block">
                                            John Doe
                                        </span>
                                        <span class="media-body">
                                            Lorem ipsum dolor sit amet
                                            <em>28 minutes ago</em>
                                        </span>
                                    </a>
                                </li>
                                <li class="clearfix">
                                    <a href="#">
                                        <span class="pull-left">
                                            <img src="images/avtar-3.jpg" alt="" class="img-circle" width="30">
                                        </span>
                                        <span class="block">
                                            John Doe
                                        </span>
                                        <span class="media-body">
                                            Lorem ipsum dolor sit amet
                                            <em>28 minutes ago</em>
                                        </span>
                                    </a>
                                </li>
                                <li class="read-more"><a href="#">View All Messages <i class="fa fa-angle-right"></i></a></li>
                            </ul>
                        </li>
                        <li class="dropdown"><a href="#" class="dropdown-toggle button-wave" data-toggle="dropdown"><i class="fa fa-bell"></i> <span class="badge badge-xs badge-warning">6</span></a>

                            <ul class="dropdown-menu dropdown-lg">
                                <li class="notify-title">
                                    3 New messages 
                                </li>
                                <li class="clearfix">
                                    <a href="#">
                                        <span class="pull-left">
                                            <i class="fa fa-envelope"></i>
                                        </span>

                                        <span class="media-body">
                                            15 New Messages
                                            <em>20 Minutes ago</em>
                                        </span>
                                    </a>
                                </li>
                                <li class="clearfix">
                                    <a href="#">
                                        <span class="pull-left">
                                            <i class="fa fa-twitter"></i>
                                        </span>

                                        <span class="media-body">
                                            13 New Followers
                                            <em>2 hours ago</em>
                                        </span>
                                    </a>
                                </li>
                                <li class="clearfix">
                                    <a href="#">
                                        <span class="pull-left">
                                            <i class="fa fa-download"></i>
                                        </span>

                                        <span class="media-body">
                                            Download complete
                                            <em>2 hours ago</em>
                                        </span>
                                    </a>
                                </li>
                                <li class="read-more"><a href="#">View All Alerts <i class="fa fa-angle-right"></i></a></li>
                            </ul>
                        </li>
                        <li class="dropdown profile-dropdown">
                            <a href="#" class="dropdown-toggle button-wave" data-toggle="dropdown" role="button" ><img src="images/avtar-2.jpg" alt="" width="25">John Doe</a>
                            <ul class="dropdown-menu">
                                <li><a href="#"><i class="fa fa-user"></i>My Profile</a></li>
                                <li><a href="#"><i class="fa fa-calendar"></i>My Calendar</a></li>                         
                                <li><a href="#"><i class="fa fa-envelope"></i>My Inbox</a></li>
                                <li><a href="#"><i class="fa fa-barcode"></i>My Task</a></li>
                                <li class="divider"></li>
                                <li><a href="#"><i class="fa fa-lock"></i>Screen lock</a></li>
                                <li><a href="#"><i class="fa fa-key"></i>Logout</a></li>
                            </ul>
                        </li>
                    </ul>
                </div><!--/.nav-collapse -->
            </div><!--/.container-fluid -->
        </nav>
        <section class="page">

         <nav class="navbar-aside navbar-static-side" role="navigation">
                <div class="sidebar-collapse nano">
                    <div class="nano-content">
                        <ul class="nav metismenu" id="side-menu">

                            <li>
                                <a href="#"><i class="fa fa-th-large"></i> <span class="nav-label">Dashboard </span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                    <li><a href="DashBoard.aspx">Dashboard </a></li>
                                    
                                    
                                    
                                </ul>
                            </li>
                            <li>
                                <a href="#"><i class="fa fa-cog fa-2x" aria-hidden="true"></i> <span class="nav-label">Admin Setup </span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                     <li>
                                <a href="#"><i class="fa fa-spinner" aria-hidden="true"></i> &nbsp;&nbsp;<span class="nav-label">General Masters </span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                    <li><a href="General-Masters.aspx">  General Masters Details</a></li>
                                    <li><a href="Delivery-Chellan-New.aspx"> Delivery Chellan New</a></li>
                                  
                                </ul>
                            </li>
                                   
                                             <li>
                                <a href="#"> <i class="fa fa-spinner" aria-hidden="true"></i> &nbsp;&nbsp;<span class="nav-label">Company Set Up</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                    <li><a href="Company.aspx"> Company</a></li>
                                    <li><a href="Location.aspx"> Location</a></li>
                                     <li><a href="Dimensions.aspx"> Dimension</a></li>
                                    <li><a href="Business-Segment.aspx"> Business Segment</a></li>
                                  
                                  
                                </ul>
                            </li>
                                </ul>
                            </li>
                            <li class="active">
                                <a href="#"><i class="fa fa-clipboard fa-2x" aria-hidden="true"></i> <span class="nav-label">Masters</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                    <li><a href="Shade-No-Master.aspx">Shade No.Master</a></li>
                                    <li><a href="Shade-Master.aspx">Shade Master</a></li>
                                    <li><a href="Item-Master.aspx">Item Master</a></li>
                                    <li><a href="Party-Master.aspx">Party Master</a></li>
                                    <li><a href="Party-Wise Rate.aspx">Partywise Rate</a></li>
                                    <li><a href="Cone-Type-Master.aspx">Cone Type Master</a></li>
                                     <li>
                                <a href="#"><i class="fa fa-line-chart" aria-hidden="true"></i> &nbsp;&nbsp; <span class="nav-label">Tax Heads</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                    <li><a href="Addition-Deduction.aspx">Addition Deduction</a></li>
                                    <li><a href="Addition-Deduction-Type.aspx">Addition Deduction Type</a></li>
                                  
                                </ul>
                            </li>
                                </ul>
                            </li>

                            <li>
                                                <a href="#"><i class="fa fa-shopping-cart fa-2x" aria-hidden="true"></i> <span class="nav-label">Purchase</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                                          <li>
                                <a href="#"><i class="fa fa-exchange" aria-hidden="true"></i> <span class="nav-label">Transactions</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                    <li><a href="Pur-Price-Cnfm.aspx">Purchase Price conformation</a></li>
                                    <li><a href="Order-Indent-Precot.aspx">Order Indent - Precot</a></li>
                                    <li><a href="Purchase-Oreder-Other.aspx">Purchase Order - Other</a></li>
                                    <li><a href="Goods-Received-Precot.aspx">Goods Received - Precot</a></li>
                                    <li><a href="Goods-Received-Note-Other.aspx">Goods Received Note - Other </a></li>
                                <li><a href="Purchase-Invoice.aspx">Purchase Invoice</a></li>
                                    <li><a href="Mismatched-Invoice-Close.aspx">Mismatched Invoice Closed</a></li>
                                    <li><a href="Indenet-ShortClose-Entry.aspx">Intent Short Close Entry</a></li>
                                    <li><a href="Goods-Return.aspx">Goods Return</a></li>
                                    <li><a href="Mill-Urgent-E-mail.aspx">Mill-Urgent E-Mail</a></li>
                                    <li><a href="Mill-Pending-XL-Import.aspx">Mill Pending XL Import</a></li>
                                     <li><a href="Mill-Indent-Conformation-Entry.aspx">Mill Indent Confirmation Entry</a></li>
                                  

                                </ul>
                            </li>
                                            <li>
                                <a href="#"><i class="fa fa-files-o"></i>  <span class="nav-label">Report</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                    <li><a href="Order-Indent-Report.aspx">Order Indent Report</a></li>
                                    <li><a href="Stock-and-Mill-Indent-Pending.aspx">Stock and Mill Indent Pending</a></li>
                                    <li><a href="Mill-Indent-Pending-Halfwise-Report.aspx">Mill Indent Pending Halfwise</a></li>
                                    <li><a href="Mill-Indent-Pending-Overall.aspx">Mill Indent Pending Overal</a></li>
                                    <li><a href="Purchase-Report.aspx">Purchase Report</a></li>
                                    <li><a href="Purchase-Registor-PartyWise-Report.aspx">Purchase Registor Partywise Report</a></li>
                                     <li><a href="Goods-Received-Registor-Precot.aspx">Goods Received Registor-Precot</a></li>
                                     <li><a href="Purchase-Registor-Report.aspx">Purchase Registor</a></li>
                                     <li><a href="Mismatch-Mill-Pending-Report.aspx">Mismatch Mill Pending</a></li>
                                     <li><a href="Goods-Received-Summary-Report.aspx">Goods Received Summary</a></li>
                                     <li><a href="Mismatch-Mill-Indent-Report.aspx">Mismatch Mill Indent Report</a></li>
                                     <li><a href="Mill-Urgent-Pending-and-Nill-Stock-List.aspx">Mill Urgent Pending and Nill Stk List</a></li>
                                     <li><a href="Excess-Goods-Arrival-Report.aspx">Excess Goods Arrival Report</a></li>

                                </ul>
                            </li>
                                </ul>
                            </li>
                            <li>
                                <a href="#"><i class="fa fa-files-o"></i> <span class="nav-label">Other Pages</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                    <li><a href="lockscreen.html">Lockscreen</a></li>
                                    <li><a href="login.html">Login</a></li>
                                    <li><a href="register.html">Register</a></li>
                                    <li><a href="404.html">404 Page</a></li>
                                    <li><a href="empty_page.html">Empty page</a></li>
                                    <li><a href="gallery.html">gallery</a></li>
                                    <li><a href="price_tables.html">Price tables</a></li>
                                    <li><a href="page_contact.html">Contact Page</a></li>
                                </ul>
                            </li>
                            <li>
                                <a href="#"><i class="fa fa-shopping-cart"></i> <span class="nav-label">E-commerce</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                    <li><a href="orders.html">orders</a></li>
                                    <li><a href="order-view.html">order View</a></li>
                                    <li><a href="products.html">Products</a></li>
                                    
                                    
                                </ul>
                            </li>
                            <li>
                                <a href="#"><i class="fa fa-flask"></i> <span class="nav-label">UI Elements</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                    <li><a href="typography.html">Typography</a></li>
                                    <li><a href="icons.html">Icons</a></li>
                                    <li><a href="buttons.html">Buttons</a></li>
                                    <li><a href="video.html">Video</a></li>
                                    <li><a href="tabs_panels.html">Panels</a></li>
                                    <li><a href="tabs.html">Tabs</a></li>
                                    <li><a href="alert_notifications.html">Alert & notifications</a></li>
                                </ul>
                            </li>

                            <li>
                                <a href="grid_options.html"><i class="fa fa-laptop"></i> <span class="nav-label">Grid options</span></a>
                            </li>
                            <li>
                                <a href="#"><i class="fa fa-table"></i> <span class="nav-label">Tables</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                    <li><a href="table_basic.html">Static Tables</a></li>
                                    <li><a href="table_data_tables.html">Data Tables</a></li>
                                </ul>
                            </li>
                            <li>
                                <a href="#"><i class="fa fa-users"></i> <span class="nav-label">Users</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                    <li><a href="user_profile.html">profile</a></li>
                                    <li><a href="user_list.html">User list</a></li>
                                    
                                </ul>
                            </li>
                            <li>
                                <a href="#"><i class="fa fa-map-marker"></i> <span class="nav-label">maps</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                    <li><a href="google_maps.html">Google maps</a></li>
                                    <li><a href="vector_maps.html">Vector Maps</a></li>
                                </ul>
                            </li>
                            <li>
                                <a href="#"><i class="fa fa-pencil"></i> <span class="nav-label">Blog</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                    <li><a href="blog_list.html">Blog list</a></li>
                                    <li><a href="blog_post.html">Blog post</a></li>
                                </ul>
                            </li>
                            <li><a href="calendar.html"><i class="fa fa-calendar"></i>  <span class="nav-label">Calendar </span></a></li>
                            
                            <li>
                                <a href="#"><i class="fa fa-sitemap"></i> <span class="nav-label">Menu Levels </span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                    <li>
                                        <a href="#">Third Level <span class="fa arrow"></span></a>
                                        <ul class="nav nav-third-level">
                                            <li>
                                                <a href="#">Third Level Item</a>
                                            </li>
                                        </ul>
                                    </li>
                                    <li><a href="#">Second Level Item</a></li>
                                </ul>
                            </li>                                    
                        </ul>

                    </div>
                </div>
            </nav>

            <div id="wrapper">
                <div class="content-wrapper container">
                    <div class="row">
                        <div class="col-sm-12">
                            <div class="page-title">
                                <h1 class="gnrl">Party Master <small>Details</small></h1>
                               
                            </div>
                        </div>
                    </div><!-- end .page title-->
                 
                    <div class="row">
                        <div class="col-md-12">
                             <div class="panel panel-default recent-activites">
                                <!-- Start .panel -->
                                <div class="panel-heading">
                                    <h4 class="panel-title">Party Master</h4>
                                    <div class="panel-actions">
                                        <a href="#" class="panel-action panel-action-toggle" data-panel-toggle></a>
                                        <a href="#" class="panel-action panel-action-dismiss" data-panel-dismiss></a>
                                    </div>
                                </div>
                                <div class="panel-body">
                                     <div class="row">
                                 <div class="col-sm-6">
                                 <div class="form-group">
                                                            <div class="col-lg-4 col-md-3 control-label"> <asp:Label ID="Label1" runat="server" Text="Category"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                             <asp:DropDownList ID="DropDownList1" runat="server" class="txt"></asp:DropDownList>
                                                               
                                                              
                                                            </div>
                                                        </div>
                                  
                                  
                                 </div>

                                      <div class="col-sm-6">
                                 <div class="form-group">
                                                            <div class="col-lg-4 col-md-3 control-label"> <asp:Label ID="Label6" runat="server" Text="Address"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                            <asp:TextBox ID="TextBox1" runat="server" class="txt" TextMode="MultiLine" 
                                                                    Height="33px"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                                  
                                  
                                 </div>
                                  
                                 </div>
                                 <br />                      <div class="row">
                                 <div class="col-sm-6">
                                 <div class="form-group">
                                                            <div class="col-lg-4 col-md-3 control-label"> <asp:Label ID="Label2" runat="server" Text="Party"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                            <asp:TextBox ID="TextBox2" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                                  
                                  
                                 </div>

                                          <div class="col-sm-6">
                                 <div class="form-group">
                                                            <div class="col-lg-4 col-md-3 control-label"> <asp:Label ID="Label7" runat="server" Text="City"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                            
                                                               <asp:DropDownList ID="DropDownList2" runat="server" class="txt"></asp:DropDownList>
                                                              
                                                            </div>
                                                        </div>
                                  
                                  
                                 </div>
                                  
                                 </div>
                                                    <br />   <div class="row">
                                 <div class="col-sm-6">
                                 <div class="form-group">
                                                            <div class="col-lg-4 col-md-3 control-label"> <asp:Label ID="Label3" runat="server" Text="Salutation"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                           
                                                               <asp:TextBox ID="TextBox3" runat="server" class="txt"></asp:TextBox>
                                                              
                                                            </div>
                                                        </div>
                                  
                                  
                                 </div>
                                                                  <div class="col-sm-6">
                                 <div class="form-group">
                                                            <div class="col-lg-4 col-md-3 control-label"> <asp:Label ID="Label8" runat="server" Text="Winding Code"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                           
                                                               <asp:TextBox ID="TextBox4" runat="server" class="txt"></asp:TextBox>
                                                              
                                                            </div>
                                                        </div>
                                  
                                  
                                 </div>
                                  
                                  
                                 </div>
                                 <br />                    
                                   <div class="row">
                                 <div class="col-sm-6">
                                 <div class="form-group">
                              <div class="col-lg-4 col-md-3 control-label"> <asp:Label ID="Label4" runat="server" Text="Control Account"></asp:Label></div>
                               <div class="col-lg-8 col-md-9">
                                 <asp:DropDownList ID="DropDownList3" runat="server" class="txt"></asp:DropDownList>
                                 </div>
                                  </div>
                     
                                 </div>
                                     <div class="col-sm-6">
                                 <div class="form-group">
                                                            <div class="col-lg-4 col-md-3 control-label"> <asp:Label ID="Label9" runat="server" Text="Pin Code"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                             <asp:TextBox ID="TextBox5" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
               
                                 </div>
                                  
                                  
                                 </div>

                                  <br /> <div class="row">
                                 
                                 <div class="col-sm-6">
                                 
                                    <div class="form-group">
                                                            <div class="col-lg-4 col-md-3 control-label"> <asp:Label ID="Label5" runat="server" Text="Tin"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                             <asp:TextBox ID="TextBox6" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                                 
                                 </div>
                                 <div class="col-sm-6">
                                  <div class="form-group">
                                                            <div class="col-lg-4 col-md-3 control-label"> <asp:Label ID="Label10" runat="server" Text="State"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                            <asp:DropDownList ID="DropDownList4" runat="server" class="txt"></asp:DropDownList>
                                                               
                                                              
                                                            </div>
                                                        </div>
                                 
                                 
                                 </div>
                                 
                                 </div>
                               <br />  <div class="row">
                                 
                                 <div class="col-sm-6">
                                   <div class="form-group">
                                                            <div class="col-lg-4 col-md-3 control-label"> <asp:Label ID="Label11" runat="server" Text="Tin Date"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                             <asp:TextBox ID="TextBox7" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                                 </div>
                                   <div class="col-sm-6">
                                   <div class="form-group">
                                                            <div class="col-lg-4 col-md-3 control-label"> <asp:Label ID="Label12" runat="server" Text="E-Mail"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                             <asp:TextBox ID="TextBox8" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                                 </div>
                                 
                                 </div>
                              <br />
                              <div class="row">
                              <div class="col-sm-6">
                                <div class="form-group">
                                                            <div class="col-lg-4 col-md-3 control-label"> <asp:Label ID="Label14" runat="server" Text="Party Type"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                           <asp:DropDownList ID="DropDownList5" runat="server" class="txt"></asp:DropDownList>
                                                               
                                                              
                                                            </div>
                                                        </div>
                              </div>
                              <div class="col-sm-6">
                               <div class="form-group">
                                                            <div class="col-lg-4 col-md-3 control-label"> <asp:Label ID="Label13" runat="server" Text="Phone"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                             <asp:TextBox ID="TextBox9" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                              </div>

                              </div>
                              <br /><div class="row">
                              <div class="col-sm-4">
                               <div class="form-group">
                                                            <div class="col-lg-4 col-md-3 control-label"> <asp:Label ID="Label15" runat="server" Text="Credit Limit"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                             <asp:TextBox ID="TextBox10" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                              </div>
                              <div class="col-sm-4">
                               <div class="form-group">
                                                            <div class="col-lg-4 col-md-3 control-label"> <asp:Label ID="Label16" runat="server" Text="Credit Days"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                             <asp:TextBox ID="TextBox11" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                              </div>
                              <div class="col-sm-4">
                                <div class="form-group">
                                                            <div class="col-lg-4 col-md-3 control-label"> <asp:Label ID="Label17" runat="server" Text="Mobile"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                             <asp:TextBox ID="TextBox12" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                              </div>
                              </div>
                              <br /><div class="row">
                              <div class="col-sm-4">
                                <div class="form-group">
                                                            <div class="col-lg-4 col-md-3 control-label"> <asp:Label ID="Label18" runat="server" Text="Transaction Limit"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                             <asp:TextBox ID="TextBox13" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                              </div>
                              <div class="col-sm-4">
                                <div class="form-group">
                                                            <div class="col-lg-4 col-md-3 control-label"> <asp:Label ID="Label19" runat="server" Text="CST No"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                             <asp:TextBox ID="TextBox14" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                                                        </div>
                                                        <div class="col-sm-4">
                                                            <div class="form-group">
                                                            <div class="col-lg-4 col-md-3 control-label"> <asp:Label ID="Label20" runat="server" Text="PAN"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                             <asp:TextBox ID="TextBox15" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                                                        </div>
                              </div>
                           
                       
                     <br />   <div class="row">
                        <div class="col-sm-6">
                        
                              <div class="form-group">
                                                            <div class="col-lg-4 col-md-3 control-label"> <asp:Label ID="Label21" runat="server" Text="Introduced By"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                            <asp:DropDownList ID="DropDownList6" runat="server" class="txt"></asp:DropDownList>
                                                               
                                                              
                                                            </div>
                                                        </div>
                        
                        </div>
                           <div class="col-sm-6">
                        
                              <div class="form-group">
                                                            <div class="col-lg-4 col-md-3 control-label"> <asp:Label ID="Label22" runat="server" Text="Bank"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                             <asp:TextBox ID="TextBox16" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                        
                        </div>
                        </div>
                        <br /><div class="row">
                        <div class="col-sm-6">
                        
                              <div class="form-group">
                                                            <div class="col-lg-4 col-md-3 control-label"> <asp:Label ID="Label23" runat="server" Text="Representative"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                             <asp:TextBox ID="TextBox17" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                        
                        </div>
                           <div class="col-sm-6">
                        
                              <div class="form-group">
                                                            <div class="col-lg-4 col-md-3 control-label"> <asp:Label ID="Label24" runat="server" Text="Bank Account No"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                             <asp:TextBox ID="TextBox18" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                        
                        </div>
                        </div>
                      <br />  <div class="row">
                          <div class="col-sm-6">
                        
                              <div class="form-group">
                                                            <div class="col-lg-4 col-md-3 control-label"> <asp:Label ID="Label25" runat="server" Text="IFSC Code"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                             <asp:TextBox ID="TextBox19" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                        
                        </div>
                        </div>
                        <br /> <div class="row">
                          <div class="col-sm-6">
                        
                              <div class="form-group">
                                                            <div class="col-lg-4 col-md-3 control-label"> <asp:Label ID="Label26" runat="server" Text="Website (http://)"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                             <asp:TextBox ID="TextBox20" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                        
                        </div>
                        </div>
                         <br /> <div class="row">
                          <div class="col-sm-8">
                        
                              <div class="form-group">
                                                            <div class="col-lg-2 col-md-3 control-label"> <asp:Label ID="Label27" runat="server" Text="Remarks"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                             <asp:TextBox ID="TextBox21" runat="server" class="txt" TextMode="MultiLine"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                        
                        </div>
                        </div>
                     </div>
                     
                                                 
                                   <br />
                                 
                         </div>

                            
                                </div>
                            </div><!-- End .panel --> 
                

              
                           <div class="row">
                        <div class="col-md-12">
                             <div class="panel panel-default recent-activites">
                                <!-- Start .panel -->
                                <div class="panel-heading">
                                    <h4 class="panel-title">Item Master Details</h4>
                                    <div class="panel-actions">
                                        <a href="#" class="panel-action panel-action-toggle" data-panel-toggle></a>
                                        <a href="#" class="panel-action panel-action-dismiss" data-panel-dismiss></a>
                                    </div>
                                </div>
                                <div class="panel-body">
                                     <div class="row">
                                     <div class="col-sm-12">

<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

<asp:TabContainer ID="TabContainer1" runat="server" Height="300px">
<asp:TabPanel ID="Company" runat="server" HeaderText="Company">
<ContentTemplate>

</ContentTemplate>


</asp:TabPanel>
<asp:TabPanel ID="Performance" runat="server" HeaderText="Performance">
<ContentTemplate>
<br /><div class="row">
                        <div class="col-sm-6">
                        
                              <div class="form-group">
                                                            <div class="col-lg-3 col-md-3 control-label"> <asp:Label ID="Label28" runat="server" Text="Turn Over"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                             <asp:TextBox ID="TextBox22" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                        
                        </div>
                           <div class="col-sm-6">
                        
                              <div class="form-group">
                                                            <div class="col-lg-5 col-md-3 control-label"> <asp:Label ID="Label29" runat="server" Text="Total Supplay Value"></asp:Label></div>
                                                            <div class="col-lg-7 col-md-8">
                                                           
                                                             <asp:TextBox ID="TextBox23" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                        
                        </div>
                        </div>
                        <br /><div class="row">
                        <div class="col-sm-6">
                        
                              <div class="form-group">
                                                            <div class="col-lg-3 col-md-3 control-label"> <asp:Label ID="Label30" runat="server" Text="Gross Margin"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                             <asp:TextBox ID="TextBox24" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                        
                        </div>
                           <div class="col-sm-6">
                        
                              <div class="form-group">
                                                            <div class="col-lg-5 col-md-3 control-label"> <asp:Label ID="Label31" runat="server" Text="Delayed Supplay Value"></asp:Label></div>
                                                            <div class="col-lg-7 col-md-8">
                                                           
                                                             <asp:TextBox ID="TextBox25" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                        
                        </div>
                        </div>
                            <br /><div class="row">
                        <div class="col-sm-6">
                        
                              <div class="form-group">
                                                            <div class="col-lg-3 col-md-3 control-label"> <asp:Label ID="Label34" runat="server" Text="No.of Bills"></asp:Label></div>
                                                            <div class="col-lg-8 col-md-9">
                                                           
                                                             <asp:TextBox ID="TextBox28" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                        
                        </div>
                           <div class="col-sm-6">
                        
                              <div class="form-group">
                                                            <div class="col-lg-5 col-md-3 control-label"> <asp:Label ID="Label35" runat="server" Text="No.Of Bills"></asp:Label></div>
                                                            <div class="col-lg-7 col-md-8">
                                                           
                                                             <asp:TextBox ID="TextBox29" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                        
                        </div>
                        </div>
                        <br /><div class="row">
                        <div class="col-sm-6">
                        
                              <div class="form-group">
                                                            <div class="col-lg-5 col-md-3 control-label"> <asp:Label ID="Label32" runat="server" Text="Over the Due Payment"></asp:Label></div>
                                                            <div class="col-lg-7 col-md-8">
                                                           
                                                             <asp:TextBox ID="TextBox26" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                        
                        </div>
                           <div class="col-sm-6">
                        
                              <div class="form-group">
                                                            <div class="col-lg-5 col-md-3 control-label"> <asp:Label ID="Label33" runat="server" Text="Total Delayed Days"></asp:Label></div>
                                                            <div class="col-lg-7 col-md-8">
                                                           
                                                             <asp:TextBox ID="TextBox27" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                        
                        </div>
                        </div>
                    
                        <br /><div class="row">
                        <div class="col-sm-6">
                        
                              <div class="form-group">
                                                            <div class="col-lg-5 col-md-2 control-label"> <asp:Label ID="Label36" runat="server" Text="Last Sale Date"></asp:Label></div>
                                                            <div class="col-lg-7 col-md-8">
                                                           
                                                             <asp:TextBox ID="TextBox30" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                        
                        </div>
                           <div class="col-sm-6">
                        
                              <div class="form-group">
                                                            <div class="col-lg-5 col-md-3 control-label"> <asp:Label ID="Label37" runat="server" Text="Last Purchase Date"></asp:Label></div>
                                                            <div class="col-lg-7 col-md-8">
                                                           
                                                             <asp:TextBox ID="TextBox31" runat="server" class="txt"></asp:TextBox>
                                                               
                                                              
                                                            </div>
                                                        </div>
                        
                        </div>
                        </div>
</ContentTemplate>


</asp:TabPanel>
<asp:TabPanel ID="Contact" runat="server" HeaderText="Contact Whom">
<ContentTemplate>

</ContentTemplate>


</asp:TabPanel>
<asp:TabPanel ID="Address" runat="server" HeaderText="Address Book">
<ContentTemplate>

</ContentTemplate>


</asp:TabPanel>
<asp:TabPanel ID="Events" runat="server" HeaderText="Events">
<ContentTemplate>

</ContentTemplate>


</asp:TabPanel>
</asp:TabContainer>

                                     </div>
                               </div>
                                 <br /><div class="row">
                                    <div class="col-sm-8">
                                      <div class="form-group">
                                                            <div class="col-sm-2"> <asp:Button ID="Button1" runat="server" Class="btn" Text="Save"></asp:Button></div>
                                     <div class="col-sm-2"> <asp:Button ID="Button2" runat="server" Class="btn" Text="  Clear"></asp:Button></div>
                                  <div class="col-sm-2"> <asp:Button ID="Button3" runat="server" Class="btn" Text="Exit"></asp:Button></div></div>
                                                        </div>
                                 </div>      </div>
                         </div>
                   
                                </div>
                            </div><!-- End .panel --> 
                        </div>
             </div>
    

                      
                                
          
          
        </section>

        <script type="text/javascript" src="js/jquery.min.js"></script>
        <script type="text/javascript" src="bootstrap/js/bootstrap.min.js"></script>
        <script src="js/metisMenu.min.js"></script>
        <script src="js/jquery-jvectormap-1.2.2.min.js"></script>
        <script src="js/pace.min.js"></script>
        <script src="js/waves.min.js"></script>
        <script src="js/jquery-jvectormap-world-mill-en.js"></script>
        <!--        <script src="js/jquery.nanoscroller.min.js"></script>-->
        <script type="text/javascript" src="js/custom.js"></script>
        <!--page plugins-->
        <script src="js/select/fancySelect.js"></script>
        <script src="js/switch/bootstrap-switch.min.js"></script>
        <script src="js/input-mask/jquery.inputmask.bundle.min.js"></script>
        <script src="js/select/select2.js"></script>
        <script src="js/slider/bootstrap-slider.min.js"></script>
        <script src="js/custom-advanced-form.js"></script>
        <!-- Google Analytics:  -->
        <script>
            (function (i, s, o, g, r, a, m) {
                i['GoogleAnalyticsObject'] = r;
                i[r] = i[r] || function () {
                    (i[r].q = i[r].q || []).push(arguments);
                }, i[r].l = 1 * new Date();
                a = s.createElement(o),
                        m = s.getElementsByTagName(o)[0];
                a.async = 1;
                a.src = g;
                m.parentNode.insertBefore(a, m)
            })(window, document, 'script', '//www.google-analytics.com/analytics.js', 'ga');
            ga('create', 'UA-3560057-28', 'auto');
            ga('send', 'pageview');
        </script>
    </body>
    </form>
</html>


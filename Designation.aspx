﻿<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Designation.aspx.cs" Inherits="Designation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
  <meta charset="utf-8" >
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1"/>
        <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
        <title>Piple - Admin</title>

        <!-- Bootstrap -->
        <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet"/>
        <link href="css/waves.min.css" type="text/css" rel="stylesheet"/>
        <link href="css/select.css" type="text/css" rel="stylesheet"/>
        <link rel="stylesheet" href="css/bootstrap-slider.min.css"/>
        <link href="css/bootstrap-switch.min.css" type="text/css" rel="stylesheet"/>
        <link href="css/menu.css" type="text/css" rel="stylesheet"/>
        <link href="css/style.css" type="text/css" rel="stylesheet"/>
        <link href="font-awesome/css/font-awesome.min.css" rel="stylesheet"/>
        <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
        <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
        <!--[if lt IE 9]>
          <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
          <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
        <![endif]-->

        <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js"></script>
<script src="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.9/jquery-ui.js" type="text/javascript"></script>
<link href="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.9/themes/blitzer/jquery-ui.css"
    rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css">
    <script type="text/javascript" src="http://code.jquery.com/jquery-1.7.2.js"></script>
    <script type="text/javascript" src="http://code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#divdialog").dialog({
                autoOpen: false,
                show: {
                    effect: "shake",
                    duration: 1000
                }
            });
        });
        function ShowMessage() {
            if ($('#txtName').val() == "") {
                $("#divdialog").dialog("open");
                return false;
            } else {
                return true;
            }
        }
    </script>
    <style type="text/css">
        .MessageStyle
        {
            font-size: 12px;
        }
    </style>
    <style type="text/css">
        .style1
        {
            width: 71px;
        }
        .style2
        {
            width: 110px
        }
    </style>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js"></script>
<script src="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.9/jquery-ui.js" type="text/javascript"></script>
<link href="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.9/themes/blitzer/jquery-ui.css"
    rel="stylesheet" type="text/css" />

    </head>
 
    <body>
       <form id="Form1" runat="server">
        <!-- Static navbar -->

        <nav class="navbar navbar-inverse yamm navbar-fixed-top">
            <div class="container-fluid">
                <button type="button" class="navbar-minimalize minimalize-styl-2  pull-left "><i class="fa fa-bars"></i></button>
                <span class="search-icon"><i class="fa fa-search"></i></span>
                <div class="search" style="display: none;">
                  
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
                            <li class="active">
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
                                        <li class="active">
                                <a href="#"> <i class="fa fa-spinner" aria-hidden="true"></i> &nbsp;&nbsp;<span class="nav-label">User Management</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                <li><a href="Employee-Master.aspx"> Employee Master</a></li>
                                    <li><a href="Designation.aspx"> Designation</a></li>
                                    <li><a href="Department-Details.aspx"> Department</a></li>
                                       <li><a href="Head-Of-Department.aspx"> Head of Department</a></li>
                                  
                                  
                                </ul>
                            </li>
                                </ul>
                            </li>
                            <li>
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
                                <a href="#"><i class="fa fa-files-o fa-2x"></i> <span class="nav-label">Sales</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                    <li><a href="Sales-Out-Sheet.aspx">Sales Out Sheet</a></li>
                                    <li><a href="Small-Sales-Outsheet.aspx">Small Sales Out Sheet</a></li>
                                    <li><a href="Branch-P-O.aspx">Branch PO</a></li>
                               
                                </ul>
                            </li>

                            <li>
                                <a href="#"><i class="fa fa-calendar-times-o fa-2x" aria-hidden="true"></i> <span class="nav-label">Financial Management</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                  <li>
                                <a href="#"><i class="fa fa-check-square" aria-hidden="true"></i>  <span class="nav-label">General Ledger Master</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                    <li><a href="Account-Budget.aspx">Account Budget</a></li>
                                    <li><a href="MIS-Configurator.aspx">MIS Configurator</a></li>

                                    
                                    
                                </ul>
                            </li>
                                           <li>
                                <a href="#"><i class="fa fa-check-square" aria-hidden="true"></i> <span class="nav-label">Account Set Up</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                    <li><a href="Chart-Of-Accounts.aspx">Chart of Accounts</a></li>
                                    <li><a href="Financial-Years.aspx">Financial Years</a></li>
                                        <li><a href="Linked-Accounts.aspx">Linked Accounts</a></li>
                                            <li><a href="Transaction-Controll-Setting.aspx">Transaction Controll Settings</a></li>
                                           <li><a href="Sub-Ledger-Type.aspx">Sub Ledger Type</a></li>
                                              <li><a href="Voucher-Types.aspx">Voucher Types</a></li>
                                               <li><a href="Ledger-Opening-Balance.aspx">Ledger Opening </a></li>
                                                <li><a href="AR-AP-Billwise-Opening-Balance.aspx">AP/AP Billwise Opening Balance</a></li>
                                                 <li><a href="Customer-Vendor-Category.aspx">Customer / Vendor Category</a></li>
                                                 <li><a href="Unreconciled-Cheques.aspx">Unreconciled-Cheques</a></li>
                                    
                                </ul>
                            </li>
                                        <li>
                                <a href="#"><i class="fa fa-check-square" aria-hidden="true"></i>  <span class="nav-label">Journal</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                    <li><a href="Journal-Templates.aspx">Journal Templates</a></li>
                                    <li><a href="Journals.aspx">Journals</a></li>
                                     <li><a href="Stock-Posting.aspx">Stock Post</a></li>
                                     <li><a href="Year-End-Journals.aspx">Year End Journals</a></li>
                                    
                                </ul>
                            </li> 
                                <li>
                                <a href="#"><i class="fa fa-check-square" aria-hidden="true"></i>  <span class="nav-label">Cash / Bank Accounting</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                    <li><a href="Receipt.aspx">Receipt</a></li>
                                    <li><a href="Payment.aspx">Payment</a></li>
                                      <li><a href="Fund-Transfer.aspx">Fund Transfer</a></li>
                                   
                                      <li>
                                <a href="#"><i class="fa fa-check-square" aria-hidden="true"></i>  <span class="nav-label">Bank Reconcilation</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                    <li><a href="Reconcile Account.aspx">Reconcile Account</a></li>
                                      <li><a href="Reconcilation-Report.aspx">Reconcilation Report</a></li>
                                   
                                    
                                </ul>
                            </li>
                                    
                                </ul>
                            </li> 
                               
                            <li>
                                <a href="#"><i class="fa fa-check-square" aria-hidden="true"></i>  <span class="nav-label">Accounts Receivable</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                  <li>
                                <a href="#"><i class="fa fa-check-square" aria-hidden="true"></i>  <span class="nav-label">Receivable Transaction</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                    <li><a href="Customer-Receipt.aspx">Customer Receipt</a></li>
                                        <li><a href="AR-AP-Offset.aspx">AR/AP Offset</a></li>
                                   
                                    
                                </ul>
                            </li> 
                                 <li>
                                <a href="#"><i class="fa fa-check-square" aria-hidden="true"></i>  <span class="nav-label">Receivable Report</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                     <li><a href="Receivable-Ageing-Details.aspx">Receivable Ageing Details</a></li>
                                    <li><a href="Receivable-Ageing-Summary.aspx">Receivable Ageing Summary</a></li>
                                        <li><a href="Receivable-with-adjustment.aspx">Receivable with adjustment</a></li>
                                          <li><a href="Receivable-Outstanding.aspx">Receivable Outstanding</a></li>
                                     <li><a href="Adjustment-and-on-Accounts.aspx">Adjustment & on Accounts</a></li>
                  
                                </ul>
                            </li> 
                                   
                                  </ul>
                            </li> 

                              <li>
                                <a href="#"><i class="fa fa-check-square" aria-hidden="true"></i>  <span class="nav-label">Accounts Payable</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                  <li>
                                <a href="#"><i class="fa fa-check-square" aria-hidden="true"></i>  <span class="nav-label">Payable Transaction</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                    <li><a href="Supplier-Payment.aspx">Supplier Payment</a></li>
                                      
                                   
                                    
                                </ul>
                            </li> 
                                 <li>
                                <a href="#"><i class="fa fa-check-square" aria-hidden="true"></i>  <span class="nav-label">Payable Reports</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                     <li><a href="Payable-Ageing-Details.aspx">Payable Ageing Details</a></li>
                                    <li><a href="Payable-Ageing-Summary.aspx">Payable Ageing Summary</a></li>
                                          <li><a href="Payable-Outstanding.aspx">Payable Outstanding</a></li>
                                     <li><a href="Payable-With-Adjustment.aspx">Payable With Adjustment</a></li>
                                    
                                </ul>
                            </li> 
                                   
                                    
                                </ul>
                            </li> 
                              <li>
                                <a href="#"><i class="fa fa-check-square" aria-hidden="true"></i>  <span class="nav-label">Finance Report</span><span class="fa arrow"></span></a>
                                <ul class="nav nav-second-level collapse">
                                     <li><a href="Voucher-Query.aspx">Voucher Query</a></li>
                                    <li><a href="Group-Summary-Party.aspx">Group Summary Party</a></li>
                                    
                                    
                                </ul>
                            </li> 
                                  
                          
                                    
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
                                <h1 class="gnrl"> Designation<small></small></h1>
                               
                            </div>
                        </div>
                    </div><!-- end .page title-->
               
                    <div class="row">
                        <div class="col-md-12">
                             <div class="panel panel-default recent-activites">
                                <!-- Start .panel -->
                            
                                <div class="panel-heading"  >
                                 
                               <div style="width:100%;" >
                                    

                                     <div  style ="float:left; padding:10px;">

                                    <h4 class="panel-title" ><%-- <img src="images/new.png" alt="" class="img-square" width="20" />   --%>
                                     <asp:Button ID="Button1" runat="server" class="btn1" Text="New"></asp:Button>                               
                                                                       </h4>     </div>
                                    
                                      <div  style ="float:left; padding:10px;">
                                    <h4 class="panel-title" >   <%--<img src="images/rsz_save-icon-5.jpg" alt="" class="img-square" width="20"   />--%>
                                     <asp:Button ID="Button2" runat="server" class="btn1" Text="Save"  
                                            onclick="Button2_Click" OnClientClick="ShowMessage();"></asp:Button>                               
                                                                       </h4>     </div>


                                  
                                       <div  style ="float:left; padding:10px;">
                                    <h4 class="panel-title" >  <%-- <img src="images/rsz_1search-icon.jpg" alt="" class="img-square" width="20"   />--%>
                                     <asp:Button ID="Button3" runat="server" Class="btn1" Text="Search" 
                                            onclick="Button3_Click"></asp:Button>                               
                                                                       </h4>     </div>
                                   
                                 
                                      <div  style ="float:left; padding:10px;">
                                    <h4 class="panel-title" >   <%-- <img src="images/rsz_untitled-25-512.jpg" alt="" class="img-square" width="20"   />--%>
                                     <asp:Button ID="Button4" runat="server" class="btn1" Text="Remove" 
                                            onclick="Button4_Click"></asp:Button>                               
                                                                       </h4>     </div>
                                    
                                    
                                        <div  style ="float:left; padding:10px;">
                                    <h4 class="panel-title" >  <%--  <img src="images/rsz_1images.jpg" alt="" class="img-square" width="20"   />--%>
                                     <asp:Button ID="Button5" runat="server" class="btn1" Text="Task"></asp:Button>                               
                                                                       </h4>     </div>
                               
                                   
                               </div>
                               <br />
                               <br />

                                    <div class="panel-actions">
                                        <a href="#" class="panel-action panel-action-toggle" data-panel-toggle></a>
                                        <a href="#" class="panel-action panel-action-dismiss" data-panel-dismiss></a>
                                    </div>
                             </div>
                             

                                <div class="panel-body">
                                     <div class="row">
                                 <div class="col-sm-12">
                                 <div class="form-group">

                                                           <div class="col-sm-6">   <div class="col-lg-3 col-md-3 control-label"> <asp:Label ID="Label1" runat="server" Text="Designation Code* " Visible="false" ></asp:Label></div>
                                                            <div class="col-lg-9 col-md-8">
                                                             <%-- <asp:DropDownList ID="DropDownList1" runat="server" class="txt" Width="200px"></asp:DropDownList>--%>
                                                              <asp:TextBox ID="txtval1" runat="server" class="txt|" Width ="200px" visible="false"></asp:TextBox>
             <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator" 
                                                                    onservervalidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
             
                                                              <asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
<ContentTemplate>
   <%-- <asp:Button ID="Button6" Text="Show Message" runat="server" OnClick="ShowMessage" />--%>
</ContentTemplate>
</asp:UpdatePanel>
                                                            </div>
                                                        </div>
                                                         <div class="col-sm-6">
                                                                        <div class="form-group">
                                                            <div class="col-lg-3 col-md-3 control-label"> </div>
                                                            <div class="col-lg-9 col-md-8">
                                                               
                                                                
                                                            </div>
                                                        </div>
                                 </div>
                                   </div>
                                  
                                 </div>
                              
                                </div>
                              
                                 <br /><div class="row">
                                 <div class="col-sm-12">
                                      <div class="form-group">
                                      <div class="col-sm-6">
                                                            <div class="col-lg-3 col-md-3 control-label"> <asp:Label ID="Label5" runat="server" Text="Designation Name*"></asp:Label></div>
                                                            <div class="col-lg-9 col-md-8">
                                                              <asp:TextBox ID="txtval2" runat="server" class="txt|" Width ="200px" ></asp:TextBox>

                                                              <asp:Label ID="Label4" runat="server" Text="Designation ID*" Visible="false"></asp:Label>
                                                         <%-- <asp:DropDownList ID="DropDownList3" runat="server" class="txt" Width="200px"></asp:DropDownList>
                                                               --%>
                                                              </div>
                                                            </div>
                                                              <div class="col-sm-6">
                                                            <div class="col-lg-3 col-md-3 control-label"> </div>
                                                            <div class="col-lg-9 col-md-8">
                                                           
                                                       <%--    <asp:TextBox ID="txtval3" runat="server" class="txt" Width="200px"></asp:TextBox>
                                                               --%>
                                                              </div>
                                                            </div>
                                                           <div class="col-sm-6">
                                                              
                                                            
                                                            </div>
                                                            <div class="col-sm-6">
                                                            <div class="col-lg-3 col-md-3 control-label"> </div>
                                                            <div class="col-lg-9 col-md-8">
                                                             
                                                              </div>
                                                            </div>
                                                        </div>
                                                          
                                 </div>
                                           
                                 </div>
                                  <br /><div class="row">
                                 <div class="col-sm-6">
                                      <div class="form-group">
                                                            <div class="col-lg-3 col-md-3 control-label"> <%--<asp:Label ID="Label2" runat="server" Text="Budget Description"></asp:Label>--%></div>
                                                            <div class="col-lg-9 col-md-8">
                                                         <%--      <asp:TextBox ID="txtval2" runat="server" class="txt" Width="880px"></asp:TextBox>
                                                     --%>
                                                            </div>
                                                        </div>
                                                          
                                 </div>
                                           
                                 </div>
                                  
                                 
                                 
                                 </div>
                                 <br /><div class="row">
                                    <div class="col-sm-8">
                                      <div class="form-group">
                                                           </div>
                                                        </div>
                                 </div><br />
                         </div>
<br />
                            
                                </div>
                            </div><!-- End .panel --> 
                           <%-- <div>
                            
                                <table style="width:100%;">
                                    <tr>
                                        <td class="style1" style="margin:-25px 20px 20px 45px" >
                                            |&nbsp; List View</td>
                                        <td class="style2">
                                              <img src="images/new.png" alt="" class="img-square" width="20" " style="margin:10px 10px 10px 10px"/>
                                       
&nbsp;<h4 class="panel-title" style="margin:-35px 7px 6px 46px" >New |</h4>

</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                </table>
                            
                            </div>--%>
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        CssClass="table table-hover" 
                        onselectedindexchanged="GridView1_SelectedIndexChanged">
                                                    <Columns>
                                                        <asp:TemplateField HeaderText="ID" Visible="false">
                                                            <EditItemTemplate>
                                                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ID") %>'></asp:TextBox>
                                                            </EditItemTemplate>
                                                            <ItemTemplate>
                                                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="DesignationCode" Visible="false">
                                                            <EditItemTemplate>
                                                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("DesignationCode") %>'></asp:TextBox>
                                                            </EditItemTemplate>
                                                            <ItemTemplate>
                                                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("DesignationCode") %>'></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="DesignationName">
                                                            <EditItemTemplate>
                                                                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("DesignationName") %>'></asp:TextBox>
                                                            </EditItemTemplate>
                                                            <ItemTemplate>
                                                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("DesignationName") %>'></asp:Label>
                                                                <br /><asp:HiddenField ID="hfid" Value='<%# Bind("DesignationCode") %>' runat="server"></asp:HiddenField>
                                                                  
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:CommandField HeaderText="Select" ShowSelectButton="True" />
                                                    </Columns>
                                                </asp:GridView>
                        </div>
                        <div class="content-wrapper">
                                                
                                                </div>
                    </div>
                      
                          
          
        </section>

        <script type="text/javascript" src="js/jquery.min.js"></script>
        <script type="text/javascript" src="bootstrap/js/bootstrap.min.js"></script>
        <script  type="text/javascript" src="js/metisMenu.min.js"></script>
        <script type="text/javascript" src="js/jquery-jvectormap-1.2.2.min.js"></script>
        <script type="text/javascript" src="js/pace.min.js"></script>
        <script type="text/javascript" src="js/waves.min.js"></script>
        <script type="text/javascript" src="js/jquery-jvectormap-world-mill-en.js"></script>
        <!--        <script src="js/jquery.nanoscroller.min.js"></script>-->
        <script type="text/javascript" src="js/custom.js"></script>
        <!--page plugins-->
        <script  type="text/javascript" src="js/select/fancySelect.js"></script>
        <script  type="text/javascript" src="js/switch/bootstrap-switch.min.js"></script>
        <script  type="text/javascript" src="js/input-mask/jquery.inputmask.bundle.min.js"></script>
        <script  type="text/javascript" src="js/select/select2.js"></script>
        <script  type="text/javascript" src="js/slider/bootstrap-slider.min.js"></script>
        <script  type="text/javascript" src="js/custom-advanced-form.js"></script>
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
            </form>
    </body>

</html>


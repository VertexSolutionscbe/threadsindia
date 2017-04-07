<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DashBoard.aspx.cs" Inherits="Main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
        <title>Threads-India- Admin</title>

        <!-- Bootstrap -->
        <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet">
        <link href="css/waves.min.css" type="text/css" rel="stylesheet">
        <!--        <link rel="stylesheet" href="css/nanoscroller.css">-->
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

                            <li class="active">
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
                                    <li><a href="Business-Segment.aspx">Business Segment</a></li>
                                  
                                  
                                </ul>
                            </li>
                                                <li>
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
                                   
                                      <li >
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
                                <h1>Dashboard <small></small></h1>
                                <ol class="breadcrumb">
                                    <li><a href="#"><i class="fa fa-home"></i></a></li>
                                    <li class="active">Dashboard</li>
                                </ol>
                            </div>
                        </div>
                    </div><!-- end .page title-->
                    <div class="row">
                        <div class="col-sm-6 col-md-3 margin-b-30">
                            <div class="tile red">
                                <div class="tile-title clearfix">
                                    Total orders
                                    <span class="pull-right"><i class="fa fa-caret-up"></i> 33%</span>
                                </div><!--.tile-title-->
                                <div class="tile-body clearfix">
                                    <i class="fa fa-cart-plus"></i>
                                    <h4 class="pull-right">2.5K</h4>
                                </div><!--.tile-body-->
                                <div class="tile-footer">
                                    <a href="#">View Details...</a>
                                </div><!--.tile footer-->
                            </div><!-- .tile-->
                        </div><!--end .col-->
                        <div class="col-sm-6 col-md-3 margin-b-30">
                            <div class="tile green">
                                <div class="tile-title clearfix">
                                    Total Sales
                                    <span class="pull-right"><i class="fa fa-caret-up"></i> 33%</span>
                                </div><!--.tile-title-->
                                <div class="tile-body clearfix">
                                    <i class="fa fa-credit-card"></i>
                                    <h4 class="pull-right">22.5M</h4>
                                </div><!--.tile-body-->
                                <div class="tile-footer">
                                    <a href="#">View Details...</a>
                                </div><!--.tile footer-->
                            </div><!-- .tile-->
                        </div><!--end .col-->
                        <div class="col-sm-6 col-md-3 margin-b-30">
                            <div class="tile blue">
                                <div class="tile-title clearfix">
                                    Users
                                    <span class="pull-right"><i class="fa fa-caret-up"></i> 50%</span>
                                </div><!--.tile-title-->
                                <div class="tile-body clearfix">
                                    <i class="fa fa-users"></i>
                                    <h4 class="pull-right">2.5K</h4>
                                </div><!--.tile-body-->
                                <div class="tile-footer">
                                    <a href="#">View Details...</a>
                                </div><!--.tile footer-->
                            </div><!-- .tile-->
                        </div><!--end .col-->
                        <div class="col-sm-6 col-md-3 margin-b-30">
                            <div class="tile purple">
                                <div class="tile-title clearfix">
                                    Total orders
                                    <span class="pull-right"><i class="fa fa-caret-up"></i> 33%</span>
                                </div><!--.tile-title-->
                                <div class="tile-body clearfix">
                                    <i class="fa fa-cart-plus"></i>
                                    <h4 class="pull-right">2.5K</h4>
                                </div><!--.tile-body-->
                                <div class="tile-footer">
                                    <a href="#">View Details...</a>
                                </div><!--.tile footer-->
                            </div><!-- .tile-->
                        </div><!--end .col-->
                    </div><!--end .row-->
                    <div class="row">
                        <div class="col-md-6">
                            <div class="panel panel-default ">
                                <!-- Start .panel -->
                                <div class="panel-heading">
                                    <h4 class="panel-title"> Sales & Earnings</h4>
                                    <div class="panel-actions">
                                        <a href="#" class="panel-action panel-action-toggle" data-panel-toggle></a>
                                        <a href="#" class="panel-action panel-action-dismiss" data-panel-dismiss></a>
                                    </div>
                                </div>
                                <div class="panel-body">
                                    <div>
                                        <canvas id="barChart" height="140"></canvas>
                                    </div>
                                </div>
                            </div><!-- End .panel -->  
                        </div><!--end .col-->
                        <div class="col-md-6">
                            <div class="panel panel-default ">
                                <!-- Start .panel -->
                                <div class="panel-heading">
                                    <h4 class="panel-title"> Last sales locations</h4>
                                    <div class="panel-actions">
                                        <a href="#" class="panel-action panel-action-toggle" data-panel-toggle></a>
                                        <a href="#" class="panel-action panel-action-dismiss" data-panel-dismiss></a>
                                    </div>
                                </div>
                                <div class="panel-body">
                                    <div id="world-map" style="width: 100%; height: 250px"></div>
                                </div>
                            </div><!-- End .panel -->                       
                        </div><!--end .col-->

                    </div><!--end .row-->
                    <div class="row">
                        <div class="col-md-4">
                            <div class="panel panel-default recent-activites">
                                <!-- Start .panel -->
                                <div class="panel-heading">
                                    <h4 class="panel-title"> Recent Activities</h4>
                                    <div class="panel-actions">
                                        <a href="#" class="panel-action panel-action-toggle" data-panel-toggle></a>
                                        <a href="#" class="panel-action panel-action-dismiss" data-panel-dismiss></a>
                                    </div>
                                </div>
                                <div class="panel-body pad-0">
                                    <ul class="list-group">
                                        <li class="list-group-item">
                                            <a href="#">Lorem ipsum dolor</a>
                                            <small><i class="fa fa-clock-o"></i> 13/08/2015 04:51:21</small>
                                        </li>
                                        <li class="list-group-item">
                                            <a href="#">Lorem ipsum dolor</a>
                                            <small><i class="fa fa-clock-o"></i> 13/08/2015 04:51:21</small>
                                        </li>
                                        <li class="list-group-item">
                                            <a href="#">Lorem ipsum dolor</a>
                                            <small><i class="fa fa-clock-o"></i> 13/08/2015 04:51:21</small>
                                        </li>
                                        <li class="list-group-item">
                                            <a href="#">Lorem ipsum dolor</a>
                                            <small><i class="fa fa-clock-o"></i> 13/08/2015 04:51:21</small>
                                        </li>                            
                                    </ul>
                                </div>
                            </div><!-- End .panel -->                       
                        </div><!--end .col-->
                        <div class="col-md-8">

                            <div class="panel panel-default recent-activites">
                                <!-- Start .panel -->
                                <div class="panel-heading">
                                    <h4 class="panel-title"> Recent Orders</h4>
                                    <div class="panel-actions">
                                        <a href="#" class="panel-action panel-action-toggle" data-panel-toggle></a>
                                        <a href="#" class="panel-action panel-action-dismiss" data-panel-dismiss></a>
                                    </div>
                                </div>
                                <div class="panel-body pad-0">
                                    <div class="table-responsive">
                                        <table class="table table-hover table-recent-orders">
                                            <thead>
                                                <tr>
                                                    <th>Id</th>
                                                    <th>Customer</th>
                                                    <th>Status</th>
                                                    <th>Date</th>
                                                    <th>Total</th>
                                                    <th>Action</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <td>4563</td>
                                                    <td>David</td>
                                                    <td><span class="text-danger">Pending</span></td>
                                                    <td>04 / 08 / 2015</td>
                                                    <td>$5679.99</td>
                                                    <td><span class="action-icon"><a href="#" data-toggle="tooltip" data-placement="top" title="View" class="btn btn-xs btn-primary"><i class="fa fa-eye-slash"></i></a></span></td>
                                                </tr>
                                                <tr>
                                                    <td>8997</td>
                                                    <td>John</td>
                                                    <td><span class="text-success">Success</span></td>
                                                    <td>04 / 08 / 2015</td>
                                                    <td>$5679.99</td>
                                                    <td><span class="action-icon"><a href="#" data-toggle="tooltip" data-placement="top" title="View" class="btn btn-xs btn-primary"><i class="fa fa-eye-slash"></i></a></span></td>
                                                </tr>
                                                <tr>
                                                    <td>2342</td>
                                                    <td>Mohinder</td>
                                                    <td><span class="text-danger">Pending</span></td>
                                                    <td>04 / 08 / 2015</td>
                                                    <td>$5679.99</td>
                                                    <td><span class="action-icon"><a href="#" data-toggle="tooltip" data-placement="top" title="View" class="btn btn-xs btn-primary"><i class="fa fa-eye-slash"></i></a></span></td>
                                                </tr>
                                                <tr>
                                                    <td>5677</td>
                                                    <td>Mohinder</td>
                                                    <td><span class="text-danger">Pending</span></td>
                                                    <td>04 / 08 / 2015</td>
                                                    <td>$5679.99</td>
                                                    <td><span class="action-icon"><a href="#" data-toggle="tooltip" data-placement="top" title="View" class="btn btn-xs btn-primary"><i class="fa fa-eye-slash"></i></a></span></td>
                                                </tr>
                                                <tr>
                                                    <td>6756</td>
                                                    <td>Camron</td>
                                                    <td><span class="text-danger">Success</span></td>
                                                    <td>04 / 08 / 2015</td>
                                                    <td>$5679.99</td>
                                                    <td><span class="action-icon"><a href="#" data-toggle="tooltip" data-placement="top" title="View" class="btn btn-xs btn-primary"><i class="fa fa-eye-slash"></i></a></span></td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>

                        </div><!--end .col-->
                    </div><!--end .row-->
                </div> 
            </div>
        </section>

        <script type="text/javascript" src="js/jquery.min.js"></script>
        <script type="text/javascript" src="bootstrap/js/bootstrap.min.js"></script>
        <script src="js/metisMenu.min.js"></script>
        <script src="js/jquery-jvectormap-1.2.2.min.js"></script>
        <!-- Flot -->
        <script src="js/flot/jquery.flot.js"></script>
        <script src="js/flot/jquery.flot.tooltip.min.js"></script>
        <script src="js/flot/jquery.flot.resize.js"></script>
        <script src="js/flot/jquery.flot.pie.js"></script>
        <script src="js/chartjs/Chart.min.js"></script>
        <script src="js/pace.min.js"></script>
        <script src="js/waves.min.js"></script>
        <script src="js/jquery-jvectormap-world-mill-en.js"></script>
        <!--        <script src="js/jquery.nanoscroller.min.js"></script>-->
        <script type="text/javascript" src="js/custom.js"></script>
        <script type="text/javascript">
            $(function () {

                var barData = {
                    labels: ["January", "February", "March", "April", "May", "June", "July"],
                    datasets: [
                        {
                            label: "My First dataset",
                            fillColor: "rgba(220,220,220,0.5)",
                            strokeColor: "rgba(220,220,220,0.8)",
                            highlightFill: "rgba(220,220,220,0.75)",
                            highlightStroke: "rgba(220,220,220,1)",
                            data: [65, 59, 80, 81, 56, 55, 40]
                        },
                        {
                            label: "My Second dataset",
                            fillColor: "rgba(14, 150, 236,0.5)",
                            strokeColor: "rgba(14, 150, 236,0.8)",
                            highlightFill: "rgba(14, 150, 236,0.75)",
                            highlightStroke: "rgba(14, 150, 236,1)",
                            data: [28, 48, 40, 19, 86, 27, 90]
                        }
                    ]
                };

                var barOptions = {
                    scaleBeginAtZero: true,
                    scaleShowGridLines: true,
                    scaleGridLineColor: "rgba(0,0,0,.05)",
                    scaleGridLineWidth: 1,
                    barShowStroke: true,
                    barStrokeWidth: 2,
                    barValueSpacing: 5,
                    barDatasetSpacing: 1,
                    responsive: true
                };


                var ctx = document.getElementById("barChart").getContext("2d");
                var myNewChart = new Chart(ctx).Bar(barData, barOptions);

            });
        </script>
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
</html>

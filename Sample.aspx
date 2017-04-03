<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sample.aspx.cs" Inherits="Sample" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <div class="row">
                        <div class="col-md-12">
                             <div class="panel panel-default recent-activites">
                                <!-- Start .panel -->
                            
                                <div class="panel-heading" style="margin:-50px  100px 15px 48px" >
                                   <h4 class="panel-title" style="margin:0px 20px 0px -11px">List View |</h4>
                                     <div>
                                     <div>
                                     <span class="pull-left">
                                            <img src="images/rsz_save-icon-5.jpg" alt="" class="img-square" width="20"  style="margin:-18px -6px 30px 126px" />
                                        </span>
                                    <h4 class="panel-title" style="margin:-30px 31px 10px 160px">Save |</h4>
                                     <span class="pull-left">
                                            <img src="images/rsz_icon_new_file_256x256.jpg" alt="" class="img-square" width="20"  style="margin:-20px 20px 20px -80px"/>
                                        </span>
                                    <h4 class="panel-title" style="margin:-8px 31px 10px 83px" >New |</h4>

                                     </div>
                                     </div>

                                    <div class="panel-actions">
                                        <a href="#" class="panel-action panel-action-toggle" data-panel-toggle></a>
                                        <a href="#" class="panel-action panel-action-dismiss" data-panel-dismiss></a>
                                    </div>
                                </div>



                                <div class="panel-body">
                                     <div class="row">
                                 <div class="col-sm-12">
                                 <div class="form-group">
                                                           <div class="col-sm-6">   <div class="col-lg-3 col-md-3 control-label"> <asp:Label ID="Label1" runat="server" Text="Budget Type "></asp:Label></div>
                                                            <div class="col-lg-9 col-md-8">
                                                           
                                                              
                                                            
                                                              <asp:DropDownList ID="DropDownList1" runat="server" class="txt" Width="200px"></asp:DropDownList>
                                                            </div>
                                                        </div>
                                                         <div class="col-sm-6">
                                                                        <div class="form-group">
                                                            <div class="col-lg-3 col-md-3 control-label"> <asp:Label ID="Label3" runat="server" Text="Year Of Budget "></asp:Label></div>
                                                            <div class="col-lg-9 col-md-8">
                                                               
                                                                 <asp:DropDownList ID="DropDownList2" runat="server" class="txt" Width="200px"></asp:DropDownList>
                                                            </div>
                                                        </div>
                                 </div>
                                   </div>
                                  
                                 </div>
                              
                                </div>
                                <br />
                                 <div class="row">
                                   <div class="col-sm-12">
                                   
                                    
                                
                              </div>
                                 </div>
                                 <br /><div class="row">
                                 <div class="col-sm-12">
                                      <div class="form-group">
                                      <div class="col-sm-6">
                                                            <div class="col-lg-3 col-md-3 control-label"> <asp:Label ID="Label5" runat="server" Text="Budget Code"></asp:Label></div>
                                                            <div class="col-lg-9 col-md-8">
                                                           
                                                          <asp:DropDownList ID="DropDownList3" runat="server" class="txt" Width="200px"></asp:DropDownList>
                                                               
                                                              </div>
                                                            </div>
                                                           <div class="col-sm-6">
                                                              
                                                            
                                                            </div>
                                                            <div class="col-sm-6">
                                                            <div class="col-lg-3 col-md-3 control-label"> </div>
                                                            <div class="col-lg-9 col-md-8">
                                                              <asp:TextBox ID="txtval1" runat="server" class="txt" Width="200px"></asp:TextBox>
                                                              </div>
                                                            </div>
                                                        </div>
                                                          
                                 </div>
                                           
                                 </div>
                                  <br /><div class="row">
                                 <div class="col-sm-6">
                                      <div class="form-group">
                                                            <div class="col-lg-3 col-md-3 control-label"> <asp:Label ID="Label2" runat="server" Text="Budget Description"></asp:Label></div>
                                                            <div class="col-lg-9 col-md-8">
                                                               <asp:TextBox ID="txtval2" runat="server" class="txt" Width="880px"></asp:TextBox>
                                                     
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
    </div>
    </form>
</body>
</html>

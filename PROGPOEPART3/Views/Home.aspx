<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PROGPOEPART3.Views.Home.Home" %>


<!DOCTYPE html>

<html>
<head>
    <title></title>
    <style>
        div.gallery {
  margin: 1px;
  border: 1px solid #ccc;
  float: left;
  width: 200px;
  margin-left: 140px;
}

div.gallery:hover {
  border: 1px solid #777;
}

div.gallery img {
  width: 100%;
  height: 207px;
            margin-left: 1px;
        }

div.desc {
  padding: 15px;
  text-align: center;
}
ul {
                    list-style-type: none;
                    margin: 0;
                    padding: 0;
                    overflow: hidden;
                    background-color:blue;
                }

                li {
                    float: left;
                }
              li a {
                display: block;
                color: white;
                text-align: center;
                padding: 14px 16px;
                text-decoration: none;
                width: 100px;
                height: 24px;
                margin-left: 35px;
                
            }
    </style>
</head>
<body>
     <ul>
                    <li><a href="Home.aspx">Home</a></li>
                    <li><a href="Modules.aspx">MODULES</a></li>
                     <li><a href="ManageModules.aspx">MANAGE</a></li>
                    <li><a href="Reminder.aspx">REMINDER</a></li>
                     <li style="float:right"><a class="active" href="../Login.aspx">LOGOUT</a></li>
</ul>
    <br /><br /><br /><br /><br /><br />
    <form id="form1">

        <div style="height: 492px"><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
            <div class="gallery"><
  <a target="_blank" href="img_5terre.jpg">
    <img src="../Images/e-learning-g567887ba4_1920.jpg" alt="Cinque Terre" width="600" height="400">
  </a>
  
</div>

<div class="gallery">
  <a target="_blank" href="img_forest.jpg">
    <img src="../Images/student-gb1688b64c_1280.jpg" alt="Forest" width="600" height="400">
  </a>
  
</div>

<div class="gallery">
  <a target="_blank" href="img_lights.jpg">
    <img src="../Images/adult-education-g1b6c38e8c_1920.jpg" alt="Northern Lights" width="600" height="400">
  </a>
 
</div>

<div class="gallery">
  <a target="_blank" href="img_mountains.jpg">
    <img src="../Images/laptop-g68330a677_1280.jpg" alt="Mountains" width="600" height="400">
  </a>
  
</div>
        </div>
    </form>
</body>
</html>
    

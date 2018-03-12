﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="~/Register.aspx.cs" Inherits="RegistryProject.Register" %>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">

  <title></title>

  <!-- Stylesheets -->
  <link rel="stylesheet" href="Register.css">

  <!--Google Fonts-->
  <link href='https://fonts.googleapis.com/css?family=Playfair+Display' rel='stylesheet' type='text/css'>
  <link href='https://fonts.googleapis.com/css?family=Lato:400,700' rel='stylesheet' type='text/css'>

</head>

<body >
<div id="main-wrapper">

  <div class="container-fluid">
    <div class="row">
      <div class="col-md-6 left-side">
        <header>
          <h3>Web Tool For<br>Registry</h3>
            <br />
          <span>You need to sign in to access the Registry Portal</span>
            <span>If not registered , createa new Account</span>

        </header>
      </div>
      <div class="col-md-6 right-side" >
          <h3 style="font-family:'Comic Sans MS';font-size:xx-large;color:blue">Register Below</h3>
        <form id="form1" runat="server" >
                    <span class="input input--hoshi">
            <asp:TextBox runat="server" ID="RegName" CssClass="input__field input__field--hoshi" Placeholder="Full Name" TextMode="SingleLine" Font-Bold="true" Font-Size="Medium" ForeColor="Tomato"></asp:TextBox>
            <label class="input__label input__label--hoshi input__label--hoshi-color-3" for="name">
                 <span class="input__label-content input__label-content--hoshi"></span>                
          </label>
        </span>
        <span class="input input--hoshi">
            <asp:TextBox runat="server" ID="RegEmail" CssClass="input__field input__field--hoshi" Placeholder="Email" TextMode="Email" Font-Bold="true" Font-Size="Medium" ForeColor="SlateGray"></asp:TextBox>
            <label class="input__label input__label--hoshi input__label--hoshi-color-3" for="name">
                 <span class="input__label-content input__label-content--hoshi"></span>                
          </label>
        </span>
        <span class="input input--hoshi">
            <asp:TextBox runat="server" ID="RegUname" CssClass="input__field input__field--hoshi" Placeholder="Username" TextMode="SingleLine" Font-Bold="true" Font-Size="Medium" ForeColor="SlateGray"></asp:TextBox>
            <label class="input__label input__label--hoshi input__label--hoshi-color-3" for="name">
                 <span class="input__label-content input__label-content--hoshi"></span>                
          </label>
        </span>
        <span class="input input--hoshi">
            <asp:TextBox runat="server" ID="RegPass" CssClass="input__field input__field--hoshi" Placeholder="Password" TextMode="SingleLine" Font-Bold="true" Font-Size="Medium" ForeColor="SlateGray"></asp:TextBox>
            <label class="input__label input__label--hoshi input__label--hoshi-color-3" for="name">
                 <span class="input__label-content input__label-content--hoshi"></span>                
          </label>
        </span>
        <span class="input input--hoshi">
            <asp:TextBox runat="server" ID="RegPass2" CssClass="input__field input__field--hoshi" Placeholder="Confirm Password" TextMode="SingleLine" Font-Bold="true" Font-Size="Medium" ForeColor="SlateGray"></asp:TextBox>
            <label class="input__label input__label--hoshi input__label--hoshi-color-3" for="name">
                 <span class="input__label-content input__label-content--hoshi"></span>                
          </label>
        </span>

<!--        <span class="input input--hoshi">
          <input class="input__field input__field--hoshi" type="password" id="password1" />
          <label class="input__label input__label--hoshi input__label--hoshi-color-3" for="password1">
            <span class="input__label-content input__label-content--hoshi">Repeat Passowrd</span>
          </label>
        </span>
 -->
                   <div class="cta">
          <asp:Button runat="server" class="btn btn-primary pull-left" Text="Sign-up Now" OnClick="Reg_Click" />
                       <span><a href="Login.aspx">I am already a member
                       </a></span>
<!--                       <asp:Label ID="haha" Text="here's what you got" runat="server"></asp:Label>
 -->       </div>
          </form>
          </div>
      </div>
    </>
  </div>

</div> <!-- end #main-wrapper -->

<!-- Scripts -->
<script src="//ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
<script src="js/scripts.js"></script>
<script src="js/classie.js"></script>
<script>
  (function() {
    // trim polyfill : https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/String/Trim
    if (!String.prototype.trim) {
      (function() {
        // Make sure we trim BOM and NBSP
        var rtrim = /^[\s\uFEFF\xA0]+|[\s\uFEFF\xA0]+$/g;
        String.prototype.trim = function() {
          return this.replace(rtrim, '');
        };
      })();
    }

    [].slice.call( document.querySelectorAll( 'input.input__field' ) ).forEach( function( inputEl ) {
      // in case the input is already filled..
      if( inputEl.value.trim() !== '' ) {
        classie.add( inputEl.parentNode, 'input--filled' );
      }

      // events:
      inputEl.addEventListener( 'focus', onInputFocus );
      inputEl.addEventListener( 'blur', onInputBlur );
    } );

    function onInputFocus( ev ) {
      classie.add( ev.target.parentNode, 'input--filled' );
    }

    function onInputBlur( ev ) {
      if( ev.target.value.trim() === '' ) {
        classie.remove( ev.target.parentNode, 'input--filled' );
      }
    }
  })();
</script>

</body>
</html>

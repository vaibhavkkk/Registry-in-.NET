<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="RegistryProject.Home" %>

<!DOCTYPE HTML>
<html>
	<head runat="server">
		<title>Hyperspace by HTML5 UP</title>
		<meta charset="utf-8" />
		<meta name="viewport" content="width=device-width, initial-scale=1" />
		<link rel="stylesheet" href="assets/css/main.css" />
	</head>
	<body>
		<!-- Sidebar -->
			<section id="sidebar">
				<div class="inner">
                    <asp:Label runat="server" Font-Bold="true" Font-Italic="true" Font-Size="Large" ForeColor="SeaGreen" Text="WELCOME" ID="Welcome"></asp:Label>
                    <asp:Label runat="server" Font-Bold="true" Font-Italic="true" Font-Size="Large" ForeColor="SeaGreen" Text="" ID="HomeName"></asp:Label>
                    <br />
                    <asp:Label runat="server" Text="" ID="Email"></asp:Label>          
                    
					<nav>
						<ul>
							<li><a href="#intro">Welcome</a></li>
							<li><a href="#one">Registered Users Forum</a></li>
							<li><a href="#two">Create,Delete RegistryKey , Subkeys</a></li>
							<li><a href="#three">View keys tree structure</a></li>
						</ul>
					</nav>
				</div>
			</section>

		<!-- Wrapper -->
			<div id="wrapper">
				<!-- Intro -->
					<section id="intro" class="wrapper style1 fullscreen fade-up">
						<div class="inner" >
							<h1>Registry Portal</h1>
							<p>Microsoft .Net enables you to access the Windows Registry programmatically to store and retrieve data. The Windows Registry is a hierarchical database that comprises of a collection of Keys, Sub Keys, Predefined Keys, Hives, and Value Entries and can be used to store system specific or application specific data. The MSDN states: "The registry acts as a central repository of information for the operating system and the applications on a computer.</p>
                            <hr />
                            <p>You can take advantage of the Windows Registry to store configuration metadata of your applications so that you can retrieve them at a later point of time if need be.</p>
                            <h3>This Portal gives you the right place for these stated functionalities</h3>
   							<ul class="actions">
								<li><a href="#two" class="button scrolly">Learn more</a></li>
							</ul>
						</div>
					</section>
				<!-- One -->
					<section id="one" class="wrapper style2 spotlights">
						<section>
<!--							<a href="#" class="image"><img src="images/pic01.jpg" alt=""  /></a> -->
						<div class="content">
								<div class="inner">
									<h2>USER PORTAL</h2>
                                        <asp:Label runat="server" ID="AAAA">Enter the Registry key and value</asp:Label>
									<h2>AVAILABLE FUNCTIONALITIES<a class="image" href="assets/css/images/intro.svg"><img src="images/registry.jpg" alt="" data-position="top center" /></a></h2>
                                    <h4>1. Create Registry Keys</h4>
                                    <h4>2. Access Registry keys</h4>
                                    <h4>3. Delete Subkeys</h4>
                                    <h4>4. Modify Subkeys</h4>
                                    
									<ul class="actions">
										<li><a href="#" class="button">Learn more</a></li>
									</ul>
								</div>
							</div>
						</section>
						<!--<section>
							&nbsp;<div class="content">
								<div class="inner">
									<h2>Feugiat consequat</h2>
									<p>Phasellus convallis elit id ullamcorper pulvinar. Duis aliquam turpis mauris, eu ultricies erat malesuada quis. Aliquam dapibus.</p>
									<ul class="actions">
										<li><a href="#" class="button">Learn more</a></li>
									</ul>
								</div>
							</div>
                            
						</section>
						<section>
							<a href="#" class="image"><img src="images/pic03.jpg" alt="" data-position="25% 25%" /></a>
							<div class="content">
								<div class="inner">
									<h2>Ultricies aliquam</h2>
									<p>Phasellus convallis elit id ullamcorper pulvinar. Duis aliquam turpis mauris, eu ultricies erat malesuada quis. Aliquam dapibus.</p>
									<ul class="actions">
										<li><a href="#" class="button">Learn more</a></li>
									</ul>
								</div>
							</div>
                            
						</section>-->
					</section>

				<!-- Two   icon major fa-code -->
				<section id="two" class="wrapper style2 spotlights">
						<section>
<!--							<a href="#" class="image"><img src="images/pic01.jpg" alt=""  /></a> -->
						<div class="content">
								<div class="inner">
							<h2>REGISTRY PLATFORM</h2>
							<p>This platform allows you to Access, Create, Delete or Modify registry keys</p>
							<div class="features">
									<span class=""></span>
                                
                                    <form runat="server">
										<asp:Button runat="server" ID="GOTO" OnClick="GOTO_Click" Text="Go to Registry PLatform"></asp:Button>
									</form>

                                    
								</div>
							</div>
                            </div>
						</section>	
                    </section>
                <section id="one" class="wrapper style2 fade-up">
						<!--<div class="inner">-->
							<div class="features">
								<section>
									<span class=""></span>
                                    
								</section>
								<section>
									<span class="icon major fa-lock"></span>
									<h3>Registry</h3>
									<p>Registry keys are the base unit of organization in the registry; they can be compared to folders in Windows Explorer</p>
								</section>
								<!--<section>
									<span class="icon major fa-cog"></span>
									<h3>Sed erat ullam corper</h3>
									<p>Phasellus convallis elit id ullam corper amet et pulvinar. Duis aliquam turpis mauris, sed ultricies erat dapibus.</p>
								</section>
								<section>
									<span class="icon major fa-desktop"></span>
									<h3>Veroeros quis lorem</h3>
									<p>Phasellus convallis elit id ullam corper amet et pulvinar. Duis aliquam turpis mauris, sed ultricies erat dapibus.</p>
								</section>
								<section>
									<span class="icon major fa-chain"></span>
									<h3>Urna quis bibendum</h3>
									<p>Phasellus convallis elit id ullam corper amet et pulvinar. Duis aliquam turpis mauris, sed ultricies erat dapibus.</p>
								</section>
								<section>
									<span class="icon major fa-diamond"></span>
									<h3>Aliquam urna dapibus</h3>
									<p>Phasellus convallis elit id ullam corper amet et pulvinar. Duis aliquam turpis mauris, sed ultricies erat dapibus.</p>
								</section>-->
							</div>
							<ul class="actions">
								<li><a href="#" class="button">Learn more</a></li>
							</ul>
<!--						</div> -->
					</section>

				<!-- Three -->
					<section id="three" class="wrapper style1 fade-up">
						<div class="inner">
							<h2>Get in touch</h2>
							<p>Contact the develpment support for any details.</p>
							<div class="split style1">
								<section>
									<!--<form method="post" action="#">-->
										<div class="field half first">
											<label for="name">Name</label>
											<input type="text" name="name" id="name" />
										</div>
										<div class="field half">
											<label for="email">Email</label>
											<input type="text" name="email" id="email" />
										</div>
										<div class="field">
											<label for="message">Message</label>
											<textarea name="message" id="message" rows="5"></textarea>
										</div>
										<ul class="actions">
											<li><a href="#two" class="button submit">Send Message</a></li>
										</ul>
<!--									</form>-->
								</section>
								<section>
									<ul class="contact">
										<li>
											<h3>Developers</h3>
											<span>Vaibhav Kakkar<br />
											Saurav Bhattcharya<br />
											Nishant Patel</span>
										</li>
										<li>
											<h3>Email</h3>
											<a href="#">user@vit.ac.in</a>
										</li>
										<li>
											<h3>Phone</h3>
											<span>(979) 004-1030</span>
										</li>
										<li>
											<h3>Social</h3>
											<ul class="icons">
												<li><a href="#" class="fa-twitter"><span class="label">Twitter</span></a></li>
												<li><a href="#" class="fa-facebook"><span class="label">Facebook</span></a></li>
												<li><a href="#" class="fa-github"><span class="label">GitHub</span></a></li>
												<li><a href="#" class="fa-instagram"><span class="label">Instagram</span></a></li>
												<li><a href="#" class="fa-linkedin"><span class="label">LinkedIn</span></a></li>
											</ul>
										</li>
									</ul>
								</section>
							</div>
						</div>
					</section>

			</div>

		<!-- Footer -->
			<footer id="footer" class="wrapper style1-alt">
				<div class="inner">
					<ul class="menu">
						<li>&copy; Untitled. All rights reserved.</li><li>Design: <a href="http://html5up.net">VIT</a></li>
					</ul>
				</div>
			</footer>

		<!-- Scripts -->
			<script src="assets/js/jquery.min.js"></script>
			<script src="assets/js/jquery.scrollex.min.js"></script>
			<script src="assets/js/jquery.scrolly.min.js"></script>
			<script src="assets/js/skel.min.js"></script>
			<script src="assets/js/util.js"></script>
			<!--[if lte IE 8]><script src="assets/js/ie/respond.min.js"></script><![endif]-->
			<script src="assets/js/main.js"></script>

	</body>
</html>
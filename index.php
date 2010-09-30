<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>NextBus WEB</title>
    <link rel="stylesheet" href="style.css" />
    <META HTTP-EQUIV="Refresh" CONTENT="60">
</head>
<body>
    <div class="container">
        <div class="main">
            <div class="header">
                <h1 style="cursor: pointer;" onClick="location.href='index.php';">
                    <span style="font-family: helvetica;">NextBus Departures</span></h1>
                <br />
            </div>
            <span style="font-weight: normal; padding: 7px 7px 5px 7px; background-color: #2E2E2E; font-size: 36px; color: #636363;">
                    <?php echo date("l, F j, g:i a", time() + (3 * 60 * 60)); ?></span>
            <div class="content">
                <?php include "execute.php"; ?>
            </div>
            <span style="font-weight: normal; padding: 7px 7px 5px 7px; background-color: #2E2E2E; font-size: 36px; color: #636363;">
                Click <a href='configure.php'>here</a> to configure your stops.
            </span>
			<br />
			<br />
			<br />
			<br />
            <div class="footer">
                Copyright &copy 2010 <a target="_blank" href="http://mbmccormick.com/">Matt McCormick</a>. All rights reserved.
            </div>
        </div>
    </div>
	<script type="text/javascript">
                function toggleBox(element)
                {
                        if (element.style.display != "none")
                          element.style.display = "none";
                        else
                          element.style.display = "";
                }
	
		function blinkOn()
		{
			var elements = document.getElementsByName("blink");
			for(var i = 0; i < elements.length; i++)
			{
				elements[i].style.color = "#DE1830";
			}
			
			setTimeout("blinkOff()", 1000);
		}
		
		function blinkOff()
		{
			var elements = document.getElementsByName("blink");
			for(var i = 0; i < elements.length; i++)
			{
				elements[i].style.color = "#734B4F";
			}
			
			setTimeout("blinkOn()", 1000);
		}
	
		blinkOn();
		
	</script>
</body>
</html>

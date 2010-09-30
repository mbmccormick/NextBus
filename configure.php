<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>NextBus WEB</title>
    <link rel="stylesheet" href="style.css" />
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
				<div class="stop">
					<table cellpadding="0" cellspacing="0">
						<tr class="green">
							<td>
								Choose from the following configuration options.
							</td>
						</tr>
						<tr class="green">
							<td>
								Add a stop by QuickCode ("BUS###"). A full list can be found <a href="http://www.gocitybus.com/stops/" target="_blank">here</a>, on the CityBus MyRide website.
							</td>
						</tr>
					</table>
				</div>
				<div class="stop">
					<table cellpadding="0" cellspacing="0">
						<tr class="green">
							<td>
								<form action="stops_add.php" method="post" style="display: inline;">
									QuickCode: <input type='text' name='stop' /> <input type='submit' value='Add' />
								</form>
							</td>
						</tr>
					</table>
				</div>
            </div>
			<span style="font-weight: normal; padding: 7px 7px 5px 7px; background-color: #2E2E2E; font-size: 36px; color: #636363;">
                Click <a href="reset.php">here</a> to remove your current stops.
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
</body>
</html>

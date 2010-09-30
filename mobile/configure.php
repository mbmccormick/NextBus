<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>NextBus MOBILE</title>
    <link rel="stylesheet" href="mobile.css" />
    <meta name="viewport" content="width=device-width; initial-scale=1.0; maximum-scale=1.0; user-scalable=no;">
</head>
<body>
    <h3><span style="font-family: helvetica;">NEXTBUS DEPARTURES</span></h3><br />
    <div class="content">
        <p>Choose from the following configuration options.</p>
        <p>Add a stop by QuickCode ("BUS###").</p>
        <form action="stops_add.php" method="post">
            <input type="text" name="stop" />&nbsp;<input type="submit" value="Add" />
        </form>
        <br />
        Click <a href="../reset.php">here</a> to remove your current stops.
    </div>
    <br />
    <br />
    <p><span style="font-family: helvetica;">Copyright &copy; 2010 <a target="_blank" href="http://www.mccormicktechnologies.com/">McCormick Technologies LLC</a>. All rights reserved.</span></p>
</body>
</html>

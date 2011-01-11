<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>NextBus WEB</title>
    <link rel="stylesheet" href="style.css" />
    <META HTTP-EQUIV="Refresh" CONTENT="60">
</head>
<body>
    <div class="page">
        <div class="board">
            <h1 onclick="location.href = location.href;">
                <table cellpadding="0" cellspacing="0" style="width: 100%;">
                    <tr valign="middle">
                        <td><img src="logo.png" /></td>
                        <td align="left" style="width: 100%; padding-top: 2px; padding-left: 10px;">NextBus Departures</td>
                    </tr>
                </table>
            </h1>
            <div class="legend">
                <span class="route">Route</span>
                <span class="name">Name</span>
                <span class="departure">Departure</span>
            </div>
            <ul>
                <?php
                
                    $data = simplexml_load_file("http://myride.gocitybus.com/widget/Default1.aspx?pt=30&code=" . $_GET[stop]);
                        
                    if ($data->Bus != null)
                    {
                        foreach ($data->Bus as $t)
                        {
                            $currtime = time() + (3 * 60 * 60);
                            $arritime = $currtime + (trim(str_replace("min", "", $t->TimeTillArrival)) * 60);
                            $diffmins = ($arritime - $currtime) / 60;
                            
                            echo "<li class='bus'>\n";
                            echo "<h2>\n";
                            
                            $route = explode(" ", $t->RouteName);
                            $route = $route[0];
                            
                            $name = str_replace($route, "", $t->RouteName);
                            
                            $route = str_replace("-", "", $route);
                            $route = substr($route, 0, 3);
                            
                            if ($diffmins <= 1)
                                $departure = "Departing";
                            else if ($diffmins < 20)
                                $departure = floor($diffmins) . " minutes";
                            else
                                $departure = "En Route";
                            
                            echo "<span class='route'><span class='strikethrough'></span><strong>" . $route . "</strong></span>\n";
                            echo "<span class='name'><span class='strikethrough'></span><strong>" . $name . "</strong></span>\n";
                            if ($diffmins <= 7)
                                echo "<span class='departure red glow'><span class='strikethrough'></span><strong>" . $departure . "</strong></span>\n";
                            elseif ($diffmins <= 15)
                                echo "<span class='departure yellow'><span class='strikethrough'></span><strong>" . $departure . "</strong></span>\n";
                            elseif ($diffmins < 20)
                                echo "<span class='departure green'><span class='strikethrough'></span><strong>" . $departure . "</strong></span>\n";
                            else
                                echo "<span class='departure'><span class='strikethrough'></span><strong>" . $departure . "</strong></span>\n";
                            echo "</h2>\n";
                            echo "</li>\n";
                        }
                    }
                
                ?>
            </ul>
        </div>
        <div class="footer">
            Copyright &copy; 2011 <a target="_blank" href="http://www.mccormicktechnologies.com/" style="text-decoration: none;">McCormick Technologies LLC</a>. All rights reserved.
        </div>
    </div>
</body>
</html>

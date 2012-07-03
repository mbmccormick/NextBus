<!DOCTYPE html>
<html>
<head>
    <title>NextBus WEB</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0" />
    <link rel="stylesheet" href="css/style.css" />
    <script type="text/javascript" src="js/jquery.js"></script>
    <script type="text/javascript" src="js/jquery.tipsy.js"></script>
    <meta http-equiv="refresh" content="60">
    <script type="text/javascript">
    
        var _gaq = _gaq || [];
        _gaq.push(['_setAccount', 'UA-6872595-11']);
        _gaq.push(['_trackPageview']);

        (function() {
            var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
            ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
            var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
        })();
      
        $(document).ready(function() {
            $(".tooltip").tipsy({gravity: "n"});

            if (navigator.geolocation)
                navigator.geolocation.getCurrentPosition(onPositionUpdate);
            else
                alert("Location Service not available.");
        });

        function changeStop()
        {
            var stop = prompt("Please enter your bus stop code:");
            if (stop != null)
                location.href = "http://apps.mbmccormick.com/nextbuslaf/?stop=" + stop;
        }
        
        function onPositionUpdate(position)
        {
            var lat = position.coords.latitude;
            var lon = position.coords.longitude;
          
            $.getJSON("http://www.onetransitapi.com/v1/stops/getListByLocation?key=04a935ed-3d58-4310-8a37-3e497edfc051&agency=citybus&lat=" + lat + "&lon=" + lon + "&radius=500", function(data) {
                window.location = "http://apps.mbmccormick.com/nextbuslaf/index2.php?stop=" + data.GetStopsByLocationResult[0].Code;
            });
        }
        
    </script>
</head>
<body>
    <?php
    
        if (isset($_GET[stop]) == true)
        {
            $data = simplexml_load_file("http://myride.gocitybus.com/widget/Default1.aspx?pt=30&code=" . $_GET[stop]);
            $stopCode = $_GET[stop];
        }
        else
        {
            $data = simplexml_load_file("http://myride.gocitybus.com/widget/Default1.aspx?pt=30&code=BUS271");
            $stopCode = "BUS271";
        }
        
        $stopName = $data[name];
        if ($stopName != "") 
        {
            $stopName = str_replace("(at Shelter)", "", $stopName);
            $stopName = str_replace("(@ Shelter)", "", $stopName);
            $stopName = str_replace("(Shelter)", "", $stopName);
            $stopName = str_replace("- " . strtoupper($stopCode), "", $stopName);
            $stopName = trim($stopName);
        }
        else 
        {
            $stopName = "N/A (" . $stopCode . ")";
        }
        
    ?>
    <div class="page">
        <div class="board">
            <div class="header">
                <a class="tooltip" onClick="changeStop();" style="cursor: pointer;" title="Click here to change your bus stop."><?php echo $stopName; ?></a>
                <p>Powered by OneTransitAPI</p>
            </div>
            <table style="width: 100%; padding: 0px 15px;" cellpadding="0" cellspacing="0">
                <thead>
                    <tr>
                        <th class="route">Route</th>
                        <th class="name">Name</th>
                        <th class="departure">Departure</th>
                    </tr>
                </thead>
                <tbody>
                    <?php
                    
                        $count = 0;
                        
                        if ($data != null)
                        {
                            foreach ($data->Bus as $t)
                            {
                                $currtime = time() + (3 * 60 * 60);
                                $arritime = $currtime + (trim(str_replace("min", "", $t->TimeTillArrival)) * 60);
                                $diffmins = ($arritime - $currtime) / 60;
                                
                                echo "<tr>\n";
                                
                                $route = explode(" ", $t->RouteName);
                                $route = $route[0];
                                
                                $name = str_replace($route, "", $t->RouteName);
                                
                                $route = str_replace("-", "", $route);
                                $route = substr($route, 0, 3);
                                
                                if ($diffmins < 1)
                                    $departure = "Departing";
                                else if ($diffmins == 1)
                                    $departure = "1 min";
                                else if ($diffmins < 20)
                                    $departure = floor($diffmins) . " mins";
                                else
                                    $departure = date("g:i A", $arritime);
                                
                                // route number
                                echo "<td class='route'><span class='strikethrough'></span><strong>" . $route . "</strong></td>\n";
                                
                                // route name
                                echo "<td class='name'><span class='strikethrough'></span><strong>" . $name . "</strong></td>\n";
                                
                                // departure time
                                if ($diffmins <= 5)
                                    echo "<td class='departure red glow'><span class='strikethrough'></span><strong>" . $departure . "</strong></td>\n";
                                else if ($diffmins <= 10)
                                    echo "<td class='departure yellow'><span class='strikethrough'></span><strong>" . $departure . "</strong></td>\n";
                                else if ($diffmins < 20)
                                    echo "<td class='departure green'><span class='strikethrough'></span><strong>" . $departure . "</strong></td>\n";
                                else
                                    echo "<td class='departure'><span class='strikethrough'></span><strong>" . $departure . "</strong></td>\n";
                                
                                echo "</tr>\n";
                                
                                $count++;
                            }
                        }
                        
                        if ($count == 0)
                        {
                            if ($data == null)
                            {
                                echo "<tr>\n";
                                echo "<td class='route'><span class='strikethrough'></span><strong>N/A</strong></td>\n";
                                echo "<td class='name'><span class='strikethrough'></span><strong>Information not available.</strong></td>\n";
                                echo "<td class='departure'><span class='strikethrough'></span><strong>N/A</strong></td>\n";
                                echo "</tr>\n";
                            }
                            else if ($data[name] == "")
                            {
                                echo "<tr>\n";
                                echo "<td class='route'><span class='strikethrough'></span><strong>N/A</strong></td>\n";
                                echo "<td class='name'><span class='strikethrough'></span><strong>Invalid bus stop code.</strong></td>\n";
                                echo "<td class='departure'><span class='strikethrough'></span><strong>N/A</strong></td>\n";
                                echo "</tr>\n";
                            }
                            else
                            {
                                echo "<tr>\n";
                                echo "<td class='route'><span class='strikethrough'></span><strong>N/A</strong></td>\n";
                                echo "<td class='name'><span class='strikethrough'></span><strong>No departures scheduled.</strong></td>\n";
                                echo "<td class='departure'><span class='strikethrough'></span><strong>N/A</strong></td>\n";
                                echo "</tr>\n";
                            }
                        }
                    
                    ?>
                </tbody>
            </table>
        </div>
    </div>
</body>
</html>

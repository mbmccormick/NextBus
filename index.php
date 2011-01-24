<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>NextBus WEB</title>
    <link rel="stylesheet" href="/css/style.css" />
    <script type="text/javascript" src="/js/jquery.js"></script>
    <script type="text/javascript" src="/js/jquery.tipsy.js"></script>
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
            $stopName = "N/A";
        }
        
    ?>
    <div class="page">
        <div class="board">
            <div class="header">
                <table cellpadding="0" cellspacing="0" style="width: 100%;">
                    <tr valign="middle">
                        <td>
                            <img src="/img/logo.png" />
                        </td>
                        <td align="left" style="width: 40%; padding-top: 2px; padding-left: 10px;">
                            <a href="/">NextBus Departures</a><br />
                            <p>Powered by CityBus MyRide</p>
                        </td>
                        <td align="right" style="width: 60%; padding-top: 4px;">
                            <div class="stop">
                                <a class="tooltip" onClick="changeStop();" style="cursor: pointer;" title="Click here to change your bus stop."><?php echo $stopName; ?></a>
                            </div>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="legend">
                <span class="route">Route</span>
                <span class="name">Name</span>
                <span class="departure">Departure</span>
            </div>
            <ul>
                <?php
                
                    $count = 0;
                    
                    if ($data != null)
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
                            
                            if ($diffmins < 1)
                                $departure = "Departing";
                            else if ($diffmins == 1)
                                $departure = "1 min";
                            else if ($diffmins < 20)
                                $departure = floor($diffmins) . " mins";
                            else
                                $departure = date("g:i A", $arritime);;
                            
                            echo "<span class='route'><span class='strikethrough'></span><strong>" . $route . "</strong></span>\n";
                            echo "<span class='name'><span class='strikethrough'></span><strong>" . $name . "</strong></span>\n";
                            if ($diffmins <= 5)
                                echo "<span class='departure red glow'><span class='strikethrough'></span><strong>" . $departure . "</strong></span>\n";
                            else if ($diffmins <= 10)
                                echo "<span class='departure yellow'><span class='strikethrough'></span><strong>" . $departure . "</strong></span>\n";
                            else if ($diffmins < 20)
                                echo "<span class='departure green'><span class='strikethrough'></span><strong>" . $departure . "</strong></span>\n";
                            else
                                echo "<span class='departure'><span class='strikethrough'></span><strong>" . $departure . "</strong></span>\n";
                            echo "</h2>\n";
                            echo "</li>\n";
                            
                            $count++;
                        }
                    }
                    
                    if ($count == 0)
                    {
                        if ($data == null)
                        {
                            echo "<li class='bus'>\n";
                            echo "<h2>\n";
                            echo "<span class='route'><span class='strikethrough'></span><strong>N/A</strong></span>\n";
                            echo "<span class='name'><span class='strikethrough'></span><strong>Information not available.</strong></span>\n";
                            echo "<span class='departure'><span class='strikethrough'></span><strong>N/A</strong></span>\n";
                            echo "</h2>\n";
                            echo "</li>\n";
                        }
                        else if ($data[name] == "")
                        {
                            echo "<li class='bus'>\n";
                            echo "<h2>\n";
                            echo "<span class='route'><span class='strikethrough'></span><strong>N/A</strong></span>\n";
                            echo "<span class='name'><span class='strikethrough'></span><strong>Invalid bus stop QuickCode.</strong></span>\n";
                            echo "<span class='departure'><span class='strikethrough'></span><strong>N/A</strong></span>\n";
                            echo "</h2>\n";
                            echo "</li>\n";
                        }
                        else
                        {
                            echo "<li class='bus'>\n";
                            echo "<h2>\n";
                            echo "<span class='route'><span class='strikethrough'></span><strong>N/A</strong></span>\n";
                            echo "<span class='name'><span class='strikethrough'></span><strong>No departures scheduled.</strong></span>\n";
                            echo "<span class='departure'><span class='strikethrough'></span><strong>N/A</strong></span>\n";
                            echo "</h2>\n";
                            echo "</li>\n";
                        }
                    }
                
                ?>
            </ul>
        </div>
        <div class="footer">
            Also available for <a href="/mobile/">mobile</a> and <a href="http://fusion.google.com/add?source=atgs&moduleurl=http%3A//nextbuslaf.com/gadget/gadget.xml">iGoogle</a>.<br />
            <br />
            Copyright &copy; 2011 <a target="_blank" href="http://www.mccormicktechnologies.com/" style="text-decoration: none;">McCormick Technologies LLC</a>. All rights reserved.
        </div>
    </div>
    <script type="text/javascript">
    
        $(".tooltip").tipsy({gravity: "n"});
        
        function changeStop()
        {
            var stop = prompt("Please enter the QuickCode (BUS###) for your bus stop.");
            if (stop != null)
                location.href = "http://nextbuslaf.com/?stop=" + stop;
        }
    
    </script>
</body>
</html>

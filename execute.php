<?php
            
    if ($_GET["up_dcenable"] == true)
    {
        $stops = explode(",", $_GET["up_dcstops"]);
    }
    else
    {
        $stops = explode(",", $_COOKIE["stops"]);
    }
    
    if ($stops[0] != "")
    {                  
        $max = 99;
        if ($_SERVER["PHP_SELF"] == "/labs/nextbus/gadget/index.php")
        {
            $max = 3;
        }
    
        $index = 0;
        foreach ($stops as $s)
        {     
            $data = simplexml_load_file("http://myride.gocitybus.com/widget/Default1.aspx?pt=30&code=" . trim($s));
            
            echo "<div class='stop'>\n";
            echo "<div class='title' onclick=\"toggleBox(this.parentNode.getElementsByTagName('table')[0]);\">&gt;&gt;&nbsp;";
            echo $data[name];
            echo "</div>\n";
        
            $count = 0;
            if ($data->Bus != null)
            {
				echo "<table cellpadding='0' cellspacing='0' style='width: 100%;'>\n";
                foreach ($data->Bus as $t)
                {
                    if ($count < $max)
                    {
                        $currtime = time() + (3 * 60 * 60);
                        $arritime = $currtime + (trim(str_replace("min", "", $t->TimeTillArrival)) * 60);
                        $diffmins = ($arritime - $currtime) / 60;
                        $realtime = true;
                        
                        if ($diffmins <= 7)
                        {
                            echo "<tr class='red'>\n";
                        }
                        elseif ($diffmins <= 15)
                        {
                            echo "<tr class='yellow'>\n";
                        }
                        else
                        {
                            echo "<tr class='green'>\n";
                        }
                        echo "<td>" . $t->RouteName . "</td>\n";
                        
                        if (floor($diffmins) <= 0)
                        {
                            echo "<td align='right' name='blink'>\n";
                            echo "Departing now";
                        }
                        elseif (floor($diffmins) == 1)
                        {
                            echo "<td align='right' name='blink'>\n";
                            echo floor($diffmins) . " minute";
                        }
			elseif (floor($diffmins) <= 5)
                        {
                            echo "<td align='right' name='blink'>\n";
                            echo floor($diffmins) . " minutes";
                        }
                        else
                        {
                            if ($diffmins > 15)
                            {
				echo "<td align='right'>\n";
                                echo date("g:i A", $arritime);
                            }
                            else
                            {
				echo "<td align='right'>\n";
                                echo floor($diffmins) . " minutes";
                            }
                        }        

                        if ($realtime == false)
                        {
                            echo " (scheduled)";
                        }
                        else
                        {
                            echo "";
                        }
                        
                        echo "</td></tr>\n";
                    }
                    
                    $count++;
                }
				
				echo "</table>\n";
            }
            
            if ($count <= 0)
            {
                echo "<div class='red'>\n";
                echo "There are no departures in the next 2 hours.";
                echo "</div>\n";
            }
            
            echo "</div>";
            $index++;                        
        }                    
    }
    else
    {
        echo "<div class='stop'>";
        echo "You have not configured any stops.";
        echo "</div>";
    }
    
?>

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
            
            echo "<div class='stop'>";
            echo "<div class='title'>&gt;&gt;&nbsp;";
            echo $data[name];
            echo "</div>";
        
            $count = 0;
            if ($data->Bus != null)
            {
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
                            echo "<div class='red'>";
                        }
                        elseif ($diffmins <= 15)
                        {
                            echo "<div class='yellow'>";
                        }
                        else
                        {
                            echo "<div class='green'>";
                        }
                        echo "<b>" . $t->RouteName . "</b>";
                        echo "<br />";                            
                        if (floor($diffmins) <= 0)
                        {
                            echo "Departing now";
                        }
                        elseif (floor($diffmins) == 1)
                        {
                            echo floor($diffmins) . " minute";
                        }
                        else
                        {
                            if ($diffmins > 15)
                            {
                                echo date("g:i A", $arritime);
                            }
                            else
                            {
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
                        
                        echo "</div>";
                    }
                    
                    $count++;
                }
            }
            
            if ($count <= 0)
            {
                echo "<div class='red'>";
                echo "There are no departures in the next 2 hours.";
                echo "</div>";
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

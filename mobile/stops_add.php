<?php

    $expire = time() + (90 * 24 * 60 * 60);
    
    if (isset($_COOKIE["stops"]))
        setcookie("stops", $_COOKIE["stops"] . "," . $_POST["stop"], $expire);
    else
        setcookie("stops", $_POST["stop"], $expire);
        
    header("Location: http://nextbuslaf.com/mobile/");
        
?>

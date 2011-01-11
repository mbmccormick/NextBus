<?php

    $expire = time() - (24 * 60 * 60);
    
    setcookie("stops", null, $expire);
    setcookie("names", null, $expire);

    echo "Your cookies have been reset.";

    header("Location: http://nextbuslaf.com/mobile/");
    
?>

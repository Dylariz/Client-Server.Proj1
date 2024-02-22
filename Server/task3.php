<?php
  
function printDiamond($n) {
    $half = floor($n / 2);
    
    for ($i = 0; $i < $n; $i++) {
        for ($j = 0; $j <= $n; $j++) {
            if ($i <= $half) {
                if ($j == $half - $i || $j == $half + $i) {
                    echo $i + 1 . "  ";
                } else {
                    echo "  ";
                }
            } else {
                if ($j == $half - ($n - $i - 1) || $j == $half + ($n - $i - 1)) {
                    echo $i + 1 . "  ";
                } else {
                    echo "  ";
                }
            }
        }
        echo "\n";
    }
}

   $q = $_REQUEST['a'];
   echo printDiamond($q);
?>
<?php
  
  function diagonalString($n) {
    $result = "";
    
    for ($i = 0; $i < $n; $i++) {
        for ($j = 0; $j <= $i; $j++) {
           $result .= $i + 1;
        }
        $result .= "\n";
    }
    
    return $result;
}

   $q = $_REQUEST['a'];
   echo diagonalString($q);
?>
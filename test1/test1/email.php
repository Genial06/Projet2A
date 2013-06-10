<?php
$TO = "ryad.kacimi@gmail.com";
$subject = "Voici le titre du mail que vous recevrez automatiquement";
$h = "From: " . $TO;
$message = "Voici le message qui sera écrit automatiquement dans le mail que vous recevrez, à chaque fois qu'un visiteur souhaitera vous laisser un message";
while (list($key, $val) = each($HTTP_POST_VARS)) {
$message .= "$key : $val\n";
}
mail($TO, $subject, $message, $h);
header("Location:accuse.html");
?> 

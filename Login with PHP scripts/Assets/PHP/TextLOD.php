<?php
$servername = "localhost";
$username = "aoguser";
$password = "Ramesh@1984";
$dbname = "AOGDatabase";

$MID = $_POST['emailid1'];
$MP = $_POST['pass1'];

$conn = new mysqli($servername, $username, $password, $dbname);

$sql1 = "INSERT INTO `userdatalod`(`userID`, `Pass`, `PlayerStat`, `Score1`, `Score2`) VALUES ('$MID','$MP','1','0','0');";
$conn->query($sql1);
$result = mysqli_query($conn,$sql1);


         if ( $result == true ) {
             echo "Successfully Registered";
         } else
         if($result == false) {
             echo "nope";
         }

$conn->close();

?>


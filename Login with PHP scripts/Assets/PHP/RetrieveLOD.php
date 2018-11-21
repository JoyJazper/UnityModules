<?php
$servername = "localhost";
$username = "aoguser";
$password = "Ramesh@1984";
$dbname = "AOGDatabase";
$MID = $_POST['emailid1'];

$conn = new mysqli($servername, $username, $password, $dbname);

$sql1 = "SELECT * FROM `userdatalod` where `userID` = '$MID';";    

$result = $conn->query($sql1); 

if ( $row = $result->fetch_assoc())
{
   
     echo $row["PlayerStat"]."#".$row["Score1"]."#".$row["Score2"]."#";

}
else
{
  echo "MisMatch";
}


$conn->close(); 

?>
<?php
$servername = "localhost";
$username = "aoguser";
$password = "Ramesh@1984";
$dbname = "AOGDatabase";
$Score1 = $_POST['Score1'];
$Score2 = $_POST['Score2'];
$MID = $_POST['emailid1'];


$conn = new mysqli($servername, $username, $password, $dbname);

$sql1 = "UPDATE `userdatalod` SET `Score1`='$Score1',`Score2`='$Score2' WHERE `userID`='$MID';";


$conn->query($sql1);
$result = mysqli_query($conn,$sql1);
if ( $result) {
      echo "Successfully Updated";
} else {
      echo "Nope";
}



$conn->close();
?>
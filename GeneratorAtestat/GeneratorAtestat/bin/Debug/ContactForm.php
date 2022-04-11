<?php
if (isset($_POST['mail'])) {

    $email_to = "xulescu123@yahoo.com";
    $email_subject = "New form submissions";

    function problem($error)
    {
        echo "We're sorry, but there were error(s) found with the form you submitted. ";
        echo "These errors appear below.<br><br>";
        echo $error . "<br><br>";
        echo "Please go back and fix these errors.<br><br>";
        die();
    }

    if (
        !isset($_POST['nume']) ||
        !isset($_POST['prenume']) ||
        !isset($_POST['mail']) ||
        !isset($_POST['mesaj'])
    ) {
        problem('We're sorry, but there appears to be a problem with the form you submitted.');
    }

    $nume = $_POST['nume'];
    $prenume = $_POST['prenume'];
    $mail = $_POST['mail'];
    $mesaj = $_POST['mesaj'];

    $error_message = "";
    $email_exp = '/^[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$/';

    if (!preg_match($email_exp, $email)) {
        $error_message .= 'The Email address you entered does not appear to be valid.<br>';
    }

    $string_exp = "/^[A-Za-z .'-]+$/";

    if (!preg_match($string_exp, $nume)) {
        $error_message .= 'The Name you entered does not appear to be valid.<br>';
    }

    if (strlen($message) < 2) {
        $error_message .= 'The Message you entered do not appear to be valid.<br>';
    }

    if (strlen($error_message) > 0) {
        problem($error_message);
    }

    $email_message = "Form details below.\n\n";

    function clean_string($string)
    {
        $bad = array("content-type", "bcc:", "to:", "cc:", "href");
        return str_replace($bad, "", $string);
    }

    $email_message .= "Nume: " . clean_string($nume) . "\n";
    $email_message .= "Preume: " . clean_string($prenume) . "\n";
    $email_message .= "Email: " . clean_string($mail) . "\n";
    $email_message .= "Mesaj: " . clean_string($mesaj) . "\n";

    // create email headers
    $headers = 'From: ' . $mail . "\r\n" .
        'Reply-To: ' . $mail . "\r\n" .
        'X-Mailer: PHP/' . phpversion();
    @mail($email_to, $email_subject, $email_message, $headers);
?>

    Thanks for getting in touch. We'll get back to you soon.

<?php
}
?>
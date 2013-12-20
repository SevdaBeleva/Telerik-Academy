<?php
require 'Slim/Slim.php';

\Slim\Slim::registerAutoloader();

$app = new \Slim\Slim();

mysql_connect("localhost", "updatacl_admin", "limona1@");
mysql_select_db("updatacl_db");


/*==========================================*/
/*               GET SERVICES               */
/*==========================================*/

// get all project asosiated with single user 
//TODO add user credentials
$app->get('/getAllProjects/:id', 'getAllProjects');

// get all tracts assosiated to single project
$app->get('/getAllTraks/:id', 'getAllTraks');

// get all tasks assosiated to single track
$app->get('/getAllTrakItems/:id', 'getAllTrakItems');

// get all user on the system
$app->get('/getAllUsers', 'getAllUsers');


/*==========================================*/
/*               POST SERVICES              */
/*==========================================*/

// register single user instance into database system
$app->post('/registerUser','registerUser');

// login single user instance in database system
$app->post('/loginUser','loginUser');

// create new Project entity to the syste stack
$app->post('/addNewProject', 'addNewProject');

// create new track to assine to existing project
$app->put('/addNewTrack/:project_id', 'addNewTrack');

// create new item to assine to existing track
$app->put('/addNewItem/:track_id', 'addNewItem');

/*==========================================*/
/*               GET METHODS
/*==========================================*/

/**
 * 
 */
function getAllProjects($id)
{    
    $getAllData   = mysql_query("SELECT * FROM projects WHERE user_id = $id");

    $rows = array();
    while ($data = mysql_fetch_assoc($getAllData)) {
        $rows[] = $data;
    }
    echo json_encode($rows);
}

/**
 * 
 * @param type $id
 */
function getAllTraks($id)
{    
    $getAllData   = mysql_query("SELECT * FROM tracks WHERE project_id = $id");

    $rows = array();
    while ($data = mysql_fetch_assoc($getAllData)) {
        $rows[] = $data;
    }
    echo json_encode($rows);
}

function getAllTrakItems($id)
{    
    $getAllData  = mysql_query("SELECT * FROM items WHERE track_id = $id");

    $rows = array();
    while ($data = mysql_fetch_assoc($getAllData)) {
        $rows[] = $data;
    }
    echo json_encode($rows);
}

/**
 * 
 */
function getAllUsers(){
    $getAllData  = mysql_query("SELECT * FROM users ");

    $rows = array();
    while ($data = mysql_fetch_assoc($getAllData)) {
        $rows[] = $data;
    }
    echo json_encode($rows);
}

/*==========================================*/
/*               POST METHODS
/*==========================================*/

/**
 *  @SERVICE - USERS
 */

function registerUser()
{
    $request = \Slim\Slim::getInstance()->request();
    $userRequest = json_decode($request->getBody());
    
    $check_user = mysql_query("SELECT * FROM users WHERE username = '$userRequest->username'");
    
    if(mysql_num_rows($check_user) == 0)
    {            
        // Check if user already Exists
        $sql = "INSERT INTO users (username, userpass, fname, lname) VALUES ( '$userRequest->username', '$userRequest->userpass', '$userRequest->fname', '$userRequest->lname')";
        mysql_query($sql);
        
        if(mysql_affected_rows() == 1)
        { 
            $user_id = mysql_insert_id();
        
            echo json_encode('{"statusCode": "200", "statusCode" : "SUCCESFUL_REGISTRATION", "statusMessage" : "User is sucsessfuly Registered", "user_id" : '.$user_id.' }');
        }
        else 
        {
            echo json_encode('{"statusCode": "400", "statusCode" : "GENERAL_ERROR", "statusMessage" : "Some issues are existens"}');
        }
    }
    else
    {
        echo json_encode('{"statusCode": "404", "statusCode" : "ERROR_USER_EXIST","statusMessage" : "User already exists"}');
    }
}

/**
 *   @SERVICE - USER
 */
function loginUser()
{
    $request = \Slim\Slim::getInstance()->request();
    $userRequest = json_decode($request->getBody());
    
    $sql = "SELECT * FROM users WHERE username = '$userRequest->username' AND userpass = '$userRequest->userpass'";
    $request_result = mysql_query($sql);
    
    if(mysql_affected_rows() == 1)
    { 
        $get = mysql_fetch_assoc($request_result);
        $user_id = $get["id"];
        
        echo json_encode('{"statusCode": "200", "statusCode" : "SUCCESSFUL_LOGIN","statusMessage" : "User is sucsessfuly Login", "user_id" : '.$user_id.' }');
    }
    else if(mysql_affected_rows() == 0)
    {
        echo json_encode('{"statusCode": "400", "statusCode" : "ERROR_USER_NOT_EXISTS", "statusMessage" : "User doesnot exist"}');
    }
}

/**
 *   @SERVICE - Project
 */
function addNewProject(){
    $request = \Slim\Slim::getInstance()->request();
    $dataRequest = json_decode($request->getBody());
    
    // Check if user already Exists
    $sql = "INSERT INTO projects (user_id, project_name,  project_description) VALUES ( '$dataRequest->user_id','$dataRequest->project_name', '$dataRequest->project_description')";
    mysql_query($sql);
}


function addNewTrack($project_id){
    
    $request = \Slim\Slim::getInstance()->request();
    $dataRequest = json_decode($request->getBody());
    
    $sql = "INSERT INTO tracks (project_id, track_name) VALUES ( $project_id ,'$dataRequest->track_name')";
    mysql_query($sql);
}

function addNewItem($track_id) {
    $request = \Slim\Slim::getInstance()->request();
    $dataRequest = json_decode($request->getBody());
    
    $sql = "INSERT INTO items (track_id, track_type, item_content) VALUES ( $track_id , 1, '$dataRequest->item_content')";
    mysql_query($sql);
}

$app->run();

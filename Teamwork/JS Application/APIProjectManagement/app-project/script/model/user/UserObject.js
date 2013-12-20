/**
 * ===========================================================
 * 
 * 
 * ===========================================================
 */

/**
 * 
 * @param {type} username
 * @param {type} userpass
 */
function UserObject(username, userpass){
    this.username = username;
    this.userpass = userpass;
    this.isSessionSet = false;
}

/**
 * 
 * @returns {JSON object}
 */
UserObject.prototype.getUserData = function(){
    var userAutentication = {};
    
    userAutentication["username"] = this.username;
    userAutentication["userpass"] = this.userpass;
    
    return JSON.stringify(userAutentication);
};

/**
 * 
 * @returns {undefined}
 */
UserObject.prototype.checkSessionStatus = function(){
   if(this.isSessionSet){
        return true;
   }else{
         return false;
   }
};

/**
 * 
 * @returns {undefined}
 */
UserObject.prototype.setSession = function(){
    this.isSessionSet = true;
    sessionStorage.setItem("userSession", "true");  
};

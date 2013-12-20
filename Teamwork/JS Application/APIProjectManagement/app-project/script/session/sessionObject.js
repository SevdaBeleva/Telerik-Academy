sessionObject = {
    
    // User Session Data Cleanup
    isLogin : function(){
        if(sessionStorage.getItem("login")){
            return true;
        }else{
            return false;
        }   
    },
    login :function(userId){
        sessionStorage.setItem("login", true);
        sessionStorage.setItem("userId", userId);
    },
    logout : function(){
        sessionStorage.clear();
    },
     userId : function(){
        return sessionStorage.getItem("userId");
     },
             
             // Project Data Cleanup
             
                setProject : function(projectId){
                   sessionStorage.setItem("projectSet", true);
                   sessionStorage.setItem("projectId", projectId);
                },
               isProject : function(){
                  if(sessionStorage.getItem("projectSet")){
                      return true;
                  }else{
                      return false;
                  }   
               },

               projectId : function(){
                       return sessionStorage.getItem("projectId");
               },
                       
                       
    setTrack :  function(trackId){
                   sessionStorage.setItem("trackSet", true);
                   sessionStorage.setItem("trackId", trackId);
                },
            isTrack : function(){
      if(sessionStorage.getItem("trackSet")){
          return true;
      }else{
          return false;
      }   
   },

   trackId : function(){
           return sessionStorage.getItem("trackId");
   }
               
               
};
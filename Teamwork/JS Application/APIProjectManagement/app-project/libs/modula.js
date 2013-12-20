/* 
 * A set of helper functions writen for current project
 * This helper function hasnot have consistant nature and
 * solve diferent problems for example Ajax and OOP 
 */

var Modula = {
    
    /**
     * 
     * @param {type} Child
     * @param {type} Parent
     * @returns {undefined}
     */
    extend_object : function (Child, Parent){
        function F(){};
        F.prototype  = Parent.prototype;
        Child.prototype = new F;
        Child.prototype.constructor = Child();
    },
    
    /*==========================================*/
    //             PUB-SUB PATTERN
    /*==========================================*/

    subscribe : function(to,data){
        $(document).trigger(to,data);
    },

    publish : function(from,setFunction){
        $(document).on(from ,setFunction);
    }
};









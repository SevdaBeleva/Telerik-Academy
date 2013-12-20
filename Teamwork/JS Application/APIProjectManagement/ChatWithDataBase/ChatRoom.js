var instanse = false;
var state;
var mes;
var file;
function getUser() {
    var name = prompt("Enter your chat name:", "Guest");

    // default name is 'Guest'
    if (!name || name === ' ') {
        name = "Guest";
    }

    // strip tags
    name = name.replace(/(<([^>]+)>)/ig, "");

    // display name on page
    $("#name-area").html("You are: <span>" + name + "</span>");

    return name;
}


var Class = (function () {
    function createClass(properties) {
        var f = function () {
            //This is an addition to enable super (base) class with inheritance
            if (this._superConstructor) {
                this._super = new this._superConstructor(arguments);
            }
            this.init.apply(this, arguments);
        }
        for (var prop in properties) {
            f.prototype[prop] = properties[prop];
        }
        if (!f.prototype.init) {
            f.prototype.init = function () { }
        }
        return f;
    }

    Function.prototype.inherit = function (parent) {
        var oldPrototype = this.prototype;
        this.prototype = new parent();
        this.prototype._superConstructor = parent;
        for (var prop in oldPrototype) {
            this.prototype[prop] = oldPrototype[prop];
        }
    }

    return {
        create: createClass,
    };
}());

var User = Class.create({
    init: function () {
        this.name = arguments[0];
    }
});

var Post = Class.create({
    init: function () {
        this.text = arguments[0];
        this.user = arguments[1];
    },
    loadPost: function () {
        var element = $('<div></div>');

        var userName = $('<strong></strong>').append(user.name);
        element.append(userName);
        var message = $('<p></p>').append(this.text);
        element.append(message);

    }
});

var ChatRoom = Class.create({
    init: function () {
        var divId = arguments[0];
        var dataBase = arguments[1];
        var info = arguments[2];
        var user = arguments[3];

        this.getState = getStateOfChat;
        this.updateChat = updateChat;
        this.sendChat = sendChat;

        var chat = $('<div id="page-wrap"></div>');

        var menu = $('<div></div>');
        var span = $('<span>' + info + '</span>');
        span.on('click', openChatRoom);
        menu.append(span);
        var close = $('<button id="close">X</button>');
        close.on('click', closeChatRoom);
        menu.append(close);
        chat.append(menu);

        var chatWrap = $('<div id="chat-wrap"></div>');
        var chatArea = $('<div id="chat-area"></div>');
        chatWrap.append(chatArea);
        chat.append(chatWrap);

        var messageArea = $('<form id="send-message-area"><p>Your message: </p></form>');
        var messageText = $('<textarea id="sendie" maxlength = "100"></textarea>');
        messageArea.append(messageText);
        chat.append(messageArea);
        var send = $('<button id="send">Send</button>');
        send.on('click', sendPost);
        messageArea.append(send);

        $('body').append(chat);

        function openChatRoom() {
            $('#chat-area')[0].style.display = '';
        }

        // asks the server are there are new lines in the text file. 
        // If true, it will return them as JSON and then this function 
        // will append those new lines to the chat
        function updateChat() {
            if (!instanse) {
                instanse = true;
                $.ajax({
                    type: "POST",
                    url: "process.php",
                    data: {
                        'function': 'update',
                        'state': state,
                        'file': file
                    },
                    dataType: "json",
                    success: function (data) {
                        if (data.text) {
                            for (var i = 0; i < data.text.length; i++) {
                                $('#chat-area').append($("<p>" + data.text[i] + "</p>"));
                            }
                        }
                        document.getElementById('chat-area').scrollTop = document.getElementById('chat-area').scrollHeight;
                        instanse = false;
                        state = data.state;
                    },
                });
            }
            else {
                setTimeout(updateChat, 1500);
            }
        }

        function closeChatRoom() {
            $('#chat-area')[0].style.display = 'none';
        }

        function sendPost() {
            var message = $("#sendie").val();
            var post = new Post(message, user);
            sendChat(post.text, post.user.name);
        }

        //asks the server basically how many lines the current text file is, 
        //so it has something to compare against and know when lines are new or not. 
        //This information is returned as JSON 
        function getStateOfChat() {
            if (!instanse) {
                instanse = true;
                $.ajax({
                    type: "POST",
                    url: "process.php",
                    data: {
                        'function': 'getState',
                        'file': file
                    },
                    dataType: "json",
                    success: function (data) {
                        state = data.state;
                        instanse = false;
                    },
                });
            }
        }

        //called when a message is entered into the text area and return is pressed. 
        //The function will pass that data to the server
        function sendChat(message, nickname) {
            updateChat();
            $.ajax({
                type: "POST",
                url: "process.php",
                data: {
                    'function': 'send',
                    'message': message,
                    'nickname': nickname,
                    'file': file
                },
                dataType: "json",
                success: function (data) {
                    updateChat();
                },
            });
        }
    }
});


// ask user for name with popup prompt    
var name = getUser();
var user = new User(name);
var chat = new ChatRoom('#page-wrap', 'chat.txt', 'JustTalk', user);

$(function () {
    chat.getState();
    // watch textarea for key presses
    $("#sendie").keydown(function (event) {
        var key = event.which;

        //all keys including return.  
        if (key >= 33) {
            var maxLength = $(this).attr("maxlength");
            var length = this.value.length;

            // don't allow new content if length is maxed out
            if (length >= maxLength) {
                event.preventDefault();
            }
        }
    });

    // watch textarea for release of key press
    $('#sendie').keyup(function (e) {
        if (e.keyCode == 13) {
            var text = $(this).val();
            var maxLength = $(this).attr("maxlength");
            var length = text.length;
            // send 
            if (length <= maxLength + 1) {
                chat.sendChat(text, name);
                $(this).val("");
            } else {
                $(this).val(text.substring(0, maxLength));
            }
        }
    });
});
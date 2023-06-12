'use strict';
var express = require('express');
var router = express.Router(); 
var getData = function () {
    
    var data = {
        'item1': 'https://img.freepik.com/free-photo/purple-osteospermum-daisy-flower_1373-16.jpg?w=2000',
        'item2': 'https://images.unsplash.com/photo-1602491673980-73aa38de027a',
        'item3': 'https://images.unsplash.com/photo-1620173834206-c029bf322dba'
    }
    return data; 
}
/* GET home page. */
router.get('/', function (req, res) {
    res.render('index', { title: 'Express', "data":getData() });
});


module.exports = router;

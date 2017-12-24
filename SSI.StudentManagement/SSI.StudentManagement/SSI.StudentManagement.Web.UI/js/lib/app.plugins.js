$.fn.shake = function(){
    var _self = this;
    _self.removeClass('shake');
    _self.addClass('shake');
    setTimeout(function(){
        _self.removeClass('shake');
    }, 2000);
}
# IdentityServer4是什么？
IdentityServer4是基于ASP.NET Core实现的认证和授权框架，是对OpenID Connect和OAuth 2.0协议的实现。
# OpenID Connect 和 OAuth2.0是什么？
 ### OpenID Connect: 
   OpenID Connect由OpenID基金会于2014年发布的一个开放标准, 是建立在OAuth 2.0协议上的一个简单的身份标识层, OpenID Connect 兼容 OAuth 2.0. 实现身份认证（Authentication）
 ### OAuth2.0:  
   OAuth2.0是一个开放的工业标准的授权协议（Authorization），它允许用户授权让第三方应用直接访问用户在某一个服务中的特定资源，但不提供给第三方账号及密码信息
# Authentication 和 Authorization的区别？
    authentication: n. 证明；鉴定；证实
    authorization: n. 授权，认可；批准，委任
    
前者是身份识别，鉴别你是谁；后者是授权许可，告诉你可以做什么。    
举个例子：你吭哧吭哧写了一天的代码，急于回家吃上一口媳妇做的热饭。当你走到小区门口的时候你需要刷小区的门禁卡才能进入到小区里面，然后再找到你家在哪一栋楼，几单元几号，然后掏出钥匙开门才能回到家。在这个过程中刷小区的门禁就是认证你是这个小区的人，拿你家的钥匙开门就是授权的过程，如果你的认证不通过，那就不存在授权。


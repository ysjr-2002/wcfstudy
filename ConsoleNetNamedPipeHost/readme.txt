netNamedPipeBinding 只适用与单台计算使用，适合超级计算机(服务和应用在同一台计算机，效率最高)

客户端必须为.net平台


基地址不允许带有端口
1.net.pipe://localhost/
2.元数据采用endpoint方式公开  <endpoint address="mex" binding="mexNamedBinding" contract="IMetadtaExchange">
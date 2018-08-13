use master
go

if exists(select * from sysdatabases where name='MyWeb')
begin 
	select '该数据库已存在'
	drop database MyWeb
end
else
begin
	create database	MyWeb
	on primary
	(
		name='myweb',
		filename='D:\VS\SQL\MyWeb\MyWeb.mdf',
		size=5mb,
		maxsize=unlimited,
		filegrowth=10%
	)
	log on
	(
		name='myweb_log',
		filename='D:\VS\SQL\MyWeb\MyWeb_log.ldf',
		size=1mb,
		maxsize=unlimited,
		filegrowth=1mb
	)
end

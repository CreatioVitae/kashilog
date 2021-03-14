use KashiLogDB

DELETE FROM kashi.MstProductTexture
DELETE FROM kashi.MstProductTaste
DELETE FROM kashi.MstProduct;
DELETE FROM kashi.CmnTexture;
DELETE FROM kashi.CmnTaste;
DELETE FROM enterprise.CmnCompany;

DBCC CHECKIDENT ([kashi.MstProductTexture], RESEED, 0);
DBCC CHECKIDENT ([kashi.MstProductTaste], RESEED, 0);
DBCC CHECKIDENT ([kashi.MstProduct], RESEED, 0);
DBCC CHECKIDENT ([kashi.CmnTexture], RESEED, 0);
DBCC CHECKIDENT ([kashi.CmnTaste], RESEED, 0);
DBCC CHECKIDENT ([enterprise.CmnCompany], RESEED, 0);


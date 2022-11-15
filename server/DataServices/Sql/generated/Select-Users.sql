


SELECT "u"."Id", 
  "u"."UserName", 
 "c"."Id", 
 "c"."AppUserId", 
 
 "c"."Name"
      FROM "Users" AS "u"
      LEFT JOIN "Categories" AS "c" ON 
      "u"."Id" = "c"."AppUserId"
      ORDER BY "u"."Id"
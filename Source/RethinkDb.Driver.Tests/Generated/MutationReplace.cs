




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;

namespace RethinkDb.Driver.Test.Generated {
    [TestFixture]
    public class MutationReplace : GeneratedTest {

            public static Table tbl = r.db(DbName).table("tbl");


        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, mutation/replace.yaml, #1
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':100}) */
                 var expected_ = r.hashMap("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 100);
                 
                 /* Original: tbl.insert([{'id':i} for i in xrange(100)]) */
                 var obtained = runOrCatch( tbl.insert(Enumerable.Range(0, 100).Select(i => r.hashMap("id", i)).ToList()) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/replace.yaml, #2
                 /* ExpectedOriginal: 100 */
                 var expected_ = 100;
                 
                 /* Original: tbl.count() */
                 var obtained = runOrCatch( tbl.count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/replace.yaml, #3
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':1,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected_ = r.hashMap("deleted", 0.0).with("replaced", 0.0).with("unchanged", 1).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.get(12).replace(lambda row:{'id':row['id']}) */
                 var obtained = runOrCatch( tbl.get(12).replace(row => r.hashMap("id", row.g("id"))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/replace.yaml, #4
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':1,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected_ = r.hashMap("deleted", 0.0).with("replaced", 1).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.get(12).replace(lambda row:{'id':row['id'], 'a':row['id']}) */
                 var obtained = runOrCatch( tbl.get(12).replace(row => r.hashMap("id", row.g("id")).with("a", row.g("id"))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/replace.yaml, #5
                 /* ExpectedOriginal: ({'deleted':1,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected_ = r.hashMap("deleted", 1).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.get(13).replace(lambda row:null) */
                 var obtained = runOrCatch( tbl.get(13).replace(row => null) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/replace.yaml, #6
                 /* ExpectedOriginal: ({'first_error':'Inserted object must have primary key `id`:\n{\n\t\"a\":\t1\n}','deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':10,'skipped':0.0,'inserted':0.0}) */
                 var expected_ = r.hashMap("first_error", "Inserted object must have primary key `id`:\n{\n\t\"a\":\t1\n}").with("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 10).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.between(10, 20, right_bound='closed').replace(lambda row:{'a':1}) */
                 var obtained = runOrCatch( tbl.between(10, 20).optArg("right_bound", "closed").replace(row => r.hashMap("a", 1)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/replace.yaml, #7
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':8,'unchanged':1,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected_ = r.hashMap("deleted", 0.0).with("replaced", 8).with("unchanged", 1).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.filter(lambda row:(row['id'] >= 10) & (row['id'] < 20)).replace(lambda row:{'id':row['id'], 'a':row['id']}) */
                 var obtained = runOrCatch( tbl.filter(row => row.g("id").ge(10).and(row.g("id").lt(20))).replace(row => r.hashMap("id", row.g("id")).with("a", row.g("id"))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/replace.yaml, #8
                 /* ExpectedOriginal: ({'first_error':"Primary key `id` cannot be changed (`{\n\t\"id\":\t1\n}` -> `{\n\t\"a\":\t1,\n\t\"id\":\t2\n}`).",'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':1,'skipped':0.0,'inserted':0.0}) */
                 var expected_ = r.hashMap("first_error", "Primary key `id` cannot be changed (`{\n\t\"id\":\t1\n}` => `{\n\t\"a\":\t1,\n\t\"id\":\t2\n}`).").with("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 1).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.get(1).replace({'id':2,'a':1}) */
                 var obtained = runOrCatch( tbl.get(1).replace(r.hashMap("id", 2).with("a", 1)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/replace.yaml, #9
                 /* ExpectedOriginal: ({'first_error':"Inserted object must have primary key `id`:\n{\n\t\"a\":\t1\n}",'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':1,'skipped':0.0,'inserted':0.0}) */
                 var expected_ = r.hashMap("first_error", "Inserted object must have primary key `id`:\n{\n\t\"a\":\t1\n}").with("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 1).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.get(1).replace({'a':1}) */
                 var obtained = runOrCatch( tbl.get(1).replace(r.hashMap("a", 1)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/replace.yaml, #16
                 /* ExpectedOriginal: err('ReqlCompileError', 'Unrecognized optional argument `foo`.') */
                 var expected_ = err("ReqlCompileError", "Unrecognized optional argument `foo`.");
                 
                 /* Original: tbl.get(1).replace({}, foo='bar') */
                 var obtained = runOrCatch( tbl.get(1).replace(r.hashMap()).optArg("foo", "bar") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/replace.yaml, #17
                 /* ExpectedOriginal: ({'deleted':99,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected_ = r.hashMap("deleted", 99).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: tbl.replace(lambda row:null) */
                 var obtained = runOrCatch( tbl.replace(row => null) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/replace.yaml, #18
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1;
                 
                 /* Original: tbl.get('sdfjk').replace({'id':'sdfjk'})['inserted'] */
                 var obtained = runOrCatch( tbl.get("sdfjk").replace(r.hashMap("id", "sdfjk")).g("inserted") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/replace.yaml, #19
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1;
                 
                 /* Original: tbl.get('sdfjki').replace({'id':'sdfjk'})['errors'] */
                 var obtained = runOrCatch( tbl.get("sdfjki").replace(r.hashMap("id", "sdfjk")).g("errors") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}

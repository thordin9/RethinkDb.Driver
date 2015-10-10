




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
    public class SindexStatus : GeneratedTest {

            public static Table tbl2 = r.db(DbName).table("tbl2");


        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, sindex/status.yaml, #2
                 /* ExpectedOriginal: ({'created':1}) */
                 var expected_ = r.hashMap("created", 1);
                 
                 /* Original: tbl2.index_create("foo") */
                 var obtained = runOrCatch( tbl2.indexCreate("foo") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, sindex/status.yaml, #3
                 /* ExpectedOriginal: ({'created':1}) */
                 var expected_ = r.hashMap("created", 1);
                 
                 /* Original: tbl2.index_create("bar", multi=True) */
                 var obtained = runOrCatch( tbl2.indexCreate("bar").optArg("multi", true) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, sindex/status.yaml, #4
                 /* ExpectedOriginal: [True, True] */
                 var expected_ = r.array(true, true);
                 
                 /* Original: tbl2.index_status().map(lambda x:x["blocks_processed"] < x["blocks_total"]) */
                 var obtained = runOrCatch( tbl2.indexStatus().map(x => x.g("blocks_processed").lt(x.g("blocks_total"))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, sindex/status.yaml, #5
                 /* ExpectedOriginal: ([true, true]) */
                 var expected_ = r.array(true, true);
                 
                 /* Original: tbl2.index_wait()['ready'] */
                 var obtained = runOrCatch( tbl2.indexWait().g("ready") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, sindex/status.yaml, #6
                 /* ExpectedOriginal: bag([false, false]) */
                 var expected_ = bag(r.array(false, false));
                 
                 /* Original: tbl2.index_wait()['geo'] */
                 var obtained = runOrCatch( tbl2.indexWait().g("geo") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, sindex/status.yaml, #7
                 /* ExpectedOriginal: bag([false, true]) */
                 var expected_ = bag(r.array(false, true));
                 
                 /* Original: tbl2.index_wait()['multi'] */
                 var obtained = runOrCatch( tbl2.indexWait().g("multi") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, sindex/status.yaml, #8
                 /* ExpectedOriginal: ([false, false]) */
                 var expected_ = r.array(false, false);
                 
                 /* Original: tbl2.index_wait()['outdated'] */
                 var obtained = runOrCatch( tbl2.indexWait().g("outdated") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, sindex/status.yaml, #9
                 /* ExpectedOriginal: ({'created':1}) */
                 var expected_ = r.hashMap("created", 1);
                 
                 /* Original: tbl2.index_create("quux") */
                 var obtained = runOrCatch( tbl2.indexCreate("quux") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, sindex/status.yaml, #10
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: tbl2.index_status("quux").do(lambda x:(x[0]["index"] == "quux") & (x[0]["blocks_processed"] < x[0]["blocks_total"])) */
                 var obtained = runOrCatch( tbl2.indexStatus("quux").do_(x => x.nth(0).g("index").eq("quux").and(x.nth(0).g("blocks_processed").lt(x.nth(0).g("blocks_total")))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, sindex/status.yaml, #11
                 /* ExpectedOriginal: ([{'index':'quux', 'ready':true}]) */
                 var expected_ = r.array(r.hashMap("index", "quux").with("ready", true));
                 
                 /* Original: tbl2.index_wait("quux").pluck('index', 'ready') */
                 var obtained = runOrCatch( tbl2.indexWait("quux").pluck("index", "ready") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, sindex/status.yaml, #12
                 /* ExpectedOriginal: ("PTYPE<BINARY>") */
                 var expected_ = "PTYPE<BINARY>";
                 
                 /* Original: tbl2.index_wait("quux").nth(0).get_field('function').type_of() */
                 var obtained = runOrCatch( tbl2.indexWait("quux").nth(0).g("function").typeOf() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}

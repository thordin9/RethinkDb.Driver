




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
using static RethinkDb.Driver.Tests.TestingCommon;

namespace RethinkDb.Driver.Test.Generated {

    // Test named aliases for math and logic operators

    [TestFixture]
    public class MathLogicAliases : GeneratedTest {

        public MathLogicAliases (){
        }




        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #5
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.expr(0).add(1) */
                 var obtained = runOrCatch( r.expr(0L).add(1L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #6
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.add(0, 1) */
                 var obtained = runOrCatch( r.add(0L, 1L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #7
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.expr(2).sub(1) */
                 var obtained = runOrCatch( r.expr(2L).sub(1L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #8
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.sub(2, 1) */
                 var obtained = runOrCatch( r.sub(2L, 1L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #9
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.expr(2).div(2) */
                 var obtained = runOrCatch( r.expr(2L).div(2L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #10
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.div(2, 2) */
                 var obtained = runOrCatch( r.div(2L, 2L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #11
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.expr(1).mul(1) */
                 var obtained = runOrCatch( r.expr(1L).mul(1L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #12
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.mul(1, 1) */
                 var obtained = runOrCatch( r.mul(1L, 1L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #13
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.expr(1).mod(2) */
                 var obtained = runOrCatch( r.expr(1L).mod(2L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #14
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.mod(1, 2) */
                 var obtained = runOrCatch( r.mod(1L, 2L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #25
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.expr(True).and_(True) */
                 var obtained = runOrCatch( r.expr(true).and(true) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #26
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.expr(True).or_(True) */
                 var obtained = runOrCatch( r.expr(true).or(true) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #27
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.and_(True, True) */
                 var obtained = runOrCatch( r.and(true, true) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #28
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.or_(True, True) */
                 var obtained = runOrCatch( r.or(true, true) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #29
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.expr(False).not_() */
                 var obtained = runOrCatch( r.expr(false).not() ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #30
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.not_(False) */
                 var obtained = runOrCatch( r.not(false) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #34
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.expr(1).eq(1) */
                 var obtained = runOrCatch( r.expr(1L).eq(1L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #35
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.expr(1).ne(2) */
                 var obtained = runOrCatch( r.expr(1L).ne(2L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #36
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.expr(1).lt(2) */
                 var obtained = runOrCatch( r.expr(1L).lt(2L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #37
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.expr(1).gt(0) */
                 var obtained = runOrCatch( r.expr(1L).gt(0L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #38
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.expr(1).le(1) */
                 var obtained = runOrCatch( r.expr(1L).le(1L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #39
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.expr(1).ge(1) */
                 var obtained = runOrCatch( r.expr(1L).ge(1L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #40
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.eq(1, 1) */
                 var obtained = runOrCatch( r.eq(1L, 1L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #41
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.ne(1, 2) */
                 var obtained = runOrCatch( r.ne(1L, 2L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #42
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.lt(1, 2) */
                 var obtained = runOrCatch( r.lt(1L, 2L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #43
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.gt(1, 0) */
                 var obtained = runOrCatch( r.gt(1L, 0L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #44
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.le(1, 1) */
                 var obtained = runOrCatch( r.le(1L, 1L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/aliases.yaml, #45
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.ge(1, 1) */
                 var obtained = runOrCatch( r.ge(1L, 1L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             

        }
    }
}

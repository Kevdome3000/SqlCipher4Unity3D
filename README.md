# SqlCipher4Unity3D

## What's this?

 I decided that there should be a simpler way and I created **SqlCipher4Unity3D**, a plugin that helps you to use [libsqlcipher](https://github.com/sqlcipher/sqlcipher/) in your Unity3d projects in a clear and easy way and works in **iOS, Android, OSX, Windows, Android** projects.

- based on
  - [codecoding/SQLite4Unity3d](https://github.com/codecoding/SQLite4Unity3d)
  - [sqlite-net](https://github.com/praeclarum/sqlite-net)

## prebuilt library

- prebuilt library are maintained by [prebuilt-libsqlcipher](https://github.com/netpyoung/prebuilt-libsqlcipher)
  - libsqlcipher v4.4.3

## installation

## using .unitypackage

- [Download this .unitypackage from Release Page](https://github.com/netpyoung/SqlCipher4Unity3D/releases)

## using UPM

using #{version} for versioning.

``` json
"com.netpyoung.sqlcipher4unity3d": "https://github.com/netpyoung/SqlCipher4Unity3D.git?path=SqlCipher4Unity3D/Assets/SqlCipher4Unity3D#1.2.0"
```

## Watchout

- Check [Issues](https://github.com/netpyoung/SqlCipher4Unity3D/issues)
- If You are on iOS, need to modify [link.xml](https://docs.unity3d.com/Manual/iphone-playerSizeOptimization.html) for prevent stripping by Unity.

## Compatibility

From `1.1.0` I removed `v` prefix for support UPM.

| SqlCipher4Unity3D tag | sqlcipher version                                                                                               |
| --------------------- | --------------------------------------------------------------------------------------------------------------- |
| 1.1.x ~               | 4.x.x                                                                                                           |
| v1.0.x ~              | [3.x.x](https://github.com/netpyoung/SqlCipher4Unity3D/blob/2c642b3f0387dadfb4a145cb7236e99c9109fb94/README.md) |

## Example & Test

- [example](./SqlCipher4Unity3D/Assets/example/), [test](./SqlCipher4Unity3D/Assets/test/)

## Contributer(❤️)

- [@jfcontart](https://github.com/jfcontart)

## LICENCE

| project                                                                                   | license                                                                 |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| [netpyoung/SqlCipher4Unity3d](./)                                                         | [MIT](./LICENSE)                                                        |
| [jfcontart/SqlCipher4Unity3D_Apple](https://github.com/jfcontart/SqlCipher4Unity3D_Apple) | [copyleft](https://github.com/jfcontart/SqlCipher4Unity3D_Apple)        |
| [robertohuertasm/SQLite4Unity3d](https://github.com/robertohuertasm/SQLite4Unity3d)       | [MIT](https://github.com/codecoding/SQLite4Unity3d/blob/master/LICENSE) |
| [praeclarum/Sqlite-net](https://github.com/praeclarum/sqlite-net)                         | [MIT](https://github.com/praeclarum/sqlite-net/blob/master/LICENSE.txt) |
| [SQLite](sqlite370_banner.gif)                                                            | [SQLite's License](https://sqlite.org/copyright.html)                   |
| [SQLCipher](https://www.zetetic.net/sqlcipher/)                                           | [SQLCipher's License](https://www.zetetic.net/sqlcipher/license/)       |

### SQLite's Licnese

``` license
All of the code and documentation in SQLite has been dedicated to the public domain by 
the authors. All code authors, and representatives of the companies they work for, have
 signed affidavits dedicating their contributions to the public domain and originals of 
 those signed affidavits are stored in a firesafe at the main offices of Hwaci. Anyone 
 is free to copy, modify, publish, use, compile, sell, or distribute the original SQLite
  code, either in source code form or as a compiled binary, for any purpose, commercial 
  or non-commercial, and by any means.

The previous paragraph applies to the deliverable code and documentation in SQLite - 
those parts of the SQLite library that you actually bundle and ship with a larger 
application. Some scripts used as part of the build process (for example the "configure"
 scripts generated by autoconf) might fall under other open-source licenses. Nothing 
 from these build scripts ever reaches the final deliverable SQLite library, however, 
 and so the licenses associated with those scripts should not be a factor in assessing 
 your rights to copy and use the SQLite library.

All of the deliverable code in SQLite has been written from scratch. No code has been 
taken from other projects or from the open internet. Every line of code can be traced 
back to its original author, and all of those authors have public domain dedications on 
file. So the SQLite code base is clean and is uncontaminated with licensed code from 
other projects.
```

### SQLCipher's Licnese

``` license
Copyright (c) 2008-2012 Zetetic LLC
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:
    * Redistributions of source code must retain the above copyright
      notice, this list of conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright
      notice, this list of conditions and the following disclaimer in the
      documentation and/or other materials provided with the distribution.
    * Neither the name of the ZETETIC LLC nor the
      names of its contributors may be used to endorse or promote products
      derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY ZETETIC LLC ''AS IS'' AND ANY
EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL ZETETIC LLC BE LIABLE FOR ANY
DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
```

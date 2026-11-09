# docs/ref/contrib/gis/install/index

- Subject: docs/ref/contrib/gis/install/index (id `12edac54-399d-4695-ae34-4e1ef7091131`)
- Kind: subject
- Budget: 1200 tokens
- Used: 888 tokens
- Facts shown: 25 of 140
- Conflicts: 0
- Gaps: 0

## Facts

- export DYLD_FALLBACK_LIBRARY_PATH=/opt/local/lib:/opt/local/lib/postgresql15 [ae885210]
- export PATH=/Library/Frameworks/Python.framework/Versions/Current/bin:$PATH [8263dcf2]
- export PATH=/opt/local/bin:/opt/local/lib/postgresql15/bin [0fde3ce5]
- # crle -l $OLD_PATH:/usr/local/lib [16d5f7b6]
- $ brew install postgresql $ brew install postgis $ brew install gdal [b0074c06]
- $ sudo apt-get install binutils [6b013cda]
- $ sudo echo /usr/local/lib >> /etc/ld.so.conf $ sudo ldconfig [5ab873b1]
- $ sudo port install postgresql15-server $ sudo port install geos $ sudo port install proj6 $ sudo port install postgis3 $ sudo port install gdal [ed0140fb]
- $ sudo yum install binutils [8671216e]
- .. code-block:: shell [8aa7203c166b13be-90]
- .. code-block:: shell [8aa7203c166b13be-91]
- .. code-block:: shell [8aa7203c166b13be-92]
- ...\> py -m pip install psycopg [6a8a66bc]
- Administrator privileges are required to execute these commands. To do this, run command prompt as administrator and enter the commands above. You need to log out and log back in again for the settings to take effect. [2c5b7422]
- Because GeoDjango takes advantage of the latest in the open source geospatial software technology, recent versions of the libraries are necessary. If binary packages aren't available for your platform, installation from source may be required. When compiling the libraries from source, please follow the directions closely, especially if you're a beginner. [0418f327]
- If installed successfully, the PostgreSQL server will run in the background each time the system is started as a Windows service. A :menuselection:`PostgreSQL 15` start menu group will created and contains shortcuts for the Application Stack Builder (ASB) as well as the 'SQL Shell', which will launch a ``psql`` command window. [0130d594]
- If you customized the OSGeo4W installation directories, then you will need to modify the ``OSGEO4W_ROOT`` variables accordingly. [aa80cb07]
- In addition, add the ``DYLD_FALLBACK_LIBRARY_PATH`` setting so that the libraries can be found by Python: [438514f8]
- PostGIS is recommended, because it is the most mature and feature-rich open source spatial database. [bdee6006]
- The PostgreSQL installer creates a new ``postgres`` database superuser You will be prompted once to set the password -- make sure to remember it! [806b6172]
- You will also have to modify the ``PATH`` in your ``.profile`` so that the MacPorts programs are accessible from the command-line: [db98333a]
- You will need to modify the ``PATH`` environment variable in your ``.profile`` file so that the new version of Python is used when ``python`` is entered at the command-line: [78a15d1b]
- export LD_LIBRARY_PATH=/usr/local/lib [fa816033]
- export PATH=$PATH:/Applications/Postgres.app/Contents/Versions/X.Y/bin [05f307a3]
- geolibs [4f951a56]

## Beyond the budget

115 more facts did not fit in the budget: [0e35b0fb] [fe027b26] [2965218b] [8083571c] [6fb766e9] [cfac0911] [ab811599] [bdae4109] [f6c89d1a] [e41ca1ae] [fb08c0a1] [af92c7ce] [b138c774] [8e6aee51] [73ebd4cc] [4930a547] [52e89cea] [662bd7c9] [e2d7c709] [f6be9cef] [8070e855] [b86ff3d8] [fefc44cb8bc5d316-2] [423631a5927aaff7-11] [8aa7203c166b13be-93] [8aa7203c166b13be-94] [8aa7203c166b13be-95] [8aa7203c166b13be-96] [8aa7203c166b13be-97] [8aa7203c166b13be-98] [8aa7203c166b13be-99] [942ae6c11625c81c-58] [942ae6c11625c81c-59] [942ae6c11625c81c-60] [942ae6c11625c81c-61] [942ae6c11625c81c-62] [942ae6c11625c81c-63] [942ae6c11625c81c-64] [b58d259f] [2237daa5fedafa78-12] [2237daa5fedafa78-13] [24da4dd5] [f6cdbceb] [800d85d1] [b790cb3e] [f3aacd31] [5e88ea70] [e8c87a12] [3126a01d] [33230d6d] [777e1eb7] [46417582] [8f35c087] [d053d0f0] [bfb0fd58] [633d0467] [af2cdb83] [d715085f] [7b180841] [b7e62dd9] [7c0dbeaa] [927cf511] [0213e2ab] [6b49c829] [28154fa2] [90243426] [bb831226] [350e9b3d] [8db4d8757db9fb63-3] [f8511abd] [b1198ff9] [fd8e1fa9] [f02d9f5d] [793e7afd] [02871969] [68ce0a18] [f8e182ed] [e7dfa87c] [44cae850] [5f21779c] [71f63dc6] [613530cbe433b1f9] [613530cbe433b1f9-2] [a61ae04b] [ee2bd614] [3304b96d] [d3776ec5] [2aff003a] [dfd2ded0] [d6e383cc] [63fefa3a37289f85] [63fefa3a37289f85-2] [d28f1ef9] [77644347] [4c342743] [e0f6c976] [f3c881ec] [9bd7b303e940ce88-2] [7f2d6a80] [d2adc5915dce89b8] [1c28347a] [ee291419] [ac81830a] [ec7f46bd] [2856fb27] [9e5d83fe] [cf7ecb41] [4dd0495a] [ee4f0b65] [c7d9a3f5] [efc41935] [52109d48] [0bb3cd40] [bc77f04a] [a2fad5a7]

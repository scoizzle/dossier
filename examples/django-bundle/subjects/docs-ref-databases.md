# docs/ref/databases

- Subject: docs/ref/databases (id `78d7fe80-f41c-4046-91f1-cfd0bdb69235`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 24 of 340
- Conflicts: 0
- Gaps: 0

## Facts

- "OPTIONS": { "init_command": "SET default_storage_engine=INNODB", } [a8b77ba9]
- "OPTIONS": { # ... "timeout": 20, # ... } [11f9971a]
- ALTER TABLE <tablename> ENGINE=INNODB; [de3319b2]
- "NAME": "localhost:1521/orclpdb1" [0d7e13f5]
- "NAME": ( "(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" "(CONNECT_DATA=(SERVICE_NAME=orclpdb1)))" ) [b34f24bc]
- "OPTIONS": { "use_returning_into": False, } [aa476dd2]
- "OPTIONS": { # ... "transaction_mode": "IMMEDIATE", # ... } [57248807]
- # my.cnf [client] database = NAME user = USER password = PASSWORD default-character-set = utf8mb4 [fec2f5a2]
- # settings.py DATABASES = { "default": { "ENGINE": "django.db.backends.mysql", "OPTIONS": { "read_default_file": "/path/to/my.cnf", }, } } [99bdae08]
- >>> from django.contrib.auth.models import User >>> User.objects.create(username="alice", pk=1) <User: alice> >>> # The sequence hasn't been updated; its next value is 1. >>> User.objects.create(username="bob") IntegrityError: duplicate key value violates unique constraint "auth_user_pkey" DETAIL: Key (id)=(1) already exists. [634cb015]
- ALTER TABLE `your_table` MODIFY `your_datetime_column` DATETIME(6) [ec5b4612]
- DATABASES = { "default": { "ENGINE": "django.db.backends.oracle", "NAME": "xe", "USER": "a_user", "PASSWORD": "a_password", "HOST": "", "PORT": "", } } [065e8913]
- DATABASES = { "default": { "ENGINE": "django.db.backends.oracle", "NAME": "xe", "USER": "a_user", "PASSWORD": "a_password", "HOST": "dbprod01ned.mycompany.com", "PORT": "1540", } } [72218902]
- DATABASES = { "default": { "ENGINE": "django.db.backends.oracle", # ... "OPTIONS": { "pool": True, }, }, } [1edabfa6]
- DATABASES = { "default": { "ENGINE": "django.db.backends.oracle", # ... "OPTIONS": { "pool": { "min": 1, "max": 10, # ... } }, }, } [42b0247a]
- DATABASES = { "default": { "ENGINE": "django.db.backends.postgresql", "OPTIONS": { "service": "my_service", "passfile": ".my_pgpass", }, } } [f764ff08]
- DATABASES = { "default": { "ENGINE": "django.db.backends.postgresql", # ... "OPTIONS": { "assume_role": "my_application_role", }, }, } [f934183e]
- DATABASES = { "default": { "ENGINE": "django.db.backends.postgresql", # ... "OPTIONS": { "pool": True, }, }, } [183591b3]
- DATABASES = { "default": { "ENGINE": "django.db.backends.postgresql", # ... "OPTIONS": { "server_side_binding": True, }, }, } [a194b1e5]
- DATABASES = { "default": { "ENGINE": "django.db.backends.sqlite3", # ... "OPTIONS": { "init_command": "PRAGMA synchronous=3; PRAGMA cache_size=2000;", }, } } [5a63c728]
- DATABASES = { "default": { "ENGINE": "mydbengine", # ... }, } [e1e658c8]
- DATABASES = { # ... "OPTIONS": { "isolation_level": IsolationLevel.SERIALIZABLE, }, } [f6f9d440]
- GRANT EXECUTE ON SYS.DBMS_LOB TO user; GRANT EXECUTE ON SYS.DBMS_RANDOM TO user; [5e8f221f]
- The JSON1 extension is enabled by default on SQLite 3.38+. [d1a8cdd6]

## Beyond the budget

314 more facts did not fit in the budget: [989743d1] [8ba84bb6] [8df7a250] [7c010b6a] [a618486b] [22ab4fb1] [e0eb16b9] [5d90beac] [79edd630] [aac5cc2e] [2f11eb36] [cfbc5fdd] [2620b42c] [09358b3e] [0ee73173f492412a-24] [36214a76] [25fb3f5a] [6820be3d] [15ee2b7e] [61cdfde3] [c5d99c45] [59fbd419] [9732c6fd] [874814ea] [73eaa51d] [f323f2e0] [4a79ac40] [e6f3f79e] [53360ce9] [e319a948] [89735dd6] [2c901371] [d2679b90] [1a7b79f4] [5e9039f2] [19b95267] [8bd3e817] [2628f3d2] [0fb70e96] [67a3e996] [47aa71ba] [9c054d78] [dd702abe] [1b535d14] [2e91162f] [000d644c] [afabbfde] [f9e0bc6f] [b0a7d249] [569c8b69] [11bbc724] [418bced2] [f89b1df7] [1a167082] [08f6d912] [169a5ff8] [b2e8220e] [86210525] [3384be3e] [05cd1aef] [5cbafcd8] [d26c6d45] [72a423bc] [16c236a3] [13e1dba7] [35cbc412] [8ab5a9b1] [c467b2c7] [5c17976a] [dcfec81e] [66d91bee] [255d7cb2] [d31297a2] [1f48875e] [623da77b] [eeb1ac19] [e807011e] [8d4b34cb] [c84b5994] [bd21db5b] [9b76df8a] [414f9d24] [a195d3a1] [7b322374] [0d4dcb40] [ad6da854] [d16ccb3d] [015070c8] [b352480b] [bac9f312] [d0941a63] [70bf09d0] [4eefac24] [07b7a56d6b1a4254] [034e9de8] [21b0a21f] [6cfd7660] [492926bd] [ab16e0aa61fdec9d-5] [eaf050be34acb41d-268] [2de00068] [05bdbc1e8a85c4aa] [0ee73173f492412a-25] [0ee73173f492412a-26] [0ee73173f492412a-27] [3a9340cd0d877339-24] [5f312d12] [2c392a7d] [942ae6c11625c81c-88] [942ae6c11625c81c-89] [942ae6c11625c81c-90] [c54b54cb0805732a-33] [c54b54cb0805732a-34] [c54b54cb0805732a-35] [af6d62b9] [75caad7f] [1e80fffa] [be47385a] [9a831b78] [6372b461] [244d5fa9] [a1d1dbdf] [3bcdd1de] [4445a0fb] [297f2ad7] [59b55bdb] [2b46d3a4] [47b77bf4] [3cc2a6a2] [ba2762da] [f4a0ab4c] [383dce08da8f0e33] [98300953] [e3d6bc02a013fdc6] [e3d6bc02a013fdc6-2] [6b8aaf35] [fd2e7cba] [4d299cc7] [956aad5e] [f8b36f08] [5d6b2a19] [78c66140] [367c9164] [27c0e5de] [243d4a28] [102fa89f] [11bf0922] [f1f69564] [8e1dd1c7] [9bd1f1af] [979e0a25] [9aa13487] [76a3cc35] [652eb9a6] [d9c7017e] [b8490798] [2580d1eb] [fc6fcf02] [3bb32189] [8ab6cf15] [f3de4196] [f34a5a75] [f703018d] [ee51d1be] [9b4e8c12] [cfbd7cf0] [0135362c] [7ac25b73] [0cef10c5] [41f7255d] [f1a0988d] [918a2bb3] [ee2ab6c4] [a6d22ed3] [f1a835a2] [a1bb3935] [80cd19cb] [c7ef1140] [4d7e167d] [182292c9] [34bbf76e] [b6267daa] [987b1e72] [73d86357] [4fbcc6cd] [124b5625] [33a0aaf3] [bcb54e6c] [403f61bc] [5f6452d4] [e9f1338f] [18f77b17] [2551c11d] [2ebb8775] [dda5b7f0] [bed7c90c] [ad5a5289] [562ab8c8] [ce80bbac] [a8c939a1] [76bf7af3] [43504e63] [7094a7d6] [23acd031] [27d3f505] [95bd904f] [5c95ceee] [8b3b935c] [a882ea11] [c0392409] [aa2a3a8c] [77584c57] [a75b584d] [8c74cf2c] [eb330552] [25d26478] [e595be90] [cf626145] [d3c6d5b5] [702649e3] [1f52c8af] [f80134e0] [3c67e5d0] [5c7874f8] [2e17bc4dc6a60e7d-4] [1cfb1f5f] [a28d3657] [75bf6b09] [8de4417c] [ab167913] [2b26f78a] [4baa12db] [d5cdb5ce] [3c85cf1f] [1756ec9d] [c6263029] [2166a45f] [6db5a8f2] [eeb69fe5] [bc85d604] [af0a7351] [155e29f9] [f717e4a2] [dbde8ff1] [732d0131] [8ce514b1] [9eff6ba4] [ce57b458] [b4fdea4d] [509332b6] [895c9733] [c8bce83b] [d6d7d075] [fe6cf694] [0a77cba5] [05fae169] [2b0ac19a] [136a5aaa] [db2f8af1] [060a34de] [3ba2fd4e] [3352883b] [23f29256] [5b6ded5e] [239d3b8e] [a7170b2b] [c2ff6983] [d584fe11] [b6038530] [d3442d0a] [b17e427d] [bffa7996] [6580de27] [18177b57] [a7fb46ab] [6b6fef5c] [c8f50a9f] [223c8887] [80119a91] [6150b794] [d74f51a2] [34ec9f72] [d949ef58] [08bcba3d] [8aff048f] [6f166122] [15b5f310] [4305e662] [cc080962] [2e553e20] [33adf472] [133002ab] [c4dbfb90] [227d588a] [6ef6bb2c] [2a5ee4c9] [5bf36738] [123f0149] [e2344d97] [bfaa77d4] [5bd969c8] [06da61af] [d9996a56] [c07d2a9a] [1a1a7ea5] [099fb63e] [56da5e4e] [fff7a791] [f64d24c6] [c21214f3] [53f93667] [c4b4a240] [aede0191] [d558ec0a]

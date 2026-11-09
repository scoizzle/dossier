# docs/releases/1.4.9

- Subject: docs/releases/1.4.9 (id `473015d2-ae24-4424-a7dc-00577ef4b358`)
- Kind: subject
- Budget: 1200 tokens
- Used: 248 tokens
- Facts shown: 7 of 7
- Conflicts: 0
- Gaps: 0

## Facts

- * Fixed a data corruption bug with ``datetime_safe.datetime.combine`` (#21256). [438518ed]
- *October 23, 2013* [e403262854511c64]
- ========================== Django 1.4.9 release notes ========================== [6061acf9]
- Bugfixes ======== [6c84539cac9c976c-35]
- Django 1.4.8 imposes a 4096-byte limit on passwords in order to mitigate a denial-of-service attack through submission of bogus but extremely large passwords. In Django 1.4.9, we've reverted this change and instead improved the speed of our PBKDF2 algorithm by not rehashing the key on every iteration. [abb8dcee]
- Django 1.4.9 fixes a security-related bug in the 1.4 series and one other data corruption bug. [21da7d46]
- Readdressed denial-of-service via password hashers ================================================== [1e40a4bce16a0517]

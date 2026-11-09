# docs/releases/1.10.6

- Subject: docs/releases/1.10.6 (id `4e4c2d66-7ebc-495d-a956-ed7f5a3c9294`)
- Kind: subject
- Budget: 1200 tokens
- Used: 290 tokens
- Facts shown: 9 of 9
- Conflicts: 0
- Gaps: 0

## Facts

- * Fixed ``ClearableFileInput``’s "Clear" checkbox on model form fields where the model field has a ``default`` (:ticket:`27805`). [7bef7d03]
- * Fixed ``RequestDataTooBig`` and ``TooManyFieldsSent`` exceptions crashing rather than generating a bad request response (:ticket:`27820`). [41bb2abb]
- * Fixed a ``GDALException`` raised by ``GDALClose`` on GDAL ≥ 2.0 (:ticket:`27479`). [8f8c96b0]
- * Fixed a crash on Oracle and PostgreSQL when subtracting ``DurationField`` or ``IntegerField`` from ``DateField`` (:ticket:`27828`). [f4e6c457]
- * Fixed query expression date subtraction accuracy on PostgreSQL for differences larger than a month (:ticket:`27856`). [34d34819]
- *March 1, 2017* [65662677]
- =========================== Django 1.10.6 release notes =========================== [42f0f067]
- Bugfixes ======== [6c84539cac9c976c-6]
- Django 1.10.6 fixes several bugs in 1.10.5. [c6e60699]

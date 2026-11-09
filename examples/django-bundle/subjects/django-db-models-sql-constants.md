# django/db/models/sql/constants

- Subject: django/db/models/sql/constants (id `6b17c976-d953-4a52-a1d6-70c56d6bff4b`)
- Kind: subject
- Budget: 1200 tokens
- Used: 210 tokens
- Facts shown: 6 of 6
- Conflicts: 0
- Gaps: 0

## Facts

- """ Constants specific to the SQL storage portion of the ORM. """ [7a0e0779]
- # How many results to expect from a cursor.execute call MULTI = "multi" SINGLE = "single" NO_RESULTS = "no results" # Rather than returning results, returns: CURSOR = "cursor" ROW_COUNT = "row count" [cfe776ec]
- # Namedtuples for sql.* internal use. [764b4dcf]
- # SQL join types. INNER = "INNER JOIN" LOUTER = "LEFT OUTER JOIN" [119332dc]
- # Size of each "chunk" for get_iterator calls. # Larger values are slightly faster at the expense of more storage space. GET_ITERATOR_CHUNK_SIZE = 100 [c92b36fb]
- ORDER_DIR = { "ASC": ("ASC", "DESC"), "DESC": ("DESC", "ASC"), } [99072b3f]

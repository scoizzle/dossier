# Fact bc13da9a

Store id: 933bb125-f33f-4031-be29-18bae9dea712

## Text

```text
def _get_combinator_part_sql(self, compiler)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:57.4958600+00:00`

## Data

```json
{
  "end_line": 677,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 653,
  "symbol": "SQLCompiler._get_combinator_part_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":653,"selector":"L653-L677","symbol":"SQLCompiler._get_combinator_part_sql"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler._get_combinator_part_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 677,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 653,
    "symbol": "SQLCompiler._get_combinator_part_sql"
  },
  "id": "933bb125-f33f-4031-be29-18bae9dea712",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.4958600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 653,
        "selector": "L653-L677",
        "symbol": "SQLCompiler._get_combinator_part_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "2d38748b-af4f-4359-a58d-0fc36748f7c0",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler._get_combinator_part_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_combinator_part_sql(self, compiler)"
}
```

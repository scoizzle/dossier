# Fact 3ed21d99

Store id: 49233e01-0902-4fb4-a5f0-b6d79059606b

## Text

```text
def pre_sql_setup(self, with_col_aliases=False)
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
- posted_at: `2026-11-09T23:32:05.6698310+00:00`

## Data

```json
{
  "end_line": 96,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 82,
  "symbol": "SQLCompiler.pre_sql_setup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":82,"selector":"L82-L96","symbol":"SQLCompiler.pre_sql_setup"}`

## Items

```json
[
  {
    "text": "Do any necessary class setup immediately prior to producing SQL. This is for things that can't necessarily be done in __init__ because we might not have all the pieces in place at that time.",
    "locator": {
      "line": 83
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.pre_sql_setup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 96,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 82,
    "symbol": "SQLCompiler.pre_sql_setup"
  },
  "id": "49233e01-0902-4fb4-a5f0-b6d79059606b",
  "items": [
    {
      "locator": {
        "line": 83
      },
      "text": "Do any necessary class setup immediately prior to producing SQL. This is for things that can't necessarily be done in __init__ because we might not have all the pieces in place at that time."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.6698310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 82,
        "selector": "L82-L96",
        "symbol": "SQLCompiler.pre_sql_setup"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "aaae8043-e54a-45a3-b24b-b3a4d5c5cc70",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.pre_sql_setup",
  "tags": [
    "entity:method"
  ],
  "text": "def pre_sql_setup(self, with_col_aliases=False)"
}
```

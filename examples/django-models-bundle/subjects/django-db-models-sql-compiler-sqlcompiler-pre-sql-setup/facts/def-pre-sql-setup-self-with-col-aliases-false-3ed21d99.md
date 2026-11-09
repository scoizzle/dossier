# Fact 3ed21d99

Store id: 5de757a1-ff73-41a3-89b8-20dc4a4065cc

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
- posted_at: `2026-11-09T22:39:50.5624210+00:00`

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
  "id": "5de757a1-ff73-41a3-89b8-20dc4a4065cc",
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
    "posted_at": "2026-11-09T22:39:50.5624210+00:00"
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
  "subject_id": "6dea3c6d-f747-446e-a1c0-5b770bbc9914",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.pre_sql_setup",
  "tags": [
    "entity:method"
  ],
  "text": "def pre_sql_setup(self, with_col_aliases=False)"
}
```

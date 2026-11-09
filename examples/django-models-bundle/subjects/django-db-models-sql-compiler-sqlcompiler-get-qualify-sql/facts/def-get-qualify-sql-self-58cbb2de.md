# Fact 58cbb2de

Store id: 3841c3b8-2591-43ec-8e45-9a6b4c066298

## Text

```text
def get_qualify_sql(self)
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
- posted_at: `2026-11-09T23:32:05.7506720+00:00`

## Data

```json
{
  "end_line": 773,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 679,
  "symbol": "SQLCompiler.get_qualify_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":679,"selector":"L679-L773","symbol":"SQLCompiler.get_qualify_sql"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.get_qualify_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 773,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 679,
    "symbol": "SQLCompiler.get_qualify_sql"
  },
  "id": "3841c3b8-2591-43ec-8e45-9a6b4c066298",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.7506720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 679,
        "selector": "L679-L773",
        "symbol": "SQLCompiler.get_qualify_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "8cb6b237-f7bb-46b7-a264-141187e24933",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_qualify_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def get_qualify_sql(self)"
}
```

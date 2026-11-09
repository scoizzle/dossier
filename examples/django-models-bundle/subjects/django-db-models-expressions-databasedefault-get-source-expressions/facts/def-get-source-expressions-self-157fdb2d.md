# Fact 157fdb2d

Store id: 57f0faa2-1f1c-43fa-9887-07b303ec1f40

## Text

```text
def get_source_expressions(self)
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
- posted_at: `2026-11-09T22:39:41.6173980+00:00`

## Data

```json
{
  "end_line": 1322,
  "entity_kind": "method",
  "parent": "DatabaseDefault",
  "start_line": 1321,
  "symbol": "DatabaseDefault.get_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1321,"selector":"L1321-L1322","symbol":"DatabaseDefault.get_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::DatabaseDefault.get_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1322,
    "entity_kind": "method",
    "parent": "DatabaseDefault",
    "start_line": 1321,
    "symbol": "DatabaseDefault.get_source_expressions"
  },
  "id": "57f0faa2-1f1c-43fa-9887-07b303ec1f40",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6173980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1321,
        "selector": "L1321-L1322",
        "symbol": "DatabaseDefault.get_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "e4b916b5-12fa-430f-a95b-ab45126d5f65",
  "subject_name": "django/db/models/expressions::DatabaseDefault.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```

# Fact 157fdb2d

Store id: c568a488-3745-4224-a3e4-e9737049269b

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
- posted_at: `2026-11-09T23:44:49.5471230+00:00`

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
  "id": "c568a488-3745-4224-a3e4-e9737049269b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5471230+00:00"
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
  "subject_id": "e654b382-5970-45a3-be1d-1235a69e020b",
  "subject_name": "django/db/models/expressions::DatabaseDefault.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```

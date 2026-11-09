# Fact 2ec0bbf1

Store id: 7c23cbfa-48a3-48c9-b8d2-a549c4dd1699

## Text

```text
def set_source_expressions(self, exprs)
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
- posted_at: `2026-11-09T23:44:49.5480380+00:00`

## Data

```json
{
  "end_line": 1325,
  "entity_kind": "method",
  "parent": "DatabaseDefault",
  "start_line": 1324,
  "symbol": "DatabaseDefault.set_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1324,"selector":"L1324-L1325","symbol":"DatabaseDefault.set_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::DatabaseDefault.set_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1325,
    "entity_kind": "method",
    "parent": "DatabaseDefault",
    "start_line": 1324,
    "symbol": "DatabaseDefault.set_source_expressions"
  },
  "id": "7c23cbfa-48a3-48c9-b8d2-a549c4dd1699",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5480380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1324,
        "selector": "L1324-L1325",
        "symbol": "DatabaseDefault.set_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "5109e038-018d-4adb-9511-4fe9a4d7f0dd",
  "subject_name": "django/db/models/expressions::DatabaseDefault.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```

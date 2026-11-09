# Fact 64ab8561

Store id: 20acaac9-be91-4401-9359-6e82e5e23649

## Text

```text
def get_group_by_cols(self)
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
- posted_at: `2026-11-09T23:44:49.6186540+00:00`

## Data

```json
{
  "end_line": 1709,
  "entity_kind": "method",
  "parent": "When",
  "start_line": 1704,
  "symbol": "When.get_group_by_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1704,"selector":"L1704-L1709","symbol":"When.get_group_by_cols"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::When.get_group_by_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1709,
    "entity_kind": "method",
    "parent": "When",
    "start_line": 1704,
    "symbol": "When.get_group_by_cols"
  },
  "id": "20acaac9-be91-4401-9359-6e82e5e23649",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6186540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1704,
        "selector": "L1704-L1709",
        "symbol": "When.get_group_by_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "db9c11d8-1c9e-4c75-9141-d5d192cfdbd4",
  "subject_name": "django/db/models/expressions::When.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```

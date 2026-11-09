# Fact 64ab8561

Store id: de8357c0-494d-44cd-9ff0-4fecd0ded7c4

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
- posted_at: `2026-11-09T22:39:41.7000380+00:00`

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
  "id": "de8357c0-494d-44cd-9ff0-4fecd0ded7c4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7000380+00:00"
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
  "subject_id": "36f39755-55e6-4fc1-90ab-01e373e9f627",
  "subject_name": "django/db/models/expressions::When.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```

# Fact beeac64c

Store id: a1294f1f-c7c8-48b1-a63d-135f3dd212ae

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
- posted_at: `2026-11-09T23:31:55.8750840+00:00`

## Data

```json
{
  "end_line": 1284,
  "entity_kind": "method",
  "parent": "RawSQL",
  "start_line": 1283,
  "symbol": "RawSQL.get_group_by_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1283,"selector":"L1283-L1284","symbol":"RawSQL.get_group_by_cols"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::RawSQL.get_group_by_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1284,
    "entity_kind": "method",
    "parent": "RawSQL",
    "start_line": 1283,
    "symbol": "RawSQL.get_group_by_cols"
  },
  "id": "a1294f1f-c7c8-48b1-a63d-135f3dd212ae",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8750840+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1283,
        "selector": "L1283-L1284",
        "symbol": "RawSQL.get_group_by_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "4be118c0-d519-4379-a57b-5c4bf8624b8d",
  "subject_name": "django/db/models/expressions::RawSQL.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```

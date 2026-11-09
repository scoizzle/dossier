# Fact beeac64c

Store id: b021298a-94e2-4442-b6ab-4d772e0c98a1

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
- posted_at: `2026-11-09T23:44:49.5404750+00:00`

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
  "id": "b021298a-94e2-4442-b6ab-4d772e0c98a1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5404750+00:00"
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
  "subject_id": "064b77cc-b564-4c33-ad47-b13296c41c2a",
  "subject_name": "django/db/models/expressions::RawSQL.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```

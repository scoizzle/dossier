# Fact 281f023b

Store id: ac726a0f-aa76-4d54-a5c1-4cc8c098ce07

## Text

```text
def earliest(self, *fields)
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
- posted_at: `2026-11-09T23:32:04.4363980+00:00`

## Data

```json
{
  "end_line": 1204,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1201,
  "symbol": "QuerySet.earliest"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1201,"selector":"L1201-L1204","symbol":"QuerySet.earliest"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.earliest](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1204,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1201,
    "symbol": "QuerySet.earliest"
  },
  "id": "ac726a0f-aa76-4d54-a5c1-4cc8c098ce07",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.4363980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1201,
        "selector": "L1201-L1204",
        "symbol": "QuerySet.earliest"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "c137f2f2-9a20-4ca1-96c9-6812c463fd2f",
  "subject_name": "django/db/models/query::QuerySet.earliest",
  "tags": [
    "entity:method"
  ],
  "text": "def earliest(self, *fields)"
}
```

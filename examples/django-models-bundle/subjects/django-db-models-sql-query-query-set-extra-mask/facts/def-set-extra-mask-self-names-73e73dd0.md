# Fact 73e73dd0

Store id: 71da9d29-0a74-4c90-a590-11c7512aae9d

## Text

```text
def set_extra_mask(self, names)
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
- posted_at: `2026-11-09T22:39:51.5324550+00:00`

## Data

```json
{
  "end_line": 2581,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2572,
  "symbol": "Query.set_extra_mask"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2572,"selector":"L2572-L2581","symbol":"Query.set_extra_mask"}`

## Items

```json
[
  {
    "text": "Set the mask of extra select items that will be returned by SELECT. Don't remove them from the Query since they might be used later.",
    "locator": {
      "line": 2573
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.set_extra_mask](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2581,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2572,
    "symbol": "Query.set_extra_mask"
  },
  "id": "71da9d29-0a74-4c90-a590-11c7512aae9d",
  "items": [
    {
      "locator": {
        "line": 2573
      },
      "text": "Set the mask of extra select items that will be returned by SELECT. Don't remove them from the Query since they might be used later."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.5324550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2572,
        "selector": "L2572-L2581",
        "symbol": "Query.set_extra_mask"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "79002478-ad79-4baf-9854-e1356fc10b42",
  "subject_name": "django/db/models/sql/query::Query.set_extra_mask",
  "tags": [
    "entity:method"
  ],
  "text": "def set_extra_mask(self, names)"
}
```

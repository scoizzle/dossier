# Fact 73e73dd0

Store id: 6549b68b-0a60-4382-bec0-0d2ab598f603

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
- posted_at: `2026-11-09T23:32:07.1230800+00:00`

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
  "id": "6549b68b-0a60-4382-bec0-0d2ab598f603",
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
    "posted_at": "2026-11-09T23:32:07.1230800+00:00"
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
  "subject_id": "0eb24bd7-bfc5-4818-87a2-9e272aaaa819",
  "subject_name": "django/db/models/sql/query::Query.set_extra_mask",
  "tags": [
    "entity:method"
  ],
  "text": "def set_extra_mask(self, names)"
}
```

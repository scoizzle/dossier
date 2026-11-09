# Fact d1281a4c

Store id: fdbaa741-9798-4bdf-a77c-19d77ccc92dc

## Text

```text
def exists(self)
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
- posted_at: `2026-11-09T23:44:55.9903700+00:00`

## Data

```json
{
  "end_line": 1484,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1478,
  "symbol": "QuerySet.exists"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1478,"selector":"L1478-L1484","symbol":"QuerySet.exists"}`

## Items

```json
[
  {
    "text": "Return True if the QuerySet would have any results, False otherwise.",
    "locator": {
      "line": 1479
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.exists](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1484,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1478,
    "symbol": "QuerySet.exists"
  },
  "id": "fdbaa741-9798-4bdf-a77c-19d77ccc92dc",
  "items": [
    {
      "locator": {
        "line": 1479
      },
      "text": "Return True if the QuerySet would have any results, False otherwise."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.9903700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1478,
        "selector": "L1478-L1484",
        "symbol": "QuerySet.exists"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "431b61b6-9790-4ed3-9d41-080abda602f0",
  "subject_name": "django/db/models/query::QuerySet.exists",
  "tags": [
    "entity:method"
  ],
  "text": "def exists(self)"
}
```

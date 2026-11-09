# Fact 4bc228f8

Store id: 8d8a0df5-1df5-4282-ac53-86feed1dc5b7

## Text

```text
def __getitem__(self, k)
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
- posted_at: `2026-11-09T23:44:56.2596780+00:00`

## Data

```json
{
  "end_line": 2520,
  "entity_kind": "method",
  "parent": "RawQuerySet",
  "start_line": 2519,
  "symbol": "RawQuerySet.__getitem__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2519,"selector":"L2519-L2520","symbol":"RawQuerySet.__getitem__"}`

## Referenced by

None.

## Subject

[django/db/models/query::RawQuerySet.__getitem__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2520,
    "entity_kind": "method",
    "parent": "RawQuerySet",
    "start_line": 2519,
    "symbol": "RawQuerySet.__getitem__"
  },
  "id": "8d8a0df5-1df5-4282-ac53-86feed1dc5b7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.2596780+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2519,
        "selector": "L2519-L2520",
        "symbol": "RawQuerySet.__getitem__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "d9d4b112-4a22-4e9b-8bd2-bb8344095c1a",
  "subject_name": "django/db/models/query::RawQuerySet.__getitem__",
  "tags": [
    "entity:method"
  ],
  "text": "def __getitem__(self, k)"
}
```

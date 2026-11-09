# Fact 4bc228f8

Store id: 7b5da905-9bf1-44c5-a571-7d90e2f6243e

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
- posted_at: `2026-11-09T22:39:49.8179540+00:00`

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
  "id": "7b5da905-9bf1-44c5-a571-7d90e2f6243e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.8179540+00:00"
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
  "subject_id": "c712dd27-7a2a-41cf-8e5e-ec7208006eb8",
  "subject_name": "django/db/models/query::RawQuerySet.__getitem__",
  "tags": [
    "entity:method"
  ],
  "text": "def __getitem__(self, k)"
}
```

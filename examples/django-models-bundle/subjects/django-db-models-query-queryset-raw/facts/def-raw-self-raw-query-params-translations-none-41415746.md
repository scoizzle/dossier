# Fact 41415746

Store id: 996833f8-b8cc-4f36-8b18-feb556552a87

## Text

```text
def raw(self, raw_query, params=(), translations=None, using=None)
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
- posted_at: `2026-11-09T23:44:56.0098590+00:00`

## Data

```json
{
  "end_line": 1544,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1532,
  "symbol": "QuerySet.raw"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1532,"selector":"L1532-L1544","symbol":"QuerySet.raw"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.raw](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1544,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1532,
    "symbol": "QuerySet.raw"
  },
  "id": "996833f8-b8cc-4f36-8b18-feb556552a87",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.0098590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1532,
        "selector": "L1532-L1544",
        "symbol": "QuerySet.raw"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "03d79978-c1fc-4a8c-856f-d12842094044",
  "subject_name": "django/db/models/query::QuerySet.raw",
  "tags": [
    "entity:method"
  ],
  "text": "def raw(self, raw_query, params=(), translations=None, using=None)"
}
```

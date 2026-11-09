# Fact e300c515

Store id: e560c2fd-8028-4cc4-b191-3e6c4020bebb

## Text

```text
def union(self, *other_qs, all=False)
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
- posted_at: `2026-11-09T22:39:49.6282460+00:00`

## Data

```json
{
  "end_line": 1771,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1760,
  "symbol": "QuerySet.union"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1760,"selector":"L1760-L1771","symbol":"QuerySet.union"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.union](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1771,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1760,
    "symbol": "QuerySet.union"
  },
  "id": "e560c2fd-8028-4cc4-b191-3e6c4020bebb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.6282460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1760,
        "selector": "L1760-L1771",
        "symbol": "QuerySet.union"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "7d8dea5c-5984-43f2-b1f7-aea5cf8c484d",
  "subject_name": "django/db/models/query::QuerySet.union",
  "tags": [
    "entity:method"
  ],
  "text": "def union(self, *other_qs, all=False)"
}
```

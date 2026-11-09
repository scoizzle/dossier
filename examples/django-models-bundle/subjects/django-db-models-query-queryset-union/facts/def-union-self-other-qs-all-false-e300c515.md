# Fact e300c515

Store id: b9e29e9c-d008-442e-a5b1-52fdb13d38a6

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
- posted_at: `2026-11-09T23:32:04.5587430+00:00`

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
  "id": "b9e29e9c-d008-442e-a5b1-52fdb13d38a6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.5587430+00:00"
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
  "subject_id": "be940036-57b9-4609-ab03-6113713d3282",
  "subject_name": "django/db/models/query::QuerySet.union",
  "tags": [
    "entity:method"
  ],
  "text": "def union(self, *other_qs, all=False)"
}
```

# Fact e300c515

Store id: c5bd0330-f104-4ef6-a8db-b1f538a752d1

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
- posted_at: `2026-11-09T23:44:56.0499530+00:00`

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
  "id": "c5bd0330-f104-4ef6-a8db-b1f538a752d1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.0499530+00:00"
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
  "subject_id": "7dcbac19-4693-47f4-b1f7-14518116a31d",
  "subject_name": "django/db/models/query::QuerySet.union",
  "tags": [
    "entity:method"
  ],
  "text": "def union(self, *other_qs, all=False)"
}
```

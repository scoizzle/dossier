# Fact 41415746

Store id: bbdf76fa-89b5-4c56-8a58-093577857b3f

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
- posted_at: `2026-11-09T23:32:04.5135700+00:00`

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
  "id": "bbdf76fa-89b5-4c56-8a58-093577857b3f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.5135700+00:00"
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
  "subject_id": "559e16d4-2dd2-44c4-9e95-6ae632a43246",
  "subject_name": "django/db/models/query::QuerySet.raw",
  "tags": [
    "entity:method"
  ],
  "text": "def raw(self, raw_query, params=(), translations=None, using=None)"
}
```
